using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Understanding_Association_Aggregation_Composition;

namespace Console_Association_Aggregation_Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            //Even if these objects objManager and objSwipe depend on each other for methods Logon() and Swipe() they can 
            //exist independent as well for methods GetManagerName() and MakeofSwipe()
            //This kind of relationship is called as association as it has 2 characteristics:
            //1.thier is no parent object or owner still they can use still each other
            //2.lifetime of both the objects are different
            Manager objManager = new Manager();

            SwipeCard objSwipe = new SwipeCard();



        }
    }
}
