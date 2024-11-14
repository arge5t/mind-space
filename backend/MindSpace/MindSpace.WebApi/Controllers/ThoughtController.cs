using Microsoft.AspNetCore.Mvc;

namespace MindSpace.WebApi.Controllers;

public class ThoughtController: BaseController
{
    [HttpPost]
    public IActionResult CreateThought()
    {
        return Ok();
    }
    
    [HttpGet]
    public IActionResult GetThoughts()
    {
        return Ok();
    }

    [HttpGet("{id}")]
    public IActionResult GetThought(Guid id)
    {
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteThought(Guid id)
    {
        return Ok();
    }

    [HttpPut("{id}")]
    public IActionResult UpdateThought(Guid id)
    {
        return Ok();
    }
}