using CashOverFlow.Models.Salaries;
using Microsoft.EntityFrameworkCore;

namespace CashOverFlow.Brokers.Storages
{
    public partial class StorageBroker
    {
        DbSet<Salary> Salaries { get; set; }
    }
}
