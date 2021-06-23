using OilSystemWithDB.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OilSystemWithDB.Data
{
    public class CafeContext:DbContext
    {
        public CafeContext():base("CafeDB")
        {

        }
        public DbSet<Cafe> Cafes { get; set; }

    }
}
