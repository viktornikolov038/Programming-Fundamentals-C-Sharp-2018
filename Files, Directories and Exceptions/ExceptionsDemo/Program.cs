using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsDemo
{
    public class Program
    {
        public static void Main()
        {
            try
            {
                var file = File.ReadAllText("number.txt");
                var number = int.Parse(file);

                Console.WriteLine(123 / number);

            }
            catch (IOException e)
            {
                Console.WriteLine("file does not exist");
                Console.WriteLine(e.StackTrace);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Ne deli na 0 bre");
                Console.WriteLine(e.StackTrace);
            }
            catch (FormatException e)
            {
                Console.WriteLine("kak che delish na bukva be !");
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Console.WriteLine("bau");
            }
            
        }

        
    }
}
