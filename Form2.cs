using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            idTextBox.Text = Form1.SetValueForID.ToString();
            medicationTextBox.Text = Form1.SetValueForMedication.ToString();
            formTextBox.Text = Form1.SetValueForDeliveryForm.ToString();
            quantityTextBox.Text = Form1.SetValueForQuantity.ToString();
            unitPriceTextBox.Text = Form1.SetValueForUnitPrice.ToString();
        }
    }
}
