namespace service.API.Models;

public class Pool
{
    public int Id { get; set;}
    public string Name { get; set;}
    public Option[] options{ get; set; }

}