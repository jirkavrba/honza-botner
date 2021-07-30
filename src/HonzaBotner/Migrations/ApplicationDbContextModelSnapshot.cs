﻿// <auto-generated />
using System;
using HonzaBotner.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace HonzaBotner.Migrations
{
    [DbContext(typeof(HonzaBotnerDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("HonzaBotner.Database.CountedEmoji", b =>
                {
                    b.Property<decimal>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric(20,0)");

                    b.Property<DateTime>("FirstUsedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<decimal>("Times")
                        .HasColumnType("numeric(20,0)");

                    b.HasKey("Id");

                    b.ToTable("CountedEmojis");
                });

            modelBuilder.Entity("HonzaBotner.Database.Reminder", b =>
                {
                    b.Property<decimal>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric(20,0)");

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<decimal>("MessageId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<decimal>("OwnerId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("DateTime");

                    b.ToTable("Reminders");
                });

            modelBuilder.Entity("HonzaBotner.Database.RoleBinding", b =>
                {
                    b.Property<string>("Emoji")
                        .HasColumnType("text");

                    b.Property<decimal>("ChannelId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<decimal>("MessageId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<decimal>("RoleId")
                        .HasColumnType("numeric(20,0)");

                    b.HasKey("Emoji", "ChannelId", "MessageId", "RoleId");

                    b.ToTable("RoleBindings");
                });

            modelBuilder.Entity("HonzaBotner.Database.Verification", b =>
                {
                    b.Property<decimal>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric(20,0)");

                    b.Property<string>("AuthId")
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.HasIndex("AuthId")
                        .IsUnique();

                    b.ToTable("Verifications");
                });

            modelBuilder.Entity("HonzaBotner.Database.Warning", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<DateTime>("IssuedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<decimal>("IssuerId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<string>("Reason")
                        .HasColumnType("text");

                    b.Property<decimal>("UserId")
                        .HasColumnType("numeric(20,0)");

                    b.HasKey("Id");

                    b.ToTable("Warnings");
                });
#pragma warning restore 612, 618
        }
    }
}
