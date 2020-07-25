using GenesisFramework.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenesisFramework.infrastructure.Data.Context
{
    public class GenesisFrameworkDbContext : DbContext
    {
        public GenesisFrameworkDbContext(DbContextOptions options)
            : base(options)
        {

        }
        public DbSet<Course> Courses { get; set; }
    }
}
