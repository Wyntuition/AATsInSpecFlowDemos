using System;
namespace Demo.Simple.AAT
{
    public interface IRegister
    {
        void BuyProduct();
        void InsertCoin();
        void ReleaseChange();
        decimal Payment { get; set; }
    }
}
