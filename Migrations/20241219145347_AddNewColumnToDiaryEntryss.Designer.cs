﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NewDiary.Data;

#nullable disable

namespace NewDiary.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241219145347_AddNewColumnToDiaryEntryss")]
    partial class AddNewColumnToDiaryEntryss
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NewDiary.Models.DiaryEntryData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DiaryEntries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Went to the library to read about Science and Chemistry",
                            CreatedDate = new DateTime(2024, 12, 19, 14, 53, 46, 403, DateTimeKind.Local).AddTicks(5570),
                            Title = "Went to the Library"
                        },
                        new
                        {
                            Id = 2,
                            Content = "Had a great time exploring historical artifacts.",
                            CreatedDate = new DateTime(2024, 12, 18, 14, 53, 46, 404, DateTimeKind.Local).AddTicks(4622),
                            Title = "Visited the Museum"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
