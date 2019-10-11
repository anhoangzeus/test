namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QlPhanHoi")]
    public partial class QlPhanHoi
    {
        [Key]
        [StringLength(10)]
        public string IDPhanHoi { get; set; }

        [StringLength(20)]
        public string IDNguoiPH { get; set; }

        [StringLength(50)]
        public string TenNguoiPH { get; set; }

        [Column(TypeName = "text")]
        public string NoiDung { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayGui { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public virtual NguoiDung NguoiDung { get; set; }
    }
}
