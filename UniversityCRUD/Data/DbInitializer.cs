using UniversityCRUD.Models;
using System;
using System.Linq;
namespace UniversityCRUD.Data;

public class DbInitializer
{
    public static void Initialize(SchoolContext context)
    {
        context.Database.EnsureCreated();
        if (context.Courses.Any()) return;

        var students = new Student[]
        {
            new Student { FirstName = "Elisia", LastName = "Parmisano", EnrollementDate = DateTime.Now },
            new Student { FirstName = "Chaewon", LastName = "Kim", EnrollementDate = DateTime.Now },
            new Student { FirstName = "Daisy", LastName = "Yu", EnrollementDate = DateTime.Now },
            new Student { FirstName = "Chaeyoung", LastName = "Son", EnrollementDate = DateTime.Now },
            new Student { FirstName = "Yoona", LastName = "Oh", EnrollementDate = DateTime.Now},
            new Student { FirstName = "Seowon", LastName = "Lim", EnrollementDate = DateTime.Now},
            new Student { FirstName = "Yujin", LastName = "An", EnrollementDate = DateTime.Now},
            new Student { FirstName = "Kazuha", LastName = "Nakamura", EnrollementDate = DateTime.Now}
        };

        foreach (var student in students)
        {
            context.Students.Add(student);
        }
        context.SaveChanges();

        var courses = new Course[]
        {
            new Course { CourseID = 1050, Title = "Chemistry", Credits = 3 },
            new Course { CourseID = 4022, Title = "Computer Programming 1", Credits = 3 },
            new Course { CourseID = 4041, Title = "Economics", Credits = 3 },
            new Course { CourseID = 1045, Title = "Calculus", Credits = 4 },
            new Course { CourseID = 3141, Title = "Trigonometry", Credits = 4 },
            new Course { CourseID = 2021, Title = "Database Systems", Credits = 3 },
            new Course { CourseID = 2042, Title = "Literature", Credits = 4 }
        };
        foreach (var course in courses)
        {
            context.Courses.Add(course);
        }
        context.SaveChanges();

        var enrollments = new Enrollment[]
        {
            new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
            new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
            new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
            new Enrollment{StudentID=3,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
            new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
            new Enrollment{StudentID=6,CourseID=1045},
            new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
        };
        foreach (Enrollment e in enrollments)
        {
            context.Enrollments.Add(e);
        }
        context.SaveChanges();
    }
}