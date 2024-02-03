using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Db
{
    public class Dato
    {
        [Key]
        public int id { get; set; }
        [Required]
        public DateTime date { get; set; }
        public float temp { get; set; }
        [Required]
        public float hum { get; set; }
    }

}
