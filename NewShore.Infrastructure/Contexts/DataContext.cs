using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NewShore.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewShore.Infrastructure.Contexts
{
    public class DataContext : IdentityDbContext<User>
    {
        public DataContext(DbContextOptions<DataContext> options) :
    base(options)
        {

        }

        public DbSet<Transport> Transports { get; set; }
        public DbSet<Flight> Flights { get; set; }
       
    }
}
