// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Data.Migrations
{
    [DbContext(typeof(StoreContext))]
    [Migration("20220113025956_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.13");

            modelBuilder.Entity("Core.Entity.Geo_Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("latitude")
                        .HasColumnType("REAL");

                    b.Property<double>("longitude")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("geo_Locations");
                });

            modelBuilder.Entity("Core.Entity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("birthday")
                        .HasColumnType("TEXT");

                    b.Property<bool>("gender")
                        .HasColumnType("INTEGER");

                    b.Property<int>("geo_location_id")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("last_active")
                        .HasColumnType("TEXT");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("geo_location_id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Core.Entity.User", b =>
                {
                    b.HasOne("Core.Entity.Geo_Location", "geo_location")
                        .WithMany()
                        .HasForeignKey("geo_location_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("geo_location");
                });
#pragma warning restore 612, 618
        }
    }
}
