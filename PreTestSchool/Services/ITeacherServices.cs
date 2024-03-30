using PreTestSchool.Models;

namespace PreTestSchool.Services;

public interface ITeacherServices
{
    Task<List<Teachers>> GetAllTeachers();
}