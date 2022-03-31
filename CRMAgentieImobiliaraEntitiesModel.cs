namespace CRMAgentieImobiliaraModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CRMAgentieImobiliaraEntitiesModel : DbContext
    {
        public CRMAgentieImobiliaraEntitiesModel()
            : base("name=CRMAgentieImobiliaraEntitiesModel")
        {
        }

        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Proprietati> Proprietatis { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Login>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Proprietati>()
                .Property(e => e.TipOferta)
                .IsUnicode(false);

            modelBuilder.Entity<Proprietati>()
                .Property(e => e.NrTel)
                .IsUnicode(false);

            modelBuilder.Entity<Proprietati>()
                .Property(e => e.TipProprietate)
                .IsUnicode(false);

            modelBuilder.Entity<Proprietati>()
                .Property(e => e.Judet)
                .IsUnicode(false);

            modelBuilder.Entity<Proprietati>()
                .Property(e => e.Oras)
                .IsUnicode(false);

            modelBuilder.Entity<Proprietati>()
                .Property(e => e.Zona)
                .IsUnicode(false);

            modelBuilder.Entity<Proprietati>()
                .Property(e => e.Adresa)
                .IsUnicode(false);

            modelBuilder.Entity<Proprietati>()
                .Property(e => e.Amplasament)
                .IsUnicode(false);

            modelBuilder.Entity<Proprietati>()
                .Property(e => e.Etaj)
                .IsUnicode(false);

            modelBuilder.Entity<Proprietati>()
                .Property(e => e.Compartimentare)
                .IsUnicode(false);

            modelBuilder.Entity<Proprietati>()
                .Property(e => e.Descriere)
                .IsUnicode(false);

            modelBuilder.Entity<Proprietati>()
                .Property(e => e.LinkOferta)
                .IsUnicode(false);

            modelBuilder.Entity<Proprietati>()
                .Property(e => e.Pret)
                .IsUnicode(false);
        }
    }
}
