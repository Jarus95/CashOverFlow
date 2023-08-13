using CashOverFlow.Models.Jobs;
using Microsoft.EntityFrameworkCore;

namespace CashOverFlow.Brokers.Storages
{
    public partial class StorageBroker
    {
        DbSet<Job> Jobs { get; set; }
    }
}
