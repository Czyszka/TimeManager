using System.Diagnostics;
using TimeManager.Models;

namespace TimeManager
{
    public partial class Form1 : Form
    {
        private List<Project> ProjectNames = new List<Project>()
        {
            new Project() { Name ="Project1", Description = "Description1"},
            new Project() { Name ="Project2", Description = "Description2"},
            new Project() { Name ="Project3", Description = "Description3"},
        };

        public static string timeSpanFormat = @"dd\.hh\:mm\:ss";
        private Project selectedProject;
        private Stopwatch stopwatch;
        private DateTime startDate;
        private DateTime lastUpdateDate;
        
        //todo DataBase
        //todo Unit tests

        public Form1()
        {
            InitializeComponent();

            ProjectsListBox.BeginUpdate();
            foreach (var name in ProjectNames)
            {
                ProjectsListBox.Items.Add(name);
            }
            ProjectsListBox.EndUpdate();

            stopwatch = new Stopwatch();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArgumentNullException.ThrowIfNull(ProjectsListBox.SelectedItem);

            selectedProject = ProjectsListBox.SelectedItem as Project;

            projectInfoUserControl.UpdateProjectControls(ProjectsListBox.SelectedItem as Project);
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
                SessionTimeSpanTextBox.Text = "Select project first.";
                return;
            }

            DateTime currentUpdateDate = DateTime.Now;
            TimeSpan tsTimeToAdd = currentUpdateDate - lastUpdateDate;
            TimeSpan tsTimeFromStart = currentUpdateDate - startDate;

            selectedProject.WorkTimeSpan = selectedProject.WorkTimeSpan.Add(tsTimeToAdd);

            SessionTimeSpanTextBox.Text = tsTimeFromStart.ToString(timeSpanFormat);
            projectInfoUserControl.UpdateProjectTimeSpanControl(selectedProject.WorkTimeSpan.ToString(timeSpanFormat));

            lastUpdateDate = currentUpdateDate;
        }
    }
}