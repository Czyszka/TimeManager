using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Throw;
using TimeManager.Models;

namespace TimeManager
{
    public partial class ProjectInfo : UserControl
    {
        public ProjectInfo()
        {
            InitializeComponent();
        }

        public void UpdateProjectControls(Project? project)
        {
            ProjectNameTextBox.Text = project?.Name ?? null;
            ProjectDescriptionTextBox.Text = project?.Description ?? null;
            WorkTimeSpanTextBox.Text = project?.WorkTimeSpan.ToString(Form1.TimeSpanFormat) ?? null;
        }
        public void UpdateTimeSpanControl(string timeSpan)
        {
            WorkTimeSpanTextBox.Text = timeSpan;
        }
        public void UpdateTimeSpanControl(TimeSpan timeSpan)
        {
            WorkTimeSpanTextBox.Text = timeSpan.ToString(Form1.TimeSpanFormat);
        }
        public Project GetProjectFromControls()
        {
            ProjectNameTextBox.Text
                .ThrowIfNull()
                .IfEmpty()
                .IfWhiteSpace();

            Project project = new Project() { Name = ProjectNameTextBox.Text, Description = ProjectDescriptionTextBox.Text };
            
            if (TimeSpan.TryParse(WorkTimeSpanTextBox.Text, out TimeSpan ts))
            {
                project.WorkTimeSpan = ts;
            }
            else
                project.WorkTimeSpan = TimeSpan.Zero;

            return project;
        }
        public void ClearControls()
        {
            ProjectNameTextBox.Text = string.Empty;
            ProjectDescriptionTextBox.Text = string.Empty;
            WorkTimeSpanTextBox.Text = string.Empty;
        }

        public void EnableControls(bool isEnabled = true)
        {
            ProjectNameTextBox.Enabled = isEnabled;
            ProjectDescriptionTextBox.Enabled = isEnabled;
            WorkTimeSpanTextBox.Enabled = isEnabled;
        }
    }
}
