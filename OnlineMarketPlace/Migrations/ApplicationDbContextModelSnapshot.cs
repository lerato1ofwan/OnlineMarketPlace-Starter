﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using OnlineMarketPlace;

namespace OnlineMarketPlace.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("OnlineMarketPlace.Models.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<int>("UserRole")
                        .HasColumnType("integer");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = new Guid("f3c88bf1-cf94-4aad-8d60-36caa4d83992"),
                            Email = "admin@admin.com",
                            FirstName = "Admin",
                            LastName = "Area",
                            Password = "$2a$10$BiKw/LkpvhHWsEyFw5gcR.Tv/EmLe2egNrmv2tQ3ZS8I79ZGDNkyK",
                            UserRole = 0
                        },
                        new
                        {
                            UserId = new Guid("c181f9ed-945c-4cfa-a4d0-805c71c1da5c"),
                            Email = "msmith@customer.com",
                            FirstName = "Mason",
                            LastName = "Smith",
                            Password = "$2a$10$UaEcyvvOVavyNf0Sb10ZGukvVaX02Mf7GJNIqVff8fnvwBqhp.kAq",
                            UserRole = 1
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
