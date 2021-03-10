//@BaseCode
using CashCow.Contracts;

namespace CashCow.Logic.Entities
{
    internal abstract partial class VersionEntity : IdentityEntity, IVersionable
    {
        public byte[] RowVersion { get; set; }
    }
}
