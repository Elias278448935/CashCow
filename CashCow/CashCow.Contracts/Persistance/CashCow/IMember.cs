using CommonBase.Attributes;

namespace CashCow.Contracts.Persistance.CashCow
{
    [ContractInfo(ContextType = ContextType.Table)]
    public partial interface IMember : IVersionable, ICopyable<IMember>
    {
        [ContractPropertyInfo(Required = true)]
        public string Name { get; set; }
    }
}
