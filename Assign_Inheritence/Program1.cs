using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_Inheritence
{
    internal class main
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("enter rn : ");
            //int rollno=byte.Parse(Console.ReadLine());
            //Console.WriteLine("enter name : ");
            //string name_s=Console.ReadLine();
            //Console.WriteLine("enter sportsname : ");
            //string sports_name=Console.ReadLine();
            //Console.WriteLine("enter score : ");
            //int s_score =byte.Parse( Console.ReadLine());
            //List<int> marks = new List<int>() { 50, 40, 55, 60, 30 };
            //Student student = new Student(rollno, name_s);
            //Sports sports = new Sports(sports_name,s_score);
            //Test test = new Test(marks);
            Result result = new Result();
            result.GetDetails();
            result.DisplayDetails();
        }
    }
}
