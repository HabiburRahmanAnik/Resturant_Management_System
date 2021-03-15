using Resturant_Management_System.Data_Access_Layer;
using Resturant_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant_Management_System.Resturant_Logic_Layer
{
    class BookingTableService
    {
        BookingTableDataAccess bookingTableDataAccess;
        public BookingTableService()
        {
            this.bookingTableDataAccess = new BookingTableDataAccess();
        }
        public List<BookingTable> GetAllTable()
        {
            return this.bookingTableDataAccess.GetAllTable();
        }
        public int BookTable(string name,string email,string tableType,string noOfGeust,string contactNo,string arrivalTime)
        {
            BookingTable bookingTable = new BookingTable()
            {
                Name = name,
                Email = email,
                TableType = tableType,
                NoOfGeust = noOfGeust,
                ContactNo = contactNo,
                Arrival_Date_Time = arrivalTime
            };
            return this.bookingTableDataAccess.BookTable(bookingTable);
        }
        public int DeleteTable(int id)
        {
            return this.bookingTableDataAccess.DeleteTable(id);
        }

        public int UpdateTable(int id,string name, string email, string tableType, string noOfGeust, string contactNo, string arrivalTime)
        {
            BookingTable bookingTable = new BookingTable()
            {
                Id = id,
                Name = name,
                Email = email,
                TableType = tableType,
                NoOfGeust = noOfGeust,
                ContactNo = contactNo,
                Arrival_Date_Time = arrivalTime
            };
            return this.bookingTableDataAccess.UpdateTable(bookingTable);
        }
    }
}
