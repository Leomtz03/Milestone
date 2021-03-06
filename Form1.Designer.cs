
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
            this.removeBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.dispenseBtn = new System.Windows.Forms.Button();
            this.viewBtn = new System.Windows.Forms.Button();
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
            this.submitBtn.BackColor = System.Drawing.Color.Green;
            this.submitBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.ForeColor = System.Drawing.Color.White;
            this.submitBtn.Location = new System.Drawing.Point(390, 178);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 1;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.resetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.resetBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.resetBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.Location = new System.Drawing.Point(309, 178);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 18;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = false;
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
            this.inventoryListBox.Size = new System.Drawing.Size(609, 212);
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
            this.updateBtn.BackColor = System.Drawing.Color.Blue;
            this.updateBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.Location = new System.Drawing.Point(228, 178);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 41;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.removeBtn.BackColor = System.Drawing.Color.Maroon;
            this.removeBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.ForeColor = System.Drawing.Color.White;
            this.removeBtn.Location = new System.Drawing.Point(147, 178);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(75, 23);
            this.removeBtn.TabIndex = 43;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.searchBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(66, 178);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 46;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // dispenseBtn
            // 
            this.dispenseBtn.BackColor = System.Drawing.Color.Red;
            this.dispenseBtn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispenseBtn.ForeColor = System.Drawing.Color.White;
            this.dispenseBtn.Location = new System.Drawing.Point(228, 459);
            this.dispenseBtn.Name = "dispenseBtn";
            this.dispenseBtn.Size = new System.Drawing.Size(156, 55);
            this.dispenseBtn.TabIndex = 47;
            this.dispenseBtn.Text = "Dispense";
            this.dispenseBtn.UseVisualStyleBackColor = false;
            this.dispenseBtn.Click += new System.EventHandler(this.dispenseBtn_Click);
            // 
            // viewBtn
            // 
            this.viewBtn.BackColor = System.Drawing.Color.Aqua;
            this.viewBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBtn.ForeColor = System.Drawing.Color.Black;
            this.viewBtn.Location = new System.Drawing.Point(546, 92);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(75, 23);
            this.viewBtn.TabIndex = 48;
            this.viewBtn.Text = "View Item";
            this.viewBtn.UseVisualStyleBackColor = false;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
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
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.dispenseBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.removeBtn);
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
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button dispenseBtn;
        private System.Windows.Forms.Button viewBtn;
    }
}

