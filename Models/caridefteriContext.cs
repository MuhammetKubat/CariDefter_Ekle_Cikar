using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NewCariDefteri.Models
{
    public partial class caridefteriContext : DbContext
    {
        public caridefteriContext()
        {
        }

        public caridefteriContext(DbContextOptions<caridefteriContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Info> Info { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Users> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Info>(entity =>
            {
                entity.HasIndex(e => e.PersonId)
                    .HasName("UQ__Info__7EABD0AA1BC1B8B9")
                    .IsUnique();

                entity.Property(e => e.InfoId)
                    .HasColumnName("info_Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address).HasColumnType("text");

                entity.Property(e => e.PersonId).HasColumnName("Person_Id");

                entity.Property(e => e.Telephone)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Person)
                    .WithOne(p => p.Info)
                    .HasForeignKey<Info>(d => d.PersonId)
                    .HasConstraintName("FK__Info__Person_Id__47DBAE45");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasIndex(e => e.UserId)
                    .HasName("UQ__Person__206D91718610BC49")
                    .IsUnique();

                entity.Property(e => e.PersonId).HasColumnName("Person_ID");

                entity.Property(e => e.Ad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Soyad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("User_Id");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.Person)
                    .HasForeignKey<Person>(d => d.UserId)
                    .HasConstraintName("FK__Person__User_Id__440B1D61");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Users__206D9190E522EAFC");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.Property(e => e.Ad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Parola)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
