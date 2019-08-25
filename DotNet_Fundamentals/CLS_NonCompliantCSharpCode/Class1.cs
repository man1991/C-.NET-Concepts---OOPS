using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLS_NonCompliantCSharpCode
{
    public class Class1
    {
        //C# is case sensitive, It's possible to access variable with same name but only change in cases
        //To check code is CLS compliant or not use, [assembly: CLSCompliant(true)] in AssemblyInfo file 
        public int intA;
        public int inta;
        public int intx;
    }
}
