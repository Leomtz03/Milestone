
namespace Milestone1
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.medicationLabel = new System.Windows.Forms.Label();
            this.formLabel = new System.Windows.Forms.Label();
            this.medicationDisplayLabel = new System.Windows.Forms.Label();
            this.formDisplayLabel = new System.Windows.Forms.Label();
            this.purposeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.okButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.purposeLabel);
            this.groupBox1.Controls.Add(this.formDisplayLabel);
            this.groupBox1.Controls.Add(this.medicationDisplayLabel);
            this.groupBox1.Controls.Add(this.formLabel);
            this.groupBox1.Controls.Add(this.medicationLabel);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medication Description";
            // 
            // medicationLabel
            // 
            this.medicationLabel.AutoSize = true;
            this.medicationLabel.Location = new System.Drawing.Point(12, 26);
            this.medicationLabel.Name = "medicationLabel";
            this.medicationLabel.Size = new System.Drawing.Size(93, 13);
            this.medicationLabel.TabIndex = 1;
            this.medicationLabel.Text = "Medication Name:";
            // 
            // formLabel
            // 
            this.formLabel.AutoSize = true;
            this.formLabel.Location = new System.Drawing.Point(223, 26);
            this.formLabel.Name = "formLabel";
            this.formLabel.Size = new System.Drawing.Size(33, 13);
            this.formLabel.TabIndex = 2;
            this.formLabel.Text = "Form:";
            // 
            // medicationDisplayLabel
            // 
            this.medicationDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.medicationDisplayLabel.Location = new System.Drawing.Point(12, 51);
            this.medicationDisplayLabel.Name = "medicationDisplayLabel";
            this.medicationDisplayLabel.Size = new System.Drawing.Size(141, 17);
            this.medicationDisplayLabel.TabIndex = 3;
            // 
            // formDisplayLabel
            // 
            this.formDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.formDisplayLabel.Location = new System.Drawing.Point(226, 51);
            this.formDisplayLabel.Name = "formDisplayLabel";
            this.formDisplayLabel.Size = new System.Drawing.Size(40, 17);
            this.formDisplayLabel.TabIndex = 4;
            // 
            // purposeLabel
            // 
            this.purposeLabel.AutoSize = true;
            this.purposeLabel.Location = new System.Drawing.Point(12, 86);
            this.purposeLabel.Name = "purposeLabel";
            this.purposeLabel.Size = new System.Drawing.Size(49, 13);
            this.purposeLabel.TabIndex = 5;
            this.purposeLabel.Text = "Purpose:";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 46);
            this.label1.TabIndex = 6;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(191, 173);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 9;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 245);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Medication Description";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label purposeLabel;
        private System.Windows.Forms.Label formDisplayLabel;
        private System.Windows.Forms.Label medicationDisplayLabel;
        private System.Windows.Forms.Label formLabel;
        private System.Windows.Forms.Label medicationLabel;
    }
}