using System.ComponentModel;
using System.Diagnostics;
using TimeManager.Models;

namespace TimeManager
{
    public partial class Form1 : Form
    {
        private BindingList<Project> projects;

        private Project? selectedProject;

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

            LoadProjectsList();

            timeSpanFormatLabel.Text = $"Format: {TimeSpanFormat.Replace(@"\", "")}";

            if (ProjectsListBox.SelectedItem is null)
            {
                SetEnabledControls(false);
            }
        }

        private void SetEnabledControls(bool isEnabled = true)
        {
            projectInfoUserControl.EnableControls(isEnabled);
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
                if (sessionTSCounting)//todo to tak nie dzia³a
                {
                    sessionTSCounting = false;
                    CounterButton.Text = "Start";
                    UpdateTimeSpanIntervalTimer.Enabled = false;
                }


                selectedProject = (Project)ProjectsListBox.SelectedItem;

                projectInfoUserControl.UpdateProjectControls((Project)ProjectsListBox.SelectedItem);
                SetEnabledControls();
            }
            else
            {
                selectedProject = null;
                projectInfoUserControl.UpdateProjectControls(null);
                SetEnabledControls(false);
            }

        }

        private void CounterStartButton_Click(object sender, EventArgs e)
        {
            if (CounterButton.Text == "Stop")
            {
                sessionTSCounting = false;
                CounterButton.Text = "Start";

                UpdateTimeSpanIntervalTimer.Enabled = false;
                timer1_Tick(sender, e);//todo think about if stop to save rest of data or abort
            }
            else
            {
                if (selectedProject is null)
                {
                    return;
                }

                sessionTSCounting = true;
                CounterButton.Text = "Stop";
                UpdateTimeSpanIntervalTimer.Enabled = true;
                startDate = lastUpdateDate = DateTime.Now;
                timer1_Tick(sender, e);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (selectedProject is null)
            {
                UserLogLabel.Text = "Select project from list first.";
                return;
            }

            DateTime currentUpdateDate = DateTime.Now;
            TimeSpan tsTimeToAdd = currentUpdateDate - lastUpdateDate;
            TimeSpan tsTimeFromStart = currentUpdateDate - startDate;

            selectedProject.WorkTimeSpan = selectedProject.WorkTimeSpan.Add(tsTimeToAdd);

            SessionTimeSpanTextBox.Text = tsTimeFromStart.ToString(timeSpanFormat);
            projectInfoUserControl.UpdateTimeSpanControl(selectedProject.WorkTimeSpan.ToString(TimeSpanFormat));

            lastUpdateDate = currentUpdateDate;

            SqliteDataAccess.UpdateProject(selectedProject);
        }

        private void AddNewProjectButton_Click(object sender, EventArgs e)
        {
            Project? project = AddNewUserControl.GetProjectFromControls();
            if (project is not null)
            {
                project.Id = new IdGen.IdGenerator(0).CreateId();
                Projects.Add(project);
                SqliteDataAccess.CreateProject(project);

                if (!sessionTSCounting)
                {
                    ProjectsListBox.SelectedItem = project;
                    listBox1_SelectedIndexChanged(this, null);
                }


                AddNewUserControl.ClearControls();
            }
            else
                UserLogLabel.Text = "Adding new project fail. Fill in the required project information.";
        }

        private void UpdateProjectButton_Click(object sender, EventArgs e)
        {
            try
            {
                Project project = projectInfoUserControl.GetProjectFromControls();

                UpdateSelectedProjectProperties(project);
            }
            catch (ArgumentNullException anex)
            {
                UserLogLabel.Text = anex.Message;
            }
            catch (ArgumentException aex)
            {
                UserLogLabel.Text = aex.Message;
            }
            catch (Exception ex)
            {
                UserLogLabel.Text = ex.Message;
            }
        }
        private void UpdateSelectedProjectProperties(Project project)
        {
            if (selectedProject is null)
            {
                return;
            }

            selectedProject.Name = project.Name;
            selectedProject.Description = project.Description;
            selectedProject.WorkTimeSpan = project.WorkTimeSpan;

            SqliteDataAccess.UpdateProject(selectedProject);
        }

        private void DeleteProjectButton_Click(object sender, EventArgs e)
        {
            projectInfoUserControl.ClearControls();
            projectInfoUserControl.EnableControls(false);

            CounterButton.Text = "Start";
            SessionTimeSpanTextBox.Text = String.Empty;
            SessionTimeSpanTextBox.Enabled = false;
            UpdateTimeSpanIntervalTimer.Enabled = false;
            sessionTSCounting = false;

            if (selectedProject is not null)
            {
                Projects.Remove(selectedProject);
                SqliteDataAccess.DeleteProject(selectedProject);
                selectedProject = null;
            }

        }
    }
}