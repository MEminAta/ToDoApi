using Microsoft.AspNetCore.Mvc;

namespace ToDoApi.Controller;

[ApiController]
[Route("[controller]")]
public class ToDoController : ControllerBase
{
    [HttpGet]
    public ActionResult<string> Test()
    {
        return "Selam";
    } 
}