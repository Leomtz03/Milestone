
namespace Milestone1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.medicationLbl = new System.Windows.Forms.Label();
            this.quantityLbl = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.unitPriceLbl = new System.Windows.Forms.Label();
            this.formLbl = new System.Windows.Forms.Label();
            this.inventoryIdLbl = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.medicationTextBox = new System.Windows.Forms.TextBox();
            this.formTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.inventoryListBox = new System.Windows.Forms.ListBox();
            this.countLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.titleLbl = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // medicationLbl
            // 
            this.medicationLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.medicationLbl.AutoSize = true;
            this.medicationLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicationLbl.Location = new System.Drawing.Point(21, 121);
            this.medicationLbl.Name = "medicationLbl";
            this.medicationLbl.Size = new System.Drawing.Size(91, 17);
            this.medicationLbl.TabIndex = 0;
            this.medicationLbl.Text = "Medication:";
            // 
            // quantityLbl
            // 
            this.quantityLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.quantityLbl.AutoSize = true;
            this.quantityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLbl.Location = new System.Drawing.Point(329, 95);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(74, 17);
            this.quantityLbl.TabIndex = 6;
            this.quantityLbl.Text = "Quantity:";
            // 
            // submitBtn
            // 
            this.submitBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.submitBtn.Location = new System.Drawing.Point(341, 178);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 1;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.resetBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.resetBtn.Location = new System.Drawing.Point(237, 178);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 18;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // unitPriceLbl
            // 
            this.unitPriceLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.unitPriceLbl.AutoSize = true;
            this.unitPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitPriceLbl.Location = new System.Drawing.Point(329, 121);
            this.unitPriceLbl.Name = "unitPriceLbl";
            this.unitPriceLbl.Size = new System.Drawing.Size(84, 17);
            this.unitPriceLbl.TabIndex = 19;
            this.unitPriceLbl.Text = "Unit Price:";
            // 
            // formLbl
            // 
            this.formLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.formLbl.AutoSize = true;
            this.formLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formLbl.Location = new System.Drawing.Point(21, 147);
            this.formLbl.Name = "formLbl";
            this.formLbl.Size = new System.Drawing.Size(113, 17);
            this.formLbl.TabIndex = 31;
            this.formLbl.Text = "Delivery Form:";
            // 
            // inventoryIdLbl
            // 
            this.inventoryIdLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inventoryIdLbl.AutoSize = true;
            this.inventoryIdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryIdLbl.Location = new System.Drawing.Point(21, 95);
            this.inventoryIdLbl.Name = "inventoryIdLbl";
            this.inventoryIdLbl.Size = new System.Drawing.Size(100, 17);
            this.inventoryIdLbl.TabIndex = 32;
            this.inventoryIdLbl.Text = "Inventory ID:";
            // 
            // idTextBox
            // 
            this.idTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.idTextBox.Location = new System.Drawing.Point(139, 94);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 33;
            // 
            // medicationTextBox
            // 
            this.medicationTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.medicationTextBox.Location = new System.Drawing.Point(139, 120);
            this.medicationTextBox.Name = "medicationTextBox";
            this.medicationTextBox.Size = new System.Drawing.Size(100, 20);
            this.medicationTextBox.TabIndex = 34;
            // 
            // formTextBox
            // 
            this.formTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.formTextBox.Location = new System.Drawing.Point(139, 146);
            this.formTextBox.Name = "formTextBox";
            this.formTextBox.Size = new System.Drawing.Size(100, 20);
            this.formTextBox.TabIndex = 35;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.quantityTextBox.Location = new System.Drawing.Point(430, 94);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityTextBox.TabIndex = 36;
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.unitPriceTextBox.Location = new System.Drawing.Point(430, 121);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.unitPriceTextBox.TabIndex = 37;
            // 
            // inventoryListBox
            // 
            this.inventoryListBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inventoryListBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.inventoryListBox.FormattingEnabled = true;
            this.inventoryListBox.Location = new System.Drawing.Point(12, 226);
            this.inventoryListBox.Name = "inventoryListBox";
            this.inventoryListBox.Size = new System.Drawing.Size(609, 264);
            this.inventoryListBox.TabIndex = 38;
            this.inventoryListBox.SelectedIndexChanged += new System.EventHandler(this.inventoryListBox_SelectedIndexChanged);
            // 
            // countLbl
            // 
            this.countLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.countLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.countLbl.Location = new System.Drawing.Point(480, 178);
            this.countLbl.Name = "countLbl";
            this.countLbl.Size = new System.Drawing.Size(141, 23);
            this.countLbl.TabIndex = 39;
            this.countLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.titleLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 70);
            this.panel1.TabIndex = 40;
            // 
            // titleLbl
            // 
            this.titleLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.White;
            this.titleLbl.Location = new System.Drawing.Point(183, 26);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(301, 24);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Pharmacy Medication Inventory";
            // 
            // updateBtn
            // 
            this.updateBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.updateBtn.Location = new System.Drawing.Point(139, 178);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 41;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.submitBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.resetBtn;
            this.ClientSize = new System.Drawing.Size(634, 541);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.countLbl);
            this.Controls.Add(this.inventoryListBox);
            this.Controls.Add(this.unitPriceTextBox);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.formTextBox);
            this.Controls.Add(this.medicationTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.inventoryIdLbl);
            this.Controls.Add(this.formLbl);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.unitPriceLbl);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.medicationLbl);
            this.Controls.Add(this.quantityLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(650, 580);
            this.Name = "Form1";
            this.Text = "Pharmacy Medication Inventory";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label medicationLbl;
        private System.Windows.Forms.Label quantityLbl;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label unitPriceLbl;
        private System.Windows.Forms.Label formLbl;
        private System.Windows.Forms.Label inventoryIdLbl;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox medicationTextBox;
        private System.Windows.Forms.TextBox formTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.ListBox inventoryListBox;
        private System.Windows.Forms.Label countLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button updateBtn;
    }
}

