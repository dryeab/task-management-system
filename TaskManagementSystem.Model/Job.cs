namespace TaskManagementSystem.Application;

public enum STATUS
{
    DONE, 
    INPROGRESS,
}

public class Job: BaseModel
{
    public string Title { get; set; }
    public string Description { get; set; }
    public STATUS Status { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public List<Checklist> Checklists { get; set; }
}