using System.ComponentModel;
using System.Diagnostics;
using TimeManager.Models;
using Throw;
namespace TimeManager
{
    public partial class Form1 : Form
    {
        private BindingList<Project> projects;

        private Project? selectedProject;
        private Project? projectWithAttachedCounter;

        private bool sessionTSCounting = false;

        private DateTime startDate;
        private DateTime lastUpdateDate;
        private static string timeSpanFormat = @"dd\.hh\:mm\:ss";
        public static string TimeSpanFormat { get => timeSpanFormat; }
        public BindingList<Project> Projects { get => projects; set => projects = value; }



        //todo Unit tests

        public Form1()
        {
            InitializeComponent();
            
            var version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            this.Text += $" Version {version}";

            LoadProjectsList();

            timeSpanFormatLabel.Text = $"Format: {TimeSpanFormat.Replace(@"\", "")}";

            if (ProjectsListBox.SelectedItem is null)
            {
                SetEnabledControls(false);
            }
        }

        private void SetEnabledControls(bool isEnabled = true)
        {
            //projectInfoUserControl.EnableControls(isEnabled);
            CounterButton.Enabled = isEnabled;
            SessionTimeSpanTextBox.Enabled = isEnabled;
            UpdateProjectButton.Enabled = isEnabled;
            DeleteProjectButton.Enabled = isEnabled;

            if (isEnabled)
            {
                SessionTimeSpanTextBox.Text = new TimeSpan().ToString(timeSpanFormat);
            }
            else
            {
                SessionTimeSpanTextBox.Text = String.Empty;
            }
        }
        private void LoadProjectsList()
        {
            Projects = new BindingList<Project>(SqliteDataAccess.ReadProjects());

            WireUpProjectsList();
        }
        private void WireUpProjectsList()
        {
            ProjectsListBox.DataSource = Projects;
            ProjectsListBox.DisplayMember = "Name";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProjectsListBox.SelectedItem is not null)
            {
                if (((Project)ProjectsListBox.SelectedItem).Id != projectWithAttachedCounter?.Id)
                {
                    UpdateTimeSpanIntervalTimer.Enabled = false;

                    projectWithAttachedCounter = null;

                    CounterButton.Text = "Start";
                    SessionTimeSpanTextBox.Text = TimeSpan.Zero.ToString(timeSpanFormat);
                    SessionTimeSpanTextBox.Enabled = false;
                }

                selectedProject = (Project)ProjectsListBox.SelectedItem;

                projectInfoUserControl.UpdateData(selectedProject.Name,
                                                  selectedProject.Description,
                                                  selectedProject.WorkTimeSpan.ToString(TimeSpanFormat));
                projectInfoUserControl.EnableControls();
                SetEnabledControls();
            }
        }

