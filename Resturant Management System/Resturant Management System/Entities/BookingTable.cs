using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant_Management_System.Entities
{
    class BookingTable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string TableType { get; set; }
        public string NoOfGeust { get; set; }
        public string ContactNo { get; set; }
        public string Arrival_Date_Time { get; set; }

    }
}
