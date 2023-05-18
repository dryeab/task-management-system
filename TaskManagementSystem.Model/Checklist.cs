namespace TaskManagementSystem.Application;

public class Checklist: BaseModel
{
    public Job Job { get; set; }
    public String Title { get; set; }
    public String Description { get; set; }
    public STATUS Status { get; set; }
}