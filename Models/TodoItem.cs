namespace api_hello_world.Models;


public class TodoItem{
    public string Title {get; set;}
    public TodoItem(string Title){
        this.Title = Title;
    }
}