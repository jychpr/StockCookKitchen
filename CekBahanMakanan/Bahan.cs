namespace CekBahanMakanan
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bahan")] //merujuk ke tabel Bahan sebagai database penyimpanan bahan makanan
    public partial class Bahan //class Bahan yang merupakan class database
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(40)]
        public string Nama { get; set; } //kolom Nama untuk nama bahan di database

        public int Jumlah { get; set; } //kolom Jumlah untuk jumlah bahan di database

        [Required]
        [StringLength(20)]
        public string Satuan { get; set; } //kolom Satuan untuk nama satuan bahan di database
    }
}
