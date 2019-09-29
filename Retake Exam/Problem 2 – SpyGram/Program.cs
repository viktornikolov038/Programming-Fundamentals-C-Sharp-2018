using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2___SpyGram
{
    public class Message
    {
        public string Name { get; set; }

        public string Encripted { get; set; }
    }

    class Program
    {
        public static void Main()
        {
            var result = new List<Message>();

            var privateKey = Console.ReadLine();
            while (true)
            {
                var commandLine = Console.ReadLine();
                if (commandLine == "END")
                {
                    break;
                }
                var commandParts = commandLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (commandParts.Length < 4)
                {

                    continue;
                }


                var recipient = commandParts[1].TrimEnd(';');
                var message = commandParts[3].TrimEnd(';');



                if (commandParts[0] != "TO:")
                {
                    continue;
                }

                if (commandParts[2] != "MESSAGE:")
                {
                    continue;
                }

                var currentLine = new StringBuilder();


                var privateKeyFinal = "";
                var timesMore = commandLine.Length / privateKey.Length;

                for (int i = 0; i < timesMore + 1; i++)
                {
                    privateKeyFinal += privateKey;
                }

                if (recipient.All(a => char.IsUpper(a)) && recipient.All(a => char.IsLetter(a)))
                {

                    for (int i = 0; i < commandLine.Length; i++)
                    {
                        for (int r = 0; r < privateKeyFinal.Length; r++)
                        {
                            if (i == r)
                            {
                                var currentSymbol = commandLine[i];
                                var currentNumber = int.Parse(privateKeyFinal[r].ToString());

                                var currentSymbolASCII = (int)currentSymbol;
                                var currentASCII = currentSymbolASCII + currentNumber;
                                currentLine.Append((char)currentASCII);
                                break;
                            }
                        }
                    }

                }
                else
                {
                    continue;
                }
                

                result.Add(new Message
                {
                    Name = recipient,
                    Encripted = currentLine.ToString()
                  
               });

                result = result.OrderBy(a => a.Name).ToList();
                
            }



            foreach (var line in result)
            {
                Console.WriteLine(line.Encripted);
            }
        }
    }
}
