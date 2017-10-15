
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
  
          return Todo.GetAll();
        }

      

        [HttpPost]
        public IActionResult Post([FromBody]string input){
          Console.WriteLine("creating");
          Todo.Create(input);
          return RedirectToAction("Get");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id){
          Console.WriteLine("Deleteing" + id);
          Todo.Delete(id);

          return RedirectToAction("Get");
        }

        

        }
    }
