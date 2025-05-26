
namespace UniversityCRUD.Models;

public class Student
{
    public int ID { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public DateTime EnrollementDate { get; set; }

    public ICollection<Enrollment> Enrollments { get; set; }
}