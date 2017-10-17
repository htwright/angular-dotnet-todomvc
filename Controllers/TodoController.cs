
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
        public void Post([FromBody] TodoAddRequest request){
          Todo.Create(request.Input);
        }

        [HttpDelete("{id}")]
        public void Delete(int id){
          Todo.Delete(id);
        }

        [HttpPut("{id}")]

        public void Put(int id, [FromBody] TodoPutRequest request){
          Console.WriteLine(id.ToString());
          if(request == null)Console.WriteLine("request is null");
          Console.WriteLine(request.Done.ToString());
          
          Todo.Toggle(id, request.Done);


        }

        

        }
    }
public class TodoAddRequest
{
    public string Input { get; set; }
}

public class TodoPutRequest
{
  public bool Done { get; set; }
}