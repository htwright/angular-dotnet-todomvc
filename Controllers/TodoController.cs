
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using angular_dotnet_todomvc.Models;

namespace angular_dotnet_todomvc.Controllers
{
    [Route("api/[controller]")]
    public class TodoController : Controller
    {

        [HttpGet]
        public IEnumerable<Todo> Get() {
          Console.WriteLine("getting");
          
          return Todo.GetAll();
        }

      

        [HttpPost]
        public void Post([FromBody] StoryAddRequest request){
          Todo.Create(request.Input);
        }

        [HttpDelete("{id}")]
        public void Delete(int id){
          Todo.Delete(id);
        }

        

        }
    }
public class StoryAddRequest
{
    public string Input { get; set; }
}
