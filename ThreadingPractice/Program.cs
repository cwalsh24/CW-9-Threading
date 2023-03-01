using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingPractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numInt;
            string numberSt;
            int threadInt;
            string threadSt;

            Console.WriteLine("How many throws do you want to make for each thread?");
            numberSt = Console.ReadLine();
            numInt = int.Parse(numberSt);

            Console.WriteLine("How many threads do you want to run?");
            threadSt = Console.ReadLine();
            threadInt = int.Parse(threadSt);

            List<Thread> tList = new List<Thread>();
            List<FindPiThread> pList = new List<FindPiThread>();

            //loop 1
            while (threadInt > 0) {
                FindPiThread find = new FindPiThread(numInt);
                pList.Add(find);
                Thread pThread = new Thread(new ThreadStart(find.throwDarts));
                tList.Add(pThread);
                pThread.Start();
                Thread.Sleep(16);
                threadInt--; 
            }


            //loop 2
            /*Loop over every item in your thread list
              Call item.Join() on it
              NOTE: this tells Main() to wait until every thread is done before continuing! */

            //loop 3
            /*Loop over every item in your FindPiThread list
              Use your accessor to collect the number of darts that landed inside!
             */
            //Print out your evaluation of pi! (4 * (number inside)/ (number thrown))
            Console.ReadKey();
        }
    }
}
