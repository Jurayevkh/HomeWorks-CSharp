﻿// <auto-generated />
using System;
using DVDrentalEntityFramework.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace QarzOldiBerdi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230801110738_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("QarzOldiBerdi.Models.qarz", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("qarzBeruvchiId")
                        .HasColumnType("integer");

                    b.Property<int>("qarzOluvchiId")
                        .HasColumnType("integer");

                    b.Property<int?>("qarzdorId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("qarzBeruvchiId");

                    b.HasIndex("qarzOluvchiId");

                    b.HasIndex("qarzdorId");

                    b.ToTable("qarz");
                });

            modelBuilder.Entity("QarzOldiBerdi.Models.qarzBeruvchi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Muddat")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("QarzOluvchiId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("qarzBeruvchi");
                });

            modelBuilder.Entity("QarzOldiBerdi.Models.qarzdor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("qarzdor");
                });

            modelBuilder.Entity("QarzOldiBerdi.Models.qarz", b =>
                {
                    b.HasOne("QarzOldiBerdi.Models.qarzBeruvchi", "qarzBeruvchi")
                        .WithMany("qarzlar")
                        .HasForeignKey("qarzBeruvchiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QarzOldiBerdi.Models.qarz", "qarzOluvchi")
                        .WithMany()
                        .HasForeignKey("qarzOluvchiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QarzOldiBerdi.Models.qarzdor", null)
                        .WithMany("qarzlar")
                        .HasForeignKey("qarzdorId");

                    b.Navigation("qarzBeruvchi");

                    b.Navigation("qarzOluvchi");
                });

            modelBuilder.Entity("QarzOldiBerdi.Models.qarzBeruvchi", b =>
                {
                    b.Navigation("qarzlar");
                });

            modelBuilder.Entity("QarzOldiBerdi.Models.qarzdor", b =>
                {
                    b.Navigation("qarzlar");
                });
#pragma warning restore 612, 618
        }
    }
}
