namespace TaskManagementSystem.Application;

public class User: BaseModel
{
    public string fullname { get; set; }
    public string password { get; set; }
    public string email { get; set; }
    public List<Task> Tasks { get; set; }
}