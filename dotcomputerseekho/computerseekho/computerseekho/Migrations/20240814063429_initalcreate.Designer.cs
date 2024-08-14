﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using computerseekho.Repositories;

#nullable disable

namespace computerseekho.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240814063429_initalcreate")]
    partial class initalcreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("computerseekho.Models.Announcement", b =>
                {
                    b.Property<int>("AnnouncementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AnnouncementId"));

                    b.Property<DateTime>("AnnouncementDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("AnnouncementText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isValid")
                        .HasColumnType("bit");

                    b.HasKey("AnnouncementId");

                    b.ToTable("Announcements");
                });
#pragma warning restore 612, 618
        }
    }
}
