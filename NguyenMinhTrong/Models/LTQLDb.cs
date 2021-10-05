using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace NguyenMinhTrong.Models
{
    public partial class LTQLDb : DbContext
    {
        public LTQLDb()
            : base("name=BaiKiemTra")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public System.Data.Entity.DbSet<NguyenMinhTrong.Models.LopHoc> LopHocs { get; set; }

        public System.Data.Entity.DbSet<NguyenMinhTrong.Models.SinhVien> SinhViens { get; set; }
    }
}
