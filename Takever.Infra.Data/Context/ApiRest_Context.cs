using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Takever.Domain;
using Takever.Domain.Entities;

namespace Takever.Infra.Data.Context
{
    public class ApiRest_Context : DbContext
    {
        public ApiRest_Context(DbContextOptions<ApiRest_Context> options) : base(options)
        {

        }

        #region DBSets
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<TVShow> TVShow { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TVShow>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });
        }
    }
}
