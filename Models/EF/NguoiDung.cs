namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NguoiDung")]
    public partial class NguoiDung
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NguoiDung()
        {
            QlPhanHois = new HashSet<QlPhanHoi>();
        }

        [Key]
        [StringLength(20)]
        public string IDNguoiDung { get; set; }

        [Required]
        [StringLength(20)]
        public string MatKhau { get; set; }

        [StringLength(50)]
        public string TenNguoiDung { get; set; }

        public double? DienThoai { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(10)]
        public string CMND { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QlPhanHoi> QlPhanHois { get; set; }
    }
}
