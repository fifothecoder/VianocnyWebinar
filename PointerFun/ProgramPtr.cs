using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointerFun
{

    struct CustomStruct
    {
        public int variable;
    }

    class CustomClass
    {
        public int variable;
    }

    class ProgramPtr
    {
        static void Main(string[] args)
        {

            int first = 0;
            int? firstNullable = 0;

            firstNullable = null;
            //first = null;

            unsafe
            {
                int number = 80;
                int* intPtr = &number;

                Console.WriteLine($"Value in variable: {number}");
                Console.WriteLine($"Address of variable: 0x{(long)(&number):x8}\n");

                Console.WriteLine($"Dereferenced value in pointer : {*intPtr}");
                Console.WriteLine($"Value in pointer : 0x{(long)(intPtr):x8}");
                Console.WriteLine($"Address of pointer : 0x{(long)(&intPtr):x8}");

                CustomStruct str = new CustomStruct() {variable = 20};
                CustomStruct* strPtr = &str;
                
                /*  Wrong!
                 *  CustomClass obj = new CustomClass() {variable = 10};
                 *  CustomClass* objPtr = &obj;
                 */

            }

            Console.ReadKey(true);
        }

        static void Init(out int a)
        {
            a = 10;
        }
    }
}
