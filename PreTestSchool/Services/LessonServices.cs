using Microsoft.EntityFrameworkCore;
using PreTestSchool.Data;
using PreTestSchool.Models;

namespace PreTestSchool.Services;

public class LessonServices : ILessonServices
{
    private readonly DataContext _context;

    public LessonServices (DataContext context)
    {
        _context = context;
    }

    public async Task<List<Lessons>> GetAllLessons()
    {
        var lessons = await _context.Lessons.ToListAsync();

        return lessons;
    }

    public async Task<Lessons> GetLessonById(int id)
    {
        var lesson = await _context.Lessons.FindAsync(id);

        if (lesson == null)
        {
            throw new Exception("Lesson Not Found");
        }

        return lesson;
    }

    public async Task<Lessons> CreateLesson(Lessons lesson)
    {
        _context.Lessons.Add(lesson);
        await _context.SaveChangesAsync();

        return lesson;

    }

    public async Task<Lessons> UpdateLesson(Lessons updatedLesson)
    {
        var dBLesson = await _context.Lessons.FindAsync(updatedLesson.LessonId);

        if (dBLesson == null)
        {
            throw new Exception("Lesson Not Found");
        }
        else
        {
            dBLesson.TeacherId = updatedLesson.TeacherId;
            dBLesson.TopicId = updatedLesson.TopicId;
            dBLesson.Notes = updatedLesson.Notes;
            dBLesson.CreationDate = updatedLesson.CreationDate;
            dBLesson.StartDate = updatedLesson.StartDate;
            dBLesson.EndDate = updatedLesson.EndDate;
        }

        await _context.SaveChangesAsync();

        return dBLesson;

    }

    public async Task<Lessons> DeleteLesson(int id)
    {
        var lesson = await _context.Lessons.FindAsync(id);

        if (lesson == null)
        {
            throw new Exception("Lesson Not Found");
        }
        else
        {
            _context.Lessons.Remove(lesson);
        }

        await _context.SaveChangesAsync();

        return lesson;

    }

    public async Task<List<LessonsJoin>> JoinLessons()
    {
        //var lessons = await _context.Lessons.ToListAsync();

        var query = from lesson in _context.Lessons
            join teacher in _context.Teachers on lesson.TeacherId equals teacher.TeacherId
            join topic in _context.Topics on lesson.TopicId equals topic.TopicId
            select new LessonsJoin()
            {
                LessonId = lesson.LessonId,
                TeacherName = teacher.TeacherName,
                TopicName = topic.TopicName,
                Notes = lesson.Notes,
                CreationDate = lesson.CreationDate,
                StartDate = lesson.StartDate,
                EndDate = lesson.EndDate

            };

        var results = await query.ToListAsync();

        return results;
    }

}
