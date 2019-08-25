using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilty_Static
{
    //This class is a collection of methods which are unrelated to each other.
    //Because, it has un-realted methods it does not represent any real world object
    //As this class does not represent any real world object, any OOP principles like Inheritance, Interfaces, Abstract 
    //class should not be applied on this class

    //This is fixed class which has fixed behavior

    //To restrict class from applying OOP principle, we need to used "static" keyword in class, variables and its methods
    //public class CommonRoutines

    //But then, because it's a class it can only be used when it's instantiated.

    //Irrespective of how mant times Static classes are called, Static classes has only one instance of the object created 
    //in-memory

    //Because of this single instance behavior, it is used in scenario where we want to share common data e.g. for 
    //configuration data, where we have 50-60 forms and every time those forms run, we want to share some common data,
    //in that case we can make class/variable static, so only one instance of the object created in-memory, thus all form 
    //can share common data 

    public static class CommonRoutines //an abstract class cannot be sealed or static
    {
        //how many times inserts of Customer and country were called? Only One's
        public static int HowManyTimes;

        //Because of single instance, static classes are also good for caching mechanism
        public static List<string> OWeeks = new List<string>();


        //As only one instance of the object is created in-memory, static constructor also runs only once
        static CommonRoutines()
        {
            //This should run only once

            OWeeks.Add("Sunday");
            OWeeks.Add("Monday");
            OWeeks.Add("Tuesday");
            OWeeks.Add("Wednesday");
            OWeeks.Add("Thursday");
            OWeeks.Add("Friday");
            OWeeks.Add("Saturday");
        }

        //public bool IsEmpty(string value)
        public static bool IsEmpty(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return true;
            }
            return false;
        }

        //public string GetComputerName()
        public static string GetComputerName()
        {
            return System.Environment.MachineName;
        }
    }

    //Cannot derive from Static class CommonRoutines
    //public class MyOwnCommonRoutines : CommonRoutines
    //{

    //}

    //Static class Cannot implement interface
    public interface I1 { }
}
