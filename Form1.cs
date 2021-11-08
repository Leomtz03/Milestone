using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Milestone1
{
    public partial class Form1 : Form
    {
        // Create binding source.
        BindingSource bs = new BindingSource();

        // Create a list of inventory items.
        List<InventoryItem> myList = new List<InventoryItem>();

        public static string SetValueForID = "";
        public static string SetValueForMedication = "";
        public static string SetValueForDeliveryForm = "";
        public static string SetValueForQuantity = "";
        public static string SetValueForUnitPrice = "";

        public Form1()
        {
            InitializeComponent();
            // Bind myList to bs.
            bs.DataSource = myList;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            // Call the method.
            FormatInput();

            // Call the method to reset input.
            Reset();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            // Call method.
            Reset();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            // Call method.
            UpdateItem();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            // Call method.
            RemoveItem();
        }

        private void inventoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Declared variable and value.
                int index = inventoryListBox.SelectedIndex;

                // Assigns each element value to respective control.
                idTextBox.Text = myList[index].InventoryId.ToString();
                medicationTextBox.Text = myList[index].Medication;
                formTextBox.Text = myList[index].DeliveryForm;
                quantityTextBox.Text = myList[index].Quantity.ToString();
                unitPriceTextBox.Text = myList[index].UnitPrice.ToString();

            }
            catch
            {
                // Meant to catch the error, but continue executing.
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            // Call method.
            Search();
        }

        private void dispenseBtn_Click(object sender, EventArgs e)
        {
            // Call method.
            Dispense();
        }

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

            // Add input to myList.
            myList.Add(input);

            // Add entire input to list box.
            inventoryListBox.Items.Add(input);

            // Display number of entries.
            countLbl.Text = inventoryListBox.Items.Count.ToString() + " entries.";

            // Return focus to inventory id.
            idTextBox.Focus();
        }

        public void Reset()
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

        public void UpdateItem()
        {
            // Get and assign user input to variable.
            var input = GetInput();

            // If any input returns null, it will not 
            if (input == null) return;

            // Selected item is assigned to index variable.
            int index = inventoryListBox.SelectedIndex;

            // Selected item is assigned to oldIndex.
            var oldIndex = myList[index];

            // New input is assigned to current index on myList.
            myList[index] = input;

            // Replace item on list at index.
            myList.Remove(oldIndex);
            myList.Add(myList[index]);

            // Add item to inventoryListBox.
            inventoryListBox.Items.Add(input);

            // Remove selected item from inventoryListBox.
            inventoryListBox.Items.Remove(oldIndex);

            // Sort items on inventoryListBox.
            inventoryListBox.Sorted = true;
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

        public void RemoveItem()
        {
            try
            {
                // Declare variable and value.
                int index = inventoryListBox.SelectedIndex;

                // Get and assign user input to variable.
                var input = GetInput();

                // If any input returns null, it will not 
                if (input == null) return;

                // Assign selected index to oldItem.
                var oldItem = myList[index];

                // Assign input to myList[index].
                myList[index] = input;

                // Remove index from myList.
                myList.Remove(myList[index]);

                // Remove oldItem from inventoryListBox.
                inventoryListBox.Items.Remove(oldItem);

                // Display number of entries.
                countLbl.Text = inventoryListBox.Items.Count.ToString() + " entries.";

                // Resets all input boxes.
                Reset();
            }
            catch
            {

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

            try
            {
                // Foreach loop checks every item in myList.
                foreach (var item in myList)
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
            catch
            {

            }
        }

        public void Dispense()
        {
            // Get and assign user input to variable.
            var input = GetInput();

            // If any input returns null, it will not 
            if (input == null) return;

            // Assign number value to dispense for specific item.
            var dispenseQuantity = input.Quantity;

            // Selected item is assigned to index variable.
            int index = inventoryListBox.SelectedIndex;
            //var oldIndex = index;
            var oldIndex = myList[index];

            // Subtract the selected item quantity with the new dispense quantity.
            var newCount = myList[index].Quantity - dispenseQuantity;

            // Assign new count to input quantity property.
            input.Quantity = newCount;

            // Assign input to index on myList.
            myList[index] = input;

            // Add new index to myList.
            myList.Add(myList[index]);

            // Remove oldIndex from myList.
            myList.Remove(oldIndex);

            // Add item to inventoryListBox.
            inventoryListBox.Items.Add(input);

            // Remove selected item from inventoryListBox.
            inventoryListBox.Items.Remove(oldIndex);

            // Sort inventoryListBox by Id.
            inventoryListBox.Sorted = true;
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            
                // Declared variable and value.
                int index = inventoryListBox.SelectedIndex;

                // Assigns each element value to respective control.
                SetValueForID = idTextBox.Text.ToString();
                SetValueForMedication = medicationTextBox.Text;
                SetValueForDeliveryForm = formTextBox.Text;
                SetValueForQuantity = quantityTextBox.Text.ToString();
                SetValueForUnitPrice = unitPriceTextBox.Text.ToString();

                Form2 form2 = new Form2();

                form2.Show();
            
        }
    }
}
// Leonides Martinez
// CST-150
// September 26, 2021
// Mark Smithers