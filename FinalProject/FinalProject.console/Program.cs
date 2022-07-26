using FinalProjectApiCli.Model;
using FinalProjectApiCli.Api;
using FinalProjectApiCli.Client;

Configuration config = new Configuration() {BasePath = "http://localhost:5176"};
var apiInstance = new MyDayApi(config);
System.Console.WriteLine("Add - Show - Delete");
string s = Console.ReadLine();
if(s=="Show")
{
    System.Console.WriteLine("Name      Description     DueDate               Status");
    foreach (var item in apiInstance.MyDayGet())
    {
        Console.Write($"{item.Name}     {item.Description}      {item.DueDate}      {item.Status} \n");
    }
}
if(s=="Add")
{

        System.Console.WriteLine("enter name");
        string name = Console.ReadLine();
        System.Console.WriteLine("enter Description");
        string description=Console.ReadLine();
        System.Console.WriteLine("enter DueDate");
        string Duedate = Console.ReadLine();
        apiInstance.MyDayPost(new MyTask(name,description,false,DateTime.Parse(Duedate)));
    
}
if(s=="Delete")
{
    System.Console.WriteLine("enter name");
    string name = Console.ReadLine();
    try{
        apiInstance.MyDayNameDelete(name);
    }
    catch
    {
        System.Console.WriteLine("this task is not found");

    }

}
