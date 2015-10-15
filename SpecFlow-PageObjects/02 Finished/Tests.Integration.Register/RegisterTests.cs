using Demo.Simple.AAT;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using VendingMachine.DAL;

namespace Tests.Integration.VendingMachine
{
    public class RegisterTests
    {
        private IRegister register;

        private TransactionScope transScope;

        [SetUp]
        public void Setup()
        {
            this.transScope = new TransactionScope();

            var paymentProcessor = new PaymentProcessor(new PaymentDao());

            register = new Register(paymentProcessor);
        }

        [TearDown]
        public void Teardown()
        {
            this.transScope.Dispose();
        }

        [Test]
        public void SavePayment_AddPayment_AddsToTotal()
        {
            register.InsertCoin();

            Assert.That(register.Payment == 25, register.Payment.ToString());
        }
    }
}
