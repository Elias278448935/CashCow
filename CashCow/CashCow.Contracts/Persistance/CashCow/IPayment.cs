using CommonBase.Attributes;
using System;

namespace CashCow.Contracts.Persistance.CashCow
{
    [ContractInfo(ContextType = ContextType.Table)]
    public partial interface IPayment : IVersionable, ICopyable<IPayment>
    {
        public DateTime Date { get; set; }
        public IMember Member { get; set; }
        public double Amount { get; set; }
        [ContractPropertyInfo(Required = true, MaxLength = 124, IsUnique = true)]
        public string EventName { get; set; }
        public string PaymentOption { get; set; }
    }
}
