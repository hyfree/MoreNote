﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MoreNote.Models;
using MoreNote.Logic.DB;
namespace MoreNote.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20191103004948_xxx")]
    partial class xxx
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0-preview2.19525.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MoreNote.Logic.Entity.ArticleEntity", b =>
                {
                    b.Property<string>("ArticleId")
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("AllowComments")
                        .HasColumnType("bit");

                    b.Property<string>("ArticleType")
                        .HasColumnType("longtext");

                    b.Property<string>("Author")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CreatUser")
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<bool>("Hot")
                        .HasColumnType("bit");

                    b.Property<string>("RecType")
                        .HasColumnType("longtext");

                    b.Property<bool>("Recommend")
                        .HasColumnType("bit");

                    b.Property<string>("SEODescription")
                        .HasColumnType("longtext");

                    b.Property<string>("SEOKeyWord")
                        .HasColumnType("longtext");

                    b.Property<string>("SEOTitle")
                        .HasColumnType("longtext");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<string>("Sources")
                        .HasColumnType("longtext");

                    b.Property<string>("Summary")
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.Property<bool>("Topping")
                        .HasColumnType("bit");

                    b.Property<bool>("TurnMap")
                        .HasColumnType("bit");

                    b.Property<string>("status")
                        .HasColumnType("longtext");

                    b.HasKey("ArticleId");

                    b.ToTable("Article");
                });

            modelBuilder.Entity("MoreNote.Logic.Entity.AuthorEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Author");
                });

            modelBuilder.Entity("MoreNote.Logic.Entity.ChapterEntity", b =>
                {
                    b.Property<string>("ChapterId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ArticleId")
                        .HasColumnType("longtext");

                    b.Property<string>("Content")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatTime")
                        .HasColumnType("datetime");

                    b.Property<int>("SerialNumber")
                        .HasColumnType("int");

                    b.Property<string>("Summary")
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.HasKey("ChapterId");

                    b.ToTable("Chapter");
                });

            modelBuilder.Entity("MoreNote.Logic.Entity.PayEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Chapter")
                        .HasColumnType("longtext");

                    b.Property<int>("Money")
                        .HasColumnType("int");

                    b.Property<DateTime>("PayTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Type")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Pay");
                });

            modelBuilder.Entity("MoreNote.Logic.Entity.UserEntity", b =>
                {
                    b.Property<string>("Userid")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Address")
                        .HasColumnType("longtext");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Avatar")
                        .HasColumnType("longtext");

                    b.Property<int>("Credit")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<int>("Gb")
                        .HasColumnType("int");

                    b.Property<string>("Intro")
                        .HasColumnType("longtext");

                    b.Property<string>("PassWord")
                        .HasColumnType("longtext");

                    b.Property<string>("QQ")
                        .HasColumnType("longtext");

                    b.Property<int>("Rank")
                        .HasColumnType("int");

                    b.Property<string>("Telephone")
                        .HasColumnType("longtext");

                    b.Property<string>("Token")
                        .HasColumnType("longtext");

                    b.Property<string>("Twitter")
                        .HasColumnType("longtext");

                    b.Property<string>("UserGroup")
                        .HasColumnType("longtext");

                    b.Property<string>("UserName")
                        .HasColumnType("longtext");

                    b.HasKey("Userid");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}
