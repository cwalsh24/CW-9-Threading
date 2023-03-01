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

            for(int i = 0; i < threadInt; i++) { 
                FindPiThread find = new FindPiThread(numInt);
                pList.Add(find);
                Thread pThread = new Thread(new ThreadStart(find.throwDarts));
                tList.Add(pThread);
                pThread.Start();
                Thread.Sleep(16);
            }


            //loop 2
            foreach(var Thread in tList)
            {
                Thread.Join();
            }

            double counter = 0; 
            //loop 3
            foreach (var FindPiThread in pList)
            {

                counter += FindPiThread.getHits();
                hitCount = FindPiThread.getHits();
                Console.WriteLine((4 * (double)(hitCount)) / ((double)(numInt)));
            }

            Console.WriteLine(threadInt);
            Console.WriteLine(4 * counter / (double)(numInt*threadInt));

            Console.ReadKey();
        }
    }
}
