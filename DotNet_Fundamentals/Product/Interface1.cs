using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    interface IDatabase
    {
        void Update();
    }
    class clsCustomer : IDatabase
    {

        public void Update()
        {
            //Define/Implementation
        }
    }
    class clsSupplier : IDatabase
    {


        public void Update()
        {
            //Define/Implementation
        }


    }
}
