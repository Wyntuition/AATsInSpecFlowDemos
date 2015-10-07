using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.DAL;

namespace Demo.Simple.AAT
{
    public class PaymentProcessor : IPaymentProcessor
    {
        private IPaymentDao paymentDao;
        public PaymentProcessor(IPaymentDao paymentDao)
        {
            this.paymentDao = paymentDao;
        }

        public void ProcessPayment(decimal amount)
        {
            paymentDao.SavePayment(amount);
        }

        //isPaymentMade()
        //getPayment()
    }
}
