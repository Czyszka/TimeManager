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

        #region Comm
        public (string name, string description, string timespan) GetData()
        {
            //todo think about verification if needed
            return ( ProjectNameTextBox.Text,
                     ProjectDescriptionTextBox.Text,
                     WorkTimeSpanTextBox.Text);
        }
        public void UpdateData(string? name, string? description, string? timespan)
        {
            if (!string.IsNullOrEmpty(name))
                ProjectNameTextBox.Text = name;

            if (!string.IsNullOrEmpty(description))
                ProjectDescriptionTextBox.Text = description;

            if (!string.IsNullOrEmpty(timespan))
                WorkTimeSpanTextBox.Text = timespan;
        }
        public void ClearData()
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
        #endregion
    }
}
