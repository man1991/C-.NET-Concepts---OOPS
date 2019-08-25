using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Understanding_PartialClass_PartialMethods
{
    //Partial classes helps us to define a class partially in one physical file as well as in other phyiscal file
    public partial class Class1
    {
        public void Method1()
        {

        }
        public void Method2()
        {

        }
        public void Method3()
        {

        }
        public void Method4()
        {

        }
        public void Method5()
        {

        }
        public void Method6()
        {

        }
        public void Method7()
        {

        }

        //Using Partial methods, helps us to define a method in one physical file and provide it's implementation in another
        //phyiscal file
        partial void SomeoneWillImplement();
    }
}
