using System;
using System.Linq;
using System.Windows.Forms;

namespace Milestone1
{
    public partial class Form1 : Form
    {
        // Create binding source.
        BindingSource bs = new BindingSource();

        // Declare Variables
        const int ROWS = 1000;
        int nextItem = 0; // Variable meant to assign the next number to next item.

        // Create Array of InventoryItem. In other words, using the properties for InventoryItem class.
        InventoryItem[] myArrayList = new InventoryItem[ROWS];

        public Form1()
        {
            InitializeComponent();
            // Bind myArrayList to bs.
            bs.DataSource = myArrayList; 
        }

        // We call GetInput method with InventoryItem object named lineItem.
        private InventoryItem GetInput(bool isSearch = false)
        {
            // Create instance of InventoryItem class.
            InventoryItem lineItem = new InventoryItem();

            // Verify conversion of user input to int.
            if (int.TryParse(idTextBox.Text, out int inventoryId))
            {
                // Assigned to InventoryItem object's inventoryId property.
                lineItem.InventoryId = inventoryId;
            }
            else
            {
                // Because we call the GetInput() in the Search(), if statement states that while not in search
                // mode, display message and return null. Otherwise, message will populate when search button is clicked
                // and nothing was retrieved from quantity text box.
                if (!isSearch)
                {
                    MessageBox.Show("Invalid entry for inventory id. Enter number only.");
                    return null;
                }
            }

            // Assigned to 's medication property.
            lineItem.Medication = medicationTextBox.Text;

            // Assigned to object's deliveryForm property.
            lineItem.DeliveryForm = formTextBox.Text;

            // Verify conversion of user input to int.
            if (int.TryParse(quantityTextBox.Text, out int quantity))
            {
                // Assigned to object's quantity property.
                lineItem.Quantity = quantity;
            }
            else
            {
                // Because we call the GetInput() in the Search(), if statement states that while not in search
                // mode, display message and return null. Otherwise, message will populate when search button is clicked
                // and nothing was retrieved from quantity text box.
                if (!isSearch)
                {
                    MessageBox.Show("Invalid entry for quantity. Enter number only.");
                    return null;
                }
            }

            // Verify conversion of user input to double.
            if (double.TryParse(unitPriceTextBox.Text, out double unitPrice))
            {
                // Assigned to object's unitPrice property.
                lineItem.UnitPrice = unitPrice;
            }
            else
            {
                // Because we call the GetInput() in the Search(), if statement states that while not in search
                // mode, display message and return null. Otherwise, message will populate when search button is clicked
                // and nothing was retrieved from quantity text box.
                if (!isSearch)
                {
                    MessageBox.Show("Invalid entry for unit price. Enter number only.");
                    return null;
                }
            }
            // Returns lineItem of InventoryItem type.
            return lineItem;
        }

        public void FormatInput()
        {
            // Set focus to idTextbox.
            idTextBox.Focus();

            // Get input and assign to variable.
            var input = GetInput();

            // If control has no input, it does not add item to ListBox.
            if (input == null) return;

            // Add input to myArrayList with current nextItem number. Then add one to nextItem.
            myArrayList[nextItem] = input;
            nextItem++;

            // Add entire input to list box.
            inventoryListBox.Items.Add(input);

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
            // Reset each control.
            idTextBox.Text = "";
            medicationTextBox.Text = "";
            formTextBox.Text = "";
            quantityTextBox.Text = "";
            unitPriceTextBox.Text = "";

            // Set focus to idTextBox.
            idTextBox.Focus();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            // Get and assign user input to variable.
            var input = GetInput();

            // If any input returns null, it will not 
            if (input == null) return;

            // Selected item is assigned to index variable.
            int index = inventoryListBox.SelectedIndex;

            // Index is then assigned to oldItem
            var oldItem = myArrayList[index];
            
            // Input replaces oldItem at index.
            myArrayList[index] = input;

            // oldItem is removed.
            inventoryListBox.Items.Remove(oldItem);

            // Add item to inventoryListBox.
            inventoryListBox.Items.Add(input);
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Declare variable and value.
                int index = inventoryListBox.SelectedIndex;

                // myArrayList is converted to list in order to remove selected item.
                var list = myArrayList.ToList();

                // index is removed from list.
                list.Remove(myArrayList[index]);

                // list is converted back to myArrayList.
                myArrayList = list.ToArray();

                // index is removed from inventoryListBox.
                inventoryListBox.Items.RemoveAt(index);

                // Because the index was deleted from list, I must deduct one from the array.
                nextItem--;
            }
            catch
            {

            }
        }

        private void inventoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Declared variable and value.
                int index = inventoryListBox.SelectedIndex;

                // Assigns each element value to respective control.
                idTextBox.Text = myArrayList[index].InventoryId.ToString();
                medicationTextBox.Text = myArrayList[index].Medication;
                formTextBox.Text = myArrayList[index].DeliveryForm;
                quantityTextBox.Text = myArrayList[index].Quantity.ToString();
                unitPriceTextBox.Text = myArrayList[index].UnitPrice.ToString();

            }
            catch
            {
                // Meant to catch the error, but continue executing.
            }
        }

        public void Search()
        {
            // Receives input if passed boolean argument returns true and assigns to variable.
            var input = GetInput(true);

            // Declare variable and initialized.
            var index = 0;
            
            // Clears any selected item.
            inventoryListBox.ClearSelected();

            // Foreach loop checks every item in myArrayList.
            foreach (var item in myArrayList)
            {
                // Since myArrayList accepts 1000 elements, most will be null. Therefore,
                // if statement checks only those elements that have a value.
                if (item != null)
                {
                    // If statement uses IsMatch method to find the input within the item properties.
                    if (IsMatch(item, input))
                    {
                        // If input is found, entire item is selected or highlighted.
                        inventoryListBox.SelectedItems.Add(inventoryListBox.Items[index]);
                    }
                    else
                    {
                        // Otherwise it removes the selected or highlight from item.
                        inventoryListBox.SelectedItems.Remove(inventoryListBox.Items[index]);
                    }
                    // Counter is added.
                    index++;
                }
            }
        }

        // Method is to determine if input matches item any property from InventoryItem.
        private bool IsMatch(InventoryItem item, InventoryItem input)
        {
            // If input matches any property, returns true. Also code sets priority for search.
            // If user inputs InventoryId value to search, it will search by Id first. If not,
            // will skip to the next criteria.
            // double data type property has tolerance of 0.0001. In other words, matches up to
            // a difference of 0.0001.
            return item.InventoryId == input.InventoryId ||
                   item.Medication.ToLower() == input.Medication.ToLower() ||
                   Math.Abs(item.UnitPrice - input.UnitPrice) < 0.0001 ||
                   item.DeliveryForm == input.DeliveryForm ||
                   item.Quantity == input.Quantity;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            // Call method.
            Search();
        }
    }
}
// Leonides Martinez
// CST-150
// September 26, 2021
// Mark Smithers