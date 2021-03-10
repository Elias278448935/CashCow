//@BaseCode
using CashCow.Contracts;

namespace CashCow.Logic.Entities
{
    internal abstract partial class IdentityEntity : IIdentifiable
    {
        public int Id { get; set; }
    }
}
