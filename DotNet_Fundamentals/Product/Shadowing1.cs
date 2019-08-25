using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Shadowing1
    {
        static void Main(string[] args)
        {
            //Old Clients
            Sales obj1 = new Sales();
            obj1.InvoiceNumber = 3;

            //New Clients
            SalesVersion2 obj2 = new SalesVersion2();
            obj2.InvoiceNumber = "ABC3";
        }
    }
    public class Sales
    {
        public int InvoiceNumber { get; set; }
    }
    public class SalesVersion2 : Sales
    {
        public new object InvoiceNumber { get; set; }
    }
}
