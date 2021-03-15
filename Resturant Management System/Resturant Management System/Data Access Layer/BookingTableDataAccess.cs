using Resturant_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant_Management_System.Data_Access_Layer
{
    class BookingTableDataAccess
    {
        DataAccess dataAccess;
        public BookingTableDataAccess()
        {
            this.dataAccess = new DataAccess();
        }
        public List<BookingTable> GetAllTable()
        {
            string query = "SELECT * FROM BookingTables";
            SqlDataReader reader = this.dataAccess.GetData(query);
            List<BookingTable> bookingTables = new List<BookingTable>();
            while(reader.Read())
            {
                BookingTable bookingTable = new BookingTable();
                bookingTable.Id = (int)reader["Id"];
                bookingTable.Name = reader["Name"].ToString();
                bookingTable.Email = reader["Email"].ToString();
                bookingTable.TableType = reader["Table_Type"].ToString();
                bookingTable.NoOfGeust = reader["NoOfGeust"].ToString();
                bookingTable.ContactNo = reader["ContactNo"].ToString();
                bookingTable.Arrival_Date_Time = reader["Arrival_Date_Time"].ToString();
                bookingTables.Add(bookingTable);
            }
            return bookingTables;
        }
        public int BookTable(BookingTable bookingTable)
        {
            string query = "INSERT INTO BookingTables (Name,Email,Table_Type,NoOfGeust,ContactNo,Arrival_Date_Time) VALUES('"+bookingTable.Name+"','"+bookingTable.Email+"','"+bookingTable.TableType+"','"+bookingTable.NoOfGeust+"','"+bookingTable.ContactNo+"','"+bookingTable.Arrival_Date_Time+"')";
            return this.dataAccess.ExecuteQuery(query);
        }
        public int DeleteTable(int id)
        {
            string query = "DELETE FROM BookingTables WHERE Id=" + id;
            return this.dataAccess.ExecuteQuery(query);
        }
        public int UpdateTable(BookingTable bookingTable)
        {
            string query= "UPDATE BookingTables SET [Name]='" + bookingTable.Name+ "',[Email]='" + bookingTable.Email + "',[Table_Type]='" + bookingTable.TableType + "',[NoOfGeust]='" + bookingTable.NoOfGeust + "',[ContactNo]='"+bookingTable.ContactNo+"',[Arrival_DAte_Time]='"+bookingTable.Arrival_Date_Time+"' WHERE [Id]="+bookingTable.Id;
            return this.dataAccess.ExecuteQuery(query);
        }
    }
}
