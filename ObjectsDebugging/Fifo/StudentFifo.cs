using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsDebugging
{

    [Flags]
    public enum Classes
    {
        None        = 0b_0000_0000,         //Binary 0
        Maths       = 0b_0000_0001,         //Binary 1
        English     = 0b_0000_0010,         //Binary 2
        ICT         = 0b_0000_0100,         //Binary 4
        Chemistry   = 0b_0000_1000,         //Binary 8
        History     = 0b_0001_0000,         //Binary 16
        Physics     = 0b_0010_0000,         //Binary 32
        All         = 0b_0011_1111          //Binary 63
    }

    /// <summary>
    /// Partial Fifo's definition of the Student class
    /// </summary>

    partial class Student
    {
        private string _name;
        private Classes _classes;

        /// <summary>
        /// Constructs student and sets his name and default classes
        /// </summary>
        /// <param name="name">Student's name</param>
        /// <param name="defaultClasseses">Student's classes (if not set, no classes are added)</param>
        public Student(string name, Classes defaultClasseses = Classes.None)
        {
            _name = name;
            _classes = defaultClasseses;
        }

        public void AddClass(Classes cl)        => _classes = cl | _classes;
        public void RemoveClass(Classes cl)     => _classes &= ~cl;
        public bool AttendsClass(Classes cl)    => (_classes & cl) == 0;

        public void PrintAttendedClasses()
        {
            Console.WriteLine($"{"Student", 10} - {_name}");
            for (int i = 1; i < (int)Classes.All; i<<=1)
            {
                if (AttendsClass((Classes)i)) 
                    Console.WriteLine("{0, 10} | Not attending", ((Classes)i));
                else 
                    Console.WriteLine("{0, 10} | Attending", (Classes)i);
            }
        }
    }
}
