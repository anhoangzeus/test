namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DanhMuc")]
    public partial class DanhMuc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DanhMuc()
        {
            BaiViets = new HashSet<BaiViet>();
        }

        [Key]
        [StringLength(10)]
        public string IDDanhMuc { get; set; }

        [StringLength(50)]
        public string TenDanhMuc { get; set; }

        [StringLength(10)]
        public string ViTri { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SoBaiViet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BaiViet> BaiViets { get; set; }
    }
}
