using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeManager.Models;

namespace TimeManager
{
    public partial class ProjectInfo : UserControl
    {
        public ProjectInfo()
        {
            InitializeComponent();
        }

        public void UpdateProjectControls(Project project)
        {
            ProjectNameTextBox.Text = project?.Name??null;
            ProjectDescriptionTextBox.Text = project?.Description??null;
            WorkTimeSpanTextBox.Text = project?.WorkTimeSpan?.ToString(Form1.TimeSpanFormat)??null;
        }
        public void UpdateProjectTimeSpanControl(string timeSpan)
        {
            WorkTimeSpanTextBox.Text = timeSpan;
        }

        public Project? GetProjectFromControls()
        {
            if (string.IsNullOrEmpty(ProjectNameTextBox.Text) 
                || string.IsNullOrEmpty(ProjectDescriptionTextBox.Text)
                /*|| string.IsNullOrEmpty(WorkTimeSpanTextBox.Text)*/)
            {
                return null;
            }

            Project project = new Project() { Name = ProjectNameTextBox.Text, Description = ProjectDescriptionTextBox.Text};

            if (string.IsNullOrEmpty(WorkTimeSpanTextBox.Text))
            {
                project.WorkTimeSpan = TimeSpan.Zero;
            }
            else if (TimeSpan.TryParse(WorkTimeSpanTextBox.Text, out TimeSpan ts))
            {
                project.WorkTimeSpan = ts;
            }
            else
                project.WorkTimeSpan = null;

            return project;
        }
        public void ClearControls()
        {
            ProjectNameTextBox.Text = string.Empty;
            ProjectDescriptionTextBox.Text = string.Empty;
            WorkTimeSpanTextBox.Text = string.Empty;
        }
    }
}
