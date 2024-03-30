using Microsoft.EntityFrameworkCore;
using PreTestSchool.Data;
using PreTestSchool.Models;

namespace PreTestSchool.Services;

public class TeacherServices : ITeacherServices
{
    private readonly DataContext _context;

    public TeacherServices (DataContext context)
    {
        _context = context;
    }

    public async Task<List<Teachers>> GetAllTeachers()
    {
        var teachers = await _context.Teachers.ToListAsync();

        return teachers;
    }
}