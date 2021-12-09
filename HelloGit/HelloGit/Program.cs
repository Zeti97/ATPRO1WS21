using System;

namespace HelloGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Person myPerson = new Person();
            myPerson.Name = "Franz";
            Console.WriteLine("Hello Student!");
            Console.WriteLine(myPerson.ToString());
        }
    }
}
