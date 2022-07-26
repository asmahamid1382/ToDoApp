
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class MyDayController:ControllerBase
{
    MyDayService _Service;

    public MyDayController(MyDayService service)
    {
        _Service = service;
    }
    [HttpGet]
    public async Task<IEnumerable<MyTask>> GetAll() => await _Service.GetAll();

    [HttpGet("{name}")]
    public async Task<ActionResult<MyTask>> GetbyName(string name)
    {
        var mytask = await _Service.GetTaskbyName(name);
        if (mytask != null)
        return mytask;
        else
        return NotFound();
    }
    [HttpPost]
    public  async Task<IActionResult> Create([FromBody] MyTask newTask)
    {
        var mytask =await _Service.Create(newTask);
        return CreatedAtAction(nameof(GetbyName), new { name = mytask!.Name }, mytask);
    }
    [HttpDelete("{name}")]
    public async Task<IActionResult> Deletebyname(string name)
    {
        var taskToDelete = await _Service.GetTaskbyName(name);
        if (taskToDelete !=  null)
        {
            await _Service.Deletetaskbyname(taskToDelete.Name);
            return Ok();
        }
        else 
        {
            return NotFound();
        }
    }
    [HttpPost("Done")]
    public  async Task<IActionResult> Done(MyTask task )
    {
        var donetask = _Service.GetTaskbyName(task.Name);

        if( donetask != null)
        {
            await _Service.Updatetaskbystatus(task);  
            return Ok() ; 
        }
        else 
            return NotFound() ; 
    }
    [HttpDelete("Deletebystatus")]
    public async Task<IActionResult> Deletebystatus(MyTask task)
    {
        await _Service.DeleteTaskbystatus(task);
        return Ok();
    }
    [HttpPut]
    public async Task<ActionResult> PutTask( string name, [FromBody] MyTask task)
    {
        if (name != task.Name)
        {
            return BadRequest();
        }

        await _Service.Update(task);

        return NoContent();
    }
}