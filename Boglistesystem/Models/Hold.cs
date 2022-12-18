﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using Boglistesystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Boglistesystem.Models
{
    [Table("Hold")]
    public partial class Hold
    {
        public Hold()
        {
            BogHolds = new HashSet<BogHold>();
        }

        [Key]
        [Required]
        [Column("Hold_id")]
        public int Hold_id { get; set; }
        [Required]
        [StringLength(30)]
        public string Navn { get; set; }
        [Required]
        [Column("Koordinator_id")]
        public int? Koordinator_id { get; set; }
        [Required]
        [Column("Uddannelse_id")]
        public int? Uddannelse_id { get; set; }
        [Required]
        [Column("Semestre_id")]
        public int? Semestre_id { get; set; }
        [Required]
        [Column("Fag_id")]
        public int? Fag_id { get; set; }
        [Required]
        [Column("Underviser_id")]
        public int? Underviser_id { get; set; }

        [ForeignKey(nameof(Fag_id))]
        [InverseProperty("Holds")]
        public virtual Fag Fag { get; set; }
        [ForeignKey(nameof(Koordinator_id))]
        [InverseProperty("Holds")]
        public virtual Koordinator Koordinator { get; set; }
        [ForeignKey(nameof(Semestre_id))]
        [InverseProperty("Holds")]
        public virtual Semestre Semestre { get; set; }
        [ForeignKey(nameof(Uddannelse_id))]
        [InverseProperty("Holds")]
        public virtual Uddannelse Uddannelse { get; set; }
        [ForeignKey(nameof(Underviser_id))]
        [InverseProperty("Holds")]
        public virtual Underviser Underviser { get; set; }
        [InverseProperty(nameof(BogHold.Hold))]
        public virtual ICollection<BogHold> BogHolds { get; set; }
    }
}