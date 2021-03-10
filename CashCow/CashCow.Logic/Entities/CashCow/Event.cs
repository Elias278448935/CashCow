using CashCow.Contracts.Persistance.CashCow;
using CommonBase.Extensions;
using System.Collections.Generic;

namespace CashCow.Logic.Entities.CashCow
{
    internal partial class Event : VersionEntity, IEvent
    {
        public string EventName { get; set; }
        public string Category { get; set; }
        public int Money { get; set; }
        public string Currency { get; set; }
        public List<IMember> Members { get; set; }

        public void CopyProperties(IEvent other)
        {
            other.CheckArgument(nameof(other));

            Id = other.Id;
            EventName = other.EventName;
            RowVersion = other.RowVersion;
            Currency = other.Currency;
            Members = other.Members;
        }
    }
}
