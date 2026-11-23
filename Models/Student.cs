// Name: Suardin Gea
// NIM: 2481006
// Course: Framework .NET Programming

namespace StudentInformationSystem.Models;

public class Student
{
    public int Id { get; set; }
    public string NIM { get; set; } = "";
    public string Name { get; set; } = "";
    public string Major { get; set; } = "";
    public int Semester { get; set; }
    public double GPA { get; set; }
}