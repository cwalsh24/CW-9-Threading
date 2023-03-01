using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadingPractice
{
    //this is the class that you will create to hold thread state.  It will also house your thread function
    public class FindPiThread
    {
        int dartNum;
        int dartHits;
        Random randomNum;

        public FindPiThread(int number)
        {
            randomNum = new Random();
            dartNum = number;
            dartHits = 0; 
        }

        public int getHits()
        {
            return dartHits;
        }

        public void throwDarts()
        {
            double x;
            double y;
            //Inside this function, you should have a loop that randomly “throws” every dart it should throw.
            //After determining the x and y coordinates, increment your counter of how many land inside!
            for(int i = 0; i < dartNum; i++)
            {
                x = randomNum.NextDouble();
                y= randomNum.NextDouble();
                double value = Math.Sqrt(x * x + y * y);
                if (value < 1)
                {
                    dartHits++;
                    dartNum--;
                }
                else
                {
                    dartNum--; 
                }

            }
        }
    }
}
