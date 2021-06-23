using OilSystemWithDB.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OilSystemWithDB.Data
{
    public class OilContext:DbContext
    {
        public OilContext():base("OilDB")
        {
            GetData();
        }
        public DbSet<Oil> Oils { get; set; }
        private void GetData()
        {
            Oils.Add(new Oil
            {
                Name = "Ai-92",
                Price = 0.90

            });
            Oils.Add(new Oil
            {
                Name = "Ai-95",
                Price = 1.25
            });
            Oils.Add(new Oil
            {
                Name = "Dizel",
                Price = 0.60
            });
            this.SaveChanges();
        }
    }
}
