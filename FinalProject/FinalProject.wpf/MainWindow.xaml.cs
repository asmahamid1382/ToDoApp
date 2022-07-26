using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FinalProjectApiCli.Model;
using FinalProjectApiCli.Api;
using FinalProjectApiCli.Client;

namespace FinalProject.wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string _Name{get;set;}
        public string Name
        {
            get=>_Name;
            set=>_Name=value;
        }
        public string Description { get; set; }
        public bool _Status { get; set; }=false;
        public string Status 
        {
            get=>_Status.ToString();
            set=>_Status=bool.Parse(value);
        }
        public DateTime _date{get;set;}
        public string DueDate
        {
            get=>_date.ToString();
            set=>_date=DateTime.Parse(value);
        }
        public int selectedIndex {get; set;}
        public ObservableCollection<MyTask> Tasks {get; set;} = 
             new ObservableCollection<MyTask>();

        public Configuration config {get; set;}
        public MyDayApi apiInstance {get; set;}
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            this.dgTasks.DataContext = this.Tasks;
            config = new Configuration() {BasePath = "http://localhost:5176"};
            apiInstance = new MyDayApi(config);
            foreach (var item in apiInstance.MyDayGet())
            {
                Tasks.Add(item);
            }
        }
        private void AddClicked(object sender, RoutedEventArgs e)
        {
            var added = new MyTask(tbname.Text,this.Description,this._Status,this._date);
            Tasks.Add(added);
            try
            {
               apiInstance.MyDayPost(added); 
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
        private void DeleteClicked(object sender, RoutedEventArgs args)
        {
            try{
             MyTask selectedtask = Tasks[selectedIndex];
            Tasks.RemoveAt(selectedIndex);
                apiInstance.MyDayNameDelete(selectedtask.Name);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}{selectedIndex}");
            }
        }

        private void DoneClicked(object sender, RoutedEventArgs args)
        {
            if(Tasks[selectedIndex].Status==true)
            {
                MessageBox.Show("this task is compeleted");
                apiInstance.MyDayDonePost(Tasks[selectedIndex]);
            }

        }
    }
}
