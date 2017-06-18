namespace CourseWork2_MarkPredictionProgram
{
    partial class AddAssessments
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
            this.moduleNameLabel = new System.Windows.Forms.Label();
            this.moduleCodeLabel = new System.Windows.Forms.Label();
            this.moduleCreditsLabel = new System.Windows.Forms.Label();
            this.assessmentSubmitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // moduleNameLabel
            // 
            this.moduleNameLabel.AutoSize = true;
            this.moduleNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moduleNameLabel.Location = new System.Drawing.Point(293, 8);
            this.moduleNameLabel.Name = "moduleNameLabel";
            this.moduleNameLabel.Size = new System.Drawing.Size(78, 18);
            this.moduleNameLabel.TabIndex = 0;
            this.moduleNameLabel.Text = "modName";
            // 
            // moduleCodeLabel
            // 
            this.moduleCodeLabel.AutoSize = true;
            this.moduleCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moduleCodeLabel.Location = new System.Drawing.Point(293, 43);
            this.moduleCodeLabel.Name = "moduleCodeLabel";
            this.moduleCodeLabel.Size = new System.Drawing.Size(74, 18);
            this.moduleCodeLabel.TabIndex = 1;
            this.moduleCodeLabel.Text = "modCode";
            // 
            // moduleCreditsLabel
            // 
            this.moduleCreditsLabel.AutoSize = true;
            this.moduleCreditsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moduleCreditsLabel.Location = new System.Drawing.Point(293, 75);
            this.moduleCreditsLabel.Name = "moduleCreditsLabel";
            this.moduleCreditsLabel.Size = new System.Drawing.Size(85, 18);
            this.moduleCreditsLabel.TabIndex = 2;
            this.moduleCreditsLabel.Text = "modCredits";
            // 
            // assessmentSubmitBtn
            // 
            this.assessmentSubmitBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.assessmentSubmitBtn.Location = new System.Drawing.Point(303, 257);
            this.assessmentSubmitBtn.Name = "assessmentSubmitBtn";
            this.assessmentSubmitBtn.Size = new System.Drawing.Size(75, 23);
            this.assessmentSubmitBtn.TabIndex = 3;
            this.assessmentSubmitBtn.Text = "Generate";
            this.assessmentSubmitBtn.UseVisualStyleBackColor = true;
            this.assessmentSubmitBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddAssessments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 292);
            this.Controls.Add(this.assessmentSubmitBtn);
            this.Controls.Add(this.moduleCreditsLabel);
            this.Controls.Add(this.moduleCodeLabel);
            this.Controls.Add(this.moduleNameLabel);
            this.Name = "AddAssessments";
            this.Text = "AddAssessments";
            this.Load += new System.EventHandler(this.AddAssessments_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label moduleNameLabel;
        private System.Windows.Forms.Label moduleCodeLabel;
        private System.Windows.Forms.Label moduleCreditsLabel;
        private System.Windows.Forms.Button assessmentSubmitBtn;
    }
}