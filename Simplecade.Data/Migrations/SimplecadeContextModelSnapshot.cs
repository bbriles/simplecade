﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Simplecade.Data;

namespace Simplecade.Data.Migrations
{
    [DbContext(typeof(SimplecadeContext))]
    partial class SimplecadeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6");

            modelBuilder.Entity("Simplecade.Data.Configuration", b =>
                {
                    b.Property<int>("ConfigurationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BackgroundPath")
                        .HasColumnType("TEXT");

                    b.Property<string>("BoxArtPath")
                        .HasColumnType("TEXT");

                    b.Property<string>("SnapPath")
                        .HasColumnType("TEXT");

                    b.Property<string>("VideoPath")
                        .HasColumnType("TEXT");

                    b.HasKey("ConfigurationId");

                    b.ToTable("Configuration");
                });

            modelBuilder.Entity("Simplecade.Data.Game", b =>
                {
                    b.Property<int>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Developer")
                        .HasColumnType("TEXT");

                    b.Property<string>("Filename")
                        .HasColumnType("TEXT");

                    b.Property<string>("Genre")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Multiplayer")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Publisher")
                        .HasColumnType("TEXT");

                    b.Property<int>("SystemId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Year")
                        .HasColumnType("TEXT");

                    b.HasKey("GameId");

                    b.HasIndex("SystemId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("Simplecade.Data.System", b =>
                {
                    b.Property<int>("SystemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ExecutablePath")
                        .HasColumnType("TEXT");

                    b.Property<string>("Extensions")
                        .HasColumnType("TEXT");

                    b.Property<string>("GamesPath")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsPCGames")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Parameters")
                        .HasColumnType("TEXT");

                    b.HasKey("SystemId");

                    b.ToTable("Systems");
                });

            modelBuilder.Entity("Simplecade.Data.Game", b =>
                {
                    b.HasOne("Simplecade.Data.System", "System")
                        .WithMany("Games")
                        .HasForeignKey("SystemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
