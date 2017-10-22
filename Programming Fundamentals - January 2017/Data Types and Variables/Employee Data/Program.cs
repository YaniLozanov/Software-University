using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string fistName = "Amanda";
            string lastName = "Jonson";
            short age = 27;
            char gender = 'f';
            long personalIdNumber = 8306112507L;
            int numOfEmployee = 27563571;

            Console.WriteLine($"First name: {fistName}");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Personal ID: {personalIdNumber}");
            Console.WriteLine($"Unique Employee number: {numOfEmployee}");



        }
    }
}
