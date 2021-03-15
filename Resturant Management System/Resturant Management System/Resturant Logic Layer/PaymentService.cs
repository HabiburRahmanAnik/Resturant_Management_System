using Resturant_Management_System.Data_Access_Layer;
using Resturant_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant_Management_System.Resturant_Logic_Layer
{
    class PaymentService
    {
        PaymentDataAccess paymentDataAccess;
        public PaymentService()
        {
            this.paymentDataAccess = new PaymentDataAccess();
        }

        public List<Payment> GetAllList()
        {
            return this.paymentDataAccess.GetAllList();
        }
        public int AddPayment(string foodName,string totalAmount,string date)
        {
            Payment payment = new Payment()
            {
                FoodName = foodName,
                TotalAmount =Convert.ToDouble( totalAmount),
                Date = date
            };
            this.paymentDataAccess = new PaymentDataAccess();
            return this.paymentDataAccess.AddPayment(payment);
        }
        public List<Payment> SearchPayment(string foodName)
        {
            return this.paymentDataAccess.SearchPayment(foodName);
        }
    }
}
