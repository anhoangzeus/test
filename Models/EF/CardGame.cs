namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CardGame")]
    public partial class CardGame
    {
        [Key]
        [StringLength(20)]
        public string SeRi { get; set; }

        [Required]
        [StringLength(20)]
        public string MaNap { get; set; }

        [StringLength(50)]
        public string NPH { get; set; }

        public double? MenhGia { get; set; }

        [Column(TypeName = "date")]
        public DateTime? HanDung { get; set; }
    }
}
