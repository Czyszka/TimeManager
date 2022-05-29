namespace TimeManager
{
    partial class ProjectInfo
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProjectInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.WorkTimeSpanTextBox = new System.Windows.Forms.TextBox();
            this.ProjectDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.ProjectNameTextBox = new System.Windows.Forms.TextBox();
            this.WorkTimeSpanLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ProjectInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProjectInfoGroupBox
            // 
            this.ProjectInfoGroupBox.Controls.Add(this.WorkTimeSpanTextBox);
            this.ProjectInfoGroupBox.Controls.Add(this.ProjectDescriptionTextBox);
            this.ProjectInfoGroupBox.Controls.Add(this.ProjectNameTextBox);
            this.ProjectInfoGroupBox.Controls.Add(this.WorkTimeSpanLabel);
            this.ProjectInfoGroupBox.Controls.Add(this.DescriptionLabel);
            this.ProjectInfoGroupBox.Controls.Add(this.NameLabel);
            this.ProjectInfoGroupBox.Location = new System.Drawing.Point(9, 10);
            this.ProjectInfoGroupBox.Name = "ProjectInfoGroupBox";
            this.ProjectInfoGroupBox.Size = new System.Drawing.Size(447, 187);
            this.ProjectInfoGroupBox.TabIndex = 0;
            this.ProjectInfoGroupBox.TabStop = false;
            this.ProjectInfoGroupBox.Text = "ProjectInfo";
            // 
            // WorkTimeSpanTextBox
            // 
            this.WorkTimeSpanTextBox.Location = new System.Drawing.Point(124, 152);
            this.WorkTimeSpanTextBox.Name = "WorkTimeSpanTextBox";
            this.WorkTimeSpanTextBox.Size = new System.Drawing.Size(144, 27);
            this.WorkTimeSpanTextBox.TabIndex = 3;
            // 
            // ProjectDescriptionTextBox
            // 
            this.ProjectDescriptionTextBox.Location = new System.Drawing.Point(124, 65);
            this.ProjectDescriptionTextBox.Multiline = true;
            this.ProjectDescriptionTextBox.Name = "ProjectDescriptionTextBox";
            this.ProjectDescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ProjectDescriptionTextBox.Size = new System.Drawing.Size(307, 81);
            this.ProjectDescriptionTextBox.TabIndex = 2;
            // 
            // ProjectNameTextBox
            // 
            this.ProjectNameTextBox.Location = new System.Drawing.Point(124, 32);
            this.ProjectNameTextBox.Name = "ProjectNameTextBox";
            this.ProjectNameTextBox.Size = new System.Drawing.Size(307, 27);
            this.ProjectNameTextBox.TabIndex = 1;
            // 
            // WorkTimeSpanLabel
            // 
            this.WorkTimeSpanLabel.AutoSize = true;
            this.WorkTimeSpanLabel.Location = new System.Drawing.Point(26, 155);
            this.WorkTimeSpanLabel.Name = "WorkTimeSpanLabel";
            this.WorkTimeSpanLabel.Size = new System.Drawing.Size(78, 20);
            this.WorkTimeSpanLabel.TabIndex = 0;
            this.WorkTimeSpanLabel.Text = "TimeSpan:";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(16, 65);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(88, 20);
            this.DescriptionLabel.TabIndex = 0;
            this.DescriptionLabel.Text = "Description:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(52, 35);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(52, 20);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name:";
            // 
            // ProjectInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ProjectInfoGroupBox);
            this.Name = "ProjectInfo";
            this.Size = new System.Drawing.Size(466, 201);
            this.ProjectInfoGroupBox.ResumeLayout(false);
            this.ProjectInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox ProjectInfoGroupBox;
        private TextBox WorkTimeSpanTextBox;
        private TextBox ProjectDescriptionTextBox;
        private TextBox ProjectNameTextBox;
        private Label WorkTimeSpanLabel;
        private Label DescriptionLabel;
        private Label NameLabel;
    }
}
