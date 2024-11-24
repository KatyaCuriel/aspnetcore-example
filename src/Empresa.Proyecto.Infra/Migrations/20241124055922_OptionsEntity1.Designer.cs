﻿// <auto-generated />
using System;
using Empresa.Proyecto.Infra.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Empresa.Proyecto.Infra.Migrations
{
    [DbContext(typeof(MyProjectContext))]
    [Migration("20241124055922_OptionsEntity1")]
    partial class OptionsEntity1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Empresa.Proyecto.Core.Entities.ComplexEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("CatalogExampleId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CatalogExampleId");

                    b.ToTable("ComplexEntity");
                });

            modelBuilder.Entity("Empresa.Proyecto.Core.Entities.SimpleEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SimpleEntity");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2024, 11, 24, 5, 59, 22, 408, DateTimeKind.Utc).AddTicks(607),
                            Modified = new DateTime(2024, 11, 24, 5, 59, 22, 408, DateTimeKind.Utc).AddTicks(610),
                            Name = "Nuevo",
                            Value = "Valor inicial 1"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2024, 11, 24, 5, 59, 22, 408, DateTimeKind.Utc).AddTicks(613),
                            Modified = new DateTime(2024, 11, 24, 5, 59, 22, 408, DateTimeKind.Utc).AddTicks(614),
                            Name = "Existente",
                            Value = "Valor inicial 2"
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2024, 11, 24, 5, 59, 22, 408, DateTimeKind.Utc).AddTicks(616),
                            Modified = new DateTime(2024, 11, 24, 5, 59, 22, 408, DateTimeKind.Utc).AddTicks(617),
                            Name = "Reconstruido",
                            Value = "Valor inicial 3"
                        });
                });

            modelBuilder.Entity("Empresa.Proyecto.Core.Entities.ComplexEntity", b =>
                {
                    b.HasOne("Empresa.Proyecto.Core.Entities.SimpleEntity", "CatalogExample")
                        .WithMany()
                        .HasForeignKey("CatalogExampleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CatalogExample");
                });
#pragma warning restore 612, 618
        }
    }
}
