using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsDebugging
{
    class ProgramObj
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("James Bond");

            A();
            s1.AddClass(Classes.All);

            s1.RemoveClass(Classes.Physics);

            s1.PrintAttendedClasses();

            s1.AddGrade(2);
            s1.AddGrade(4);
            s1.PrintAverage();
            s1.AddGrade(1);
            s1.AddGrade(1);
            s1.PrintAverage();

            Console.ReadKey(true);
        }

        static void A()
        {
            B();
        }
        static void B()
        {
            C();
        }
        static void C()
        {
            Console.WriteLine("Hello");
        }
    }
}
