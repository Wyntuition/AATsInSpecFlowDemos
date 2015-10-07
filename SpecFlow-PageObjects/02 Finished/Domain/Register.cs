using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Simple.AAT
{
    public class Register : IRegister
    {
        private IPaymentProcessor paymentProcessor;

        public Register(IPaymentProcessor paymentProcessor)
        {
            this.paymentProcessor = paymentProcessor;
        }

        public decimal Payment { get; set; }

        public void InsertCoin()
        {
            this.paymentProcessor.ProcessPayment(25);
        }

        public void BuyProduct()
        {
            throw new NotImplementedException();
        }

        public void ReleaseChange()
        {
            throw new NotImplementedException();
        }
    }
}
