﻿// <auto-generated />
using DiscordSharpBencher.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DiscordSharpBencher.Migrations
{
    [DbContext(typeof(CsharpiEntities))]
    [Migration("20210413122502_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("DiscordSharpBencher.Database.EightBallAnswer", b =>
                {
                    b.Property<long>("AnswerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AnswerColor")
                        .HasColumnType("TEXT");

                    b.Property<string>("AnswerText")
                        .HasColumnType("TEXT");

                    b.HasKey("AnswerId");

                    b.ToTable("EightBallAnswer");
                });
#pragma warning restore 612, 618
        }
    }
}
