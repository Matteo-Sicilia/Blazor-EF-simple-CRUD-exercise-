using Microsoft.EntityFrameworkCore;
using PreTestSchool.Data;
using PreTestSchool.Models;

namespace PreTestSchool.Services;

public class TopicServices : ITopicsServices
{
    private readonly DataContext _context;

    public TopicServices (DataContext context)
    {
        _context = context;
    }

    public async Task<List<Topics>> GetAllTopics()
    {
        var topics = await _context.Topics.ToListAsync();

        return topics;
    }
}