﻿// <auto-generated />
using System;
using EasyCashIdentityProject.DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EasyCashIdentityProject.DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230814094311_DbContext")]
    partial class DbContext
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EasyCashIdentityProject.EntityLayer.Concrete.CustomerAccount", b =>
                {
                    b.Property<int>("CustomerAccountID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerAccountID"));

                    b.Property<decimal>("CustomerAccountBalance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("CustomerAccountBankBranch")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerAccountCurrency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerAccountNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerAccountID");

                    b.ToTable("CustomerAccounts");
                });

            modelBuilder.Entity("EasyCashIdentityProject.EntityLayer.Concrete.CustomerAccountProcess", b =>
                {
                    b.Property<int>("CustomerAccountProcessID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerAccountProcessID"));

                    b.Property<decimal>("CustomerAccountProcessAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CustomerAccountProcessDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CustomerAccountProcessType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerAccountProcessID");

                    b.ToTable("CustomerAccountProcesses");
                });
#pragma warning restore 612, 618
        }
    }
}
