using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StateParksApi.Models;

    public class StateParksApiContext : DbContext
    {
        public StateParksApiContext (DbContextOptions<StateParksApiContext> options)
            : base(options)
        {
        }

        public DbSet<StateParksApi.Models.Park> Park { get; set; }
    }
