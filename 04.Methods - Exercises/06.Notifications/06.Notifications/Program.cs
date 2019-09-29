using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Notifications
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            if (operation == "success")
            {
                string message = Console.ReadLine();
                string secondMsg = Console.ReadLine();
                Console.WriteLine(ShowSuccess(message,secondMsg));
            }
            string secondOperatio = Console.ReadLine();
            if(secondOperatio == "error")
            {
                string msg = Console.ReadLine();               
                string reason = Console.ReadLine();
                int code = int.Parse(Console.ReadLine());
                Console.WriteLine(ShowError(msg,code,reason));
            }
        }
        public static string ShowSuccess(string operation, string message)
        {
            return $@"Successfully executed {operation}.
==============================
Message: {message}.
";
        }
        public static string ShowError(string operation,int code,string reason)
        {
            if (code >= 0)
            {
                reason = "Invalid Client Data";
            }
            else
            {
                reason = "Internal System Failure";
            }
            return $@"Error: Failed to execute {operation}.
==============================
Error Code: {code}.
Reason: {reason}.
";
        }
    }
}
