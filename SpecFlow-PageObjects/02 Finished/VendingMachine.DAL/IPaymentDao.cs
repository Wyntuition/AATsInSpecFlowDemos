using System;
namespace VendingMachine.DAL
{
    public interface IPaymentDao
    {
        decimal RetrievePayment(int id);
        int SavePayment(decimal payment);
    }
}
