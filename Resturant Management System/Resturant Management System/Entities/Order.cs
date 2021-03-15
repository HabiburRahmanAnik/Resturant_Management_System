using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant_Management_System.Entities
{
    class Order
    {
        public int Order_Id { get; set; }
        public string Food_Name { get; set; }
        public int Quantity { get; set; }
        public double Total_Amount { get; set; }
        public string Date { get; set; }

    }
}
