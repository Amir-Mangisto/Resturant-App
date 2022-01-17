using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ResturantUsingMvcEtLts.Models
{
    public partial class ResturantContext : DbContext
    {
        public ResturantContext()
            : base("name=ResturantContext")
        {
        }

        public virtual DbSet<Waiter> Waiters { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
