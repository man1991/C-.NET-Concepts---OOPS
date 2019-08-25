using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerLibrary_AccessModifier;

namespace CustomerExportLibrary_AccessModifier
{
    public class CustomerExport : Customer
    {
        public void Export()
        {
            Validate1();//Protected
            Add();//Public
                  //Validate();//Not accessible as it is private.
                  //Validate2();//Not accessible, As it is internal
                  //Export to excel
            Validate3();//Accesible as its protected internal

        }
    }
}
