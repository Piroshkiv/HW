﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PW_4_3_ModuleTask;

#nullable disable

namespace PW_4_3_ModuleTask.Migrations
{
    [DbContext(typeof(SongContext))]
    partial class SongContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ArtistSong", b =>
                {
                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<int>("SongId")
                        .HasColumnType("int");

                    b.HasKey("ArtistId", "SongId");

                    b.HasIndex("SongId");

                    b.ToTable("ArtistSong");

                    b.HasData(
                        new
                        {
                            ArtistId = 1,
                            SongId = 1
                        },
                        new
                        {
                            ArtistId = 1,
                            SongId = 2
                        },
                        new
                        {
                            ArtistId = 2,
                            SongId = 3
                        },
                        new
                        {
                            ArtistId = 4,
                            SongId = 2
                        },
                        new
                        {
                            ArtistId = 4,
                            SongId = 4
                        });
                });

            modelBuilder.Entity("PW_4_3_ModuleTask.Models.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfDeath")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("InstagramUrl")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.ToTable("Artist", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfBirth = new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "Name1"
                        },
                        new
                        {
                            Id = 2,
                            DateOfBirth = new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            DateOfDeath = new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "Name2"
                        },
                        new
                        {
                            Id = 3,
                            DateOfBirth = new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "Name3"
                        },
                        new
                        {
                            Id = 4,
                            DateOfBirth = new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            DateOfDeath = new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "Name4"
                        },
                        new
                        {
                            Id = 5,
                            DateOfBirth = new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "Name5"
                        });
                });

            modelBuilder.Entity("PW_4_3_ModuleTask.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Genre", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Title = "Rock"
                        },
                        new
                        {
                            Id = 2,
                            Title = "Metal"
                        },
                        new
                        {
                            Id = 3,
                            Title = "Rap"
                        },
                        new
                        {
                            Id = 4,
                            Title = "Chanson"
                        },
                        new
                        {
                            Id = 5,
                            Title = "Classical"
                        });
                });

            modelBuilder.Entity("PW_4_3_ModuleTask.Models.Song", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("time");

                    b.Property<int?>("GenreId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReleasedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.ToTable("Song", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Duration = new TimeSpan(0, 0, 3, 0, 0),
                            ReleasedDate = new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title1"
                        },
                        new
                        {
                            Id = 2,
                            Duration = new TimeSpan(0, 0, 2, 0, 0),
                            GenreId = 5,
                            ReleasedDate = new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title2"
                        },
                        new
                        {
                            Id = 3,
                            Duration = new TimeSpan(0, 0, 3, 0, 0),
                            ReleasedDate = new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title3"
                        },
                        new
                        {
                            Id = 4,
                            Duration = new TimeSpan(0, 0, 4, 0, 0),
                            GenreId = 2,
                            ReleasedDate = new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title4"
                        },
                        new
                        {
                            Id = 5,
                            Duration = new TimeSpan(0, 0, 3, 0, 0),
                            GenreId = 1,
                            ReleasedDate = new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title5"
                        });
                });

            modelBuilder.Entity("ArtistSong", b =>
                {
                    b.HasOne("PW_4_3_ModuleTask.Models.Song", null)
                        .WithMany()
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PW_4_3_ModuleTask.Models.Artist", null)
                        .WithMany()
                        .HasForeignKey("SongId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PW_4_3_ModuleTask.Models.Song", b =>
                {
                    b.HasOne("PW_4_3_ModuleTask.Models.Genre", "Genre")
                        .WithMany("Songs")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("PW_4_3_ModuleTask.Models.Genre", b =>
                {
                    b.Navigation("Songs");
                });
#pragma warning restore 612, 618
        }
    }
}
