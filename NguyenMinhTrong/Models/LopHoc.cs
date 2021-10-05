using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NguyenMinhTrong.Models
{
   [Table("LopHoc")]
    public class LopHoc
    {
        [Key]
        public int ID { get; set; }
        public int MaLop { get; set; }

        [Required]
        [StringLength(50)]
        public string TenLop { get; set; }
    }
}