
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using registrar_hima0013.Data;

#nullable disable

namespace Registrar.Migrations
{
    [DbContext(typeof(RegistrarContext))]
    partial class RegistrarContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.4");

            modelBuilder.Entity("registrar_hima0013.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("StudentId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("WeeklyHours")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("registrar_hima0013.Models.Registration", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CourseId")
                        .HasColumnType("INTEGER");

                    b.HasKey("StudentId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("Registrations");
                });

            modelBuilder.Entity("registrar_hima0013.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("registrar_hima0013.Models.Course", b =>
                {
                    b.HasOne("registrar_hima0013.Models.Student", null)
                        .WithMany("Courses")
                        .HasForeignKey("StudentId");
                });

            modelBuilder.Entity("registrar_hima0013.Models.Registration", b =>
                {
                    b.HasOne("registrar_hima0013.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("registrar_hima0013.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("registrar_hima0013.Models.Student", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
