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
            string connectionstring = "Data Source=(localdb)\\ProjectModels;Initial Catalog=cashoverflowDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            optionsBuilder.UseSqlServer(connectionstring);
        }
    }
}


//this.configuration.GetConnectionString(name: "DefaultConnection");
//string connectionstring = "Data Source=(localdb)\\ProjectModels;Initial Catalog=cashoverflowDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";