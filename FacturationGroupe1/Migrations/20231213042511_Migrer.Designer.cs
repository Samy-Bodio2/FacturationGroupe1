﻿// <auto-generated />
using System;
using FacturationGroupe1.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FacturationGroupe1.Migrations
{
    [DbContext(typeof(FactureContext))]
    [Migration("20231213042511_Migrer")]
    partial class Migrer
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("FacturationGroupe1.Entity.Client", b =>
                {
                    b.Property<int>("IdClient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClientName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("ClientNumber")
                        .HasColumnType("double");

                    b.Property<string>("ClientPosition")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("IdClient");

                    b.HasIndex("userId");

                    b.ToTable("clients");
                });

            modelBuilder.Entity("FacturationGroupe1.Entity.Invoice", b =>
                {
                    b.Property<int>("invoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Invoice")
                        .HasColumnType("int");

                    b.Property<DateTime>("invoiceDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("invoicePDF")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("invoiceTotal")
                        .HasColumnType("double");

                    b.HasKey("invoiceId");

                    b.HasIndex("Invoice")
                        .IsUnique();

                    b.ToTable("invoices");
                });

            modelBuilder.Entity("FacturationGroupe1.Entity.JournalAudit", b =>
                {
                    b.Property<int>("IdAudit")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("ActionDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ActionRealisee")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("JournalAudit")
                        .HasColumnType("int");

                    b.HasKey("IdAudit");

                    b.HasIndex("JournalAudit")
                        .IsUnique();

                    b.ToTable("journals");
                });

            modelBuilder.Entity("FacturationGroupe1.Entity.Order", b =>
                {
                    b.Property<int>("IdOrder")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("OrderTotal")
                        .HasColumnType("double");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("clientIdClient")
                        .HasColumnType("int");

                    b.HasKey("IdOrder");

                    b.HasIndex("UserId");

                    b.HasIndex("clientIdClient");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("FacturationGroupe1.Entity.OrderLine", b =>
                {
                    b.Property<int>("IdLine")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ProductIdProduct")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("double");

                    b.Property<int>("orderIdOrder")
                        .HasColumnType("int");

                    b.HasKey("IdLine");

                    b.HasIndex("ProductIdProduct");

                    b.HasIndex("orderIdOrder");

                    b.ToTable("orderLines");
                });

            modelBuilder.Entity("FacturationGroupe1.Entity.Product", b =>
                {
                    b.Property<int>("IdProduct")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ActualStock")
                        .HasColumnType("int");

                    b.Property<double>("BuyPrice")
                        .HasColumnType("double");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ReferenceProduct")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("SillStock")
                        .HasColumnType("int");

                    b.Property<double>("SoldPrice")
                        .HasColumnType("double");

                    b.Property<int>("TVA")
                        .HasColumnType("int");

                    b.Property<int>("providerIdProvier")
                        .HasColumnType("int");

                    b.HasKey("IdProduct");

                    b.HasIndex("providerIdProvier");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("FacturationGroupe1.Entity.Provider", b =>
                {
                    b.Property<int>("IdProvier")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ProviderName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ProviderPosition")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("IdProvier");

                    b.ToTable("Providers");
                });

            modelBuilder.Entity("FacturationGroupe1.Entity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("users");
                });

            modelBuilder.Entity("FacturationGroupe1.Entity.Client", b =>
                {
                    b.HasOne("FacturationGroupe1.Entity.User", "user")
                        .WithMany("clients")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("FacturationGroupe1.Entity.Invoice", b =>
                {
                    b.HasOne("FacturationGroupe1.Entity.Order", "order")
                        .WithOne("invoice")
                        .HasForeignKey("FacturationGroupe1.Entity.Invoice", "Invoice")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("order");
                });

            modelBuilder.Entity("FacturationGroupe1.Entity.JournalAudit", b =>
                {
                    b.HasOne("FacturationGroupe1.Entity.User", "user")
                        .WithOne("journal")
                        .HasForeignKey("FacturationGroupe1.Entity.JournalAudit", "JournalAudit");

                    b.Navigation("user");
                });

            modelBuilder.Entity("FacturationGroupe1.Entity.Order", b =>
                {
                    b.HasOne("FacturationGroupe1.Entity.User", null)
                        .WithMany("orders")
                        .HasForeignKey("UserId");

                    b.HasOne("FacturationGroupe1.Entity.Client", "client")
                        .WithMany("orders")
                        .HasForeignKey("clientIdClient")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("client");
                });

            modelBuilder.Entity("FacturationGroupe1.Entity.OrderLine", b =>
                {
                    b.HasOne("FacturationGroupe1.Entity.Product", "Product")
                        .WithMany("orderLines")
                        .HasForeignKey("ProductIdProduct")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FacturationGroupe1.Entity.Order", "order")
                        .WithMany()
                        .HasForeignKey("orderIdOrder")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("order");
                });

            modelBuilder.Entity("FacturationGroupe1.Entity.Product", b =>
                {
                    b.HasOne("FacturationGroupe1.Entity.Provider", "provider")
                        .WithMany("Products")
                        .HasForeignKey("providerIdProvier")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("provider");
                });

            modelBuilder.Entity("FacturationGroupe1.Entity.Client", b =>
                {
                    b.Navigation("orders");
                });

            modelBuilder.Entity("FacturationGroupe1.Entity.Order", b =>
                {
                    b.Navigation("invoice")
                        .IsRequired();
                });

            modelBuilder.Entity("FacturationGroupe1.Entity.Product", b =>
                {
                    b.Navigation("orderLines");
                });

            modelBuilder.Entity("FacturationGroupe1.Entity.Provider", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("FacturationGroupe1.Entity.User", b =>
                {
                    b.Navigation("clients");

                    b.Navigation("journal")
                        .IsRequired();

                    b.Navigation("orders");
                });
#pragma warning restore 612, 618
        }
    }
}
