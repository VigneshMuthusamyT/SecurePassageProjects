﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SecurePassageProjects.DataContext;

#nullable disable

namespace SecurePassageProjects.Migrations
{
    [DbContext(typeof(SecureDbContext))]
    [Migration("20240318151307_newModelcreations")]
    partial class newModelcreations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SecurePassageProjects.Models.BankingModel", b =>
                {
                    b.Property<int>("bankId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("bankId"));

                    b.Property<string>("BankPhonenumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BankSignupId")
                        .HasColumnType("int");

                    b.Property<string>("Bankname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UPIPin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("accounttype")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("bankId");

                    b.ToTable("bankingModels");
                });

            modelBuilder.Entity("SecurePassageProjects.Models.FacebookModel", b =>
                {
                    b.Property<int>("FacebookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FacebookId"));

                    b.Property<string>("AccounttypeFb")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FBPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FBuserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FSignupId")
                        .HasColumnType("int");

                    b.HasKey("FacebookId");

                    b.ToTable("facebookModels");
                });

            modelBuilder.Entity("SecurePassageProjects.Models.GoogleModel", b =>
                {
                    b.Property<int>("GoogleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GoogleId"));

                    b.Property<string>("Accounttypego")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GSignupId")
                        .HasColumnType("int");

                    b.Property<string>("GooglePassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GoogleuserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GoogleId");

                    b.ToTable("googleModels");
                });

            modelBuilder.Entity("SecurePassageProjects.Models.InstgramModel", b =>
                {
                    b.Property<int>("InstaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InstaId"));

                    b.Property<string>("AccounttypeIN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("INPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("INSignupId")
                        .HasColumnType("int");

                    b.Property<string>("INuserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InstaId");

                    b.ToTable("instgramModels");
                });

            modelBuilder.Entity("SecurePassageProjects.Models.signupModel", b =>
                {
                    b.Property<int>("signupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("signupId"));

                    b.Property<string>("PassWord")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("signupId");

                    b.ToTable("signupModels");
                });
#pragma warning restore 612, 618
        }
    }
}
