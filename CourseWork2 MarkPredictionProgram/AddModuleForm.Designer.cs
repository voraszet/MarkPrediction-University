namespace CourseWork2_MarkPredictionProgram
{
    partial class AddModuleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.moduleNameTxt = new System.Windows.Forms.TextBox();
            this.moduleCodeTxt = new System.Windows.Forms.TextBox();
            this.moduleCreditsTxt = new System.Windows.Forms.TextBox();
            this.setModuleBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.numOfAssessmentsTxt = new System.Windows.Forms.TextBox();
            this.creditsComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Module Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Module Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Credits";
            // 
            // moduleNameTxt
            // 
            this.moduleNameTxt.Location = new System.Drawing.Point(164, 22);
            this.moduleNameTxt.Name = "moduleNameTxt";
            this.moduleNameTxt.Size = new System.Drawing.Size(121, 20);
            this.moduleNameTxt.TabIndex = 3;
            // 
            // moduleCodeTxt
            // 
            this.moduleCodeTxt.Location = new System.Drawing.Point(164, 58);
            this.moduleCodeTxt.Name = "moduleCodeTxt";
            this.moduleCodeTxt.Size = new System.Drawing.Size(121, 20);
            this.moduleCodeTxt.TabIndex = 4;
            // 
            // moduleCreditsTxt
            // 
            this.moduleCreditsTxt.Location = new System.Drawing.Point(268, 96);
            this.moduleCreditsTxt.Name = "moduleCreditsTxt";
            this.moduleCreditsTxt.Size = new System.Drawing.Size(121, 20);
            this.moduleCreditsTxt.TabIndex = 5;
            // 
            // setModuleBtn
            // 
            this.setModuleBtn.Location = new System.Drawing.Point(164, 202);
            this.setModuleBtn.Name = "setModuleBtn";
            this.setModuleBtn.Size = new System.Drawing.Size(75, 23);
            this.setModuleBtn.TabIndex = 6;
            this.setModuleBtn.Text = "Add";
            this.setModuleBtn.UseVisualStyleBackColor = true;
            this.setModuleBtn.Click += new System.EventHandler(this.setModuleBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Number of Assessments";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // numOfAssessmentsTxt
            // 
            this.numOfAssessmentsTxt.Location = new System.Drawing.Point(181, 156);
            this.numOfAssessmentsTxt.Name = "numOfAssessmentsTxt";
            this.numOfAssessmentsTxt.Size = new System.Drawing.Size(42, 20);
            this.numOfAssessmentsTxt.TabIndex = 8;
            this.numOfAssessmentsTxt.TextChanged += new System.EventHandler(this.numOfAssessments_TextChanged);
            // 
            // creditsComboBox
            // 
            this.creditsComboBox.FormattingEnabled = true;
            this.creditsComboBox.Location = new System.Drawing.Point(164, 96);
            this.creditsComboBox.Name = "creditsComboBox";
            this.creditsComboBox.Size = new System.Drawing.Size(62, 21);
            this.creditsComboBox.TabIndex = 9;
            // 
            // AddModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 269);
            this.Controls.Add(this.creditsComboBox);
            this.Controls.Add(this.numOfAssessmentsTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.setModuleBtn);
            this.Controls.Add(this.moduleCreditsTxt);
            this.Controls.Add(this.moduleCodeTxt);
            this.Controls.Add(this.moduleNameTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddModuleForm";
            this.Text = "AddModuleForm";
            this.Load += new System.EventHandler(this.AddModuleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox moduleNameTxt;
        private System.Windows.Forms.TextBox moduleCodeTxt;
        private System.Windows.Forms.TextBox moduleCreditsTxt;
        private System.Windows.Forms.Button setModuleBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox numOfAssessmentsTxt;
        private System.Windows.Forms.ComboBox creditsComboBox;
    }
}