using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceWithSameMethodName
{
    class Program
    {
        static void Main(string[] args)
        {
            I1 i1obj = new A();
            i1obj.Method1();

            I2 i2obj = new A();
            i2obj.Method1();

            Console.ReadLine();
        }
        interface I1
        {
            void Method1();
        }
        interface I2
        {
            void Method1();
        }
        class A : I1, I2
        {
            void I1.Method1()
            {
                Console.WriteLine("This is called via I1...");
            }
            void I2.Method1()
            {
                Console.WriteLine("This is called via I2...");
            }
        }
    }
}
