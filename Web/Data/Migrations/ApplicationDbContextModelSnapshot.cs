﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Web.Data;

namespace Web.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("ASPectLibrary.ApplicationRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "2d33cc5d-5ef4-41b9-a5ea-0dd205ddc69f",
                            ConcurrencyStamp = "2d33cc5d-5ef4-41b9-a5ea-0dd205ddc69f",
                            CreatedDate = new DateTime(2021, 4, 11, 12, 22, 23, 792, DateTimeKind.Local).AddTicks(8550),
                            Description = "This is the administrator role.",
                            Name = "Administrator",
                            NormalizedName = "Administrator"
                        },
                        new
                        {
                            Id = "a4d11734-85c1-42bf-9b5d-eb17aaa534b6",
                            ConcurrencyStamp = "a4d11734-85c1-42bf-9b5d-eb17aaa534b6",
                            CreatedDate = new DateTime(2021, 4, 11, 12, 22, 23, 797, DateTimeKind.Local).AddTicks(9280),
                            Description = "This is the instructor role.",
                            Name = "Instructor",
                            NormalizedName = "Instructor"
                        },
                        new
                        {
                            Id = "e9485476-5548-4c6a-9f88-74cad46d5dd0",
                            ConcurrencyStamp = "e9485476-5548-4c6a-9f88-74cad46d5dd0",
                            CreatedDate = new DateTime(2021, 4, 11, 12, 22, 23, 797, DateTimeKind.Local).AddTicks(9310),
                            Description = "This is the student role.",
                            Name = "Student",
                            NormalizedName = "Student"
                        });
                });

            modelBuilder.Entity("ASPectLibrary.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "5bb3f1ca-d27c-4655-b8d6-6c2b3016f2d3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "211598e8-8944-4daa-9542-e4e929f9537b",
                            Email = "admin@aspect.com",
                            EmailConfirmed = true,
                            FirstName = "Adam",
                            LastName = "Aldridge",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@ASPECT.COM",
                            NormalizedUserName = "ADMIN@ASPECT.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEGPq1iZ+f7K7qa+kTswt2+/wgd5K2nLy9QZSkO7yE7kNyDET3k9TlxEKNbuqk7PV+A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2bdc69d1-c1dd-4326-bc46-5eb5f35b5d09",
                            TwoFactorEnabled = false,
                            UserName = "admin@aspect.com"
                        },
                        new
                        {
                            Id = "9216a976-f1ba-4d73-aff6-f818b4b5c6a7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a2ef17a4-48cd-43f4-a0c2-fa34d244b9b7",
                            Email = "instructor@aspect.com",
                            EmailConfirmed = true,
                            FirstName = "Ted",
                            LastName = "Smith",
                            LockoutEnabled = false,
                            NormalizedEmail = "INSTRUCTOR@ASPECT.COM",
                            NormalizedUserName = "INSTRUCTOR@ASPECT.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAECWg3JH0S7Kp5ngeltUI5zZFxgAQOjRFQytdz2XRRiKhrA2sOnRNoCB97ganHRMwhQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f69dc59b-905f-4d26-94e8-5ec58b624dba",
                            TwoFactorEnabled = false,
                            UserName = "instructor@aspect.com"
                        },
                        new
                        {
                            Id = "363624a6-0978-4866-b5ee-b135a6fc3870",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "56a111f0-1e5f-4367-9a47-a5b71c8d2e6a",
                            Email = "student@aspect.com",
                            EmailConfirmed = true,
                            FirstName = "Mike",
                            LastName = "Myers",
                            LockoutEnabled = false,
                            NormalizedEmail = "STUDENT@ASPECT.COM",
                            NormalizedUserName = "STUDENT@ASPECT.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEK4SaokSgS5bwaBtj+zOLGoENmE0BL+FyqnJscJShSO3aR5np2UV+u47viaqOq1B1Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1e47e80e-7539-4ed2-8237-e795b5926f65",
                            TwoFactorEnabled = false,
                            UserName = "student@aspect.com"
                        },
                        new
                        {
                            Id = "363624a6-1111-4866-b5ee-b135a6fc3870",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c8d58bbb-6bbf-49b2-a6e4-39bb5a7229ff",
                            Email = "student2@aspect.com",
                            EmailConfirmed = true,
                            FirstName = "Mike2",
                            LastName = "Myers2",
                            LockoutEnabled = false,
                            NormalizedEmail = "STUDENT2@ASPECT.COM",
                            NormalizedUserName = "STUDENT2@ASPECT.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEC63sN96h+H1PcrZwkVyDqzPZDPf1sB8XNYdfky8orl79Ze1LWEA1cE3KRvoKuoB/A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "54fa7c4a-c4e6-4612-899d-98fc14c19a2a",
                            TwoFactorEnabled = false,
                            UserName = "student2@aspect.com"
                        });
                });

            modelBuilder.Entity("ASPectLibrary.Assignment", b =>
                {
                    b.Property<int>("AssignmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("courseId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("description")
                        .HasColumnType("TEXT");

                    b.HasKey("AssignmentId");

                    b.HasIndex("courseId");

                    b.ToTable("Assignments");
                });

            modelBuilder.Entity("ASPectLibrary.Course", b =>
                {
                    b.Property<int>("CourseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CourseTitle")
                        .HasColumnType("TEXT");

                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("InstructorID")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProjectOutline")
                        .HasColumnType("TEXT");

                    b.Property<string>("Term")
                        .HasColumnType("TEXT");

                    b.HasKey("CourseID");

                    b.HasIndex("Id");

                    b.ToTable("Course");

                    b.HasData(
                        new
                        {
                            CourseID = 1,
                            CourseTitle = "COMP3800 - Practicum",
                            InstructorID = "9216a976-f1ba-4d73-aff6-f818b4b5c6a7",
                            ProjectOutline = "https://www.bcit.ca/outlines/20211088135/",
                            Term = "4"
                        },
                        new
                        {
                            CourseID = 2,
                            CourseTitle = "COMP4870 - Intranet Planning & Development",
                            InstructorID = "9216a976-f1ba-4d73-aff6-f818b4b5c6a7",
                            ProjectOutline = "https://www.bcit.ca/outlines/20211049852/",
                            Term = "4"
                        });
                });

            modelBuilder.Entity("ASPectLibrary.Enrollment", b =>
                {
                    b.Property<int>("EnrollmentId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CourseID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Semester")
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("EnrollmentId", "CourseID", "Id");

                    b.HasIndex("CourseID");

                    b.HasIndex("Id");

                    b.ToTable("Enrollments");

                    b.HasData(
                        new
                        {
                            EnrollmentId = 1,
                            CourseID = 1,
                            Id = "363624a6-0978-4866-b5ee-b135a6fc3870",
                            Semester = "Fall",
                            Year = 2020
                        },
                        new
                        {
                            EnrollmentId = 2,
                            CourseID = 2,
                            Id = "363624a6-0978-4866-b5ee-b135a6fc3870",
                            Semester = "Winter",
                            Year = 2021
                        });
                });

            modelBuilder.Entity("ASPectLibrary.Membership", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProjectId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CourseID")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id", "ProjectId");

                    b.HasIndex("CourseID");

                    b.HasIndex("ProjectId");

                    b.ToTable("Memberships");

                    b.HasData(
                        new
                        {
                            Id = "363624a6-0978-4866-b5ee-b135a6fc3870",
                            ProjectId = 1
                        },
                        new
                        {
                            Id = "363624a6-1111-4866-b5ee-b135a6fc3870",
                            ProjectId = 1
                        },
                        new
                        {
                            Id = "363624a6-0978-4866-b5ee-b135a6fc3870",
                            ProjectId = 2
                        });
                });

            modelBuilder.Entity("ASPectLibrary.PeerEvaluation", b =>
                {
                    b.Property<int>("PeerEvaluationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Comments")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProjectId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Rating")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserBeingEvaluatedId")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserEvaluatingId")
                        .HasColumnType("TEXT");

                    b.HasKey("PeerEvaluationId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("UserBeingEvaluatedId");

                    b.HasIndex("UserEvaluatingId");

                    b.ToTable("PeerEvaluations");
                });

            modelBuilder.Entity("ASPectLibrary.ProgressUpdate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Issues")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastWeekActivity")
                        .HasColumnType("TEXT");

                    b.Property<string>("NextWeekActivity")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProjectId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("ProgressUpdates");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2021, 4, 11, 12, 22, 23, 843, DateTimeKind.Local).AddTicks(4450),
                            Issues = "Schema may need to be reworked",
                            LastWeekActivity = "Finished DB Design",
                            NextWeekActivity = "Going to work on the API",
                            ProjectId = 1
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2021, 4, 11, 12, 22, 23, 843, DateTimeKind.Local).AddTicks(6310),
                            Issues = "Need to find solution for deployment",
                            LastWeekActivity = "Finished API Design",
                            NextWeekActivity = "Going to implement the API",
                            ProjectId = 1
                        });
                });

            modelBuilder.Entity("ASPectLibrary.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AppName")
                        .HasColumnType("TEXT");

                    b.Property<string>("AspNetUserId")
                        .HasColumnType("TEXT");

                    b.Property<int>("CourseId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProjectCategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TeamName")
                        .HasColumnType("TEXT");

                    b.HasKey("ProjectId");

                    b.HasIndex("CourseId");

                    b.HasIndex("ProjectCategoryId");

                    b.ToTable("Project");

                    b.HasData(
                        new
                        {
                            ProjectId = 1,
                            AppName = "Twitter",
                            AspNetUserId = "363624a6-0978-4866-b5ee-b135a6fc3870",
                            CourseId = 1,
                            Description = "An app for tweeting",
                            ProjectCategoryId = 1,
                            TeamName = "RA"
                        },
                        new
                        {
                            ProjectId = 2,
                            AppName = "PlaneGo",
                            AspNetUserId = "363624a6-0978-4866-b5ee-b135a6fc3870",
                            CourseId = 1,
                            Description = "It's like uber but for planes",
                            ProjectCategoryId = 2,
                            TeamName = "Team Fly"
                        });
                });

            modelBuilder.Entity("ASPectLibrary.ProjectCategory", b =>
                {
                    b.Property<int>("ProjectCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProjectCategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("ProjectCategoryId");

                    b.ToTable("ProjectCategory");

                    b.HasData(
                        new
                        {
                            ProjectCategoryId = 1,
                            ProjectCategoryName = "Blockchain"
                        },
                        new
                        {
                            ProjectCategoryId = 2,
                            ProjectCategoryName = "React"
                        });
                });

            modelBuilder.Entity("ASPectLibrary.ProjectRequirement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AssignmentId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Requirement")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AssignmentId");

                    b.ToTable("ProjectRequirements");
                });

            modelBuilder.Entity("ASPectLibrary.ProjectRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ProjectRoles");

                    b.HasData(
                        new
                        {
                            Id = "Arch",
                            RoleName = "Software Architect"
                        },
                        new
                        {
                            Id = "DBA",
                            RoleName = "Database Administrator"
                        },
                        new
                        {
                            Id = "UIUIX",
                            RoleName = "UI/UX Designer"
                        },
                        new
                        {
                            Id = "SD",
                            RoleName = "Software Developer"
                        },
                        new
                        {
                            Id = "PM",
                            RoleName = "Project Manager"
                        },
                        new
                        {
                            Id = "SA",
                            RoleName = "System Administrator"
                        },
                        new
                        {
                            Id = "FE",
                            RoleName = "Front End Developer"
                        },
                        new
                        {
                            Id = "BE",
                            RoleName = "Back End Developer"
                        },
                        new
                        {
                            Id = "QA",
                            RoleName = "Quality Assurance"
                        },
                        new
                        {
                            Id = "TE",
                            RoleName = "Software Tester"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "5bb3f1ca-d27c-4655-b8d6-6c2b3016f2d3",
                            RoleId = "2d33cc5d-5ef4-41b9-a5ea-0dd205ddc69f"
                        },
                        new
                        {
                            UserId = "9216a976-f1ba-4d73-aff6-f818b4b5c6a7",
                            RoleId = "a4d11734-85c1-42bf-9b5d-eb17aaa534b6"
                        },
                        new
                        {
                            UserId = "363624a6-0978-4866-b5ee-b135a6fc3870",
                            RoleId = "e9485476-5548-4c6a-9f88-74cad46d5dd0"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ASPectLibrary.Assignment", b =>
                {
                    b.HasOne("ASPectLibrary.Course", "Course")
                        .WithMany("Assignments")
                        .HasForeignKey("courseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("ASPectLibrary.Course", b =>
                {
                    b.HasOne("ASPectLibrary.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("Id");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ASPectLibrary.Enrollment", b =>
                {
                    b.HasOne("ASPectLibrary.Course", "Course")
                        .WithMany("Enrollments")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASPectLibrary.ApplicationUser", "User")
                        .WithMany("Enrollments")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ASPectLibrary.Membership", b =>
                {
                    b.HasOne("ASPectLibrary.Course", null)
                        .WithMany("Memberships")
                        .HasForeignKey("CourseID");

                    b.HasOne("ASPectLibrary.ApplicationUser", "Student")
                        .WithMany("Memberships")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASPectLibrary.Project", "Project")
                        .WithMany("Memberships")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("ASPectLibrary.PeerEvaluation", b =>
                {
                    b.HasOne("ASPectLibrary.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASPectLibrary.ApplicationUser", "UserBeingEvaluated")
                        .WithMany()
                        .HasForeignKey("UserBeingEvaluatedId");

                    b.HasOne("ASPectLibrary.ApplicationUser", "UserEvaluating")
                        .WithMany()
                        .HasForeignKey("UserEvaluatingId");

                    b.Navigation("Project");

                    b.Navigation("UserBeingEvaluated");

                    b.Navigation("UserEvaluating");
                });

            modelBuilder.Entity("ASPectLibrary.ProgressUpdate", b =>
                {
                    b.HasOne("ASPectLibrary.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
                });

            modelBuilder.Entity("ASPectLibrary.Project", b =>
                {
                    b.HasOne("ASPectLibrary.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASPectLibrary.ProjectCategory", "ProjectCategory")
                        .WithMany()
                        .HasForeignKey("ProjectCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("ProjectCategory");
                });

            modelBuilder.Entity("ASPectLibrary.ProjectRequirement", b =>
                {
                    b.HasOne("ASPectLibrary.Assignment", "Assignment")
                        .WithMany()
                        .HasForeignKey("AssignmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Assignment");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("ASPectLibrary.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ASPectLibrary.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ASPectLibrary.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("ASPectLibrary.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASPectLibrary.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ASPectLibrary.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ASPectLibrary.ApplicationUser", b =>
                {
                    b.Navigation("Enrollments");

                    b.Navigation("Memberships");
                });

            modelBuilder.Entity("ASPectLibrary.Course", b =>
                {
                    b.Navigation("Assignments");

                    b.Navigation("Enrollments");

                    b.Navigation("Memberships");
                });

            modelBuilder.Entity("ASPectLibrary.Project", b =>
                {
                    b.Navigation("Memberships");
                });
#pragma warning restore 612, 618
        }
    }
}
