// Name: Suardin Gea
// NIM: 2481006
// Course: Framework .NET Programming

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentInformationSystem.Data;
using StudentInformationSystem.Models;

namespace StudentInformationSystem.Controllers;

[ApiController]
[Route("api/students")]
public class StudentsApiController : ControllerBase
{
    private readonly ApplicationDbContext _db;
    public StudentsApiController(ApplicationDbContext db) => _db = db;

    [HttpGet]
    public async Task<ActionResult<List<Student>>> GetAllStudents()
    {
        var students = await _db.Students.AsNoTracking()
            .OrderBy(s => s.NIM).ToListAsync();
        return Ok(students);
    }

    [HttpGet("{nim}")]
    public async Task<ActionResult<Student>> GetStudentByNIM(string nim)
    {
        var student = await _db.Students.AsNoTracking()
            .FirstOrDefaultAsync(s => s.NIM == nim);
        return student is null
            ? NotFound(new { message = "Student not found." })
            : Ok(student);
    }
}