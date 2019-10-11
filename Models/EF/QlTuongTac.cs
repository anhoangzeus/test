namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QlTuongTac")]
    public partial class QlTuongTac
    {
        [Key]
        [Column(TypeName = "date")]
        public DateTime Ngay { get; set; }

        [Required]
        [StringLength(10)]
        public string IDBaiViet { get; set; }

        public double? SoTT { get; set; }

        public virtual BaiViet BaiViet { get; set; }
    }
}
