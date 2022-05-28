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
            ProjectNameTextBox.Text = project.Name;
            ProjectDescriptionTextBox.Text = project.Description;
            WorkTimeSpanTextBox.Text = project.WorkTimeSpan.ToString(Form1.timeSpanFormat);
        }
        public void UpdateProjectTimeSpanControl(string timeSpan)
        {
            WorkTimeSpanTextBox.Text = timeSpan;

        }
    }
}
