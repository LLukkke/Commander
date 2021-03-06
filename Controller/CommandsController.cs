using System.Collections.Generic;
using Commander.Data;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controller
{
  [Route("api/commands")]
  [ApiController]
  public class CommandController : ControllerBase
  {
    private readonly MockCommonerRepo _repository = new MockCommonerRepo();
    // GET api/commons
    [HttpGet]
    public ActionResult<IEnumerable<Command>> GetAllCommands()
    {
      var commandItems = _repository.GetAppCommands();
      return Ok(commandItems);
    }

    
    // GET api/commons/{id}
    [HttpGet("{id}")]
    public ActionResult<Command> GetCommandById(int id)
    {
      var commandItem = _repository.GetCommandById(id);
      return Ok(commandItem);
    }
  }

}