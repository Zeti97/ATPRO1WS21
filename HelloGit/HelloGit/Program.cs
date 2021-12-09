using System;

namespace HelloGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Person myPerson = new Person();
            myPerson Name = "Franz";
           myPerson.Birthdate = new DateTime();

            Console.WriteLine("Hello Student!");
            Console.WriteLine(myPerson.ToString());
        }
    }
}
