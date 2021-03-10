//@BaseCode

namespace CashCow.Contracts
{
    public partial interface IVersionable : IIdentifiable
    {
        public byte[] RowVersion { get; set; }
    }
}
