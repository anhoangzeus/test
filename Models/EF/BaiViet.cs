namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaiViet")]
    public partial class BaiViet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BaiViet()
        {
            QlTuongTacs = new HashSet<QlTuongTac>();
        }

        [Key]
        [StringLength(10)]
        public string MaBaiViet { get; set; }

        [StringLength(50)]
        public string TenBaiViet { get; set; }

        [StringLength(10)]
        public string TheLoai { get; set; }

        [StringLength(50)]
        public string NguoiViet { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayViet { get; set; }

        [Column(TypeName = "text")]
        public string NoiDung { get; set; }

        public virtual DanhMuc DanhMuc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QlTuongTac> QlTuongTacs { get; set; }
    }
}
