namespace QuranSchool.Api.Models;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
    public string GuardianPhone { get; set; } = string.Empty;
    public string Level { get; set; } = "مبتدئ";
    public DateTime EnrollmentDate { get; set; } = DateTime.Now;
}
