using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_Inheritence
{
    internal class Result:Test
    {
        int totalscore;

        public Result()
        {
                
        }
        public Result(int  totalscore)
        {
            this.totalscore = totalscore;
        }
        public void  DisplayDetails()
        {
            base.DisplayDetails();
            totalscore = totalmarks + score;
            Console.WriteLine($"total score is : {totalscore}");

        }

    }
}
