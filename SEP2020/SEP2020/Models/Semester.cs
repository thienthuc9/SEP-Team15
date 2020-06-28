namespace SEP2020.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;
    using System.Web.Mvc;
    [Table("Semester")]
    public partial class Semester
    {
        SEP2020Entities model = new SEP2020Entities();

        [Key]
        public int id_semester { get; set; }
        [DisplayName("Tên học kì")]
        [Remote("IsUserExists", "Semester", ErrorMessage = "Tên Học kì đã tồn tại")]
        [Required(ErrorMessage ="Tên học kì chưa được nhập")]
        [StringLength(50)]
        
        public string namesemester { get; set; }
        [DisplayName("Ngày bắt đầu")]
        [Required(ErrorMessage = "Ngày bắt đầu chưa được nhập")]
        [DisplayFormat(DataFormatString = "{dd/MM/yyyy}")]
        [Column(TypeName = "date")]
        public DateTime? start_date { get; set; }
        [DisplayName("Ngày kết thúc")]
        [Required(ErrorMessage = "Ngày kết thức chưa được nhập")]
        [DisplayFormat(DataFormatString = "{dd/MM/yyyy}")]
        [Column(TypeName = "date")]
        public DateTime? end_date { get; set; }
        [Required]
        public int Account_id { get; set; }

        public virtual Account Account { get; set; }
       

    }
}
