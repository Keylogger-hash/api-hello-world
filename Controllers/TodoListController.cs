using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text.Json;
using api_hello_world.Models;
using Microsoft.EntityFrameworkCore;
namespace api_hello_world.Controllers;



[ApiController]
[Route("[controller]")]
public class TodoListController: ControllerBase {


    List<TodoItem> ListTodoItems = new List<TodoItem>{
        new TodoItem("Clean room"),
        new TodoItem("Watch Netflix"),
        new TodoItem("Programming")
    };

    [HttpGet(Name="/todo/list")]
    public async Task<ActionResult> Get(){
            
        var asyncJsonString = string.Empty;
        using (var stream = new MemoryStream())
        {
            await JsonSerializer.SerializeAsync(stream, this.ListTodoItems);
            stream.Position = 0;
            using var reader = new StreamReader(stream);
            asyncJsonString = await reader.ReadToEndAsync();
        }
        return Ok(asyncJsonString);
    }
    
    [HttpPost(Name="/todo/add")]
    public async Task<ActionResult<TodoItem>> PostTodoItem(TodoItem todoItem)        {
        this.ListTodoItems.Append(todoItem);
    
        return Ok("ok");
    }

  




}