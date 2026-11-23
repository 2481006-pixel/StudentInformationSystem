// Name: Suardin Gea
// NIM: 2481006
// Course: Framework .NET Programming

using StudentInformationSystem.Models;

namespace StudentInformationSystem.Data
{
    public static class StudentData
    {
        public static readonly List<Student> Students = new()
        {
            new Student
            {
                NIM = "2481006",
                Name = "Suardin Gea",
                Major = "Teknik Informatika",
                Semester = 3,
                GPA = 3.75
            },
            // TODO: ganti dengan nama & NIM asli teman Anda (dengan izin mereka).
            // GPA di bawah ini adalah NILAI CONTOH, bukan IPK asli.
            new Student
            {
                NIM = "2481011",
                Name = "Thomas",
                Major = "Teknik Informatika",
                Semester = 3,
                GPA = 3.00 // sample value
            },
            new Student
            {
                NIM = "2643007",
                Name = "Adit Saputra",
                Major = "Farmasi",
                Semester = 3,
                GPA = 3.50 // sample value
            }
        };

        public static Student? GetByNim(string nim) =>
            Students.FirstOrDefault(s => s.NIM == nim);
    }
}