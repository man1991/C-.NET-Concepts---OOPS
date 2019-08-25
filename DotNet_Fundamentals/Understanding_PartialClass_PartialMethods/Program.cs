using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Understanding_PartialClass_PartialMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();
            //Methods of both physical files Class1.cs and Class2.cs are accessible with obj here as we have used "partial"
            obj.Method1();
            obj.Method2();
            obj.Method3();
            obj.Method4();
            obj.Method5();
            obj.Method6();
            obj.Method7();
            obj.Method8();
            obj.Method9();
            obj.Method10();
            obj.Method11();
            obj.Method12();
            obj.Method13();
            obj.Method14();
            obj.Method15();
            obj.Method16();
            obj.Method17();
            obj.Method18();

        }
    }
}
