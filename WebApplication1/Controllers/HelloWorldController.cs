
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Dto;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetHelloWorld()
        {
            return Ok("Hello, World~!");
        }
        
        [HttpPost]
        public IActionResult PostMessage([FromBody] MessageDto message)
        {
            Console.Out.Write("message: "+ message);
            
            return Ok($"You sent: {message.Message}");
        }
        
    }
}