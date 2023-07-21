﻿// <auto-generated />
using System;
using DisneyAPI.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DisneyAPI.Domain.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230717201346_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CharacterMovieOrSerie", b =>
                {
                    b.Property<Guid>("CharactersId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("MoviesOrSeriesId")
                        .HasColumnType("uuid");

                    b.HasKey("CharactersId", "MoviesOrSeriesId");

                    b.HasIndex("MoviesOrSeriesId");

                    b.ToTable("MovieOrSerieCharacter", (string)null);
                });

            modelBuilder.Entity("DisneyAPI.Domain.Entities.Character", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int?>("Age")
                        .HasColumnType("integer");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Story")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<float?>("Weight")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Character");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ea9009f7-9c59-4944-81da-48ee5a773124"),
                            Age = 92,
                            ImageUrl = "https://disney-api.app.csharpjourney.com/minnie.png",
                            Name = "Mickey Mouse",
                            Story = "Mickey Mouse is the iconic and beloved character in Disney's cartoons.",
                            Weight = 23.5f
                        },
                        new
                        {
                            Id = new Guid("25f94e5b-7aa0-415a-9d3d-34edb85e3277"),
                            Age = 92,
                            ImageUrl = "https://disney-api.app.csharpjourney.com/mickey.png",
                            Name = "Minnie Mouse",
                            Story = "Minnie Mouse is Mickey Mouse's girlfriend and one of Disney's iconic characters.",
                            Weight = 21.4f
                        });
                });

            modelBuilder.Entity("DisneyAPI.Domain.Entities.Genre", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.ToTable("Genre");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a5af601b-5b6e-45b3-a60d-53111d60cd90"),
                            Name = "Animation"
                        },
                        new
                        {
                            Id = new Guid("2dc506fe-16c8-4c8a-af98-425fca9424cc"),
                            Name = "Fantasy"
                        },
                        new
                        {
                            Id = new Guid("935c52c6-b1e1-4dc9-968a-ba2564eaa7e2"),
                            Name = "Family"
                        },
                        new
                        {
                            Id = new Guid("da36de85-3f72-4f14-9f35-8697e070c64e"),
                            Name = "Holiday"
                        });
                });

            modelBuilder.Entity("DisneyAPI.Domain.Entities.MovieOrSerie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("GenreId")
                        .HasColumnType("uuid");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Rating")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.ToTable("MoviesOrSerie");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ae471f1b-8d60-4489-8519-23b854237d0d"),
                            CreationDate = new DateTime(1928, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GenreId = new Guid("a5af601b-5b6e-45b3-a60d-53111d60cd90"),
                            ImageUrl = "https://disney-api.app.csharpjourney.com/Steamboat-Willie.jpg",
                            Rating = 8,
                            Title = "Steamboat Willie"
                        },
                        new
                        {
                            Id = new Guid("45e04d11-dd27-4b45-904b-ca527f7de124"),
                            CreationDate = new DateTime(1940, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GenreId = new Guid("2dc506fe-16c8-4c8a-af98-425fca9424cc"),
                            ImageUrl = "https://disney-api.app.csharpjourney.com/fantasia.jpg",
                            Rating = 7,
                            Title = "Fantasia"
                        },
                        new
                        {
                            Id = new Guid("f976eacc-bc89-450b-944b-359c726f9c64"),
                            CreationDate = new DateTime(1955, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GenreId = new Guid("935c52c6-b1e1-4dc9-968a-ba2564eaa7e2"),
                            ImageUrl = "https://disney-api.app.csharpjourney.com/The-Mickey-Mouse-Club",
                            Rating = 6,
                            Title = "The Mickey Mouse Club"
                        },
                        new
                        {
                            Id = new Guid("0ede5856-5245-41d4-9cbc-f74ad2bb6cdf"),
                            CreationDate = new DateTime(1999, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GenreId = new Guid("da36de85-3f72-4f14-9f35-8697e070c64e"),
                            ImageUrl = "https://disney-api.app.csharpjourney.com/Mickeys-Once-Upon-a-Christmas.jpg",
                            Rating = 7,
                            Title = "Mickey's Once Upon a Christmas"
                        });
                });

            modelBuilder.Entity("DisneyAPI.IdentyEntities.ApplicationRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("DisneyAPI.IdentyEntities.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("CharacterMovieOrSerie", b =>
                {
                    b.HasOne("DisneyAPI.Domain.Entities.Character", null)
                        .WithMany()
                        .HasForeignKey("CharactersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DisneyAPI.Domain.Entities.MovieOrSerie", null)
                        .WithMany()
                        .HasForeignKey("MoviesOrSeriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DisneyAPI.Domain.Entities.MovieOrSerie", b =>
                {
                    b.HasOne("DisneyAPI.Domain.Entities.Genre", "Genre")
                        .WithMany("MoviesOrSeries")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("DisneyAPI.IdentyEntities.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("DisneyAPI.IdentyEntities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("DisneyAPI.IdentyEntities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("DisneyAPI.IdentyEntities.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DisneyAPI.IdentyEntities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("DisneyAPI.IdentyEntities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DisneyAPI.Domain.Entities.Genre", b =>
                {
                    b.Navigation("MoviesOrSeries");
                });
#pragma warning restore 612, 618
        }
    }
}