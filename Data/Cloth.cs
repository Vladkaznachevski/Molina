using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Cloth : BaseEntity
    {
        
        public string Name { get; set; }

        public int Price { get; set; }

        public int MaterialId { get; set; }
        public Material Material { get; set; }

        public int ClassId { get; set; }
        public Class Class { get; set; }

        public int SizeId { get; set; }
        public Size Size { get; set; }
    }
}
