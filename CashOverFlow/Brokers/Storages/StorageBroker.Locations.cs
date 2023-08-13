using CashOverFlow.Models.Locations;
using Microsoft.EntityFrameworkCore;

namespace CashOverFlow.Brokers.Storages
{
    public partial class StorageBroker
    {
        DbSet<Location> Locations { get; set; }
    }
}
