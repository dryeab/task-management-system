namespace TaskManagementSystem.Application;

public enum STATUS
{
    DONE, 
    INPROGRESS,
}

public class Task: BaseModel
{
    public User Owner { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public STATUS Status { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public List<Checklist> Checklists { get; set; }
}