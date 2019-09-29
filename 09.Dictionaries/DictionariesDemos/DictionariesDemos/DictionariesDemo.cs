using System;
using System.Collections.Generic;
namespace DictionariesDemos
{
    class DictionariesDemo
    {
        public static void Main()
        {
            var phoneBook = new Dictionary<string, string>();
            phoneBook["Ivan"] = "+35923421412";
            phoneBook["Pesho"] = "+3591234152";
            phoneBook["Stavri"] = "+441561234";
            phoneBook["Temelko"] = "+561234862";

            var keys = phoneBook.Keys;
            //foreach (var key in keys)
            //{
            //    console.writeline(key);
            //}
            //var values = phonebook.values;
            //foreach (var value in values)
            //{
            //    console.writeline(value);
            //}
            //foreach (var kvp in phoneBook)
            //{
            //    var key = kvp.Key;
            //    var value = kvp.Value;
            //    Console.WriteLine($"{key} -> {value}");
            //}

            //phoneBook.Add("Asparuh", "+1");
            //phoneBook.Remove("Temelko");
            //phoneBook.Clear();

            //var existKey = phoneBook.ContainsKey("Temelko");
            //var existValue = phoneBook.ContainsValue("+3598441244");
            //Console.WriteLine(existKey);
            //Console.WriteLine(existValue);

            //var name = Console.ReadLine();
            //var nameNumber = Console.ReadLine();
            //if (!phoneBook.ContainsKey(name))
            //{
            //    phoneBook.Add(name, nameNumber);

            //}
            //else
            //{
            //    Console.WriteLine("You need to provide unique name and number");
            //}

            //var secondPhoneBook = new Dictionary<string, List<string>>();
            //secondPhoneBook["Gosho"] = new List<string>
            //{
            //    "+2141234","+16612"
            //};

            //var gosheNumbers = secondPhoneBook["Gosho"];
            //foreach (var phone in gosheNumbers)
            //{
            //    Console.WriteLine(phone);
            //}

            //foreach (var key in phoneBook.Keys)
            //{
            //    Console.WriteLine(key);
            //    Console.WriteLine(phoneBook[key]);

            //    Console.WriteLine("---");
            //}





            //int number;
            //bool parsed = int.TryParse(text, out number);
            //Console.WriteLine(number);
            //Console.WriteLine(parsed);

            var phone = new Dictionary<string, string>();
            phone["Ivan"] = "+1234557";
            string number;
            var succes = phone.TryGetValue("Ivan", out number);
            Console.WriteLine(succes);
            Console.WriteLine(number);

        }
    }
}
