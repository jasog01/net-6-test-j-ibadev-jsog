/*-----------------------------------------------------------------------------
- Creator: Jose Sogamoso
- Creation date: 5 Ago 2022
- Project: EERP El Sol
- Epic: EP001 Epic text
- UH: UH002 UH text
-------------------------------------------------------------------------------
*/

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PruebaApi.Model
{
    public partial class ApiFormContext : DbContext
    {
        public ApiFormContext()
        {
        }

        public ApiFormContext(DbContextOptions<ApiFormContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Form> Forms { get; set; } = null!;
        public virtual DbSet<TypeForm> TypeForms { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-7UK397V\\SQLEXPRESS;Database=ApiForm;Trusted_Connection=True;user id=sa; password=Colombia123++");
            }
        }
        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     var configuration = new ConfigurationBuilder()
        //         .SetBasePath(Directory.GetCurrentDirectory())
        //         .AddJsonFile("appsettings.json")
        //         .Build();

        //     var connectionString = configuration.GetConnectionString("AppDb");
        //     optionsBuilder.UseSqlServer(connectionString);
        // }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Form>(entity =>
            {
                entity.HasKey(e => e.IdForm)
                    .HasName("PK__Form__007D03D9683BD5BA");

                entity.ToTable("Form");

                entity.Property(e => e.StateDisabled).HasDefaultValueSql("('0')");

                entity.Property(e => e.StatePublished).HasDefaultValueSql("('0')");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                // entity.HasOne(d => d.IdTypeFormNavigation)
                //     .WithMany(p => p.Forms)
                //     .HasForeignKey(d => d.IdTypeForm)
                //     .OnDelete(DeleteBehavior.ClientSetNull)
                //     .HasConstraintName("FK__Form__StatePubli__286302EC");
            });

            modelBuilder.Entity<TypeForm>(entity =>
            {
                entity.HasKey(e => e.IdTypeForm)
                    .HasName("PK__TypeForm__0C6E530CF58B69FF");

                entity.ToTable("TypeForm");

                entity.Property(e => e.DescriptionType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
