using CashCow.Contracts.Persistance.CashCow;

namespace CashCow.Logic.Entities.CashCow
{
    internal partial class Partialpant : VersionEntity, IMember
    {
        public string Name { get; set; }

        public void CopyProperties(IMember other)
        {
            other.CheckArgument(nameof(other));

            Id = other.Id;
            RowVersion = other.RowVersion;
            Name = other.Name;
        }
    }
}
