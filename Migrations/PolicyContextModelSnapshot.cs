﻿// <auto-generated />
using InsurancePolicyApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace InsurancePolicyApi.Migrations
{
    [DbContext(typeof(PolicyContext))]
    partial class PolicyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("InsurancePolicyApi.Models.Policy", b =>
                {
                    b.Property<int>("PolicyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PolicyId"));

                    b.Property<string>("PolicyDescription")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("PolicyName")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("PolicyId");

                    b.ToTable("Policies");
                });
#pragma warning restore 612, 618
        }
    }
}
