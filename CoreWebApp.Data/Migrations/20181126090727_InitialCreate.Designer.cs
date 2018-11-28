﻿// <auto-generated />
using System;
using CoreWebApp.Data.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoreWebApp.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20181126090727_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoreWebApp.Model.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100);

                    b.Property<int>("CreateBy");

                    b.Property<DateTime>("CreateTime");

                    b.Property<bool>("Enabled");

                    b.Property<string>("LastLoginIP")
                        .HasMaxLength(50);

                    b.Property<DateTime>("LastLoginTime");

                    b.Property<int>("LoginCount");

                    b.Property<string>("PassWord")
                        .HasMaxLength(30);

                    b.Property<string>("RegIP")
                        .HasMaxLength(50);

                    b.Property<int>("UpdateBy");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("UserName")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("sys_User");
                });
#pragma warning restore 612, 618
        }
    }
}