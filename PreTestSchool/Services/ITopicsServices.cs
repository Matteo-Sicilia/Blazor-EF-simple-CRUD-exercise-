using PreTestSchool.Models;

namespace PreTestSchool.Services;

public interface ITopicsServices
{
    Task<List<Topics>> GetAllTopics();
}