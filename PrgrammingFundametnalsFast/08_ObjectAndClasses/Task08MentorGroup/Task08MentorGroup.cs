using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Task08MentorGroup
{
    class Student
    {

        public string Name { get; set; }

        public List<DateTime> Attends { get; set; }

        public List<string> Comments { get; set; }

        public Student(string name)
        {
            this.Name = name;

            this.Attends = new List<DateTime>();

            this.Comments = new List<string>();


        }
    }
    class Task08MentorGroup
    {
        static void Main(string[] args)
        {

            SortedDictionary<string, Student> dataBase = new SortedDictionary<string, Student>();

            var dateNameInput = Console.ReadLine().Split(new char[] { ' ',',' }, StringSplitOptions.RemoveEmptyEntries);

            while (dateNameInput[0]!="end")
            {
                string name = dateNameInput[0];

                if (!dataBase.ContainsKey(name))
                {
                    dataBase[name] = new Student(name);
                }

                foreach (var stringDate in dateNameInput.Skip(1))
                {
                    var currentDate = DateTime.ParseExact(stringDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                    dataBase[name].Attends.Add(currentDate);
                }

                dateNameInput = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            }

          var  commentInput = Console.ReadLine().Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

            while (commentInput[0]!= "end of comments")
            {

                string name = commentInput[0];

                string currentComment = commentInput[1]; 

                if (dataBase.ContainsKey(name))
                {
                    dataBase[name].Comments.Add(currentComment);
                }
                commentInput = Console.ReadLine().Split(new char[] {'-'}, StringSplitOptions.RemoveEmptyEntries);
            }


            foreach (var student in dataBase.Values)
            {
                Console.WriteLine(student.Name);

                Console.WriteLine("Comments:");

                foreach (var comment in student.Comments)
                {
                    Console.WriteLine($"- {comment}");
                }

                Console.WriteLine("Dates attended:");

                foreach (var date in student.Attends.OrderBy(n=>n))
                {
                    Console.WriteLine($"-- {date.ToString("dd/MM/yyyy")}");
                }
            }
        }
    }
}
