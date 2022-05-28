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
            this.TimeCounterLabel = new System.Windows.Forms.Label();
            this.SessionTimeSpanTextBox = new System.Windows.Forms.TextBox();
            this.CounterButton = new System.Windows.Forms.Button();
            this.UpdateTimeSpanIntervalTimer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Project = new System.Windows.Forms.TabPage();
            this.projectInfoUserControl = new TimeManager.ProjectInfo();
            this.CounterGroupBox = new System.Windows.Forms.GroupBox();
            this.Add = new System.Windows.Forms.TabPage();
            this.AddNewUserControl = new TimeManager.ProjectInfo();
            this.tabControl1.SuspendLayout();
            this.Project.SuspendLayout();
            this.CounterGroupBox.SuspendLayout();
            this.Add.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProjectsListBox
            // 
            this.ProjectsListBox.FormattingEnabled = true;
            this.ProjectsListBox.ItemHeight = 20;
            this.ProjectsListBox.Location = new System.Drawing.Point(553, 41);
            this.ProjectsListBox.Name = "ProjectsListBox";
            this.ProjectsListBox.Size = new System.Drawing.Size(321, 264);
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
            this.ProjectListLabel.Location = new System.Drawing.Point(553, 18);
            this.ProjectListLabel.Name = "ProjectListLabel";
            this.ProjectListLabel.Size = new System.Drawing.Size(83, 20);
            this.ProjectListLabel.TabIndex = 2;
            this.ProjectListLabel.Text = "ProjectsList";
            // 
            // TimeCounterLabel
            // 
            this.TimeCounterLabel.AutoSize = true;
            this.TimeCounterLabel.Location = new System.Drawing.Point(116, 33);
            this.TimeCounterLabel.Name = "TimeCounterLabel";
            this.TimeCounterLabel.Size = new System.Drawing.Size(94, 20);
            this.TimeCounterLabel.TabIndex = 2;
            this.TimeCounterLabel.Text = "TimeCounter";
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
            this.CounterButton.Location = new System.Drawing.Point(59, 119);
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
            this.tabControl1.Controls.Add(this.Project);
            this.tabControl1.Controls.Add(this.Add);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(516, 436);
            this.tabControl1.TabIndex = 5;
            // 
            // Project
            // 
            this.Project.Controls.Add(this.projectInfoUserControl);
            this.Project.Controls.Add(this.CounterGroupBox);
            this.Project.Location = new System.Drawing.Point(4, 29);
            this.Project.Name = "Project";
            this.Project.Padding = new System.Windows.Forms.Padding(3);
            this.Project.Size = new System.Drawing.Size(508, 403);
            this.Project.TabIndex = 0;
            this.Project.Text = "Project";
            this.Project.UseVisualStyleBackColor = true;
            // 
            // projectInfoUserControl
            // 
            this.projectInfoUserControl.Location = new System.Drawing.Point(11, 11);
            this.projectInfoUserControl.Name = "projectInfoUserControl";
            this.projectInfoUserControl.Size = new System.Drawing.Size(464, 171);
            this.projectInfoUserControl.TabIndex = 7;
            // 
            // CounterGroupBox
            // 
            this.CounterGroupBox.Controls.Add(this.TimeCounterLabel);
            this.CounterGroupBox.Controls.Add(this.SessionTimeSpanTextBox);
            this.CounterGroupBox.Controls.Add(this.CounterButton);
            this.CounterGroupBox.Controls.Add(this.SessionTimeSpanLabel);
            this.CounterGroupBox.Location = new System.Drawing.Point(20, 188);
            this.CounterGroupBox.Name = "CounterGroupBox";
            this.CounterGroupBox.Size = new System.Drawing.Size(444, 201);
            this.CounterGroupBox.TabIndex = 6;
            this.CounterGroupBox.TabStop = false;
            this.CounterGroupBox.Text = "StopWatch";
            // 
            // Add
            // 
            this.Add.Controls.Add(this.AddNewUserControl);
            this.Add.Location = new System.Drawing.Point(4, 29);
            this.Add.Name = "Add";
            this.Add.Padding = new System.Windows.Forms.Padding(3);
            this.Add.Size = new System.Drawing.Size(508, 728);
            this.Add.TabIndex = 1;
            this.Add.Text = "Add New";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // AddNewUserControl
            // 
            this.AddNewUserControl.Location = new System.Drawing.Point(6, 6);
            this.AddNewUserControl.Name = "AddNewUserControl";
            this.AddNewUserControl.Size = new System.Drawing.Size(465, 170);
            this.AddNewUserControl.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 452);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ProjectListLabel);
            this.Controls.Add(this.ProjectsListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Project.ResumeLayout(false);
            this.CounterGroupBox.ResumeLayout(false);
            this.CounterGroupBox.PerformLayout();
            this.Add.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox ProjectsListBox;
        private Label SessionTimeSpanLabel;
        private Label ProjectListLabel;
        private Label TimeCounterLabel;
        private TextBox SessionTimeSpanTextBox;
        private Button CounterButton;
        private System.Windows.Forms.Timer UpdateTimeSpanIntervalTimer;
        private TabControl tabControl1;
        private TabPage Project;
        private TabPage Add;
        private GroupBox CounterGroupBox;
        private ProjectInfo AddNewUserControl;
        private ProjectInfo projectInfoUserControl;
    }
}