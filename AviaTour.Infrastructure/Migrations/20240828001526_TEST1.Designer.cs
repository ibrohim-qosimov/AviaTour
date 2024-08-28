﻿// <auto-generated />
using System;
using AviaTour.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AviaTour.Infrastructure.Migrations
{
    [DbContext(typeof(AviaTourDbContext))]
    [Migration("20240828001526_TEST1")]
    partial class TEST1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AviaTour.Domain.Entities.AboutUsModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("AboutUs");
                });

            modelBuilder.Entity("AviaTour.Domain.Entities.Address", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string>("District")
                        .HasColumnType("text");

                    b.Property<string>("Door")
                        .HasColumnType("text");

                    b.Property<long>("Latitude")
                        .HasColumnType("bigint");

                    b.Property<long>("Longitude")
                        .HasColumnType("bigint");

                    b.Property<string>("Street")
                        .HasColumnType("text");

                    b.Property<long>("ZipCode")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("AviaTour.Domain.Entities.Auth.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("PhotoUrl")
                        .HasColumnType("text");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("AviaTour.Domain.Entities.Comment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTimeOffset?>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("From")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasMaxLength(240)
                        .HasColumnType("character varying(240)");

                    b.Property<DateTimeOffset?>("ModifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("TourId")
                        .HasColumnType("bigint");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("TourId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("AviaTour.Domain.Entities.ContactModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("AviaTour.Domain.Entities.EmailAddressModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Emails");
                });

            modelBuilder.Entity("AviaTour.Domain.Entities.Tour", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTimeOffset?>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("DeletedAt")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("ModifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("PicturePath")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("Price")
                        .HasColumnType("bigint");

                    b.Property<string>("Subtitle")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Where")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("character varying(80)");

                    b.Property<string>("WhereEx")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("character varying(80)");

                    b.HasKey("Id");

                    b.ToTable("Tours");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedAt = new DateTimeOffset(new DateTime(2024, 8, 28, 0, 15, 25, 612, DateTimeKind.Unspecified).AddTicks(812), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "The tour price includes:\r\n\r\nDirect flight Tashkent-Dubai-Tashkent (Fly Dubai flights)\r\n\r\nAccommodation in the selected hotel\r\n\r\nTransfer airport – hotel – airport\r\n\r\nMeals on board\r\n\r\nLuggage included in tour price\r\n\r\nBreakfast\r\n\r\nThe tour price does not include:\r\n\r\nAll COVID-19 tests\\r\n\r\nVISA (80 USD per person)\r\n\r\nMedical insurance\r\n\r\nTourism dirham (tourist tax)",
                            IsDeleted = false,
                            PicturePath = "/TourPhotos/f92cd6e4c9934fde980c7e9c7fbddbf2.jpg",
                            Price = 2000000L,
                            Subtitle = "Dubai is the most populous city in the United Arab Emirates (UAE) and the capital of the Emirate of Dubai, the most populated of the country's seven emirates. Founded in the 1800s as a fishing village, Dubai has emerged as a major center for regional and international trade since the early 20th century and early 21st centuries with a focus on tourism and luxury.",
                            Where = "Luxury Dubai",
                            WhereEx = "Dubai"
                        },
                        new
                        {
                            Id = 2L,
                            CreatedAt = new DateTimeOffset(new DateTime(2024, 8, 28, 0, 15, 25, 612, DateTimeKind.Unspecified).AddTicks(822), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "Paradise islands and beautiful beaches\r\n\r\nSophisticated tourists have long realized that the best vacation in Thailand is on the islands. There are many of them here – Koh Samui, Phuket, Koh Chang, Koh Tao… And on each one there are beautiful beaches with snow–white sand and clear water, small picturesque coves, huge coconut palms, beautiful waterfalls, inviting jungles and neat rice fields.\r\n\r\n \r\n\r\nThe holiday season all year round Thailand is remarkable in that you can relax here almost all year round. The holiday season ends in one place of the country, you just need to plan a trip to another part of it. You can always find a region where there are no tropical downpours.\r\n\r\n \r\n\r\nA rich excursion program A variety of sightseeing tours will give a lot of impressions. You will see clear rivers and majestic mountains, pristine jungles and magnificent ancient palaces. You can go by boat on the River Kwai, try your hand at elephant training, learn Thai massage or see the famous transvestite show.\r\n\r\n \r\n\r\nDiverse outdoor activities Lovers of active spending time, as a rule, speak very warmly about their holidays in Thailand. Here you can do almost any kind of sport at your leisure. The most common type of active recreation in this country is diving. Thai resorts promise diving enthusiasts a vivid and varied experience. In addition to diving, golf, windsurfing, fishing, yachting and snorkeling are popular in Thailand.\r\n\r\n \r\n\r\nInteresting places for diving Divers from all over the world go to Thailand for deep-sea dives. The best places for them are the Similan Islands, Phuket, Koh Tao and Pi-Pi. Beautiful underwater landscapes, mysterious grottoes, amazing colored water, unusual soft corals, fish of bizarre colors, giant water turtles – in general, there is something to see.\r\n\r\n \r\n\r\nExotic nature and animals the riot of nature in Thailand is amazing. There is lush vegetation everywhere, a lot of palm trees, magnificent orchids all around. In the national parks of the country, you can not only see elephants and monkeys, but also admire the delightful show of exotic butterflies, tickle your nerves with the spectacle of the dance of poisonous snakes or visit a crocodile farm.\r\n\r\n \r\n\r\nAsian cuisine and tropical fruits you will want to taste local cuisine again and again. Unique seasonings give a special taste to meat, fish, vegetables. And the famous Tom Yam soup is a masterpiece of culinary art. The variety of delicious fruits is also striking. You probably have never heard of some of them, but  many people go to the country to taste them.\r\n\r\n \r\n\r\nHospitable Thais Travelers compose legends about the cordiality and goodwill of local residents. People on the streets sincerely smile and welcome guests like children. They will be happy to help you, tell you how to get through, offer any assistance. This is not surprising – the majority of the population professes Buddhism, and not in words, but in deeds.",
                            IsDeleted = false,
                            PicturePath = "/TourPhotos/1617289741_35-p-oboi-samui-ostrov-v-tailande-43.jpg",
                            Price = 5000000L,
                            Subtitle = "Tai peoples migrated from southwestern China to mainland Southeast Asia from the 6th to 11th centuries. Indianised kingdoms such as the Mon, Khmer Empire, and Malay states ruled the region, competing with Thai states such as the Kingdoms of Ngoenyang, Sukhothai, Lan Na, and Ayutthaya, which also rivalled each other. European contact began in 1511 with a Portuguese diplomatic mission to Ayutthaya, which became a regional power by the end of the 15th century.",
                            Where = "The paradise islands of Tailand",
                            WhereEx = "Tailand"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<long>", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<long>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<long>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<long>", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<long>", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("AviaTour.Domain.Entities.Comment", b =>
                {
                    b.HasOne("AviaTour.Domain.Entities.Tour", "Tour")
                        .WithMany("Comments")
                        .HasForeignKey("TourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tour");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<long>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<long>", b =>
                {
                    b.HasOne("AviaTour.Domain.Entities.Auth.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<long>", b =>
                {
                    b.HasOne("AviaTour.Domain.Entities.Auth.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<long>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<long>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AviaTour.Domain.Entities.Auth.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<long>", b =>
                {
                    b.HasOne("AviaTour.Domain.Entities.Auth.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AviaTour.Domain.Entities.Tour", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}
