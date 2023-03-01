using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
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

            List<Thread> t = new List<Thread>(); 
            List<FindPiThread> p = new List<FindPiThread>();

            //loop 1
            FindPiThread find = new FindPiThread(numInt);
            /*Add this object to the appropriate list!
              Create a new Thread object, and tie it to the appropriate FindPiThread object:
              new Thread(new ThreadStart(piThread.throwDarts))
              NOTE: you don’t need () after the name of the function!
              Add the thread object to the appropriate list!
              Tell the thread to start!
              myThread.Start();
              Tricksy bit: tell Main() to sleep!
              Thread.Sleep(16)
              NOTE: this tells Main() to pause for 16 milliseconds - this ensures that your random number generators in each FindPiThread object gets a unique seed!*/

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