        private void CounterStartButton_Click(object sender, EventArgs e)
        {
            if (CounterButton.Text == "Stop")
            {
                UpdateTimeSpanIntervalTimer.Enabled = false;

                projectWithAttachedCounter = null;

                CounterButton.Text = "Start";
                SessionTimeSpanTextBox.Text = TimeSpan.Zero.ToString(timeSpanFormat);
                SessionTimeSpanTextBox.Enabled = false;
            }
            else if (CounterButton.Text == "Start")
            {
                if (selectedProject is null)
                {
                    return;
                }

                projectWithAttachedCounter = selectedProject;

                CounterButton.Text = "Stop";
                SessionTimeSpanTextBox.Enabled = true;

                UpdateTimeSpanIntervalTimer.Enabled = true;
                startDate = lastUpdateDate = DateTime.Now;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (projectWithAttachedCounter is null)
            {
                UpdateTimeSpanIntervalTimer.Enabled = false;
                UserLogLabel.Text = "Select project from list first.";
                return;
            }

            DateTime currentUpdateDate = DateTime.Now;
            TimeSpan tsTimeToAdd = currentUpdateDate - lastUpdateDate;
            TimeSpan tsTimeFromStart = currentUpdateDate - startDate;

            projectWithAttachedCounter.WorkTimeSpan = projectWithAttachedCounter.WorkTimeSpan.Add(tsTimeToAdd);

            SessionTimeSpanTextBox.Text = tsTimeFromStart.ToString(TimeSpanFormat);
            projectInfoUserControl.UpdateData(null, null, projectWithAttachedCounter.WorkTimeSpan.ToString(TimeSpanFormat));

            lastUpdateDate = currentUpdateDate;

            SqliteDataAccess.UpdateProject(projectWithAttachedCounter);
        }

        private void AddNewProjectButton_Click(object sender, EventArgs e)
        {
            try
            {
                var data = AddNewUserControl.GetData();

                data.name
                    .ThrowIfNull()
                    .IfEmpty()
                    .IfWhiteSpace();

                Project newProject = new Project() { Id = new IdGen.IdGenerator(0).CreateId(), Name = data.name, Description = data.description ?? string.Empty };

                //timeSpan Parsing
                if (string.IsNullOrEmpty(data.timespan))
                {
                    newProject.WorkTimeSpan = TimeSpan.Zero;
                }
                else
                {
                    TimeSpan.TryParse(data.timespan, out TimeSpan ts)
                        .Throw(_ => throw new InvalidOperationException($"Failed to parse timespan '{data.timespan}'. Timespan format: {TimeSpanFormat}. "))
                        .IfFalse();
                    newProject.WorkTimeSpan = ts;
                }

                Projects.Add(newProject);
                SqliteDataAccess.CreateProject(newProject);

                AddNewUserControl.ClearData();
            }
            catch (ArgumentNullException anex)
            {
                UserLogLabel.Text = $"{anex.ParamName} cannot be null. Fill required information.";
            }
            catch (ArgumentException aex)
            {
                UserLogLabel.Text = $"{aex.ParamName}: error. Fill required information.";
            }
            catch (InvalidOperationException ioex)
            {
                UserLogLabel.Text = $"{ioex.Message}";
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void UpdateProjectButton_Click(object sender, EventArgs e)
        {
            try
            {
                selectedProject.ThrowIfNull();

                var data = projectInfoUserControl.GetData();

                if(!string.IsNullOrEmpty(data.name))
                    selectedProject.Name = data.name;
                if (!string.IsNullOrEmpty(data.name))
                    selectedProject.Description = data.description;

                //timeSpan Parsing
                if (!string.IsNullOrEmpty(data.timespan))
                {
                    TimeSpan.TryParse(data.timespan, out TimeSpan ts)
                        .Throw(_ => throw new InvalidOperationException($"Failed to parse timespan '{data.timespan}'. Timespan format: {TimeSpanFormat}. "))
                        .IfFalse();
                    selectedProject.WorkTimeSpan = ts;
                }

                SqliteDataAccess.UpdateProject(selectedProject);

                //Project project = projectInfoUserControl.GetProjectFromControls();

                //UpdateSelectedProjectProperties(project);
            }
            catch (ArgumentNullException anex)
            {
                UserLogLabel.Text = $"{anex.ParamName} cannot be null. Fill required information.";
            }
            catch (InvalidOperationException ioex)
            {
                UserLogLabel.Text = $"{ioex.Message}";
            }
            catch (Exception ex)
            {
                UserLogLabel.Text = ex.Message;
            }
        }

        private void DeleteProjectButton_Click(object sender, EventArgs e)
        {
           //// projectInfoUserControl.ClearControls();
           // //projectInfoUserControl.EnableControls(false);

           // CounterButton.Text = "Start";
           // SessionTimeSpanTextBox.Text = String.Empty;
           // SessionTimeSpanTextBox.Enabled = false;
           // UpdateTimeSpanIntervalTimer.Enabled = false;
           // sessionTSCounting = false;

           // if (selectedProject is not null)
           // {
           //     Projects.Remove(selectedProject);
           //     SqliteDataAccess.DeleteProject(selectedProject);
           //     selectedProject = null;
           // }

            try
            {
                selectedProject.ThrowIfNull();

                Projects.Remove(selectedProject);
                SqliteDataAccess.DeleteProject(selectedProject);
                
                selectedProject = null;

                projectInfoUserControl.ClearData();
                projectInfoUserControl.EnableControls(false);

                SetEnabledControls(false);
            }
            catch (ArgumentNullException anex)
            {
                UserLogLabel.Text = $"{anex.ParamName} cannot be null. Fill required information.";
            }
            catch (Exception ex)
            {
                UserLogLabel.Text = ex.Message;
            }


        }
    }
}