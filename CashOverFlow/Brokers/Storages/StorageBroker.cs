// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Developed by CashOverflow Team
// --------------------------------------------------------


using CashOverFlow.Models.Locations;
using EFxceptions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace CashOverFlow.Brokers.Storages
{
    public partial class StorageBroker : EFxceptionsContext
    {
        private readonly IConfiguration configuration;
        public StorageBroker(IConfiguration configuration)
        {
            this.configuration = configuration;
            this.Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionstring = "Server=(localdb)\\MSSQLLocalDB;Database=CashOverflowDb;Trusted_Connection=True;MultipleActiveResultSets=true";
            optionsBuilder.UseSqlServer(connectionstring);
        }
    }
}


//this.configuration.GetConnectionString(name: "DefaultConnection");