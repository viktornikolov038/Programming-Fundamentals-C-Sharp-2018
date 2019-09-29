using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Note_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputFrequency = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            var notes = "C C# D D# E F F# G G# A A# B "
                .Split(' ')
                .ToList();

            var frequencies = "261.63 277.18 293.66 311.13 329.63 349.23 369.99 392.00 415.30 440.00 466.16 493.88"
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            var resultNotes = new List<string>();

            foreach (var freiquency in inputFrequency)
            {
                var frequencyIndex = frequencies.IndexOf(freiquency);
                var note = notes[frequencyIndex];
                resultNotes.Add(note);              
            }

            var allNotes = string.Join(" ", resultNotes);
            Console.WriteLine("Notes: {0}",allNotes);

            var naturals = new List<string>();
            var sharps = new List<string>();
            foreach (var note in resultNotes)
            {
                if (note.Contains("#"))
                {
                    sharps.Add(note);
                }
                else
                {
                    naturals.Add(note);
                }
            }
            Console.WriteLine("Naturals: {0}",string.Join(", ",naturals));
            Console.WriteLine("Sharps: {0}", string.Join(", ", sharps));

            double naturalSum = 0;
            foreach (var note in naturals)
            {
                var frequaencyIndex = notes.IndexOf(note);
                var frequency = frequencies[frequaencyIndex];
                naturalSum += frequency;
            }
            Console.WriteLine("Naturals sum: {0}",naturalSum);
            double sharpsSum = 0;
            foreach (var note in sharps)
            {
                var frequaencyIndex = notes.IndexOf(note);
                var frequency = frequencies[frequaencyIndex];
                sharpsSum += frequency;
            }
            Console.WriteLine("Sharps sum: {0}",sharpsSum);
        }
    }
}
