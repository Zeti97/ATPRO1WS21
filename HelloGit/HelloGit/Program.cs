using System;

namespace HelloGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Person myPerson = new Person();
            myPerson.Birthdate = new DateTime();

            Console.WriteLine("Hello World!");
            Console.WriteLine(myPerson.ToString());
        }
    }
}
