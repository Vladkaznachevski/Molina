using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class OrderDetail : BaseEntity
    {
        public int OrderId { get; set; }
        public int ClothId { get; set; }

        public Cloth Cloth { get; set; }
        public Order Order { get; set; }

    }
}