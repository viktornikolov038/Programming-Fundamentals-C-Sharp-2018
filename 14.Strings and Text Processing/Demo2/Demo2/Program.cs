using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    class Program
    {
        public static void Main()
        {
            ////strimgbuilder
            //var stopwatch = Stopwatch.StartNew();
            //var result = new StringBuilder();
            //for (int i = 0; i < 200000; i++)
            //{
            //    result.Append("a");
            //}
            //var resultAsString = result.ToString();
            ////Console.WriteLine(result);
            //stopwatch.Stop();
            //Console.WriteLine(stopwatch.Elapsed);



            //// regular number adder 
            //stopwatch.Start();
            //var numberResult = 0;
            //for (int i = 0; i < 200000; i++)
            //{
            //    numberResult += 1;
            //}
            //stopwatch.Stop();
            //Console.WriteLine(stopwatch.Elapsed);

            ////regular string adder 
            //stopwatch.Start();
            //var slowresult = "";
            //for (int i = 0; i < 200000; i++)
            //{
            //    slowresult += "a";
            //}
            ////Console.WriteLine(slowresult);
            //stopwatch.Stop();
            //Console.WriteLine(stopwatch.Elapsed);


            var sb = new StringBuilder();
            sb.AppendLine("Goshe");
            sb.AppendLine("Pesho");
            sb.Append("Kire");
            sb[1] = 'y';
            sb.Replace("Pesho", "Stamat");
            Console.WriteLine(sb);
        }
    }
}
