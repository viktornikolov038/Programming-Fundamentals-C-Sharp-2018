using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.User_Logins
{
    class Program
    {
        static void Main(string[] args)
        {
            var singupParams = new Dictionary<string, string>();
            var line = Console.ReadLine();

            var loginName = "";
            var loginPass = "";
            while (line != "login")
            {
                var tokens = line.Split();
                loginName = tokens[0];
                loginPass = tokens[tokens.Length - 1];
                singupParams[loginName] = loginPass;
                line = Console.ReadLine();
            }
            var failsCounter = 0;
            line = Console.ReadLine();

            var loginParams = new Dictionary<string, string>();
            while (line != "end")
            {
                var tokens = line.Split();
                var tryName = tokens[0];
                var tryPass = tokens[tokens.Length - 1];
                loginParams[tryName] = tryPass;
                if (singupParams.ContainsKey(tryName))
                {
                    var realName = singupParams[tryName];
                    var realPassword = singupParams[tryName];
                    var loginPassword = loginParams[tryName];
                    if (realPassword == loginPassword)
                    {
                        Console.WriteLine($"{tryName}: logged in successfully");
                    }
                    else
                    {
                        failsCounter++;
                        Console.WriteLine($"{tryName}: login failed");
                    }
                    
                }
                else
                {
                    failsCounter++;
                    Console.WriteLine($"{tryName}: login failed");
                }
                line = Console.ReadLine();
            }
            Console.WriteLine("unsuccessful login attempts: {0}", failsCounter);
        }
    }
}
