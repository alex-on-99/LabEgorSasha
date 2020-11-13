using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KisLab4.Models
{
    public class Sale
    {
        [Key]
        public int Sale_id { get; set; }  
        
        public int Check_no { get; set; }  
        
        public DateTime Date_sale { get; set; }  
        
        public int Quantity { get; set; }  
        
        public int fk_Good_id { get; set; }

        public Good Good { get; set; }
    }
}
