using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIUsageTestGitHubCopilot.Models
{
    public class ShoppingListModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int Quantity { get; set; }

        public ShoppingListModel()
        {
            Id = GenerateRandomId();
        }

        private int GenerateRandomId()
        {
            Random random = new Random();
            return random.Next(0, 100000);
        }
    }
}
