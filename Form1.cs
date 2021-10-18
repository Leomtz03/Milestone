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
    public partial class Form1 : Form
    {
        List<InventoryItem> myList = new List<InventoryItem>();
        BindingSource bs = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            bs.DataSource = myList;
        }

        // We call GetInput method with InventoryItem object named lineItem.
        private void GetInput(InventoryItem lineItem)
        {
            // Verify conversion of user input to int.
            if (int.TryParse(idTextBox.Text, out int inventoryId))
            {
                // Assigned to InventoryItem object's inventoryId property.
                lineItem.inventoryId = inventoryId;
            }
            else
            {
                MessageBox.Show("Invalid entry for inventory id. Enter number only.");
            }

            // Assigned to object's medication property.
            lineItem.medication = medicationTextBox.Text;

            // Assigned to object's deliveryForm property.
            lineItem.deliveryForm = formTextBox.Text;

            // Verify conversion of user input to int.
            if (int.TryParse(quantityTextBox.Text, out int quantity))
            {
                // Assigned to object's quantity property.
                lineItem.quantity = quantity;
            }
            else
            {
                MessageBox.Show("Invalid entry for quantity. Enter number only.");
            }

            // Verify conversion of user input to double.
            if (double.TryParse(unitPriceTextBox.Text, out double unitPrice))
            {
                // Assigned to object's unitPrice property.
                lineItem.unitPrice = unitPrice;
            }
            else
            {
                MessageBox.Show("Invalid entry for unit price. Enter number only.");
            }
        }

        public void FormatInput()
        {
            idTextBox.Focus();

            // Create an object or instance named item.
            InventoryItem item = new InventoryItem();

            // Pass the item object or instance when GetInput method is called.
            GetInput(item);

            myList.Add(item);
            //inventoryListBox.DataSource = bs;
            //bs.ResetBindings(false);

            // Add entire item to list box.
            inventoryListBox.Items.Add(item.inventoryId + " " + item.medication + " " + item.deliveryForm + " " +
                item.quantity.ToString() + " " + item.unitPrice.ToString("c"));

            // Add item to myList.
            //myList.Add(item.inventoryId + " " + item.medication + " " + item.deliveryForm + " " +
            //item.quantity.ToString() + " " + item.unitPrice.ToString("c"));

            // Bind myList to inventoryListBox.
            //inventoryListBox.DataSource = bs;

            // Display number of entries.
            countLbl.Text = inventoryListBox.Items.Count.ToString() + " entries.";

            // Return focus to inventory id.
            idTextBox.Focus();

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            // Call the method.
            FormatInput();

            // Call the method to reset input.
            reset();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        {
            idTextBox.Text = "";
            medicationTextBox.Text = "";
            formTextBox.Text = "";
            quantityTextBox.Text = "";
            unitPriceTextBox.Text = "";

            idTextBox.Focus();
        }

        private void inventoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int index = inventoryListBox.SelectedIndex;

                idTextBox.Text = myList[index].inventoryId.ToString();
                medicationTextBox.Text = myList[index].medication;
                formTextBox.Text = myList[index].deliveryForm;
                quantityTextBox.Text = myList[index].quantity.ToString();
                unitPriceTextBox.Text = myList[index].unitPrice.ToString();
            }
            catch
            {
                // Meant to catch the error, but continue executing.
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            InventoryItem item = new InventoryItem();

            int index = inventoryListBox.SelectedIndex;

            GetInput(item);

            myList.Add(item);
            //inventoryListBox.DataSource = bs;
            //bs.ResetBindings(false);

            inventoryListBox.Items.Add(item.inventoryId + " " + item.medication + " " + item.deliveryForm + " " +
              item.quantity.ToString() + " " + item.unitPrice.ToString("c"));

            inventoryListBox.Items.RemoveAt(index);
        }
    }
}
// Leonides Martinez
// CST-150
// September 26, 2021
// Mark Smithers