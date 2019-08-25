using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Understanding_LambdaExp_Action_Predicate_Func
{
    class Program
    {
        //delegate declaration is not required for Lamba+Func
        //delegate double CalAreaPointer(int r);

        //Created object for calling delegate
        //Not required for Anonympus expression
        //static CalAreaPointer cPointer = CalculateArea;
        static void Main(string[] args)
        {
            //Calling method with delegate object
            //double area = cPointer.Invoke(20);

            //Using Anonymous method, we don't need to create function outside Main method
            //This is also called as inline function
            //CalAreaPointer cPointer = new CalAreaPointer(
            //                                                delegate (int r)
            //                                                {
            //                                                    return 3.14 * r * r;
            //                                                }
            //                                                );
            //double area = cPointer(20);

            //Using Lambda Expression, It's divided into two parts:
            //1) whatever is after => is a line of code; 2) whatever is before => is a input parameters;
            //Lambda Expression understands variable's type by looking at the calculation parts or a line of code;
            //e.g. in below example it understood input r can be int and return type will be double
            //CalAreaPointer cPointer = r => 3.14 * r * r;
            //double area = cPointer(20);

            //Lambda expression + Func
            //Func<> is a generic delegate which takes input and gives output so in Func<double, double>, first double is
            //input and second double is output
            //Func will be used to point towrds methods where input and output type can be anything 
            Func<double, double> cPointer = r => 3.14 * r * r;

            //To point to a function which doesn't have output, but it can have inputs, so return type of those methods or
            //functions is alwas void, for such methods and functions we can use Action which is also a generic delegate  
            //Action will be used when method is not giving anything e.g. Void and it takes input
            Action<string> MyAction = y => Console.WriteLine(y);
            MyAction("Hello");

            //Predicate is extension to Func. We can replace Predicate delegate with Func, in other words Predicate delagate
            //can be avoided
            //Predicate is used when return type is boolean
            Predicate<string> CheckGreaterThan5 = x => x.Length > 5;
            Console.WriteLine(CheckGreaterThan5("Manish12345"));

            double area = cPointer(20);

            //How is this things useful?
            List<string> oString = new List<string>();
            oString.Add("Man");
            oString.Add("Manish456");
            string str = oString.Find(CheckGreaterThan5);//Find internally uses Predicate delegate
            Console.WriteLine(str);        
        }

        //Function which will calculate area
        //Not required for Anonympus expression
        //static double CalculateArea(int r)
        //{
        //    return 3.14 * r * r;
        //} 
    }
}
