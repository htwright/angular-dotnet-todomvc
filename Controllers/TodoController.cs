
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

        [HttpGet("[action]")]
        public IEnumerable<Todo> Todos() {
  
          return Todo.GetAll();
        }

      

        [HttpPost("[action]")]
        public IActionResult Create(string input){
          Todo.Create(input);
          return RedirectToAction("Todos");
        }

        public IActionResult Delete(int id){
          Todo.Delete(id);
          return RedirectToAction("Todos");
        }

        

        }
    }
