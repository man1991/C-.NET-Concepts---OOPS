using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddingDLL_Understanding_Assembly_EXE_DLL;

//Assebmly or EXE

namespace Understanding_Assembly_EXE_DLL
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj_DLL = new Class1();
            Console.WriteLine(obj_DLL.Method());
            Console.WriteLine("Hello");
            Console.ReadLine();
        }
    }
}
