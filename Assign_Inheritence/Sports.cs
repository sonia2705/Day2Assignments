using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_Inheritence
{
    internal class Sports:Student
    {
        public string sportsname;
        public int score;
        public Sports()
        {
                
        }
        public Sports(string sportsname, int score)
        {
            this.sportsname = sportsname;
            this.score = score;
        }
        public void GetDetails()

        {
            base.GetDetails(); 
            Console.WriteLine("enter sportsname : ");
            sportsname = Console.ReadLine();
            Console.WriteLine("enter score : ");
              score = byte.Parse(Console.ReadLine());
        }
        public void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"sports name : {sportsname}\n score : {score}");
        }
    }

   
}
