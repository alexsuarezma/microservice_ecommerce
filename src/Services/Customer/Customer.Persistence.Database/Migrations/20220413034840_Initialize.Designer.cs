﻿// <auto-generated />
using Customer.Persistence.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Customer.Persistence.Database.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220413034840_Initialize")]
    partial class Initialize
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Customer")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Customer.Domain.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bank")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankAccountNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BussinesName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClientType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("CreditLimit")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("DefaultPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Dni")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("InitialBalance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ResidentForeign")
                        .HasColumnType("bit");

                    b.Property<string>("Ruc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Salesman")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SocialReason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SpecialContribuyent")
                        .HasColumnType("bit");

                    b.Property<bool>("State")
                        .HasColumnType("bit");

                    b.Property<string>("TypeOfBankAccount")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClientId");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            ClientId = 1,
                            BussinesName = "Client Bussines 1",
                            CreditLimit = 0m,
                            DefaultPrice = 0m,
                            Discount = 0m,
                            InitialBalance = 0m,
                            Name = "Client 1",
                            ResidentForeign = false,
                            SocialReason = "Client Social 1",
                            SpecialContribuyent = false,
                            State = false
                        },
                        new
                        {
                            ClientId = 2,
                            BussinesName = "Client Bussines 2",
                            CreditLimit = 0m,
                            DefaultPrice = 0m,
                            Discount = 0m,
                            InitialBalance = 0m,
                            Name = "Client 2",
                            ResidentForeign = false,
                            SocialReason = "Client Social 2",
                            SpecialContribuyent = false,
                            State = false
                        },
                        new
                        {
                            ClientId = 3,
                            BussinesName = "Client Bussines 3",
                            CreditLimit = 0m,
                            DefaultPrice = 0m,
                            Discount = 0m,
                            InitialBalance = 0m,
                            Name = "Client 3",
                            ResidentForeign = false,
                            SocialReason = "Client Social 3",
                            SpecialContribuyent = false,
                            State = false
                        },
                        new
                        {
                            ClientId = 4,
                            BussinesName = "Client Bussines 4",
                            CreditLimit = 0m,
                            DefaultPrice = 0m,
                            Discount = 0m,
                            InitialBalance = 0m,
                            Name = "Client 4",
                            ResidentForeign = false,
                            SocialReason = "Client Social 4",
                            SpecialContribuyent = false,
                            State = false
                        },
                        new
                        {
                            ClientId = 5,
                            BussinesName = "Client Bussines 5",
                            CreditLimit = 0m,
                            DefaultPrice = 0m,
                            Discount = 0m,
                            InitialBalance = 0m,
                            Name = "Client 5",
                            ResidentForeign = false,
                            SocialReason = "Client Social 5",
                            SpecialContribuyent = false,
                            State = false
                        },
                        new
                        {
                            ClientId = 6,
                            BussinesName = "Client Bussines 6",
                            CreditLimit = 0m,
                            DefaultPrice = 0m,
                            Discount = 0m,
                            InitialBalance = 0m,
                            Name = "Client 6",
                            ResidentForeign = false,
                            SocialReason = "Client Social 6",
                            SpecialContribuyent = false,
                            State = false
                        },
                        new
                        {
                            ClientId = 7,
                            BussinesName = "Client Bussines 7",
                            CreditLimit = 0m,
                            DefaultPrice = 0m,
                            Discount = 0m,
                            InitialBalance = 0m,
                            Name = "Client 7",
                            ResidentForeign = false,
                            SocialReason = "Client Social 7",
                            SpecialContribuyent = false,
                            State = false
                        },
                        new
                        {
                            ClientId = 8,
                            BussinesName = "Client Bussines 8",
                            CreditLimit = 0m,
                            DefaultPrice = 0m,
                            Discount = 0m,
                            InitialBalance = 0m,
                            Name = "Client 8",
                            ResidentForeign = false,
                            SocialReason = "Client Social 8",
                            SpecialContribuyent = false,
                            State = false
                        },
                        new
                        {
                            ClientId = 9,
                            BussinesName = "Client Bussines 9",
                            CreditLimit = 0m,
                            DefaultPrice = 0m,
                            Discount = 0m,
                            InitialBalance = 0m,
                            Name = "Client 9",
                            ResidentForeign = false,
                            SocialReason = "Client Social 9",
                            SpecialContribuyent = false,
                            State = false
                        },
                        new
                        {
                            ClientId = 10,
                            BussinesName = "Client Bussines 10",
                            CreditLimit = 0m,
                            DefaultPrice = 0m,
                            Discount = 0m,
                            InitialBalance = 0m,
                            Name = "Client 10",
                            ResidentForeign = false,
                            SocialReason = "Client Social 10",
                            SpecialContribuyent = false,
                            State = false
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
