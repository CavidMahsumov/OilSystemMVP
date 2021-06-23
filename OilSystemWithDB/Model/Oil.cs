using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OilSystemWithDB.Model
{
    public class Oil
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
