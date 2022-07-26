
using Microsoft.EntityFrameworkCore;
public class MyDayService
{
    private readonly MYDayContext _context;

    public MyDayService(MYDayContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<MyTask>> GetAll() => await _context.Tasks.AsNoTracking().ToListAsync();

    public async Task<MyTask> GetTaskbyName(string name) =>
    await _context.Tasks.AsNoTracking().SingleOrDefaultAsync(t => t.Name == name);

    public async Task<MyTask> Create(MyTask newtask)
    {
        _context.Tasks.Add(newtask);
        await _context.SaveChangesAsync();
        return newtask;
    }
    public async Task<MyTask> Updatetaskbystatus(MyTask task)
    {
        var donetask = await GetTaskbyName(task.Name);
        if(donetask!=null)
        {
            task.Name=donetask.Name;
            task.Description=donetask.Description;
            task.Status=true;
            task.DueDate=donetask.DueDate;
            _context.Tasks.Remove(donetask);
            _context.Tasks.Add(task);
            await _context.SaveChangesAsync() ;  
            return donetask; 
        }
        else
        {
            throw new Exception("task was not found ");
        }
    }
    public async Task DeleteTaskbystatus(MyTask task)
    {
        if(task.Status==true)
        {
            _context.Tasks.Remove(task);
            await _context.SaveChangesAsync();
        }
    }
    public async Task Deletetaskbyname(string name )
    {
        var deletedtask = await _context.Tasks.FindAsync(name);
        if(deletedtask is not null)
        {
            _context.Tasks.Remove(deletedtask);
            await _context.SaveChangesAsync();
        }
    }
     public async Task Update(MyTask task)
    {
         _context.Entry(task).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

}