using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant_Management_System.Entities
{
    class Payment
    {
        public int Id { set; get; }
        public string FoodName { set; get; }
        public double TotalAmount { get; set; }
        public string Date { get; set; }
    }
}
