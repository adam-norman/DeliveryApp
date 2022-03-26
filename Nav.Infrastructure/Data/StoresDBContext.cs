using Microsoft.EntityFrameworkCore;
using Nav.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nav.Infrastructure.Data
{
    public class StoresDBContext : DbContext
    {
        public StoresDBContext(DbContextOptions<StoresDBContext> options) : base(options) { }
        public DbSet<Store> Stores { get; set; }
    }
}
