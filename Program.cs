using System;

namespace fifthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Kisaki";
            string lastName = "Суня";
            Console.WriteLine(firstName + lastName);

            (firstName, lastName) = (lastName, firstName);
            Console.WriteLine(firstName + lastName);
        }
    }
}
