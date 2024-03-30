using PreTestSchool.Models;


namespace PreTestSchool.Services;

public interface ILessonServices
{
    Task<List<Lessons>> GetAllLessons();

    Task<Lessons> GetLessonById(int id);

    Task<Lessons> CreateLesson (Lessons lesson);

    Task<Lessons> UpdateLesson (Lessons lesson);

    Task<Lessons> DeleteLesson(int id);

    Task<List<LessonsJoin>> JoinLessons();

}