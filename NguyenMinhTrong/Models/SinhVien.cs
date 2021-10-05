using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NguyenMinhTrong.Models
{
    [Table("SinhVien")]
    public class SinhVien
    {
        [Key]
        public int ID { get; set; }
        [StringLength(20)]
        public string MaSinhVien { get; set; }

        [Required]
        [StringLength(50)]
        public string HoTen { get; set; }

        public int MaLop { get; set; }
    }
}
