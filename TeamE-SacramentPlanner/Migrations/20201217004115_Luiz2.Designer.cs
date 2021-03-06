﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TeamE_SacramentPlanner.Data;

namespace TeamE_SacramentPlanner.Migrations
{
    [DbContext(typeof(TeamE_SacramentPlannerContext))]
    [Migration("20201217004115_Luiz2")]
    partial class Luiz2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("TeamE_SacramentPlanner.Models.MeetingProgram", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Benediction")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ClHymnName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("ClHymnNumber")
                        .HasColumnType("int");

                    b.Property<string>("Conducting")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Invocation")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("MeetingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MusicalNumber")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("OpHymnName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("OpHymnNumber")
                        .HasColumnType("int");

                    b.Property<string>("Presiding")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SHymnName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("SHymnNumber")
                        .HasColumnType("int");

                    b.Property<int?>("SpeakerID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("SpeakerID");

                    b.ToTable("MeetingProgram");
                });

            modelBuilder.Entity("TeamE_SacramentPlanner.Models.Speaker", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("MeetingID")
                        .HasColumnType("int");

                    b.Property<string>("SpeakerName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SpeakerType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Speaker");
                });

            modelBuilder.Entity("TeamE_SacramentPlanner.Models.MeetingProgram", b =>
                {
                    b.HasOne("TeamE_SacramentPlanner.Models.Speaker", "Speaker")
                        .WithMany()
                        .HasForeignKey("SpeakerID");

                    b.Navigation("Speaker");
                });
#pragma warning restore 612, 618
        }
    }
}
