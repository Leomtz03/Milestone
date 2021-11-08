
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.formTextBox = new System.Windows.Forms.TextBox();
            this.medicationTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.inventoryIdLbl = new System.Windows.Forms.Label();
            this.formLbl = new System.Windows.Forms.Label();
            this.unitPriceLbl = new System.Windows.Forms.Label();
            this.medicationLbl = new System.Windows.Forms.Label();
            this.quantityLbl = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.unitPriceTextBox.Location = new System.Drawing.Point(159, 137);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.unitPriceTextBox.TabIndex = 47;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.quantityTextBox.Location = new System.Drawing.Point(159, 110);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityTextBox.TabIndex = 46;
            // 
            // formTextBox
            // 
            this.formTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.formTextBox.Location = new System.Drawing.Point(159, 83);
            this.formTextBox.Name = "formTextBox";
            this.formTextBox.Size = new System.Drawing.Size(100, 20);
            this.formTextBox.TabIndex = 45;
            // 
            // medicationTextBox
            // 
            this.medicationTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.medicationTextBox.Location = new System.Drawing.Point(159, 57);
            this.medicationTextBox.Name = "medicationTextBox";
            this.medicationTextBox.Size = new System.Drawing.Size(100, 20);
            this.medicationTextBox.TabIndex = 44;
            // 
            // idTextBox
            // 
            this.idTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.idTextBox.Location = new System.Drawing.Point(159, 31);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 43;
            // 
            // inventoryIdLbl
            // 
            this.inventoryIdLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inventoryIdLbl.AutoSize = true;
            this.inventoryIdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryIdLbl.Location = new System.Drawing.Point(41, 32);
            this.inventoryIdLbl.Name = "inventoryIdLbl";
            this.inventoryIdLbl.Size = new System.Drawing.Size(100, 17);
            this.inventoryIdLbl.TabIndex = 42;
            this.inventoryIdLbl.Text = "Inventory ID:";
            // 
            // formLbl
            // 
            this.formLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.formLbl.AutoSize = true;
            this.formLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formLbl.Location = new System.Drawing.Point(41, 84);
            this.formLbl.Name = "formLbl";
            this.formLbl.Size = new System.Drawing.Size(113, 17);
            this.formLbl.TabIndex = 41;
            this.formLbl.Text = "Delivery Form:";
            // 
            // unitPriceLbl
            // 
            this.unitPriceLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.unitPriceLbl.AutoSize = true;
            this.unitPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitPriceLbl.Location = new System.Drawing.Point(41, 138);
            this.unitPriceLbl.Name = "unitPriceLbl";
            this.unitPriceLbl.Size = new System.Drawing.Size(84, 17);
            this.unitPriceLbl.TabIndex = 40;
            this.unitPriceLbl.Text = "Unit Price:";
            // 
            // medicationLbl
            // 
            this.medicationLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.medicationLbl.AutoSize = true;
            this.medicationLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicationLbl.Location = new System.Drawing.Point(41, 58);
            this.medicationLbl.Name = "medicationLbl";
            this.medicationLbl.Size = new System.Drawing.Size(91, 17);
            this.medicationLbl.TabIndex = 38;
            this.medicationLbl.Text = "Medication:";
            // 
            // quantityLbl
            // 
            this.quantityLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.quantityLbl.AutoSize = true;
            this.quantityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLbl.Location = new System.Drawing.Point(41, 111);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(74, 17);
            this.quantityLbl.TabIndex = 39;
            this.quantityLbl.Text = "Quantity:";
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.closeBtn.BackColor = System.Drawing.Color.Red;
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(121, 174);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 48;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AcceptButton = this.closeBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(314, 226);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.unitPriceTextBox);
            this.Controls.Add(this.inventoryIdLbl);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.quantityLbl);
            this.Controls.Add(this.formTextBox);
            this.Controls.Add(this.medicationLbl);
            this.Controls.Add(this.medicationTextBox);
            this.Controls.Add(this.unitPriceLbl);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.formLbl);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Medication Description";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox formTextBox;
        private System.Windows.Forms.TextBox medicationTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label inventoryIdLbl;
        private System.Windows.Forms.Label formLbl;
        private System.Windows.Forms.Label unitPriceLbl;
        private System.Windows.Forms.Label medicationLbl;
        private System.Windows.Forms.Label quantityLbl;
        private System.Windows.Forms.Button closeBtn;
    }
}