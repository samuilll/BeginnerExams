using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Task10StudentGroups
{
    class Student
    {

        public string Name { get; set; }

        public string Mail { get; set; }

        public DateTime RegistrationDate { get; set; }

        public Student(string name, string mail, DateTime date)
        {

            this.Name = name;

            this.Mail = mail;

            this.RegistrationDate = date;
        }

    }
    class Group
    {

        public string Town { get; set; }

        public List<Student> Students { get; set; }

        public Group(string town)
        {
            this.Town = town;

            this.Students = new List<Student>();
        }
    }
    class Town
    {

        public string Name { get; set; }

        public int Seats { get; set; }

        public List<Student> Students { get; set; }

        public Town(string name, int seats)
        {
            this.Name = name;

            this.Seats = seats;

            this.Students = new List<Student>();
        }
    }
    class Task10StudentGroups
    {
        static void Main(string[] args)
        {


            string input = Console.ReadLine();

            HashSet<Town> townsList = new HashSet<Town>();

            List<Group> groupsList = new List<Group>();

            Town currentTown = new Town(string.Empty, 0) ;

            while (input!="End")
            {
                if (input.Contains("=>"))
                {

                    var inputSplit = input.Split(new string[] { "=>"}, StringSplitOptions.None);

                    string townName = inputSplit[0].Trim();

                    int seats = int.Parse(inputSplit[1].Trim().Split(' ').First());

                    currentTown = new Town(townName, seats);

                    townsList.Add(currentTown);
                }
                if (!(input.Contains("=>")))
                {
                    var inputSplit = input.Split(new char[] {'|'},StringSplitOptions.None);

                    var studentName = inputSplit[0].Trim();

                    var studentMail = inputSplit[1].Trim();

                    var registrationDate = DateTime.ParseExact(inputSplit[2].Trim(), "d-MMM-yyyy", CultureInfo.InvariantCulture);

                    var currentStudent = new Student(studentName, studentMail, registrationDate);

                    townsList.Single(n => n.Name == currentTown.Name).Students.Add(currentStudent);
                }

                input = Console.ReadLine();
            }

            foreach (var town in townsList)
            {
                var currentGroup = new Group(town.Name);

                foreach (var student in town.Students.OrderBy(n=>n.RegistrationDate).ThenBy(n=>n.Name).ThenBy(n=>n.Mail))
                {
                    if (currentGroup.Students.Count==town.Seats)
                    {
                        groupsList.Add(currentGroup);

                        currentGroup = new Group(town.Name);
                    }
                    currentGroup.Students.Add(student);
                }

                if (currentGroup.Students.Count>0)
                {
                    groupsList.Add(currentGroup);
                }
            }

            Console.WriteLine($"Created {groupsList.Count} groups in {townsList.Count} towns:");

            foreach (var group in groupsList.OrderBy(n=>n.Town))
            {
                Console.WriteLine($"{group.Town} => {string.Join(", ",group.Students.Select(n=>n.Mail))}");
            }

        }

    }
}
