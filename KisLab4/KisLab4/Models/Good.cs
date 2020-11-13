using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KisLab4.Models
{
    public class Good
    {
        [Key]
        public int Good_id { get; set; }

        public string Name { get; set; }

        public string Price { get; set; }

        public int Quantity { get; set; }

        public string Producer { get; set; }

        public string Description { get; set; }

        public List<Sale> Sales { get; set; }
    }
}
