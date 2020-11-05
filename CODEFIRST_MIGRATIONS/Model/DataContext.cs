using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CODEFIRST_MIGRATIONS.Model
{
    public class DataContext : DbContext
    {
        public DbSet<FILME> FILME { get; set; }
        public DbSet<NOTAFILME> NOTAFILME { get; set; }

        public DataContext() : base("name=DefaultConnection")
        {
            
        }
    }
}
