using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Customer_Static;
using Masters_Static;
using Utilty_Static;

namespace Understanding_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerClass oCustomer = new CustomerClass();
            oCustomer.Insert();

            CountryMaster oCountry = new CountryMaster();
            oCountry.Insert();
            oCountry.Insert();

            //I have called the insert 3 times, 1 for CustomerClass and 2 for CountryMaster
            Console.WriteLine(CommonRoutines.HowManyTimes.ToString());
            foreach(string str in CommonRoutines.OWeeks)
            {
                Console.WriteLine(str);
            }
            Console.ReadLine();
        }
    }
}
