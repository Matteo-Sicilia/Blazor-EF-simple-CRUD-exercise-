using Microsoft.AspNetCore.Mvc;
using PreTestSchool.Services;
using PreTestSchool.Models;

namespace PreTestSchool.Controller;


[Route("api/[controller]")]
[ApiController]
public class TeacherController : ControllerBase
{
    private readonly ITeacherServices _teacherServices;

    public TeacherController(ITeacherServices teacherServices)
    {
        _teacherServices = teacherServices;
    }

    [HttpGet]
    public async Task<ActionResult<List<Teachers>>> GetAllTeachersAsyc()
    {
        var teachers = await _teacherServices.GetAllTeachers();

        return Ok(teachers);
    }
}
