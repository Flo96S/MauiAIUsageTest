using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIUsageTestBingCopilot.Models
{
    // A class that represents a shopping list item
    public class ShoppingListModel
    {
        // A property that holds the id of the item
        public int Id { get; set; }

        // A property that holds the name of the item
        public string Name { get; set; } = ""; //Changed by hand

        // A property that holds the quantity of the item
        public int Quantity { get; set; }

        // A constructor that creates a new item with a random id
        public ShoppingListModel() //Changed parameters by hand | Bing Copilot added: string name, int quantity
        {
            // Generate a random number between 0 and 99999
            Random random = new Random();
            int id = random.Next(0, 100000);

            // Assign the values to the properties
            Id = id;
        }
    }
}
