using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Student
    {
            [Key]
            public int ogr_id { get; set; }
            [StringLength(50)]
            public string ogr_ad { get; set; }
            [StringLength(50)]
            public string ogr_soyad { get; set; }
    }
}
