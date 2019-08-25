using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerLibrary_AccessModifier;

namespace CustomerUI_AccessModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            //This code is complex. Customer UI developer has to be aware that VALIDATE() should be called befor ADD()
            //Customer UI developer has to know too much about this components
            //What if he forgets to call Validate() and calls Add() directly?

            Customer obj = new Customer();

            //As Validate() is now private thier is no more need to call this here also it's not accessible anymore
            //obj.Validate();//Validates
            //obj.Validate1(); //Not accessible as it's protected
            //obj.Validate2();//Not accessible as it's internal
            //obj.Validate3();//Not accessible as it's protected internal

            //As Add() is public it's accessible anywhere
            obj.Add();//Insert this data
        }
    }
}
