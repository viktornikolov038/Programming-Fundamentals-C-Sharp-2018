using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_and_Text_Demo
{
    class Program
    {
        public static void Main(string[] args)
        {
            //var longText = "some long text long text";
            //var indexOflong = longText.IndexOf("longest");
            ////nachin da proverime dali dadena duma se sadurja v string ako e po malko ot 0 znachi ne sushtestvuva
            //var lastIndexOfLong = longText.LastIndexOf("some");
            //Console.WriteLine(indexOflong);
            //Console.WriteLine(lastIndexOfLong);


            var text = "qj ,mi huq!";
            var commaIndex = text.IndexOf(",");
            var partOfTheText = text.Substring(commaIndex + 1);
            Console.WriteLine(partOfTheText);


            var newText = "1  2                3  44";
            var parts = newText.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(string.Join(" ",parts));


            var cities = "Sofia Varna Sofia Sofia";
            cities = cities.Replace("Sofia", "Kyustendil");
            Console.WriteLine(cities);
            var removedCities = cities.Remove(5, 5);
            Console.WriteLine(removedCities);

            var removeVarna = cities.Replace("Varna", string.Empty).Trim();
            //TRIM trie ot pred i ot zad prazni mesta   
            Console.WriteLine(removeVarna);


            var againHere = " a   kopele    aaa ";
            Console.WriteLine(againHere.Trim('a',' '));
            
        }
    }
}
