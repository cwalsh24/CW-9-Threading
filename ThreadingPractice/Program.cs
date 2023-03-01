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
            int hitCount = 0;  

            Console.WriteLine("How many throws do you want to make for each thread?");
            numberSt = Console.ReadLine();
            numInt = int.Parse(numberSt);

            Console.WriteLine("How many threads do you want to run?");
            threadSt = Console.ReadLine();
            threadInt = int.Parse(threadSt);

            List<Thread> tList = new List<Thread>();
            List<FindPiThread> pList = new List<FindPiThread>();

            //loop 1
            while(threadInt > 0) {
                FindPiThread find = new FindPiThread(numInt);
                pList.Add(find);
                Thread pThread = new Thread(new ThreadStart(find.throwDarts));
                tList.Add(pThread);
                pThread.Start();
                Thread.Sleep(16);
                threadInt--; 
            }


            //loop 2
            foreach(var Thread in tList)
            {
                Thread.Join();
            }

            //loop 3
            foreach (var FindPiThread in pList)
            {

                //or hitCount += FindPiThread.getHits(); ? not sure
                hitCount = FindPiThread.getHits();
                Console.WriteLine(4 * (hitCount) / (numInt));
            }

            //This might return a divide by zero error, it was mad about the variable "not being assigned"
            Console.WriteLine(4 * hitCount / (numInt*threadInt));

            Console.ReadKey();
        }
    }
}
