using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    interface IDb
    {
         void Update();
    }
    public class clsSQLServer : IDb
    {
        public void Update()
        {

        }
    }
    public class clsOracle : IDb
    {


        public void Update()
        {

        }


    }
    public class clsCustomerObject
    {
        public void Update(IDb obj)
        {
            obj.Update();
        }
    }
}
