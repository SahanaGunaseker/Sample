using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;

namespace Sample
{
    public class SampleRep : IPrint
    {
        public void Print(Sample sample)
        {
            var demo = new AsyncAwaitDemo();
            demo.DoStuff();
            while (true)
            {
                Console.WriteLine("Hello World");
            }
        } 
}
    public class AsyncAwaitDemo
    {
        public async Task DoStuff()
        {
            await Task.Run(() => {LongRunningOperation();
            });
        }
        private static async Task<string> LongRunningOperation()
        {
            int count;
            for(count = 0;count<2000; count++)
            {
                Console.WriteLine(count);
            }
            return "count = " + count;
        }
    }

    }
    
   
