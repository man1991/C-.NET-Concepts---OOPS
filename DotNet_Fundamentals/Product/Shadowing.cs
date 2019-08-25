using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Shadowing
    {
        static void Main(string[] args)
        {
            Class1 obj1 = new Class1();
            obj1.i = 2;//It will call member variable
            Class2 obj2 = new Class2();
            obj2.i();//It will call member method
        }
    }
    public class Class1
    {
        public int i = 0;
    }
    public class Class2 : Class1
    {
        public new void i()
        {

        }
    }
}
