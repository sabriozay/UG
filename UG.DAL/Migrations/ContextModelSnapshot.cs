// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UG.DAL.Contexts;

namespace UG.DAL.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UG.DAL.Entities.Customer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10)
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UNVAN")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasKey("ID");

                    b.ToTable("MUSTERI_TANIM_TABLE");
                });

            modelBuilder.Entity("UG.DAL.Entities.CustomerInvoice", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10)
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerID")
                        .HasMaxLength(10)
                        .HasColumnType("int")
                        .HasColumnName("MUSTERI_ID");

                    b.Property<DateTime>("FATURA_TARIHI")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("FATURA_TUTARI")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("ODEME_TARIHI")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("CustomerID");

                    b.ToTable("MUSTERI_FATURA_TABLE");
                });

            modelBuilder.Entity("UG.DAL.Entities.CustomerInvoice", b =>
                {
                    b.HasOne("UG.DAL.Entities.Customer", null)
                        .WithMany("CustomerInvoices")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UG.DAL.Entities.Customer", b =>
                {
                    b.Navigation("CustomerInvoices");
                });
#pragma warning restore 612, 618
        }
    }
}
