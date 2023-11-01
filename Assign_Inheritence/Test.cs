using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_Inheritence
{
    internal class Test : Sports
    {
        List<int> marks = new List<int>(5);
        public int totalmarks;
        public Test()
        {
            //base.GetDetails();
            marks = new List<int>() { 50, 40, 55, 60, 30 };
        }
        public Test(List<int> marks)
        {
            this.marks = marks;

        }

        public void DisplayDetails()
        {
            base.DisplayDetails();
            totalmarks = marks.ToList().Sum();
            Console.WriteLine($"totalmarks : {totalmarks}");
        }
    }

}
