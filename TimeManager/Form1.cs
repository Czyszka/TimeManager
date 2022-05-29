using System.ComponentModel;
using System.Diagnostics;
using TimeManager.Models;

namespace TimeManager
{
    public partial class Form1 : Form
    {
        private BindingList<Project> projectNames = new BindingList<Project>()
        {
            new Project() { Name ="Project1", Description = "Description1", WorkTimeSpan = new TimeSpan()},
            new Project() { Name ="Project2", Description = "Description2", WorkTimeSpan = new TimeSpan()},
            new Project() { Name ="Project3", Description = "Description3", WorkTimeSpan = new TimeSpan()},
        };
        private Project selectedProject;

        private DateTime startDate;
        private DateTime lastUpdateDate;
        private static string timeSpanFormat = @"dd\.hh\:mm\:ss";
        public static string TimeSpanFormat { get => timeSpanFormat; }

        //todo DataBase
        //todo Unit tests

        public Form1()
        {
            InitializeComponent();
            timeSpanFormatLabel.Text = $"Format: {TimeSpanFormat.Replace(@"\", "")}";

            ProjectsListBox.DataSource = projectNames;
            ProjectsListBox.DisplayMember = "Name";

            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProjectsListBox.SelectedItem is not null)
            {
                selectedProject = (Project)ProjectsListBox.SelectedItem;

                projectInfoUserControl.UpdateProjectControls((Project)ProjectsListBox.SelectedItem);
            }

        }

        private void CounterStartButton_Click(object sender, EventArgs e)
        {
            if (CounterButton.Text == "Stop")
            {
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

            selectedProject.WorkTimeSpan = selectedProject.WorkTimeSpan?.Add(tsTimeToAdd);

            SessionTimeSpanTextBox.Text = tsTimeFromStart.ToString(timeSpanFormat);
            projectInfoUserControl.UpdateProjectTimeSpanControl(selectedProject.WorkTimeSpan?.ToString(TimeSpanFormat));

            lastUpdateDate = currentUpdateDate;
        }

        private void AddNewProjectButton_Click(object sender, EventArgs e)
        {
            Project? project = AddNewUserControl.GetProjectFromControls();
            if (project is not null)
            {
                projectNames.Add(project);
                ProjectsListBox.SelectedItem = project;
                AddNewUserControl.ClearControls();
            }
            else
                UserLogLabel.Text = "Adding new project fail. Fill in the required project information.";
        }

        private void UpdateProjectButton_Click(object sender, EventArgs e)
        {
            Project? project = projectInfoUserControl.GetProjectFromControls();
            if (project is not null)
            {
                UpdateSelectedProjectProperties(project);


            }
            else
                UserLogLabel.Text = "Update project fail. Fill in the required project information.";
        }

        private void UpdateSelectedProjectProperties(Project? project)
        {
            selectedProject.Name = project?.Name;
            selectedProject.Description = project?.Description;
            selectedProject.WorkTimeSpan = (project?.WorkTimeSpan)?? selectedProject.WorkTimeSpan;
            projectInfoUserControl.UpdateProjectTimeSpanControl(selectedProject.WorkTimeSpan?.ToString(TimeSpanFormat));
        }
    }
}