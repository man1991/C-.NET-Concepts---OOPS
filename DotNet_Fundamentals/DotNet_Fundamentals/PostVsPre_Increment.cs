using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Fundamentals
{
    class PostVsPre_Increment
    {
        static void Main(string[] args)
        {
            int i = 1;
            //int j = i++;//Post-Increment or Postfix: first it is assigned and then increment happens
            int j = ++i;//Pre-Increment or Prefix: first increment happens and then it is assigned
        }
    }
}
