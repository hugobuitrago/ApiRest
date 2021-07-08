using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Perfius.Model.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext()
        {

        }
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {

        }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
