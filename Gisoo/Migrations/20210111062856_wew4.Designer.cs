﻿// <auto-generated />
using System;
using Gisoo.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Gisoo.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20210111062856_wew4")]
    partial class wew4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Gisoo.Models.AboutUs", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("description")
                        .IsRequired()
                        .HasMaxLength(5000);

                    b.HasKey("id");

                    b.ToTable("AboutUss");
                });

            modelBuilder.Entity("Gisoo.Models.Advertisment", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("adminConfirmStatus");

                    b.Property<int>("areaId");

                    b.Property<int>("cityId");

                    b.Property<string>("code");

                    b.Property<int?>("countView");

                    b.Property<DateTime>("createDate")
                        .HasMaxLength(50);

                    b.Property<string>("description")
                        .HasMaxLength(1000);

                    b.Property<DateTime>("expireDate")
                        .HasMaxLength(50);

                    b.Property<string>("image1")
                        .HasMaxLength(500);

                    b.Property<string>("image2")
                        .HasMaxLength(500);

                    b.Property<string>("image3")
                        .HasMaxLength(500);

                    b.Property<bool>("isDeleted");

                    b.Property<bool>("isWorkshop");

                    b.Property<string>("notConfirmDescription")
                        .HasMaxLength(1000);

                    b.Property<int>("provinceId");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<int>("userId");

                    b.HasKey("id");

                    b.HasIndex("areaId");

                    b.HasIndex("cityId");

                    b.HasIndex("provinceId");

                    b.HasIndex("userId");

                    b.ToTable("Advertisments");
                });

            modelBuilder.Entity("Gisoo.Models.AllPrice", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("advertismentPrice");

                    b.Property<long>("barberPrice");

                    b.Property<bool>("isHasAdvertismentPrice");

                    b.Property<bool>("isHasBarberPrice");

                    b.Property<bool>("isHasSaloonPrice");

                    b.Property<bool>("isHasWorkshopPrice");

                    b.Property<long?>("maxDiscount")
                        .IsRequired();

                    b.Property<long?>("minDiscount")
                        .IsRequired();

                    b.Property<long?>("oneSubscriptionPrice")
                        .IsRequired();

                    b.Property<long>("saloonPrice");

                    b.Property<int?>("scoreWithInturducer");

                    b.Property<long?>("threeSubscriptionPrice")
                        .IsRequired();

                    b.Property<long>("workshopPrice");

                    b.HasKey("id");

                    b.ToTable("AllPrices");
                });

            modelBuilder.Entity("Gisoo.Models.AndroidVersion", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("appAndroidUrl")
                        .HasMaxLength(70);

                    b.Property<string>("currVersion")
                        .HasMaxLength(20);

                    b.HasKey("id");

                    b.ToTable("AndroidVersions");
                });

            modelBuilder.Entity("Gisoo.Models.Area", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .HasMaxLength(50);

                    b.Property<int>("provinceId");

                    b.HasKey("id");

                    b.HasIndex("provinceId");

                    b.ToTable("Areas");
                });

            modelBuilder.Entity("Gisoo.Models.Article", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("description");

                    b.Property<string>("image")
                        .HasMaxLength(500);

                    b.Property<string>("title")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("id");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("Gisoo.Models.Banner", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("image")
                        .HasMaxLength(500);

                    b.Property<string>("link")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("id");

                    b.ToTable("Banners");
                });

            modelBuilder.Entity("Gisoo.Models.City", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .HasMaxLength(50);

                    b.HasKey("id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Gisoo.Models.ClassRoom", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("adminConfirmStatus");

                    b.Property<int>("classRoomLaw");

                    b.Property<int>("classRoomTypeId");

                    b.Property<int?>("countView");

                    b.Property<string>("description")
                        .HasMaxLength(500);

                    b.Property<DateTime>("expireDate");

                    b.Property<string>("notConfirmDescription")
                        .HasMaxLength(1000);

                    b.Property<long>("price");

                    b.Property<DateTime>("registerDate");

                    b.Property<DateTime?>("reserveDate");

                    b.Property<string>("reserveHour")
                        .HasMaxLength(50);

                    b.Property<string>("title")
                        .HasMaxLength(50);

                    b.Property<int>("userId");

                    b.HasKey("id");

                    b.HasIndex("classRoomTypeId");

                    b.HasIndex("userId");

                    b.ToTable("ClassRooms");
                });

            modelBuilder.Entity("Gisoo.Models.ClassRoomImage", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("classRoomId");

                    b.Property<string>("url")
                        .HasMaxLength(200);

                    b.HasKey("id");

                    b.HasIndex("classRoomId");

                    b.ToTable("ClassRoomImages");
                });

            modelBuilder.Entity("Gisoo.Models.ClassRoomType", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .HasMaxLength(100);

                    b.HasKey("id");

                    b.ToTable("ClassRoomTypes");
                });

            modelBuilder.Entity("Gisoo.Models.ContactUs", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("androidVersion")
                        .HasMaxLength(20);

                    b.Property<string>("email")
                        .HasMaxLength(200);

                    b.Property<string>("pageInstagramUrl")
                        .HasMaxLength(200);

                    b.Property<string>("pageTelegramUrl")
                        .HasMaxLength(200);

                    b.Property<string>("pageTwitterUrl")
                        .HasMaxLength(200);

                    b.Property<string>("phone")
                        .HasMaxLength(50);

                    b.HasKey("id");

                    b.ToTable("ContactUss");
                });

            modelBuilder.Entity("Gisoo.Models.Factor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("advertismentId");

                    b.Property<int?>("classRoomId");

                    b.Property<string>("createDatePersian")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("factorKind");

                    b.Property<int?>("lineId");

                    b.Property<int?>("noticeId");

                    b.Property<int?>("productId");

                    b.Property<int>("state");

                    b.Property<long>("totalPrice");

                    b.Property<int>("userId");

                    b.HasKey("id");

                    b.HasIndex("advertismentId");

                    b.HasIndex("classRoomId");

                    b.HasIndex("lineId");

                    b.HasIndex("noticeId");

                    b.HasIndex("productId");

                    b.HasIndex("userId");

                    b.ToTable("Factors");
                });

            modelBuilder.Entity("Gisoo.Models.FactorItem", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FactorId");

                    b.Property<int>("ProductId");

                    b.Property<long>("price");

                    b.HasKey("id");

                    b.HasIndex("FactorId");

                    b.HasIndex("ProductId");

                    b.ToTable("FactorItems");
                });

            modelBuilder.Entity("Gisoo.Models.Information", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("description")
                        .IsRequired()
                        .HasMaxLength(5000);

                    b.Property<string>("title")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.HasKey("id");

                    b.ToTable("Informations");
                });

            modelBuilder.Entity("Gisoo.Models.Line", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("adminConfirmStatus");

                    b.Property<int?>("countView");

                    b.Property<string>("description")
                        .HasMaxLength(500);

                    b.Property<DateTime>("expireDate");

                    b.Property<int>("lineLaw");

                    b.Property<int>("lineTypeId");

                    b.Property<string>("notConfirmDescription")
                        .HasMaxLength(1000);

                    b.Property<long>("price");

                    b.Property<DateTime>("registerDate");

                    b.Property<DateTime?>("reserveDate");

                    b.Property<string>("reserveHour")
                        .HasMaxLength(50);

                    b.Property<string>("title")
                        .HasMaxLength(50);

                    b.Property<int>("userId");

                    b.HasKey("id");

                    b.HasIndex("lineTypeId");

                    b.HasIndex("userId");

                    b.ToTable("Lines");
                });

            modelBuilder.Entity("Gisoo.Models.LineImage", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("lineId");

                    b.Property<string>("url")
                        .HasMaxLength(200);

                    b.HasKey("id");

                    b.HasIndex("lineId");

                    b.ToTable("LineImages");
                });

            modelBuilder.Entity("Gisoo.Models.LineType", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .HasMaxLength(100);

                    b.HasKey("id");

                    b.ToTable("LineTypes");
                });

            modelBuilder.Entity("Gisoo.Models.Notice", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("adminConfirmStatus");

                    b.Property<int>("areaId");

                    b.Property<int>("cityId");

                    b.Property<string>("code");

                    b.Property<int>("condition");

                    b.Property<int?>("countView");

                    b.Property<DateTime>("createDate")
                        .HasMaxLength(50);

                    b.Property<string>("description")
                        .HasMaxLength(1000);

                    b.Property<DateTime>("expireDate")
                        .HasMaxLength(50);

                    b.Property<string>("image1")
                        .HasMaxLength(500);

                    b.Property<string>("image2")
                        .HasMaxLength(500);

                    b.Property<string>("image3")
                        .HasMaxLength(500);

                    b.Property<bool>("isBarber");

                    b.Property<bool>("isDeleted");

                    b.Property<string>("notConfirmDescription")
                        .HasMaxLength(1000);

                    b.Property<int>("provinceId");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<int>("userId");

                    b.HasKey("id");

                    b.HasIndex("areaId");

                    b.HasIndex("cityId");

                    b.HasIndex("provinceId");

                    b.HasIndex("userId");

                    b.ToTable("Notices");
                });

            modelBuilder.Entity("Gisoo.Models.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("adminConfirmStatus");

                    b.Property<int?>("countView");

                    b.Property<DateTime>("createDate")
                        .HasMaxLength(50);

                    b.Property<string>("description")
                        .HasMaxLength(1000);

                    b.Property<DateTime>("expireDate");

                    b.Property<string>("notConfirmDescription")
                        .HasMaxLength(1000);

                    b.Property<long>("price");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<int>("userId");

                    b.HasKey("id");

                    b.HasIndex("userId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Gisoo.Models.ProductImage", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("productId");

                    b.Property<string>("url")
                        .HasMaxLength(200);

                    b.HasKey("id");

                    b.HasIndex("productId");

                    b.ToTable("ProductImages");
                });

            modelBuilder.Entity("Gisoo.Models.Province", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("cityId");

                    b.Property<string>("name")
                        .HasMaxLength(50);

                    b.HasKey("id");

                    b.HasIndex("cityId");

                    b.ToTable("Provinces");
                });

            modelBuilder.Entity("Gisoo.Models.Reserve", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("classroomId");

                    b.Property<DateTime>("date");

                    b.Property<int?>("lineId");

                    b.Property<long>("price");

                    b.Property<int?>("productId");

                    b.Property<int?>("userId");

                    b.HasKey("id");

                    b.HasIndex("classroomId");

                    b.HasIndex("lineId");

                    b.HasIndex("productId");

                    b.HasIndex("userId");

                    b.ToTable("Reserves");
                });

            modelBuilder.Entity("Gisoo.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleNameEn")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("RoleNameFa")
                        .IsRequired()
                        .HasMaxLength(1000);

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Gisoo.Models.Rule", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("description")
                        .IsRequired()
                        .HasMaxLength(5000);

                    b.HasKey("id");

                    b.ToTable("Rules");
                });

            modelBuilder.Entity("Gisoo.Models.Slider", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("image")
                        .HasMaxLength(500);

                    b.Property<bool>("isForWebSite");

                    b.Property<string>("link")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("titleForWebSite")
                        .HasMaxLength(200);

                    b.HasKey("id");

                    b.ToTable("Sliders");
                });

            modelBuilder.Entity("Gisoo.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address")
                        .HasMaxLength(1000);

                    b.Property<string>("cellphone")
                        .IsRequired()
                        .HasMaxLength(11);

                    b.Property<string>("code")
                        .HasMaxLength(6);

                    b.Property<string>("fullname")
                        .HasMaxLength(200);

                    b.Property<bool>("hasCertificate");

                    b.Property<double>("latitude");

                    b.Property<string>("linkInstagram")
                        .HasMaxLength(100);

                    b.Property<string>("linkTelegram")
                        .HasMaxLength(100);

                    b.Property<string>("longDescription")
                        .HasMaxLength(2000);

                    b.Property<double>("longitude");

                    b.Property<string>("nationalCode")
                        .HasMaxLength(10);

                    b.Property<string>("password")
                        .HasMaxLength(200);

                    b.Property<string>("passwordShow")
                        .HasMaxLength(20);

                    b.Property<int>("roleId");

                    b.Property<long>("score");

                    b.Property<string>("shebaNumber")
                        .HasMaxLength(16);

                    b.Property<string>("shortDescription")
                        .HasMaxLength(500);

                    b.Property<string>("token")
                        .HasMaxLength(100);

                    b.Property<string>("url");

                    b.Property<bool>("userStatus");

                    b.Property<string>("workingHours")
                        .HasMaxLength(1000);

                    b.HasKey("id");

                    b.HasIndex("roleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Gisoo.Models.UserDocumentImage", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("url")
                        .HasMaxLength(200);

                    b.Property<int>("userId");

                    b.HasKey("id");

                    b.HasIndex("userId");

                    b.ToTable("UserDocumentImages");
                });

            modelBuilder.Entity("Gisoo.Models.Visit", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ip");

                    b.Property<int>("anyNoticeId");

                    b.Property<DateTime>("date")
                        .HasMaxLength(50);

                    b.Property<int>("whichTableEnum");

                    b.HasKey("id");

                    b.ToTable("Visits");
                });

            modelBuilder.Entity("Gisoo.Models.Advertisment", b =>
                {
                    b.HasOne("Gisoo.Models.Area", "area")
                        .WithMany()
                        .HasForeignKey("areaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Gisoo.Models.City", "city")
                        .WithMany()
                        .HasForeignKey("cityId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Gisoo.Models.Province", "province")
                        .WithMany()
                        .HasForeignKey("provinceId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Gisoo.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Gisoo.Models.Area", b =>
                {
                    b.HasOne("Gisoo.Models.Province", "province")
                        .WithMany()
                        .HasForeignKey("provinceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Gisoo.Models.ClassRoom", b =>
                {
                    b.HasOne("Gisoo.Models.ClassRoomType", "classRoomType")
                        .WithMany()
                        .HasForeignKey("classRoomTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Gisoo.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Gisoo.Models.ClassRoomImage", b =>
                {
                    b.HasOne("Gisoo.Models.ClassRoom", "classRoom")
                        .WithMany("ClassRoomImages")
                        .HasForeignKey("classRoomId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Gisoo.Models.Factor", b =>
                {
                    b.HasOne("Gisoo.Models.Advertisment", "advertisment")
                        .WithMany()
                        .HasForeignKey("advertismentId");

                    b.HasOne("Gisoo.Models.ClassRoom", "classRoom")
                        .WithMany()
                        .HasForeignKey("classRoomId");

                    b.HasOne("Gisoo.Models.Line", "line")
                        .WithMany()
                        .HasForeignKey("lineId");

                    b.HasOne("Gisoo.Models.Notice", "notice")
                        .WithMany()
                        .HasForeignKey("noticeId");

                    b.HasOne("Gisoo.Models.Product", "product")
                        .WithMany()
                        .HasForeignKey("productId");

                    b.HasOne("Gisoo.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Gisoo.Models.FactorItem", b =>
                {
                    b.HasOne("Gisoo.Models.Factor", "Factor")
                        .WithMany()
                        .HasForeignKey("FactorId");

                    b.HasOne("Gisoo.Models.Notice", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Gisoo.Models.Line", b =>
                {
                    b.HasOne("Gisoo.Models.LineType", "lineType")
                        .WithMany()
                        .HasForeignKey("lineTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Gisoo.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Gisoo.Models.LineImage", b =>
                {
                    b.HasOne("Gisoo.Models.Line", "line")
                        .WithMany("LineImages")
                        .HasForeignKey("lineId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Gisoo.Models.Notice", b =>
                {
                    b.HasOne("Gisoo.Models.Area", "area")
                        .WithMany()
                        .HasForeignKey("areaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Gisoo.Models.City", "city")
                        .WithMany()
                        .HasForeignKey("cityId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Gisoo.Models.Province", "province")
                        .WithMany()
                        .HasForeignKey("provinceId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Gisoo.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Gisoo.Models.Product", b =>
                {
                    b.HasOne("Gisoo.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Gisoo.Models.ProductImage", b =>
                {
                    b.HasOne("Gisoo.Models.Product", "product")
                        .WithMany("ProductImages")
                        .HasForeignKey("productId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Gisoo.Models.Province", b =>
                {
                    b.HasOne("Gisoo.Models.City", "city")
                        .WithMany()
                        .HasForeignKey("cityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Gisoo.Models.Reserve", b =>
                {
                    b.HasOne("Gisoo.Models.ClassRoom", "classroom")
                        .WithMany()
                        .HasForeignKey("classroomId");

                    b.HasOne("Gisoo.Models.Line", "line")
                        .WithMany()
                        .HasForeignKey("lineId");

                    b.HasOne("Gisoo.Models.Product", "product")
                        .WithMany()
                        .HasForeignKey("productId");

                    b.HasOne("Gisoo.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userId");
                });

            modelBuilder.Entity("Gisoo.Models.User", b =>
                {
                    b.HasOne("Gisoo.Models.Role", "role")
                        .WithMany("Users")
                        .HasForeignKey("roleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Gisoo.Models.UserDocumentImage", b =>
                {
                    b.HasOne("Gisoo.Models.User", "user")
                        .WithMany("UserDocumentImages")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
