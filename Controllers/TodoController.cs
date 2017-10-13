// using System;
// using System.Collections.Generic;
// using System.Diagnostics;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using Todo_Mvc.Models;

// namespace Todo_Mvc.Controllers
// {
//     public class TodoController : Controller
//     {
//         public IActionResult Index()
//         {
//           return View(Todo.GetAll());
//         }

//         public IActionResult Create(string task)
//         {
//             Todo.Create(task);
//             return RedirectToAction("Index");
//         }

//         public IActionResult Delete(int Id){
//           Todo.Delete(Id);
//           return RedirectToAction("Index");
//         }

//         public IActionResult Contact()
//         {
//             ViewData["Message"] = "Your contact page.";

//             return View();
//         }

//         public IActionResult Error()
//         {
//             return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
//         }
//     }
// }


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
        // private static string[] Summaries = new[]
        // {
        //     "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        // };

        // public todos = new Todo[];

        [HttpGet("[action]")]
        public IEnumerable<Todo> Todos()
        {
  
          return Todo.GetAll();
        }

        // public class WeatherForecast
        // {
        //     public string DateFormatted { get; set; }
        //     public int TemperatureC { get; set; }
        //     public string Summary { get; set; }

        //     public int TemperatureF
        //     {
        //         get
        //         {
        //             return 32 + (int)(TemperatureC / 0.5556);
        //         }
        //     }
        // }

        

        }
    }
