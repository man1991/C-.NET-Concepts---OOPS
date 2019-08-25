using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverLoading
{
    class Program
    {
        static void Main(string[] args)
        {
            //test if this works
            Class1 obj1 = new Class1();
            obj1.Num1 = 04;
            obj1.Str1 = "Manish";

            Class1 obj2 = new Class1();
            obj2.Num1 = 91;
            obj2.Str1 = "Singh";

            Class1 obj3 = new Class1();
            obj3 = obj1 + obj2;
        }
    }
    class Class1
    {
        public int Num1 = 0;
        public string Str1 = "";
        public static Class1 operator +(Class1 obj1, Class1 obj2)
        {
            Class1 obj3 = new Class1();
            obj3.Num1 = obj1.Num1 + obj2.Num1;
            obj3.Str1 = obj1.Str1 + obj2.Str1;
            return obj3;
        }
    }
}
