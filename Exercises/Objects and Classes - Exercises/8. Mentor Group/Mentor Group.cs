using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Mentor_Group
{
    class Program
    {
        static void Main(string[] args)
        {

            var students = new SortedDictionary<string, students>();
            var entry = Console.ReadLine().Split(' ').ToList();
            List<DateTime> dates = new List<DateTime>();
            while (string.Join(" ", entry) != "end of dates")
            {
                var name = entry[0];
                if (!students.ContainsKey(name))
                {
                    students student = new students(name);
                    if (entry.Count ==2)
                    {
                        dates = entry[1].Split(',')
                            .Select(s => DateTime.ParseExact(s, "dd/MM/yyyy", CultureInfo.InvariantCulture)).ToList();
                        student.dates.AddRange(dates);

                    }
                    students.Add(name, student);
                }
                else
                {
                    if (entry.Count == 2)
                    {
                        dates = entry[1].Split(',')
                            .Select(s => DateTime.ParseExact(s, "dd/MM/yyyy", CultureInfo.InvariantCulture)).ToList();
                       
                            students[name].dates.AddRange(dates);

                    }
                }
                entry = Console.ReadLine().Split(' ').ToList();
            }
            var secondEntry = Console.ReadLine().Split('-').ToList();
            while (secondEntry[0] != "end of comments")
            {
                var name = secondEntry[0];           
                    var comment = secondEntry[1];
                    if (students.ContainsKey(name))
                    {
                        students[name].comments.Add(comment);
                    }               
                secondEntry = Console.ReadLine().Split('-').ToList();
            }
            foreach (var student in students)
            {
                Console.WriteLine(student.Key);
                Console.WriteLine("Comments:");
                foreach (var comment in student.Value.comments)
                {
                    Console.WriteLine($"- {comment}");
                }
                Console.WriteLine("Dates attended: ");
                foreach (var date in student.Value.dates.OrderBy(d => d))
                {
                    Console.WriteLine($"-- {date:dd/MM/yyyy}");
                }
            }
        }
    }
    class students
    {
        public students(string name)
        {
            this.name = name;
            dates = new List<DateTime>();
            comments = new List<string>();
        }
        public string name { get; set; }
        public List<DateTime> dates { get; set; }
        public List<string> comments { get; set; }
    }
}
