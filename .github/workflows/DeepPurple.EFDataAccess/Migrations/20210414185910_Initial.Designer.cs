﻿// <auto-generated />
using System;
using DDeepPurple.EFDataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DeepPurple.EFDataAccess.Migrations
{
    [DbContext(typeof(DeepPurpleContext))]
    [Migration("20210414185910_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DeepPurple.ApplicationLogic.Data.Brandmark", b =>
                {
                    b.Property<Guid>("BrandMarkID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("MaterCard")
                        .HasColumnType("bit");

                    b.Property<bool>("PayPal")
                        .HasColumnType("bit");

                    b.Property<bool>("Visa")
                        .HasColumnType("bit");

                    b.HasKey("BrandMarkID");

                    b.ToTable("Brandmarks");
                });

            modelBuilder.Entity("DeepPurple.ApplicationLogic.Data.Card", b =>
                {
                    b.Property<Guid>("CardID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccNumber")
                        .HasColumnType("int");

                    b.Property<int>("BrandMark")
                        .HasColumnType("int");

                    b.Property<int>("CVV")
                        .HasColumnType("int");

                    b.Property<string>("CardHolder")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CardID");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("DeepPurple.ApplicationLogic.Data.Event", b =>
                {
                    b.Property<Guid>("EventID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("EventID");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("DeepPurple.ApplicationLogic.Data.UserCard", b =>
                {
                    b.Property<Guid>("UserCardID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CardID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("UserCardID");

                    b.ToTable("UserCard");
                });

            modelBuilder.Entity("DeepPurple.ApplicationLogic.Data.UserEvent", b =>
                {
                    b.Property<Guid>("UserEventID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("EventID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("userID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserEventID");

                    b.HasIndex("EventID");

                    b.HasIndex("userID");

                    b.ToTable("UserEvent");
                });

            modelBuilder.Entity("DeepPurple.ApplicationLogic.Data.Users", b =>
                {
                    b.Property<Guid>("userID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<bool>("Member")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("userID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DeepPurple.ApplicationLogic.Data.UserEvent", b =>
                {
                    b.HasOne("DeepPurple.ApplicationLogic.Data.Event", "Event")
                        .WithMany()
                        .HasForeignKey("EventID");

                    b.HasOne("DeepPurple.ApplicationLogic.Data.Users", "User")
                        .WithMany()
                        .HasForeignKey("userID");
                });
#pragma warning restore 612, 618
        }
    }
}
