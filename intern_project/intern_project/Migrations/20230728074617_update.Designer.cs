﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using intern_project.Entities;

#nullable disable

namespace intern_project.Migrations
{
    [DbContext(typeof(InternDbContext))]
    [Migration("20230728074617_update")]
    partial class update
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("intern_project.Entities.Chua", b =>
                {
                    b.Property<int>("Chuaid")
                        .HasColumnType("int")
                        .HasColumnName("chuaid");

                    b.Property<DateTime?>("Capnhat")
                        .HasColumnType("datetime")
                        .HasColumnName("capnhat");

                    b.Property<string>("Diachi")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("diachi");

                    b.Property<DateTime?>("Ngaythanhlap")
                        .HasColumnType("datetime")
                        .HasColumnName("ngaythanhlap");

                    b.Property<string>("Tenchua")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("tenchua");

                    b.Property<int?>("Trutri")
                        .HasColumnType("int")
                        .HasColumnName("trutri");

                    b.HasKey("Chuaid");

                    b.ToTable("chuas", (string)null);
                });

            modelBuilder.Entity("intern_project.Entities.Daotrang", b =>
                {
                    b.Property<int>("Daotrangid")
                        .HasColumnType("int")
                        .HasColumnName("daotrangid");

                    b.Property<bool?>("Daketthuc")
                        .HasColumnType("bit")
                        .HasColumnName("daketthuc");

                    b.Property<int?>("Nguoitrutri")
                        .HasColumnType("int")
                        .HasColumnName("nguoitrutri");

                    b.Property<string>("Noidung")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("noidung");

                    b.Property<string>("Noitochuc")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("noitochuc");

                    b.Property<int?>("Sothanhvienthamgia")
                        .HasColumnType("int")
                        .HasColumnName("sothanhvienthamgia");

                    b.Property<DateTime?>("Thoigiantochuc")
                        .HasColumnType("datetime")
                        .HasColumnName("thoigiantochuc");

                    b.HasKey("Daotrangid");

                    b.ToTable("daotrangs", (string)null);
                });

            modelBuilder.Entity("intern_project.Entities.Dondangky", b =>
                {
                    b.Property<int>("Dondangkyid")
                        .HasColumnType("int")
                        .HasColumnName("dondangkyid");

                    b.Property<int?>("Daotrangid")
                        .HasColumnType("int")
                        .HasColumnName("daotrangid");

                    b.Property<DateTime?>("Ngayguidon")
                        .HasColumnType("datetime")
                        .HasColumnName("ngayguidon");

                    b.Property<DateTime?>("Ngayxuly")
                        .HasColumnType("datetime")
                        .HasColumnName("ngayxuly");

                    b.Property<int?>("Nguoixuly")
                        .HasColumnType("int")
                        .HasColumnName("nguoixuly");

                    b.Property<int?>("Phattuid")
                        .HasColumnType("int")
                        .HasColumnName("phattuid");

                    b.Property<int?>("Trangthaidon")
                        .HasColumnType("int")
                        .HasColumnName("trangthaidon");

                    b.HasKey("Dondangkyid");

                    b.HasIndex("Daotrangid");

                    b.HasIndex("Phattuid");

                    b.ToTable("dondangkys", (string)null);
                });

            modelBuilder.Entity("intern_project.Entities.Kieuthanhvien", b =>
                {
                    b.Property<int>("Kieuthanhvienid")
                        .HasColumnType("int")
                        .HasColumnName("kieuthanhvienid");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("code");

                    b.Property<string>("Tenkieu")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("tenkieu");

                    b.HasKey("Kieuthanhvienid");

                    b.ToTable("kieuthanhviens", (string)null);
                });

            modelBuilder.Entity("intern_project.Entities.Phattu", b =>
                {
                    b.Property<int>("Phattuid")
                        .HasColumnType("int")
                        .HasColumnName("phattuid");

                    b.Property<string>("Anhchup")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("anhchup");

                    b.Property<int?>("Chuaid")
                        .HasColumnType("int")
                        .HasColumnName("chuaid");

                    b.Property<bool?>("Dahoantuc")
                        .HasColumnType("bit")
                        .HasColumnName("dahoantuc");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("email");

                    b.Property<int?>("Gioitinh")
                        .HasColumnType("int")
                        .HasColumnName("gioitinh");

                    b.Property<string>("Ho")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ho");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int?>("Kieuthanhvienid")
                        .HasColumnType("int")
                        .HasColumnName("kieuthanhvienid");

                    b.Property<DateTime?>("Ngaycapnhat")
                        .HasColumnType("datetime")
                        .HasColumnName("ngaycapnhat");

                    b.Property<DateTime?>("Ngayhoantuc")
                        .HasColumnType("datetime")
                        .HasColumnName("ngayhoantuc");

                    b.Property<DateTime?>("Ngaysinh")
                        .HasColumnType("datetime")
                        .HasColumnName("ngaysinh");

                    b.Property<DateTime?>("Ngayxuatgia")
                        .HasColumnType("datetime")
                        .HasColumnName("ngayxuatgia");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("password");

                    b.Property<string>("Phapdanh")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("phapdanh");

                    b.Property<string>("Sodienthoai")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("sodienthoai");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ten");

                    b.Property<string>("Tendem")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("tendem");

                    b.HasKey("Phattuid");

                    b.HasIndex("Chuaid");

                    b.HasIndex("Kieuthanhvienid");

                    b.ToTable("phattus", (string)null);
                });

