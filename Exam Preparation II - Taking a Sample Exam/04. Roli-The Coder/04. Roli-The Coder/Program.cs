using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Roli_The_Coder
{
    public class Event
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<string> Participants { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var result = new List<Event>();
            var eventById = new Dictionary<int, Event>();

            while (true)
            {
                var currentLine = Console.ReadLine();
                if (currentLine == "Time for Code")
                {
                    break;
                }
                var lineParts = currentLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                //id
                var id = 0;
                if (!int.TryParse(lineParts[0], out id))
                {
                    continue;
                }
                //eventName
                var eventName = "";
                if (lineParts.Length > 1 && lineParts[1].StartsWith("#"))
                {
                    eventName = lineParts[1].Trim('#');
                }
                else
                {
                    continue;
                }

                //participants
                var participants = new List<string>();
                if (lineParts.Length > 2)
                {
                    participants = lineParts.Skip(2).ToList();
                    if (!participants.All(p => p.StartsWith("@")))
                    {
                        continue;
                    }
                }


                if (eventById.ContainsKey(id))
                {
                    if (eventById[id].Name == eventName)
                    {
                        var existingEvent = eventById[id];
                        existingEvent.Participants.AddRange(participants);
                    }
                    else
                    {
                        continue;
                    }

                }
                else
                {
                    var newEvent = new Event
                    {
                        Id = id,
                        Name = eventName,
                        Participants = participants
                    };

                    result.Add(newEvent);

                    eventById.Add(id, newEvent);
                }
                participants.Sort();

          
            }

            var sortedEvents = result
                    .OrderByDescending(e => e.Participants.Distinct().Count())
                    .ThenBy(e => e.Name);
            foreach (var ev in sortedEvents)
                {
                    var distinctParticipants = ev.Participants.Distinct().ToList();
                    Console.WriteLine($"{ev.Name} - {distinctParticipants.Count}");
                    foreach (var participant in distinctParticipants.OrderBy(p => p))
                    {
                        Console.WriteLine(participant);
                    }
                }
        }
    }
}
