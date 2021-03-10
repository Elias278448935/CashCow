using CashCow.Contracts.Persistance.CashCow;
using CommonBase.Extensions;
using System;

namespace CashCow.Logic.Entities.CashCow
{
    internal partial class Transaction : VersionEntity, IPayment
    {
        public DateTime Date { get; set; }
        public IMember Member { get; set; }
        public double Amount { get; set; }
        public string EventName { get; set; }
        public string PaymentOption { get; set; }

        public void CopyProperties(IPayment other)
        {
            other.CheckArgument(nameof(other));

            Id = other.Id;
            Member = other.Member;
            Amount = other.Amount;
            RowVersion = other.RowVersion;
            EventName = other.EventName;
            Date = other.Date;
            PaymentOption = other.PaymentOption;
        }
    }
}