            modelBuilder.Entity("intern_project.Entities.Phattudaotrang", b =>
                {
                    b.Property<int>("Phattudaotrangid")
                        .HasColumnType("int")
                        .HasColumnName("phattudaotrangid");

                    b.Property<int?>("Daotrangid")
                        .HasColumnType("int")
                        .HasColumnName("daotrangid");

                    b.Property<bool?>("Dathamgia")
                        .HasColumnType("bit")
                        .HasColumnName("dathamgia");

                    b.Property<string>("Lidokhongthamgia")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("lidokhongthamgia");

                    b.Property<int?>("Phattuid")
                        .HasColumnType("int")
                        .HasColumnName("phattuid");

                    b.HasKey("Phattudaotrangid");

                    b.HasIndex("Daotrangid");

                    b.HasIndex("Phattuid");

                    b.ToTable("phattudaotrangs", (string)null);
                });

            modelBuilder.Entity("intern_project.Entities.Token", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int?>("Phattuid")
                        .HasColumnType("int")
                        .HasColumnName("phattuid");

                    b.Property<string>("Token1")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("token");

                    b.Property<int?>("Tokentype")
                        .HasColumnType("int")
                        .HasColumnName("tokentype");

                    b.HasKey("Id");

                    b.HasIndex("Phattuid");

                    b.ToTable("token", (string)null);
                });

            modelBuilder.Entity("intern_project.Entities.Dondangky", b =>
                {
                    b.HasOne("intern_project.Entities.Daotrang", "Daotrang")
                        .WithMany("Dondangkies")
                        .HasForeignKey("Daotrangid")
                        .HasConstraintName("FK_dondangkys_daotrangs");

                    b.HasOne("intern_project.Entities.Phattu", "Phattu")
                        .WithMany("Dondangkies")
                        .HasForeignKey("Phattuid")
                        .HasConstraintName("FK_dondangkys_phattus");

                    b.Navigation("Daotrang");

                    b.Navigation("Phattu");
                });

            modelBuilder.Entity("intern_project.Entities.Phattu", b =>
                {
                    b.HasOne("intern_project.Entities.Chua", "Chua")
                        .WithMany("Phattus")
                        .HasForeignKey("Chuaid")
                        .HasConstraintName("FK_phattus_chuas");

                    b.HasOne("intern_project.Entities.Kieuthanhvien", "Kieuthanhvien")
                        .WithMany("Phattus")
                        .HasForeignKey("Kieuthanhvienid")
                        .HasConstraintName("FK_phattus_kieuthanhviens");

                    b.Navigation("Chua");

                    b.Navigation("Kieuthanhvien");
                });

            modelBuilder.Entity("intern_project.Entities.Phattudaotrang", b =>
                {
                    b.HasOne("intern_project.Entities.Daotrang", "Daotrang")
                        .WithMany("Phattudaotrangs")
                        .HasForeignKey("Daotrangid")
                        .HasConstraintName("FK_phattudaotrangs_daotrangs");

                    b.HasOne("intern_project.Entities.Phattu", "Phattu")
                        .WithMany("Phattudaotrangs")
                        .HasForeignKey("Phattuid")
                        .HasConstraintName("FK_phattudaotrangs_phattus");

                    b.Navigation("Daotrang");

                    b.Navigation("Phattu");
                });

            modelBuilder.Entity("intern_project.Entities.Token", b =>
                {
                    b.HasOne("intern_project.Entities.Phattu", "Phattu")
                        .WithMany("Tokens")
                        .HasForeignKey("Phattuid")
                        .HasConstraintName("FK_token_phattus");

                    b.Navigation("Phattu");
                });

            modelBuilder.Entity("intern_project.Entities.Chua", b =>
                {
                    b.Navigation("Phattus");
                });

            modelBuilder.Entity("intern_project.Entities.Daotrang", b =>
                {
                    b.Navigation("Dondangkies");

                    b.Navigation("Phattudaotrangs");
                });

            modelBuilder.Entity("intern_project.Entities.Kieuthanhvien", b =>
                {
                    b.Navigation("Phattus");
                });

            modelBuilder.Entity("intern_project.Entities.Phattu", b =>
                {
                    b.Navigation("Dondangkies");

                    b.Navigation("Phattudaotrangs");

                    b.Navigation("Tokens");
                });
#pragma warning restore 612, 618
        }
    }
}