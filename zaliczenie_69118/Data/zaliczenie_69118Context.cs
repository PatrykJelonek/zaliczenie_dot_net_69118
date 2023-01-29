using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using zaliczenie_69118.Models;

namespace zaliczenie_69118.Data
{
    public class zaliczenie_69118Context : DbContext
    {
        public zaliczenie_69118Context(DbContextOptions<zaliczenie_69118Context> options) : base(options)
        {
        }

        public DbSet<zaliczenie_69118.Models.Order> Order { get; set; } = default!;
    }
}

