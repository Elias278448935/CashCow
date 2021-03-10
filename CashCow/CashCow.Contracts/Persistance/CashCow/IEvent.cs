using CommonBase.Attributes;

namespace CashCow.Contracts.Persistance.CashCow
{
    [ContractInfo(ContextType = ContextType.Table)]
    public partial interface IEvent : IVersionable, ICopyable<IEvent>
    {
        [ContractPropertyInfo(Required = true, MaxLength = 124, IsUnique = true)]
        public string EventName { get; set; }
        public string Category { get; set; }
        [ContractPropertyInfo(Required = true, MaxLength = 8, IsUnique = false)]
        public int Money { get; set; }
        [ContractPropertyInfo(Required = true, MaxLength = 4, IsUnique = false)]
        public string Currency { get; set; }
    }
}
