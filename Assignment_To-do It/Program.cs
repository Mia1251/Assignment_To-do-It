using Assignment_To_do_It.Models;

namespace Assignment_To_do_It
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Person p1 = new Person(1, "", "Godderi");
            Person p2 = new Person(2, "Charles", "");
            Person p3 = new Person(3, "Maria", "Svensson");
            Console.WriteLine(p1.id + " " + p1.firstName);

        }
    }
}