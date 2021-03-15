using Resturant_Management_System.Data_Access_Layer;
using Resturant_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant_Management_System.Resturant_Logic_Layer
{
    class FinancialService
    {
        FinancialDataAccess financialDataAccess;
        public FinancialService()
        {
            this.financialDataAccess = new FinancialDataAccess();
        }
        public List<Payment> GetFinancial(string fromDate,string toDate)
        {
            return this.financialDataAccess.GetFinancial(fromDate,toDate);
        }
    }
}
