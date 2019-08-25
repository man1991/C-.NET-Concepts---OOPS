using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilty_Static;

namespace Customer_Static
{
    public class CustomerClass
    {
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        private string MachineName = "";
        public CustomerClass()
        {
            //As in Utilty_Static, its class and its methods are static thier is no point in using "new" and creating object of its.
            //CommonRoutines oCommon = new CommonRoutines();
            MachineName = CommonRoutines.GetComputerName();
        }

        //As IsEmpty is private in Customer_Static, in order to consume this in Masters_Static we need to make this public
        //private bool IsEmpty(string value)
        //Moving this too Utilty_Static to achieve OOP-Abstraction 
        //public bool IsEmpty(string value)

        //{
        //    if (value.Length == 0)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        public void Insert()
        {
            //As in Utilty_Static, its class and its methods are static thier is no point in using "new" and creating object of its.
            //CommonRoutines oCommon = new CommonRoutines();
            CommonRoutines.HowManyTimes++;
            if(!CommonRoutines.IsEmpty(CustomerCode) && !CommonRoutines.IsEmpty(CustomerName))
            {
                //Let the insert happen
            }
        }
    }
}
