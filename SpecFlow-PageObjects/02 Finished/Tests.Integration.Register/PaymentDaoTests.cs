using Demo.Simple.AAT;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.DAL;

namespace Tests.Integration.VendingMachine
{
    public class PaymentDaoTests
    {
        private PaymentDao paymentDao;

        [SetUp]
        public void Setup()
        {
            paymentDao = new PaymentDao();
        }

        [Test]
        public void SavePayment_AddPayment_AddsToTotal()
        {
            var id = paymentDao.SavePayment(25);

            var payment = paymentDao.RetrievePayment(id);

            Assert.That(payment == 25);
        }
    }
}
