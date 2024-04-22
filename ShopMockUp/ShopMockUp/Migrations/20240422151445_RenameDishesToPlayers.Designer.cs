﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopMockUp.Data;

#nullable disable

namespace ShopMockUp.Migrations
{
    [DbContext(typeof(MenuContext))]
    [Migration("20240422151445_RenameDishesToPlayers")]
    partial class RenameDishesToPlayers
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ShopMockUp.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("ShopMockUp.Models.Items", b =>
                {
                    b.Property<int>("itemId")
                        .HasColumnType("int");

                    b.Property<int>("playerId")
                        .HasColumnType("int");

                    b.HasKey("itemId", "playerId");

                    b.HasIndex("playerId");

                    b.ToTable("DishIngredients");
                });

            modelBuilder.Entity("ShopMockUp.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("ShopMockUp.Models.Items", b =>
                {
                    b.HasOne("ShopMockUp.Models.Player", "player")
                        .WithMany("items")
                        .HasForeignKey("itemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShopMockUp.Models.Item", "item")
                        .WithMany("itemsList")
                        .HasForeignKey("playerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("item");

                    b.Navigation("player");
                });

            modelBuilder.Entity("ShopMockUp.Models.Item", b =>
                {
                    b.Navigation("itemsList");
                });

            modelBuilder.Entity("ShopMockUp.Models.Player", b =>
                {
                    b.Navigation("items");
                });
#pragma warning restore 612, 618
        }
    }
}
