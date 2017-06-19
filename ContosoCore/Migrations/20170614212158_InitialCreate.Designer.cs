using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ContosoCore.Data;

namespace ContosoCore.Migrations
{
    [DbContext(typeof(SchoolContext))]
    [Migration("20170614212158_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ContosoCore.Models.Course", b =>
                {
                    b.Property<int>("CourseID");

                    b.Property<int>("Credits");

                    b.Property<string>("Title");

                    b.HasKey("CourseID");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("ContosoCore.Models.Enrollment", b =>
                {
                    b.Property<int>("EnrollmentID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CourseID");

                    b.Property<int?>("Grade");

                    b.Property<int>("StudentID");

                    b.HasKey("EnrollmentID");

                    b.HasIndex("CourseID");

                    b.HasIndex("StudentID");

                    b.ToTable("Enrollment");
                });

            modelBuilder.Entity("ContosoCore.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EnrollmentDate");

                    b.Property<string>("FirstMidName");

                    b.Property<string>("LastName");

                    b.HasKey("ID");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("ContosoCore.Models.Enrollment", b =>
                {
                    b.HasOne("ContosoCore.Models.Course", "Course")
                        .WithMany("Enrollments")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ContosoCore.Models.Student", "Student")
                        .WithMany("Enrollments")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
