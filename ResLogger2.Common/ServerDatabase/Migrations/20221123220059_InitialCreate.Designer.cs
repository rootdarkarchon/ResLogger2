﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ResLogger2.Common.ServerDatabase;

#nullable disable

namespace ResLogger2.Common.ServerDatabase.Migrations
{
    [DbContext(typeof(ServerHashDatabase))]
    [Migration("20221123220059_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.11");

            modelBuilder.Entity("ResLogger2.Common.ServerDatabase.Model.GameVersion", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Comment")
                        .HasColumnType("TEXT");

                    b.Property<uint>("Day")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsSpecial")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("Month")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("Part")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("Revision")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("GameVersions");
                });

            modelBuilder.Entity("ResLogger2.Common.ServerDatabase.Model.Index1StagingEntry", b =>
                {
                    b.Property<uint>("IndexId")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("FolderHash")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("FileHash")
                        .HasColumnType("INTEGER");

                    b.Property<long>("FirstSeenId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("LastSeenId")
                        .HasColumnType("INTEGER");

                    b.HasKey("IndexId", "FolderHash", "FileHash");

                    b.HasIndex("FirstSeenId");

                    b.HasIndex("LastSeenId");

                    b.HasIndex("IndexId", "FolderHash", "FileHash");

                    b.ToTable("Index1StagingEntries");
                });

            modelBuilder.Entity("ResLogger2.Common.ServerDatabase.Model.Index2StagingEntry", b =>
                {
                    b.Property<uint>("IndexId")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("FullHash")
                        .HasColumnType("INTEGER");

                    b.Property<long>("FirstSeenId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("LastSeenId")
                        .HasColumnType("INTEGER");

                    b.HasKey("IndexId", "FullHash");

                    b.HasIndex("FirstSeenId");

                    b.HasIndex("LastSeenId");

                    b.HasIndex("IndexId", "FullHash");

                    b.ToTable("Index2StagingEntries");
                });

            modelBuilder.Entity("ResLogger2.Common.ServerDatabase.Model.LatestIndex", b =>
                {
                    b.Property<uint>("IndexId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("GameVersionId")
                        .HasColumnType("INTEGER");

                    b.HasKey("IndexId");

                    b.HasIndex("GameVersionId");

                    b.ToTable("LatestIndexes");
                });

            modelBuilder.Entity("ResLogger2.Common.ServerDatabase.Model.LatestProcessedVersion", b =>
                {
                    b.Property<string>("Repo")
                        .HasColumnType("TEXT");

                    b.Property<long>("VersionId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Repo");

                    b.HasIndex("VersionId");

                    b.ToTable("LatestProcessedVersions");
                });

            modelBuilder.Entity("ResLogger2.Common.ServerDatabase.Model.PathEntry", b =>
                {
                    b.Property<uint>("IndexId")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("FolderHash")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("FileHash")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("FullHash")
                        .HasColumnType("INTEGER");

                    b.Property<long>("FirstSeenId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("LastSeenId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Path")
                        .HasColumnType("TEXT");

                    b.HasKey("IndexId", "FolderHash", "FileHash", "FullHash");

                    b.HasIndex("FirstSeenId");

                    b.HasIndex("IndexId");

                    b.HasIndex("LastSeenId");

                    b.HasIndex("IndexId", "FullHash");

                    b.HasIndex("IndexId", "FolderHash", "FileHash");

                    b.HasIndex("IndexId", "FolderHash", "FileHash", "FullHash");

                    b.ToTable("Paths");
                });

            modelBuilder.Entity("ResLogger2.Common.ServerDatabase.Model.Index1StagingEntry", b =>
                {
                    b.HasOne("ResLogger2.Common.ServerDatabase.Model.GameVersion", "FirstSeen")
                        .WithMany()
                        .HasForeignKey("FirstSeenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ResLogger2.Common.ServerDatabase.Model.GameVersion", "LastSeen")
                        .WithMany()
                        .HasForeignKey("LastSeenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FirstSeen");

                    b.Navigation("LastSeen");
                });

            modelBuilder.Entity("ResLogger2.Common.ServerDatabase.Model.Index2StagingEntry", b =>
                {
                    b.HasOne("ResLogger2.Common.ServerDatabase.Model.GameVersion", "FirstSeen")
                        .WithMany()
                        .HasForeignKey("FirstSeenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ResLogger2.Common.ServerDatabase.Model.GameVersion", "LastSeen")
                        .WithMany()
                        .HasForeignKey("LastSeenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FirstSeen");

                    b.Navigation("LastSeen");
                });

            modelBuilder.Entity("ResLogger2.Common.ServerDatabase.Model.LatestIndex", b =>
                {
                    b.HasOne("ResLogger2.Common.ServerDatabase.Model.GameVersion", "GameVersion")
                        .WithMany()
                        .HasForeignKey("GameVersionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GameVersion");
                });

            modelBuilder.Entity("ResLogger2.Common.ServerDatabase.Model.LatestProcessedVersion", b =>
                {
                    b.HasOne("ResLogger2.Common.ServerDatabase.Model.GameVersion", "Version")
                        .WithMany()
                        .HasForeignKey("VersionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Version");
                });

            modelBuilder.Entity("ResLogger2.Common.ServerDatabase.Model.PathEntry", b =>
                {
                    b.HasOne("ResLogger2.Common.ServerDatabase.Model.GameVersion", "FirstSeen")
                        .WithMany()
                        .HasForeignKey("FirstSeenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ResLogger2.Common.ServerDatabase.Model.GameVersion", "LastSeen")
                        .WithMany()
                        .HasForeignKey("LastSeenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FirstSeen");

                    b.Navigation("LastSeen");
                });
#pragma warning restore 612, 618
        }
    }
}