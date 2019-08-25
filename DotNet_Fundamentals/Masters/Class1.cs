using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilty_Static;
namespace Masters_Static
{
    public class CountryMaster
    {
        public string CountryCode { get; set; }
        public string CountryName { get; set; }

        //As ComputerName is private in Masters_Static, in order to consume this in Customer_Static we need to make this public
        //private string ComputerName { get
        //Moving this too Utilty_Static to achieve OOP-Abstraction 
        //public string ComputerName
        //{
        //    get

        //    {
        //        return System.Environment.MachineName;
        //    }
        //}

        public string ComputerName
        {
            get
            {
                //As in Utilty_Static, its class and its methods are static thier is no point in using "new" and creating object of its.
                //CommonRoutines oRoutines = new CommonRoutines();
                return CommonRoutines.GetComputerName();
            }
        }
        public void Insert()
        {
            //As in Utilty_Static, its class and its methods are static thier is no point in using "new" and creating object of its.
            //CommonRoutines oRoutines = new CommonRoutines();
            CommonRoutines.HowManyTimes++;
            if (!CommonRoutines.IsEmpty(CountryCode) && !CommonRoutines.IsEmpty(CountryName))
            {
                //go and insert in to DB call the dataaccess layer.
            }
        }
    }
}
