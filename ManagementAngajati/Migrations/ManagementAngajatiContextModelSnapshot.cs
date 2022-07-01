﻿// <auto-generated />
using System;
using ManagementAngajati.Persistence.DbUtils;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ManagementAngajati.Migrations
{
    [DbContext(typeof(ManagementAngajatiContext))]
    partial class ManagementAngajatiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AngajatPost", b =>
                {
                    b.Property<long>("AngajatiID")
                        .HasColumnType("bigint");

                    b.Property<long>("PosturiID")
                        .HasColumnType("bigint");

                    b.HasKey("AngajatiID", "PosturiID");

                    b.HasIndex("PosturiID");

                    b.ToTable("AngajatPost");
                });

            modelBuilder.Entity("ManagementAngajati.Models.Angajat", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"), 1L, 1);

                    b.Property<DateTime>("DataNasterii")
                        .HasColumnType("datetime2");

                    b.Property<int>("Experienta")
                        .HasColumnType("int");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Angajati");
                });

            modelBuilder.Entity("ManagementAngajati.Models.Concediu", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"), 1L, 1);

                    b.Property<long>("AngajatID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DataIncepere")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataTerminare")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("AngajatID");

                    b.ToTable("Concedii");
                });

            modelBuilder.Entity("ManagementAngajati.Models.IstoricAngajat", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"), 1L, 1);

                    b.Property<long>("AngajatID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DataAngajare")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataReziliere")
                        .HasColumnType("datetime2");

                    b.Property<long>("PostID")
                        .HasColumnType("bigint");

                    b.Property<int>("Salariu")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AngajatID");

                    b.HasIndex("PostID");

                    b.ToTable("IstoricuriAngajati");
                });

            modelBuilder.Entity("ManagementAngajati.Models.Post", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"), 1L, 1);

                    b.Property<string>("Departament")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DetaliuFunctie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Functie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Posturi");
                });

            modelBuilder.Entity("AngajatPost", b =>
                {
                    b.HasOne("ManagementAngajati.Models.Angajat", null)
                        .WithMany()
                        .HasForeignKey("AngajatiID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ManagementAngajati.Models.Post", null)
                        .WithMany()
                        .HasForeignKey("PosturiID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ManagementAngajati.Models.Concediu", b =>
                {
                    b.HasOne("ManagementAngajati.Models.Angajat", "Angajat")
                        .WithMany()
                        .HasForeignKey("AngajatID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Angajat");
                });

            modelBuilder.Entity("ManagementAngajati.Models.IstoricAngajat", b =>
                {
                    b.HasOne("ManagementAngajati.Models.Angajat", "Angajat")
                        .WithMany()
                        .HasForeignKey("AngajatID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ManagementAngajati.Models.Post", "Post")
                        .WithMany()
                        .HasForeignKey("PostID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Angajat");

                    b.Navigation("Post");
                });
#pragma warning restore 612, 618
        }
    }
}