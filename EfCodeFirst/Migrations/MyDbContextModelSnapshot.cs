﻿// <auto-generated />
using EfCodeFirst.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EfCodeFirst.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EfCodeFirst.Model.SalesAssociate", b =>
                {
                    b.Property<int>("SalesAssociateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SalesAssociateId"), 1L, 1);

                    b.Property<string>("AccountNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SalesAssociateName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SalesAssociateId");

                    b.ToTable("SalesAssociate");
                });

            modelBuilder.Entity("EfCodeFirst.Model.Subsidiary", b =>
                {
                    b.Property<int>("SubsidiaryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubsidiaryId"), 1L, 1);

                    b.Property<int>("SalesAssociateId")
                        .HasColumnType("int");

                    b.Property<string>("SubsidiaryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubsidiaryId");

                    b.HasIndex("SalesAssociateId");

                    b.ToTable("Subsidiary");
                });

            modelBuilder.Entity("EfCodeFirst.Model.Subsidiary", b =>
                {
                    b.HasOne("EfCodeFirst.Model.SalesAssociate", "SalesAssociate")
                        .WithMany("Subsidiaries")
                        .HasForeignKey("SalesAssociateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SalesAssociate");
                });

            modelBuilder.Entity("EfCodeFirst.Model.SalesAssociate", b =>
                {
                    b.Navigation("Subsidiaries");
                });
#pragma warning restore 612, 618
        }
    }
}
