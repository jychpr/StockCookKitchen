namespace CekBahanMakanan
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BahanModel : DbContext //class BahanModel merupakan turunan dari class Bahan yang merupakan databasenya
    {
        public BahanModel()
            : base("name=BahanModel3")
        {
        }

        public virtual DbSet<Bahan> Bahans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
