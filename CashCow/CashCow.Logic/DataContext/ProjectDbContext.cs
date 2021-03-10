//@BaseCode
using Microsoft.EntityFrameworkCore;

namespace CashCow.Logic.DataContext
{
    internal partial class ProjectDbContext : DbContext, Contracts.IContext
    {
    }
}
