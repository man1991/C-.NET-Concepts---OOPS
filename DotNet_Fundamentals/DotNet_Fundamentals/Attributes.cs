using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace DotNet_Fundamentals
{
    class Attributes
    {
        static void Main(string[] args)
        {
            Customer obj = new Customer();
            //obj.Add();//It will show warning as deprecated
            //obj.CustomerName = "12345678901234";//will throw exception as length is greater than 10
            obj.CustomerName = "1234567";//will throw exception as length is greater than 10

            //loop using reflection and read the attribute and perform validations
            Type CustomerType = obj.GetType();

            //Browse through the properties
            foreach(PropertyInfo prop in CustomerType.GetProperties())
            {
                //Browse through the attributes
                foreach(Attribute att in prop.GetCustomAttributes(false))
                {
                    Check c = (Check) att;//as our custom attribute class is Check, so typecasting general attribute 
                                            //att to Check class
                    if(prop.Name == "CustomerName")
                    {
                        if(obj.CustomerName.Length > c.MaxLength)
                        {
                            throw new Exception("Not Allowed");
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }

    //[Check(MaxLength = 20)]//Applying attribute over class which is illogical 
    class Customer
    {
        [Check(MaxLength = 10)]//Applying attribute over property. It's just mere information
        public string CustomerName { get; set; }

        [Check(MaxLength = 10)]//Applying attribute over property. It's just mere information
        public string CustomerName1 { get; set; }
        //[Obsolete("Do not invoke this method. It's old", true)]//Attribute with Obsolete and text, a parameter with bool value is given to throw error
        public void Add()
        {

        }
        public void AddNew()
        {
            //Hence forth...
        }
    }
     
    [AttributeUsage(AttributeTargets.Property, Inherited =false, AllowMultiple =false)]//To specify where custom attributes should be used and whether class should inherit attributes in inheritance chain
    class Check : Attribute //this Check class or attribute checks kinds of validations attached with the property
    {
        public int MaxLength { get; set; }
    }
}
