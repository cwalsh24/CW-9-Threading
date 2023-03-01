/**
 * @file FindPiThread.cs
 * @author Connor Walsh
 * @date 2023-3-01
 * @brief implementation for the FindPiThread class
 * 
 * This class file contains the implementation for the FindPiThread which estimates the value of pi using the monte 
 * carlo method. This is accomplished by simulating a 4th of a dart board. We are able to calculate the value of pi using
 * the loop contained inside of the class. 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadingPractice
{
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

            for(int i = 0; i < dartNum; i++)
            {
                x = randomNum.NextDouble();
                y= randomNum.NextDouble();
                double value = Math.Sqrt((x * x) + (y * y));
                if (value < 1)
                {
                    dartHits++;
                }

            }
        }
    }
}
