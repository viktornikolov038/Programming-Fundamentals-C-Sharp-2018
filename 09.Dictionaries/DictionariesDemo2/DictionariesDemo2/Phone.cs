using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionariesDemo2
{
    class Phone
    {
        public static void Main()
        {
            var phoneBook = new Dictionary<string,string>();
            phoneBook["Goshe"] = "+234123414";
            phoneBook["Ivan"] = "+0851234155";
            phoneBook["Pesho"] = "+0881751234";
            phoneBook["Stavri"] = "+588120561";

            Console.WriteLine("This is your smartphone");
            Console.WriteLine("If you want more info type \"info\"");
            //command : call,contacts
            string[] command = Console.ReadLine().Split(' ');
            var trash = string.Empty;
            while (command[0] != "end")
            {
                if (command[0] == "call")
                {
                    Console.WriteLine("Calling {0} {1}", command[1], phoneBook[command[1]]);
                }

                else if (command[0] == "contacts" && phoneBook.Count > 0)
                {
                    foreach (var contact in phoneBook)
                    {
                        var names = contact.Key;
                        var numbers = contact.Value;
                        Console.WriteLine($"{names} -> {numbers}");
                    }
                }
                else if (command[0] == "contacts" && phoneBook.Count <= 0)
                {
                    Console.WriteLine("You dont have any contacts");
                }
                else if (command[0] == "add")
                {
                    var addedName = command[1];
                    var addedNumber = command[2];
                    phoneBook.Add(addedName, addedNumber);
                    Console.WriteLine("Succesfully added {0}",addedName);
                }

                else if (command[0] == "remove" && phoneBook.TryGetValue(command[1], out trash))
                {
                    phoneBook.Remove(command[1]);
                    Console.WriteLine("Succresfully removed {0}",command[1]);
                }
                else if (command[0] == "info")
                {
                    Console.WriteLine("You can see your contacts by typing \"contacts\"");
                    Console.WriteLine("You can call your friends by typing \"call\" and theirs name");
                    Console.WriteLine("You can add contacts by typing \"add\" then theirs name and number");
                    Console.WriteLine("You can remove contacts by typing \"remove\" and theirs name");
                    Console.WriteLine("Type \"end\" to close your phone");
                }
                else
                {
                    Console.WriteLine("Invalid Command");
                }
                command = Console.ReadLine().Split(' ');
            }
        }
    }
}
