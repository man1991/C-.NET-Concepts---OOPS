using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Fundamentals
{
    class Datatype
    {
        static void Main(string[] args)
        {
            //byte is unsigned 8 bit length datatype(Range: 0-255)
            byte b = 75;//1000001

            //Char is a 2 byte length datatype which can contain unicode data
            char c = 'K';

            //series of char data
            string s = "KLM";

            //Numbers without decimals
            //16 bit signed numeric(Range: -32768 - 32767)
            //Int16 and short are same
            Int16 n16 = 123;
            short nshort16 = 123;

            //32 bit signed numeric(Range: -2147483648 - 2147483647)
            //Int32 and int are same
            Int32 n32 = 234;
            int nint32 = 234;

            //64 bit signed numeric(Range: -9223372036854775808 - 9223372036854775807)
            //Int64 and long are same
            Int64 n64 = 456;
            long nlong64 = 234;

            //16 bit unsigned numeric(Range: 0 - 65535)
            //UInt16 and ushort are same
            UInt16 un16 = 123;
            ushort unshort16 = 123;

            //32 bit unsigned numeric(Range: 0 - 4294967295)
            //UInt32 and uint are same
            UInt32 un32 = 234;
            uint unint32 = 234;

            //64 bit unsigned numeric(Range: 0 - 18446744073709551615)
            //UInt64 and ulong are same
            UInt64 un64 = 456;
            ulong unlong64 = 234;

            //Numbers with decimals
            float f = 0.123456789f;// precision: 7
            double d = 0.123456789012345678;// 16 precision
            decimal dec = 0.123456789012345678M;//29 precision

        }
    }
}
