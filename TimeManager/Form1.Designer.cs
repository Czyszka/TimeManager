namespace TimeManager
{
    partial class Form1
    {


        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ProjectsListBox = new System.Windows.Forms.ListBox();
            this.SessionTimeSpanLabel = new System.Windows.Forms.Label();
            this.ProjectListLabel = new System.Windows.Forms.Label();
            this.SessionTimeSpanTextBox = new System.Windows.Forms.TextBox();
            this.CounterButton = new System.Windows.Forms.Button();
            this.UpdateTimeSpanIntervalTimer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Info = new System.Windows.Forms.TabPage();
            this.UpdateProjectButton = new System.Windows.Forms.Button();
            this.projectInfoUserControl = new TimeManager.ProjectInfo();
            this.CounterGroupBox = new System.Windows.Forms.GroupBox();
            this.Add = new System.Windows.Forms.TabPage();
            this.timeSpanFormatLabel = new System.Windows.Forms.Label();
            this.AddNewProjectButton = new System.Windows.Forms.Button();
            this.AddNewUserControl = new TimeManager.ProjectInfo();
            this.UserLogLabel = new System.Windows.Forms.Label();
            this.DeleteProjectButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Info.SuspendLayout();
            this.CounterGroupBox.SuspendLayout();
            this.Add.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProjectsListBox
            // 
            this.ProjectsListBox.FormattingEnabled = true;
            this.ProjectsListBox.ItemHeight = 20;
            this.ProjectsListBox.Location = new System.Drawing.Point(534, 40);
            this.ProjectsListBox.Name = "ProjectsListBox";
            this.ProjectsListBox.Size = new System.Drawing.Size(183, 264);
            this.ProjectsListBox.TabIndex = 0;
            this.ProjectsListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // SessionTimeSpanLabel
            // 
            this.SessionTimeSpanLabel.AutoSize = true;
            this.SessionTimeSpanLabel.Location = new System.Drawing.Point(10, 59);
            this.SessionTimeSpanLabel.Name = "SessionTimeSpanLabel";
            this.SessionTimeSpanLabel.Size = new System.Drawing.Size(124, 20);
            this.SessionTimeSpanLabel.TabIndex = 3;
            this.SessionTimeSpanLabel.Text = "SessionTimeSpan";
            // 
            // ProjectListLabel
            // 
            this.ProjectListLabel.AutoSize = true;
            this.ProjectListLabel.Location = new System.Drawing.Point(530, 16);
            this.ProjectListLabel.Name = "ProjectListLabel";
            this.ProjectListLabel.Size = new System.Drawing.Size(83, 20);
            this.ProjectListLabel.TabIndex = 2;
            this.ProjectListLabel.Text = "ProjectsList";
            // 
            // SessionTimeSpanTextBox
            // 
            this.SessionTimeSpanTextBox.Location = new System.Drawing.Point(175, 56);
            this.SessionTimeSpanTextBox.Name = "SessionTimeSpanTextBox";
            this.SessionTimeSpanTextBox.Size = new System.Drawing.Size(112, 27);
            this.SessionTimeSpanTextBox.TabIndex = 1;
            // 
            // CounterButton
            // 
            this.CounterButton.Location = new System.Drawing.Point(175, 98);
            this.CounterButton.Name = "CounterButton";
            this.CounterButton.Size = new System.Drawing.Size(94, 29);
            this.CounterButton.TabIndex = 4;
            this.CounterButton.Text = "Start";
            this.CounterButton.UseVisualStyleBackColor = true;
            this.CounterButton.Click += new System.EventHandler(this.CounterStartButton_Click);
            // 
            // UpdateTimeSpanIntervalTimer
            // 
            this.UpdateTimeSpanIntervalTimer.Interval = 1000;
            this.UpdateTimeSpanIntervalTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Info);
            this.tabControl1.Controls.Add(this.Add);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(516, 399);
            this.tabControl1.TabIndex = 5;
            // 
            // Info
            // 
            this.Info.Controls.Add(this.DeleteProjectButton);
            this.Info.Controls.Add(this.UpdateProjectButton);
            this.Info.Controls.Add(this.projectInfoUserControl);
            this.Info.Controls.Add(this.CounterGroupBox);
            this.Info.Location = new System.Drawing.Point(4, 29);
            this.Info.Name = "Info";
            this.Info.Padding = new System.Windows.Forms.Padding(3);
            this.Info.Size = new System.Drawing.Size(508, 366);
            this.Info.TabIndex = 0;
            this.Info.Text = "Info";
            this.Info.UseVisualStyleBackColor = true;
            // 
            // UpdateProjectButton
            // 
            this.UpdateProjectButton.Location = new System.Drawing.Point(287, 166);
            this.UpdateProjectButton.Name = "UpdateProjectButton";
            this.UpdateProjectButton.Size = new System.Drawing.Size(74, 29);
            this.UpdateProjectButton.TabIndex = 8;
            this.UpdateProjectButton.Text = "Save";
            this.UpdateProjectButton.UseVisualStyleBackColor = true;
            this.UpdateProjectButton.Click += new System.EventHandler(this.UpdateProjectButton_Click);
            // 
            // projectInfoUserControl
            // 
            this.projectInfoUserControl.Location = new System.Drawing.Point(5, 5);
            this.projectInfoUserControl.Name = "projectInfoUserControl";
            this.projectInfoUserControl.Size = new System.Drawing.Size(464, 204);
            this.projectInfoUserControl.TabIndex = 7;
            // 
            // CounterGroupBox
            // 
            this.CounterGroupBox.Controls.Add(this.SessionTimeSpanTextBox);
            this.CounterGroupBox.Controls.Add(this.CounterButton);
            this.CounterGroupBox.Controls.Add(this.SessionTimeSpanLabel);
            this.CounterGroupBox.Location = new System.Drawing.Point(14, 204);
            this.CounterGroupBox.Name = "CounterGroupBox";
            this.CounterGroupBox.Size = new System.Drawing.Size(447, 155);
            this.CounterGroupBox.TabIndex = 6;
            this.CounterGroupBox.TabStop = false;
            this.CounterGroupBox.Text = "StopWatch";
            // 
            // Add
            // 
            this.Add.Controls.Add(this.timeSpanFormatLabel);
            this.Add.Controls.Add(this.AddNewProjectButton);
            this.Add.Controls.Add(this.AddNewUserControl);
            this.Add.Location = new System.Drawing.Point(4, 29);
            this.Add.Name = "Add";
            this.Add.Padding = new System.Windows.Forms.Padding(3);
            this.Add.Size = new System.Drawing.Size(508, 366);
            this.Add.TabIndex = 1;
            this.Add.Text = "New";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // timeSpanFormatLabel
            // 
            this.timeSpanFormatLabel.AutoSize = true;
            this.timeSpanFormatLabel.Location = new System.Drawing.Point(288, 169);
            this.timeSpanFormatLabel.Name = "timeSpanFormatLabel";
            this.timeSpanFormatLabel.Size = new System.Drawing.Size(119, 20);
            this.timeSpanFormatLabel.TabIndex = 8;
            this.timeSpanFormatLabel.Text = "timeSpanFormat";
            // 
            // AddNewProjectButton
            // 
            this.AddNewProjectButton.Location = new System.Drawing.Point(138, 212);
            this.AddNewProjectButton.Name = "AddNewProjectButton";
            this.AddNewProjectButton.Size = new System.Drawing.Size(94, 29);
            this.AddNewProjectButton.TabIndex = 7;
            this.AddNewProjectButton.Text = "Add";
            this.AddNewProjectButton.UseVisualStyleBackColor = true;
            this.AddNewProjectButton.Click += new System.EventHandler(this.AddNewProjectButton_Click);
            // 
            // AddNewUserControl
            // 
            this.AddNewUserControl.Location = new System.Drawing.Point(6, 6);
            this.AddNewUserControl.Name = "AddNewUserControl";
            this.AddNewUserControl.Size = new System.Drawing.Size(465, 200);
            this.AddNewUserControl.TabIndex = 6;
            // 
            // UserLogLabel
            // 
            this.UserLogLabel.AutoSize = true;
            this.UserLogLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.UserLogLabel.Location = new System.Drawing.Point(15, 424);
            this.UserLogLabel.Name = "UserLogLabel";
            this.UserLogLabel.Size = new System.Drawing.Size(0, 20);
            this.UserLogLabel.TabIndex = 6;
            // 
            // DeleteProjectButton
            // 
            this.DeleteProjectButton.Location = new System.Drawing.Point(372, 166);
            this.DeleteProjectButton.Name = "DeleteProjectButton";
            this.DeleteProjectButton.Size = new System.Drawing.Size(74, 29);
            this.DeleteProjectButton.TabIndex = 8;
            this.DeleteProjectButton.Text = "Delete";
            this.DeleteProjectButton.UseVisualStyleBackColor = true;
            this.DeleteProjectButton.Click += new System.EventHandler(this.DeleteProjectButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 422);
            this.Controls.Add(this.UserLogLabel);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ProjectListLabel);
            this.Controls.Add(this.ProjectsListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Info.ResumeLayout(false);
            this.CounterGroupBox.ResumeLayout(false);
            this.CounterGroupBox.PerformLayout();
            this.Add.ResumeLayout(false);
            this.Add.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox ProjectsListBox;
        private Label SessionTimeSpanLabel;
        private Label ProjectListLabel;
        private TextBox SessionTimeSpanTextBox;
        private Button CounterButton;
        private System.Windows.Forms.Timer UpdateTimeSpanIntervalTimer;
        private TabControl tabControl1;
        private TabPage Info;
        private TabPage Add;
        private GroupBox CounterGroupBox;
        private ProjectInfo AddNewUserControl;
        private ProjectInfo projectInfoUserControl;
        private Button AddNewProjectButton;
        private Label UserLogLabel;
        private Button UpdateProjectButton;
        private Label timeSpanFormatLabel;
        private Button DeleteProjectButton;
    }
}