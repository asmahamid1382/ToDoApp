using System.ComponentModel.DataAnnotations;

public class MyTask
{
    public MyTask()
    {
    }

    public MyTask(string name, string description, DateTime dueDate)
    {
        Name = name;
        Description = description;
        DueDate = dueDate;
    }
    [Key]
    public string Name { get; set; }
    public string Description { get; set; }
    public bool Status { get; set; }=false;
    public DateTime DueDate{get;set;}
}
