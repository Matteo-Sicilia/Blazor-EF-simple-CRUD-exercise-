using Microsoft.AspNetCore.Mvc;
using PreTestSchool.Services;
using PreTestSchool.Models;

namespace PreTestSchool.Controller;


[Route("api/[controller]")]
[ApiController]
public class TopicController : ControllerBase
{
    private readonly ITopicsServices _topicServices;

    public TopicController(ITopicsServices topicsServices)
    {
        _topicServices = topicsServices;
    }

    [HttpGet]
    public async Task<ActionResult<List<Topics>>> GetAllTopicsAsync()
    {
        var topics = await _topicServices.GetAllTopics();

        return Ok(topics);
    }
}