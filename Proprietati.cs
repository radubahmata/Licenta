namespace CRMAgentieImobiliaraModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Proprietati")]
    public partial class Proprietati
    {
        public int Id { get; set; }

        [Required]
        [StringLength(15)]
        public string TipOferta { get; set; }

        [Required]
        [StringLength(13)]
        public string NrTel { get; set; }

        [Required]
        [StringLength(50)]
        public string TipProprietate { get; set; }

        [Required]
        [StringLength(5)]
        public string Judet { get; set; }

        [Required]
        [StringLength(50)]
        public string Oras { get; set; }

        [Required]
        [StringLength(50)]
        public string Zona { get; set; }

        [Required]
        public string Adresa { get; set; }

        [StringLength(50)]
        public string Amplasament { get; set; }

        public int? NrCamere { get; set; }

        public int? NrBai { get; set; }

        [StringLength(10)]
        public string Etaj { get; set; }

        public double? SuprafataUtila { get; set; }

        [StringLength(50)]
        public string Compartimentare { get; set; }

        public int? LocuriParcare { get; set; }

        [Required]
        public string Descriere { get; set; }

        public string LinkOferta { get; set; }

        [StringLength(10)]
        public string Pret { get; set; }

        [Column(TypeName = "image")]
        public byte[] Imagini { get; set; }
    }
}
