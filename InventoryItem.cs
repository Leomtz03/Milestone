using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone1
{
    class InventoryItem
    {
        // Constructor
        public InventoryItem()
        {
            int inventoryId = 0;
            string medication = "";
            string deliveryForm = "";
            int quantity = 0;
            double unitPrice = 0.0;
        }

        // Get and Set inventoryId property. Similar to Java Getters and Setters.
        public int inventoryId { get; set;  }

        // Get and Set medicaiton property. Similar to Java Getters and Setters.
        public string medication { get; set; }
        
        // Get and Set deliveryForm property. Similar to Java Getters and Setters.
        public string deliveryForm { get; set; }

        // Get and Set quantity property. Similar to Java Getters and Setters.
        public int quantity { get; set; }

        // Get and Set unitPrice property. Similar to Java Getters and Setters.
        public double unitPrice { get; set; }


        // Different setup.
        /*private int _inventoryId;
        private string _medication;
        private string _deliveryForm;
        int _quantity;
        double _unitPrice;

        // Constructor
        public InventoryItem(int inventoryId, string medication, string deliveryForm, int quantity, double unitPrice)
        {
            int _inventoryId = inventoryId;
            string _medication = medication;
            string _deliveryForm = deliveryForm;
            int _quantity = quantity;
            double _unitPrice = unitPrice;
        }

        // Constructor
        /*public string FormatItem(int inventoryId, string medication, string deliveryForm, int quantity, double unitPrice)
        {
            return inventoryId + " " + medication + " " + deliveryForm + " " + quantity.ToString() + " " + unitPrice.ToString("c");
        }

        // Get and Set inventoryId property. Similar to Java Getters and Setters.
        public int inventoryId { get { return _inventoryId; } set { _inventoryId = value; } }

        // Get and Set medicaiton property. Similar to Java Getters and Setters.
        public string medication { get { return _medication; } set { _medication = value; } }

        // Get and Set deliveryForm property. Similar to Java Getters and Setters.
        public string deliveryForm { get { return _deliveryForm; } set { _deliveryForm = value; } }

        // Get and Set quantity property. Similar to Java Getters and Setters.
        public int quantity { get { return _quantity; } set { _quantity = value; } }

        // Get and Set unitPrice property. Similar to Java Getters and Setters.
        public double unitPrice { get { return _unitPrice; } set { _unitPrice = value; } } */
    }
}
