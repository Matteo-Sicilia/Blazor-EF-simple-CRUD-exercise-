using Microsoft.AspNetCore.Mvc;
using PreTestSchool.Services;
using PreTestSchool.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PreTestSchool.Data;
using Teachers = PreTestSchool.Components.Pages.Teachers;
using PreTestSchool.Data;

namespace PreTestSchool.Controller;


[Route("api/[controller]")]
[ApiController]
public class LessonsController : ControllerBase
{
    private readonly ILessonServices _lessonServices;

    public LessonsController(ILessonServices lessonServices)
    {
        _lessonServices = lessonServices;
    }

    [HttpGet]
    public async Task<ActionResult<List<Lessons>>> GetAllLessonsAsyc()
    {
        var lessons = await _lessonServices.GetAllLessons();

        return Ok(lessons);
    }

    [HttpGet]
    [Route("{id}")]
    public async Task<ActionResult<Lessons>> GetLessonByIdAsync(int id)
    {
        try
        {
            var lesson = await _lessonServices.GetLessonById(id);
            return Ok(lesson);
        }
        catch (Exception)
        {
            return NotFound("Lesson Not Found");
        }
    }

    [HttpPost]
    public async Task<ActionResult<Lessons>> CreateLessonsAsync(Lessons lessons)
    {
        var newLesson = await _lessonServices.CreateLesson(lessons);

        return Ok("Lesson Added Correctly");
    }

    [HttpPut]
    public async Task<ActionResult<Lessons>> UpdateLessonsAsync(Lessons updatedLessons)
    {
        try
        {
            var dBLesson = await _lessonServices.UpdateLesson(updatedLessons);
            return Ok("Lesson Updated Correctly");
        }
        catch (Exception)
        {
            return NotFound("Lesson Not Found");
        }
    }

    [HttpDelete]
    public async Task<ActionResult<Lessons>> DeleteLessonAsync(int id)
    {
        try
        {
            var lesson = await _lessonServices.DeleteLesson(id);
            return Ok("Lesson Deleted Successfully");
        }
        catch (Exception)
        {
            return NotFound("Lesson Not Found");
        }
    }

    [HttpGet]
    [Route("join")]
    public async Task<ActionResult<Lessons>> JoinLessonsAsync()
    {
        var joinLesson = await _lessonServices.JoinLessons();

        return Ok(joinLesson);
    }


}