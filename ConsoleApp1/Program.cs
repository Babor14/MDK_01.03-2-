using System;
using System.Diagnostics;
using System.Threading;
 int n = 1;
 Thread thr1;
    thr1 = new Thread(d);
    thr1.Start();

   
    thr1.Join();

    Console.ReadLine();


static void d(object size)
{
    Stopwatch sw = new Stopwatch();
    sw.Start();

    string stri1;
    stri1 = "мама, папа, и никита";
    stri1 = stri1.Replace(" ", "<>");
    Console.WriteLine(stri1);

    sw.Stop();
    Console.WriteLine("Stopwatch: " + sw.ElapsedTicks.ToString());
}
