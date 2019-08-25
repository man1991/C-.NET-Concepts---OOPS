using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    abstract class DB
    {
        public abstract void Connect();
        public string DBIpAddress()
        {
            return "10.10.1.1";
        }
    }
    class SQLServer : DB
    {
        public override void Connect()
        {
            Console.WriteLine("This method will connect to SQL Server");
        }
    }
    class Oracle : DB
    {
        public override void Connect()
        {
            Console.WriteLine("This method will connect to Oracle");
        }
    }
}
