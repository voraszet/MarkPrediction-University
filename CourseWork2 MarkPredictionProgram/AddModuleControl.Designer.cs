namespace CourseWork2_MarkPredictionProgram
{
    partial class AddModuleControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.moduleRemoveBtn = new System.Windows.Forms.Button();
            this.moduleNameLbl = new System.Windows.Forms.Label();
            this.moduleCodeLbl = new System.Windows.Forms.Label();
            this.moduleCreditsLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Module Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Credits:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Module Code:";
            // 
            // moduleRemoveBtn
            // 
            this.moduleRemoveBtn.Location = new System.Drawing.Point(515, 122);
            this.moduleRemoveBtn.Name = "moduleRemoveBtn";
            this.moduleRemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.moduleRemoveBtn.TabIndex = 3;
            this.moduleRemoveBtn.Text = "Remove";
            this.moduleRemoveBtn.UseVisualStyleBackColor = true;
            this.moduleRemoveBtn.Click += new System.EventHandler(this.moduleRemoveBtn_Click);
            // 
            // moduleNameLbl
            // 
            this.moduleNameLbl.AutoSize = true;
            this.moduleNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moduleNameLbl.Location = new System.Drawing.Point(189, 16);
            this.moduleNameLbl.Name = "moduleNameLbl";
            this.moduleNameLbl.Size = new System.Drawing.Size(46, 18);
            this.moduleNameLbl.TabIndex = 4;
            this.moduleNameLbl.Text = "label4";
            // 
            // moduleCodeLbl
            // 
            this.moduleCodeLbl.AutoSize = true;
            this.moduleCodeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moduleCodeLbl.Location = new System.Drawing.Point(189, 46);
            this.moduleCodeLbl.Name = "moduleCodeLbl";
            this.moduleCodeLbl.Size = new System.Drawing.Size(46, 18);
            this.moduleCodeLbl.TabIndex = 5;
            this.moduleCodeLbl.Text = "label5";
            // 
            // moduleCreditsLbl
            // 
            this.moduleCreditsLbl.AutoSize = true;
            this.moduleCreditsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moduleCreditsLbl.Location = new System.Drawing.Point(189, 77);
            this.moduleCreditsLbl.Name = "moduleCreditsLbl";
            this.moduleCreditsLbl.Size = new System.Drawing.Size(46, 18);
            this.moduleCreditsLbl.TabIndex = 6;
            this.moduleCreditsLbl.Text = "label6";
            // 
            // AddModuleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.moduleCreditsLbl);
            this.Controls.Add(this.moduleCodeLbl);
            this.Controls.Add(this.moduleNameLbl);
            this.Controls.Add(this.moduleRemoveBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddModuleControl";
            this.Size = new System.Drawing.Size(597, 150);
            this.Load += new System.EventHandler(this.AddModuleControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button moduleRemoveBtn;
        private System.Windows.Forms.Label moduleNameLbl;
        private System.Windows.Forms.Label moduleCodeLbl;
        private System.Windows.Forms.Label moduleCreditsLbl;
    }
}
