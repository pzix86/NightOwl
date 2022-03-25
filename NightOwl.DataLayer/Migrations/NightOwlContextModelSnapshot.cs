﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NightOwl.DataLayer.Context;

#nullable disable

namespace NightOwl.DataLayer.Migrations
{
    [DbContext(typeof(NightOwlContext))]
    partial class NightOwlContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("NightOwl.DataLayer.Entities.Categories", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "فیلم",
                            ItemId = 0
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "سریال",
                            ItemId = 0
                        });
                });

            modelBuilder.Entity("NightOwl.DataLayer.Entities.Genres", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenreId"), 1L, 1);

                    b.Property<string>("GenreName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            GenreId = 1,
                            GenreName = "اکشن",
                            ItemId = 0
                        },
                        new
                        {
                            GenreId = 2,
                            GenreName = "ترسناک",
                            ItemId = 0
                        },
                        new
                        {
                            GenreId = 3,
                            GenreName = "مهیج",
                            ItemId = 0
                        },
                        new
                        {
                            GenreId = 4,
                            GenreName = "درام",
                            ItemId = 0
                        },
                        new
                        {
                            GenreId = 5,
                            GenreName = "تاریخی",
                            ItemId = 0
                        },
                        new
                        {
                            GenreId = 6,
                            GenreName = "خانوادگی",
                            ItemId = 0
                        },
                        new
                        {
                            GenreId = 7,
                            GenreName = "انیمیشن",
                            ItemId = 0
                        });
                });

            modelBuilder.Entity("NightOwl.DataLayer.Entities.Items", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemId"), 1L, 1);

                    b.Property<string>("Actors")
                        .HasMaxLength(800)
                        .HasColumnType("nvarchar(800)");

                    b.Property<string>("AvailableQualities")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Banner")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2500)
                        .HasColumnType("nvarchar(2500)");

                    b.Property<string>("Director")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("ImdbScore")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Language")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("ManufacturerCountry")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("MetaCriticScore")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("ReleaseYear")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("RottenTomatoScore")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("RunningTime")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("ItemId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("NightOwl.DataLayer.Entities.Roles", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"), 1L, 1);

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("NightOwl.DataLayer.Entities.SelectedCategory", b =>
                {
                    b.Property<int>("SelectedCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SelectedCategoryId"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.HasKey("SelectedCategoryId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ItemId");

                    b.ToTable("SelectedCategories");
                });

            modelBuilder.Entity("NightOwl.DataLayer.Entities.SelectedGenres", b =>
                {
                    b.Property<int>("SelectedGenresId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SelectedGenresId"), 1L, 1);

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.HasKey("SelectedGenresId");

                    b.HasIndex("GenreId");

                    b.HasIndex("ItemId");

                    b.ToTable("SelectedGenres");
                });

            modelBuilder.Entity("NightOwl.DataLayer.Entities.Users", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("IpAddress")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int?>("WalletId")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            EmailAddress = "pzix886@gmail.com",
                            IpAddress = "192.168.1.127",
                            Password = "20-2C-B9-62-AC-59-07-5B-96-4B-07-15-2D-23-4B-70",
                            PhoneNumber = "09121111111",
                            RegisterDate = new DateTime(2022, 3, 25, 14, 18, 54, 694, DateTimeKind.Local).AddTicks(7514),
                            RoleId = 2,
                            Username = "ادمین سیستم",
                            WalletId = 1
                        });
                });

            modelBuilder.Entity("NightOwl.DataLayer.Entities.WalletTransactions", b =>
                {
                    b.Property<int>("WalletId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WalletId"), 1L, 1);

                    b.Property<int?>("DepositValue")
                        .HasColumnType("int");

                    b.Property<bool>("IsConfirmed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("WalletBalance")
                        .HasColumnType("int");

                    b.Property<int?>("WithdrawalValue")
                        .HasColumnType("int");

                    b.HasKey("WalletId");

                    b.HasIndex("UserId");

                    b.ToTable("WalletTransactions");
                });

            modelBuilder.Entity("NightOwl.DataLayer.Entities.Roles", b =>
                {
                    b.HasOne("NightOwl.DataLayer.Entities.Users", "Users")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("NightOwl.DataLayer.Entities.SelectedCategory", b =>
                {
                    b.HasOne("NightOwl.DataLayer.Entities.Categories", "Categories")
                        .WithMany("SelectedCategory")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NightOwl.DataLayer.Entities.Items", "Items")
                        .WithMany("SelectedCategory")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categories");

                    b.Navigation("Items");
                });

            modelBuilder.Entity("NightOwl.DataLayer.Entities.SelectedGenres", b =>
                {
                    b.HasOne("NightOwl.DataLayer.Entities.Genres", "Genres")
                        .WithMany("SelectedGenres")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NightOwl.DataLayer.Entities.Items", "Items")
                        .WithMany("SelectedGenres")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genres");

                    b.Navigation("Items");
                });

            modelBuilder.Entity("NightOwl.DataLayer.Entities.WalletTransactions", b =>
                {
                    b.HasOne("NightOwl.DataLayer.Entities.Users", "Users")
                        .WithMany("WalletTransactions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("NightOwl.DataLayer.Entities.Categories", b =>
                {
                    b.Navigation("SelectedCategory");
                });

            modelBuilder.Entity("NightOwl.DataLayer.Entities.Genres", b =>
                {
                    b.Navigation("SelectedGenres");
                });

            modelBuilder.Entity("NightOwl.DataLayer.Entities.Items", b =>
                {
                    b.Navigation("SelectedCategory");

                    b.Navigation("SelectedGenres");
                });

            modelBuilder.Entity("NightOwl.DataLayer.Entities.Users", b =>
                {
                    b.Navigation("Roles");

                    b.Navigation("WalletTransactions");
                });
#pragma warning restore 612, 618
        }
    }
}
