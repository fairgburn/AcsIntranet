﻿// <auto-generated />
using AcsIntranet.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace AcsIntranet.Migrations
{
    [DbContext(typeof(QuoteSystemContext))]
    partial class QuoteSystemContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("AcsIntranet.Data.QuoteSystem.Block", b =>
                {
                    b.Property<string>("BlockName")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Class");

                    b.Property<string>("Creator");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description");

                    b.Property<string>("InsertionPoint");

                    b.Property<string>("PartNumber");

                    b.Property<decimal>("Price");

                    b.Property<int>("Qflag");

                    b.Property<int>("SpecNumber");

                    b.HasKey("BlockName");

                    b.ToTable("Blocks");
                });
#pragma warning restore 612, 618
        }
    }
}
