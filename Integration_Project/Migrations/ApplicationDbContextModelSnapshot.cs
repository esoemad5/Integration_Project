﻿// <auto-generated />
using System;
using Integration_Project.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Integration_Project.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Integration_Project.Models.ApplicationRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Name");

                    b.Property<string>("NormalizedName");

                    b.HasKey("Id");

                    b.ToTable("ApplicationRole");

                    b.HasData(
                        new { Id = "49573032-75a1-4a20-a956-9bc2b8f95fa6", ConcurrencyStamp = "fab9889c-afd4-40ff-91a5-ad7dbae0aedc", Name = "Standard", NormalizedName = "STANDARD" }
                    );
                });

            modelBuilder.Entity("Integration_Project.Models.Event", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("CanInviteParticipants");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<DateTime>("EndDate");

                    b.Property<byte[]>("EventPicture");

                    b.Property<bool>("IsPrivate");

                    b.Property<bool>("IsWeatherDependent");

                    b.Property<int>("MaxParticipants");

                    b.Property<int>("MinParticipants");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name");

                    b.Property<int>("Premium");

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("VenueId");

                    b.HasKey("Id");

                    b.HasIndex("VenueId");

                    b.ToTable("Events");

                    b.HasData(
                        new { Id = "1", CanInviteParticipants = true, CreatedDate = new DateTime(2018, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), Description = "Doubles or Singles Tennis Match", EndDate = new DateTime(2018, 11, 14, 18, 0, 0, 0, DateTimeKind.Unspecified), IsPrivate = false, IsWeatherDependent = true, MaxParticipants = 4, MinParticipants = 2, ModifiedDate = new DateTime(2018, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), Name = "Doubles or Singles Tennis Match", Premium = 0, StartDate = new DateTime(2018, 11, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), VenueId = "1" },
                        new { Id = "2", CanInviteParticipants = true, CreatedDate = new DateTime(2018, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), Description = "Weekly Meditation Practice", EndDate = new DateTime(2018, 11, 18, 11, 0, 0, 0, DateTimeKind.Unspecified), IsPrivate = false, IsWeatherDependent = false, MaxParticipants = 15, MinParticipants = 2, ModifiedDate = new DateTime(2018, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), Name = "Weekly Meditation Practice", Premium = 1, StartDate = new DateTime(2018, 11, 18, 9, 0, 0, 0, DateTimeKind.Unspecified), VenueId = "2" },
                        new { Id = "3", CanInviteParticipants = false, CreatedDate = new DateTime(2018, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), Description = "Weekly morning meditation sit", EndDate = new DateTime(2018, 11, 12, 7, 0, 0, 0, DateTimeKind.Unspecified), IsPrivate = true, IsWeatherDependent = false, MaxParticipants = 8, MinParticipants = 2, ModifiedDate = new DateTime(2018, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), Name = "Weekly Morning Meditation Sit", Premium = 0, StartDate = new DateTime(2018, 11, 12, 6, 30, 0, 0, DateTimeKind.Unspecified), VenueId = "3" },
                        new { Id = "4", CanInviteParticipants = false, CreatedDate = new DateTime(2018, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), Description = "Friday Night Magic", EndDate = new DateTime(2018, 11, 20, 18, 0, 0, 0, DateTimeKind.Unspecified), IsPrivate = false, IsWeatherDependent = false, MaxParticipants = 36, MinParticipants = 4, ModifiedDate = new DateTime(2018, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), Name = "Friday Night Magic", Premium = 0, StartDate = new DateTime(2018, 11, 20, 15, 30, 0, 0, DateTimeKind.Unspecified), VenueId = "5" },
                        new { Id = "5", CanInviteParticipants = false, CreatedDate = new DateTime(2018, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), Description = "MTG Draft", EndDate = new DateTime(2018, 11, 21, 18, 0, 0, 0, DateTimeKind.Unspecified), IsPrivate = false, IsWeatherDependent = false, MaxParticipants = 8, MinParticipants = 6, ModifiedDate = new DateTime(2018, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), Name = "MTG Draft", Premium = 0, StartDate = new DateTime(2018, 11, 21, 15, 30, 0, 0, DateTimeKind.Unspecified), VenueId = "6" },
                        new { Id = "6", CanInviteParticipants = false, CreatedDate = new DateTime(2018, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), Description = "D&D homebrew group", EndDate = new DateTime(2018, 11, 22, 18, 0, 0, 0, DateTimeKind.Unspecified), IsPrivate = true, IsWeatherDependent = false, MaxParticipants = 6, MinParticipants = 4, ModifiedDate = new DateTime(2018, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), Name = "D&D homebrew group", Premium = 0, StartDate = new DateTime(2018, 11, 22, 15, 30, 0, 0, DateTimeKind.Unspecified), VenueId = "4" },
                        new { Id = "7", CanInviteParticipants = false, CreatedDate = new DateTime(2018, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), Description = "Weekly One-Shot", EndDate = new DateTime(2018, 11, 23, 18, 0, 0, 0, DateTimeKind.Unspecified), IsPrivate = false, IsWeatherDependent = false, MaxParticipants = 6, MinParticipants = 4, ModifiedDate = new DateTime(2018, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), Name = "Weekly One-Shot", Premium = 0, StartDate = new DateTime(2018, 11, 23, 15, 30, 0, 0, DateTimeKind.Unspecified), VenueId = "5" }
                    );
                });

            modelBuilder.Entity("Integration_Project.Models.EventInterest", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EventId");

                    b.Property<string>("InterestId");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("InterestId");

                    b.ToTable("EventInterests");

                    b.HasData(
                        new { Id = "1", EventId = "1", InterestId = "1" },
                        new { Id = "2", EventId = "2", InterestId = "2" },
                        new { Id = "3", EventId = "3", InterestId = "2" },
                        new { Id = "4", EventId = "4", InterestId = "6" },
                        new { Id = "5", EventId = "5", InterestId = "6" },
                        new { Id = "6", EventId = "6", InterestId = "7" },
                        new { Id = "7", EventId = "7", InterestId = "7" },
                        new { Id = "8", EventId = "6", InterestId = "8" },
                        new { Id = "9", EventId = "7", InterestId = "8" }
                    );
                });

            modelBuilder.Entity("Integration_Project.Models.EventOrganizer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EventId");

                    b.Property<bool>("IsCreator");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("UserId");

                    b.ToTable("EventOrganizers");

                    b.HasData(
                        new { Id = 1, EventId = "1", IsCreator = true, UserId = "00df3fb1-fe99-4400-bf75-6d19c31662a6f" },
                        new { Id = 2, EventId = "2", IsCreator = true, UserId = "00df3fb1-fe99-4400-bf75-6d19c31662a6f" },
                        new { Id = 3, EventId = "3", IsCreator = true, UserId = "00df3fb1-fe99-4400-bf75-6d19c31662a6f" },
                        new { Id = 4, EventId = "4", IsCreator = true, UserId = "aaf5b1d2-e64c-4c8e-9a8b-41eaec051fb6" },
                        new { Id = 5, EventId = "5", IsCreator = true, UserId = "aaf5b1d2-e64c-4c8e-9a8b-41eaec051fb6" },
                        new { Id = 6, EventId = "6", IsCreator = true, UserId = "aaf5b1d2-e64c-4c8e-9a8b-41eaec051fb6" },
                        new { Id = 7, EventId = "7", IsCreator = true, UserId = "aaf5b1d2-e64c-4c8e-9a8b-41eaec051fb6" }
                    );
                });

            modelBuilder.Entity("Integration_Project.Models.Interest", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<bool>("Verified");

                    b.HasKey("Id");

                    b.ToTable("Interests");

                    b.HasData(
                        new { Id = "1", CreationDate = new DateTime(2018, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), Description = "Tennis", Name = "Tennis", Verified = false },
                        new { Id = "2", CreationDate = new DateTime(2018, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), Description = "Vipassana Meditation", Name = "Meditation", Verified = false },
                        new { Id = "3", CreationDate = new DateTime(2018, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), Description = "Computer Coding", Name = "Coding", Verified = false },
                        new { Id = "4", CreationDate = new DateTime(2018, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), Description = "American Football", Name = "American Football", Verified = false },
                        new { Id = "5", CreationDate = new DateTime(2018, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), Description = "Kite flying enthusiasts", Name = "Kites", Verified = false },
                        new { Id = "6", CreationDate = new DateTime(2018, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), Description = "Magic: The Gathering Game", Name = "Magic: The Gathering", Verified = false },
                        new { Id = "7", CreationDate = new DateTime(2018, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), Description = "Dungeons & Dragons 5e", Name = "Dungeons & Dragons 5e", Verified = false },
                        new { Id = "8", CreationDate = new DateTime(2018, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), Description = "Pathfinder", Name = "Pathfinder", Verified = false },
                        new { Id = "9", CreationDate = new DateTime(2018, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), Description = "League of Legends", Name = "League of Legends", Verified = false }
                    );
                });

            modelBuilder.Entity("Integration_Project.Models.Participant", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ConfirmedDate");

                    b.Property<string>("EventId");

                    b.Property<string>("InvitedBy");

                    b.Property<DateTime>("InvitedDate");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("InvitedBy");

                    b.HasIndex("UserId");

                    b.ToTable("Participants");

                    b.HasData(
                        new { Id = "2", ConfirmedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), EventId = "1", InvitedBy = "b7813711-0140-4696-b984-8bd4569c7bba", InvitedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), UserId = "51e53b9a-f338-4211-9d7a-8be20bc068a9" },
                        new { Id = "3", ConfirmedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), EventId = "2", InvitedBy = "b7813711-0140-4696-b984-8bd4569c7bba", InvitedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), UserId = "51e53b9a-f338-4211-9d7a-8be20bc068a9" }
                    );
                });

            modelBuilder.Entity("Integration_Project.Models.Rating", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Rank");

                    b.Property<string>("UserId");

                    b.Property<string>("VenueId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("VenueId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("Integration_Project.Models.StandardUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationUserId");

                    b.Property<string>("Bio");

                    b.Property<string>("City");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("State");

                    b.Property<int>("ZipCode");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("StandardUsers");

                    b.HasData(
                        new { Id = "b7813711-0140-4696-b984-8bd4569c7bba", ApplicationUserId = "00df3fb1-fe99-4400-bf75-6d19c31662a6f", Bio = "Tennis. Code. Meditation.", City = "Milwaukee", Email = "c.james.obrien@gmail.com", FirstName = "Casey", LastName = "O'Brien", State = "WI", ZipCode = 53202 },
                        new { Id = "51e53b9a-f338-4211-9d7a-8be20bc068a9", ApplicationUserId = "aaf5b1d2-e64c-4c8e-9a8b-41eaec051fb6", Bio = "Code. Milwaukee. Games.", City = "Shorewood", Email = "esoemad5@gmail.com", FirstName = "Elliot", LastName = "Soemadi", State = "Wisconsin", ZipCode = 53211 },
                        new { Id = "789e4076-5d71-4e12-b146-2c8f38622f13", ApplicationUserId = "b69a12da-22da-41b4-9cda-a58600ae433c", Bio = "Games. Code. Pathfinder.", City = "South Milwaukee", Email = "stoltenberg96@gmail.com", FirstName = "Josh", LastName = "Stoltenberg", State = "WI", ZipCode = 53172 }
                    );
                });

            modelBuilder.Entity("Integration_Project.Models.UserInterest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("InterestId");

                    b.Property<string>("StandardUserId");

                    b.HasKey("Id");

                    b.HasIndex("InterestId");

                    b.HasIndex("StandardUserId");

                    b.ToTable("UserInterests");

                    b.HasData(
                        new { Id = 1, InterestId = "1", StandardUserId = "b7813711-0140-4696-b984-8bd4569c7bba" },
                        new { Id = 2, InterestId = "2", StandardUserId = "b7813711-0140-4696-b984-8bd4569c7bba" },
                        new { Id = 3, InterestId = "3", StandardUserId = "b7813711-0140-4696-b984-8bd4569c7bba" },
                        new { Id = 4, InterestId = "4", StandardUserId = "51e53b9a-f338-4211-9d7a-8be20bc068a9" },
                        new { Id = 5, InterestId = "5", StandardUserId = "51e53b9a-f338-4211-9d7a-8be20bc068a9" },
                        new { Id = 6, InterestId = "6", StandardUserId = "51e53b9a-f338-4211-9d7a-8be20bc068a9" },
                        new { Id = 7, InterestId = "7", StandardUserId = "51e53b9a-f338-4211-9d7a-8be20bc068a9" },
                        new { Id = 8, InterestId = "8", StandardUserId = "51e53b9a-f338-4211-9d7a-8be20bc068a9" },
                        new { Id = 9, InterestId = "9", StandardUserId = "51e53b9a-f338-4211-9d7a-8be20bc068a9" }
                    );
                });

            modelBuilder.Entity("Integration_Project.Models.Venue", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Description");

                    b.Property<bool>("IsPrivate");

                    b.Property<float>("Latitude");

                    b.Property<float>("Longitude");

                    b.Property<string>("Name");

                    b.Property<decimal>("OverallRating");

                    b.Property<byte[]>("ProfilePicture");

                    b.Property<string>("State");

                    b.Property<string>("TwitterHandle");

                    b.Property<string>("WebsiteUrl");

                    b.Property<int>("Zipcode");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.ToTable("Venues");

                    b.HasData(
                        new { Id = "1", Address = "1750 N Lincoln Memorial Dr", City = "Milwaukee", CreatedBy = "00df3fb1-fe99-4400-bf75-6d19c31662a6f", CreationDate = new DateTime(2018, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), Description = "6 public hard court tennis courts", IsPrivate = false, Latitude = 43.05395f, Longitude = -87.88557f, Name = "McKinley Park Tennis Courts", OverallRating = 0m, State = "WI", WebsiteUrl = "https://county.milwaukee.gov/EN/Parks/Explore/Lakefront/McKinley-Marina", Zipcode = 53202 },
                        new { Id = "2", Address = "2344 N Oakland Ave", City = "Milwaukee", CreatedBy = "00df3fb1-fe99-4400-bf75-6d19c31662a6f", CreationDate = new DateTime(2018, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), Description = "Local meditation center in Milwaukee in Shambhala tradition.", IsPrivate = false, Latitude = 43.06116f, Longitude = -87.88788f, Name = "Shambhala Meditation Center of Milwaukee", OverallRating = 0m, State = "WI", WebsiteUrl = "https://milwaukee.shambhala.org", Zipcode = 53211 },
                        new { Id = "3", Address = "1660 N Prospect Ave", City = "Milwaukee", CreatedBy = "00df3fb1-fe99-4400-bf75-6d19c31662a6f", CreationDate = new DateTime(2018, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), Description = "Morning meditation group.Meets on Mondays for 30 minutes.", IsPrivate = true, Latitude = 43.05191f, Longitude = -87.89092f, Name = "Morning Meditation Group", OverallRating = 0m, State = "WI", Zipcode = 53202 },
                        new { Id = "4", Address = "1717 E Kensington Blvd", City = "Shorewood", CreatedBy = "aaf5b1d2-e64c-4c8e-9a8b-41eaec051fb6", CreationDate = new DateTime(2018, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), Description = "Game night!", IsPrivate = true, Latitude = 43.09802f, Longitude = -87.88787f, Name = "My Mom's Basement", OverallRating = 0m, State = "WI", Zipcode = 53211 },
                        new { Id = "5", Address = "1204 Minnesota Ave", City = "South Milwaukee", CreatedBy = "aaf5b1d2-e64c-4c8e-9a8b-41eaec051fb6", CreationDate = new DateTime(2018, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), Description = "Gaming Venue", IsPrivate = false, Latitude = 42.91303f, Longitude = -87.86496f, Name = "Pink Bunny Games", OverallRating = 0m, State = "WI", WebsiteUrl = "pinkbunnygames.com", Zipcode = 53172 },
                        new { Id = "6", Address = "12714 W Hampton Ave", City = "Butler", CreatedBy = "aaf5b1d2-e64c-4c8e-9a8b-41eaec051fb6", CreationDate = new DateTime(2018, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), Description = "Gaming Venue", IsPrivate = false, Latitude = 43.10522f, Longitude = -88.07062f, Name = "Evolution Gaming", OverallRating = 0m, State = "WI", WebsiteUrl = "evo-game.com", Zipcode = 53007 }
                    );
                });

            modelBuilder.Entity("Integration_Project.Models.VenueInterest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("InterestId");

                    b.Property<string>("VenueID");

                    b.HasKey("Id");

                    b.HasIndex("InterestId");

                    b.HasIndex("VenueID");

                    b.ToTable("VenueInterests");

                    b.HasData(
                        new { Id = 1, InterestId = "1", VenueID = "1" },
                        new { Id = 2, InterestId = "2", VenueID = "2" },
                        new { Id = 3, InterestId = "2", VenueID = "3" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUserRole<string>");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Integration_Project.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");


                    b.ToTable("ApplicationUser");

                    b.HasDiscriminator().HasValue("ApplicationUser");

                    b.HasData(
                        new { Id = "00df3fb1-fe99-4400-bf75-6d19c31662a6f", AccessFailedCount = 0, ConcurrencyStamp = "baddab696890", Email = "c.james.obrien@gmail.com", EmailConfirmed = false, LockoutEnabled = false, NormalizedEmail = "C.JAMES.OBRIEN@GMAIL.COM", NormalizedUserName = "C.JAMES.OBRIEN@GMAIL.COM", PasswordHash = "AQAAAAEAACcQAAAAEJG8SzwSAu8tIzIHfAIwjt+5rY6LxLg5k3mXSBRGKxGwIzDWkQT1TpQUozpuBjY1ng==", PhoneNumberConfirmed = false, SecurityStamp = "GSZ7JNO4GZ7JR6W2NU7MQZIZGU5BBEJS", TwoFactorEnabled = false, UserName = "c.james.obrien@gmail.com" },
                        new { Id = "aaf5b1d2-e64c-4c8e-9a8b-41eaec051fb6", AccessFailedCount = 0, ConcurrencyStamp = "009d8a32-2338-41c6-8715-ba819eb861c2", Email = "esoemad5@gmail.com", EmailConfirmed = false, LockoutEnabled = false, NormalizedEmail = "ESOEMAD5@GMAIL.COM", NormalizedUserName = "ESOEMAD5@GMAIL.COM", PasswordHash = "AQAAAAEAACcQAAAAEPDcXogAFBdXHB/ILP//pOgad2XY2YtsOMzQhutbq3vwWLMberWfDDTc5S0bKNtgiw==", PhoneNumberConfirmed = false, SecurityStamp = "BEMZA2GJMIASDNCYCHHKQYFZCLX7TG3L", TwoFactorEnabled = false, UserName = "esoemad5@gmail.com" },
                        new { Id = "b69a12da-22da-41b4-9cda-a58600ae433c", AccessFailedCount = 0, ConcurrencyStamp = "e001d86c-27e1-43ed-9b5f-a4a54e9ea1eb", Email = "stoltenberg96@gmail.com", EmailConfirmed = false, LockoutEnabled = false, NormalizedEmail = "STOLTENBERG96@GMAIL.COM", NormalizedUserName = "STOLTENBERG96@GMAIL.COM", PasswordHash = "AQAAAAEAACcQAAAAELw3XmOscJd2XVFufXA0AEASpKA+PRKGF4dDv7QAwaAgNTPaBe5Sm3nI5LL0BmNV4A==", PhoneNumberConfirmed = false, SecurityStamp = "5D6YY3GMYCV6ZDFWTS4MIAIT6KS2WQUW", TwoFactorEnabled = false, UserName = "stoltenberg96@gmail.com" }
                    );
                });

            modelBuilder.Entity("Integration_Project.Models.ApplicationUserRole", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUserRole<string>");


                    b.ToTable("ApplicationUserRole");

                    b.HasDiscriminator().HasValue("ApplicationUserRole");

                    b.HasData(
                        new { UserId = "00df3fb1-fe99-4400-bf75-6d19c31662a6f", RoleId = "49573032-75a1-4a20-a956-9bc2b8f95fa6" },
                        new { UserId = "aaf5b1d2-e64c-4c8e-9a8b-41eaec051fb6", RoleId = "49573032-75a1-4a20-a956-9bc2b8f95fa6" },
                        new { UserId = "b69a12da-22da-41b4-9cda-a58600ae433c", RoleId = "49573032-75a1-4a20-a956-9bc2b8f95fa6" }
                    );
                });

            modelBuilder.Entity("Integration_Project.Models.Event", b =>
                {
                    b.HasOne("Integration_Project.Models.Venue", "Venues")
                        .WithMany()
                        .HasForeignKey("VenueId");
                });

            modelBuilder.Entity("Integration_Project.Models.EventInterest", b =>
                {
                    b.HasOne("Integration_Project.Models.Event", "Events")
                        .WithMany()
                        .HasForeignKey("EventId");

                    b.HasOne("Integration_Project.Models.Interest", "Interests")
                        .WithMany()
                        .HasForeignKey("InterestId");
                });

            modelBuilder.Entity("Integration_Project.Models.EventOrganizer", b =>
                {
                    b.HasOne("Integration_Project.Models.Event", "Events")
                        .WithMany()
                        .HasForeignKey("EventId");

                    b.HasOne("Integration_Project.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Integration_Project.Models.Participant", b =>
                {
                    b.HasOne("Integration_Project.Models.Event", "Event")
                        .WithMany()
                        .HasForeignKey("EventId");

                    b.HasOne("Integration_Project.Models.StandardUser", "Invite")
                        .WithMany()
                        .HasForeignKey("InvitedBy");

                    b.HasOne("Integration_Project.Models.StandardUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Integration_Project.Models.Rating", b =>
                {
                    b.HasOne("Integration_Project.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.HasOne("Integration_Project.Models.Venue", "Venue")
                        .WithMany()
                        .HasForeignKey("VenueId");
                });

            modelBuilder.Entity("Integration_Project.Models.StandardUser", b =>
                {
                    b.HasOne("Integration_Project.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");
                });

            modelBuilder.Entity("Integration_Project.Models.UserInterest", b =>
                {
                    b.HasOne("Integration_Project.Models.Interest", "Interest")
                        .WithMany()
                        .HasForeignKey("InterestId");

                    b.HasOne("Integration_Project.Models.StandardUser", "StandardUser")
                        .WithMany()
                        .HasForeignKey("StandardUserId");
                });

            modelBuilder.Entity("Integration_Project.Models.Venue", b =>
                {
                    b.HasOne("Integration_Project.Models.ApplicationUser", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatedBy");
                });

            modelBuilder.Entity("Integration_Project.Models.VenueInterest", b =>
                {
                    b.HasOne("Integration_Project.Models.Interest", "Interest")
                        .WithMany()
                        .HasForeignKey("InterestId");

                    b.HasOne("Integration_Project.Models.Venue", "Venue")
                        .WithMany()
                        .HasForeignKey("VenueID");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
