using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Student_Groups
{
    class Program
    {
        static void Main(string[] args)
        {

            // Problem:
            // At the Software University, we often organize programming courses for beginners in different towns. We usually run a registration form and after the registration finishes, we distribute the students into study groups. Groups have different sizes in each town.
            // You are given a report holding the registrations for each town and the lab capacity(seats count) for each town. It comes in the following format:
            // Town name => X seats(where X is the capacity of the training lab in this town).
            // Student name | student email | registration date(in format day - month - year).The month name is given as 3 letters in English, e.g. “May”, “Aug” or “Nov”.
            // The next student come after the first, etc.
            // Then the next town and its students come, etc.
            // The input ends by a line holding “End”.
            // The input comes in the following structure:
            // Town1 => X seats
            // Student1 Name | student1_email@somewhere.com | day - month - year
            // Student2 Name | student2_email@somewhere.com | day - month - year
            // Student3 Name | student3_email@somewhere.com | day - month - year  
            // Town2 => X seats
            // Student1 Name | student1_email@somewhere.com | day - month - year
            // Student2 Name | student2_email@somewhere.com | day - month - year
            // End
            // Your task is to create and print the study groups for each town as follows:
            // For each town create and print one or several study groups(depends of the number or registered students and the capacity of the lab in this town).
            // For each town order the students by registration date(ascending), then by name(ascending) then by email(ascending), then fill them into groups.If the students are less or equal to the lab capacity, create only one group.When the students are more than the lab capacity, distribute them in multiple groups.
            // Print all groups ordered by town(ascending) in the following format:
            // Created G groups and T towns:
            // Town1 => email1, email2, …
            // Town1 => email1, email2, …
            //⦁	…
            //⦁	Town2 => email1, email2, …
            //⦁	…



            List<Town> towns = new List<Town>();
            string command = Console.ReadLine();


            while (command != "End")
            {
                if (command.IndexOf("=>") != -1)
                {
                    towns.Add(ReadTown(command));
                }
                else
                {
                    towns[towns.Count - 1].Students.Add(ReadStudent(command));
                }

                command = Console.ReadLine();
            }

            List<Group> groups = DistributeStudentsIntoGroups(towns);

            Console.WriteLine("Created {0} groups in {1} towns:", groups.Count, towns.Count);

            foreach (Group group in groups.OrderBy(g => g.Town.Name))
            {
                Console.WriteLine("{0} => {1}", group.Town.Name, string.Join(", ", group.Students.Select(s => s.Email).ToList()));
            }
        }

        static Town ReadTown(string input)
        {
            string[] tokens = input.Split(new[] { "=>" }, StringSplitOptions.RemoveEmptyEntries);
            string name = tokens[0].Trim();
            int seatsCount = int.Parse(tokens[1].Trim().Split(' ')[0]);
            List<Student> students = new List<Student>();
            return new Town { Name = name, SeatsCount = seatsCount, Students = students };
        }

        static Student ReadStudent(string input)
        {
            string[] tokens = input.Split('|');
            string name = tokens[0].Trim();
            string email = tokens[1].Trim();
            DateTime registrationDate = DateTime.ParseExact(tokens[2].Trim(), "d-MMM-yyyy", CultureInfo.InvariantCulture);

            return new Student { Name = name, Email = email, RegistrationDate = registrationDate };
        }

        static List<Group> DistributeStudentsIntoGroups(List<Town> towns)
        {
            var groups = new List<Group>();

            foreach (Town town in towns)
            {
                IEnumerable<Student> students = town.Students.OrderBy(s => s.RegistrationDate).ThenBy(s => s.Name).ThenBy(s => s.Email);

                while (students.Any())
                {
                    Group group = new Group();
                    group.Town = town;
                    group.Students = students.Take(group.Town.SeatsCount).ToList();
                    students = students.Skip(group.Town.SeatsCount);
                    groups.Add(group);
                }
            }

            return groups;
        }
    }

    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
    }

    class Town
    {
        public string Name { get; set; }
        public int SeatsCount { get; set; }
        public List<Student> Students { get; set; }
    }

    class Group
    {
        public Town Town { get; set; }
        public List<Student> Students { get; set; }
    }
}