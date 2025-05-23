using Microsoft.AspNetCore.Mvc;
using System.Runtime;
using System.Text.Json;
using Test_1.Models;

namespace Test_1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController: ControllerBase
    {
        private readonly string _BaseDirectory;
        public UsersController(string baseDirectory)
        {
            _BaseDirectory = baseDirectory;
        }


        [HttpPost]
        public IActionResult SaveUser([FromBody] List<User> users)
        {
            var path = _BaseDirectory;
            var inPath = Path.Combine(path, "IN");

            if (!Directory.Exists(inPath))
                Directory.CreateDirectory(inPath);

            var timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            var fileName = $"users_{timestamp}.json";
            var filePath = Path.Combine(inPath, fileName);

            var json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            System.IO.File.WriteAllText(filePath, json);

            return Ok(new { Message = "Saved" });
        }
    }
}
