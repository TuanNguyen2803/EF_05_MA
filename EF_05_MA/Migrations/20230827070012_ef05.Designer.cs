﻿// <auto-generated />
using EF_05_MA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EF_05_MA.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230827070012_ef05")]
    partial class ef05
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EF_05_MA.Model.Congthuc", b =>
                {
                    b.Property<int>("CongthucID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CongthucID"));

                    b.Property<string>("Donvitinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MonanID")
                        .HasColumnType("int");

                    b.Property<int>("NguyenlieuID")
                        .HasColumnType("int");

                    b.Property<int>("Soluong")
                        .HasColumnType("int");

                    b.HasKey("CongthucID");

                    b.HasIndex("MonanID");

                    b.HasIndex("NguyenlieuID");

                    b.ToTable("Congthucs");
                });

            modelBuilder.Entity("EF_05_MA.Model.Loaimonan", b =>
                {
                    b.Property<int>("LoaimonanID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LoaimonanID"));

                    b.Property<string>("Mota")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tenloai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LoaimonanID");

                    b.ToTable("Loaimonan");
                });

            modelBuilder.Entity("EF_05_MA.Model.Monan", b =>
                {
                    b.Property<int>("MonanID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MonanID"));

                    b.Property<string>("Cachlam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Giaban")
                        .HasColumnType("float");

                    b.Property<string>("Gioithieu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LoaimonanID")
                        .HasColumnType("int");

                    b.Property<string>("Tenmon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MonanID");

                    b.HasIndex("LoaimonanID");

                    b.ToTable("Monan");
                });

            modelBuilder.Entity("EF_05_MA.Model.Nguyenlieu", b =>
                {
                    b.Property<int>("NguyenlieuID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NguyenlieuID"));

                    b.Property<string>("GhiChu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tennguyenlieu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NguyenlieuID");

                    b.ToTable("Nguyenlieu");
                });

            modelBuilder.Entity("EF_05_MA.Model.Congthuc", b =>
                {
                    b.HasOne("EF_05_MA.Model.Monan", "Monan")
                        .WithMany("Congthucs")
                        .HasForeignKey("MonanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF_05_MA.Model.Nguyenlieu", "Nguyenlieu")
                        .WithMany("Congthucs")
                        .HasForeignKey("NguyenlieuID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Monan");

                    b.Navigation("Nguyenlieu");
                });

            modelBuilder.Entity("EF_05_MA.Model.Monan", b =>
                {
                    b.HasOne("EF_05_MA.Model.Loaimonan", "Loaimonan")
                        .WithMany("Monans")
                        .HasForeignKey("LoaimonanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Loaimonan");
                });

            modelBuilder.Entity("EF_05_MA.Model.Loaimonan", b =>
                {
                    b.Navigation("Monans");
                });

            modelBuilder.Entity("EF_05_MA.Model.Monan", b =>
                {
                    b.Navigation("Congthucs");
                });

            modelBuilder.Entity("EF_05_MA.Model.Nguyenlieu", b =>
                {
                    b.Navigation("Congthucs");
                });
#pragma warning restore 612, 618
        }
    }
}
