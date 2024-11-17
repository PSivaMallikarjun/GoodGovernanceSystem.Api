﻿// <auto-generated />
using GoodGovernanceSystem.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GoodGovernanceSystem.Api.Migrations
{
    [DbContext(typeof(GovernanceContext))]
    partial class GovernanceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GoodGovernanceSystem.Api.Models.Budget", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<decimal>("AllocatedAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("SpentAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.ToTable("Budgets");
                });

            modelBuilder.Entity("GoodGovernanceSystem.Api.Models.Citizen", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<decimal>("Income")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TaxAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.ToTable("Citizens");
                });

            modelBuilder.Entity("GoodGovernanceSystem.Api.Models.Feedback", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("CitizenID")
                        .HasColumnType("int");

                    b.Property<string>("FeedbackText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Feedbacks");
                });
#pragma warning restore 612, 618
        }
    }
}
