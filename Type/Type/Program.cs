using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type
{
    class Program
    {
        static void Type(string arg, object obj, string type)
        {
            sbyte sbytevalue;
            byte bytevalue;
            short shortvalue;
            ushort ushortvalue;
            uint uintvalue;
            int intvalue;
            long longvalue;
            ulong ulongvalue;
            double doublevalue;
            float floatvalue;
            char chartvalue;

            bool typesbyte = sbyte.TryParse(arg, out sbytevalue);
            bool typebyte = byte.TryParse(arg, out bytevalue);
            bool typeshort = short.TryParse(arg, out shortvalue);
            bool typeushort = ushort.TryParse(arg, out ushortvalue);
            bool typeuint = uint.TryParse(arg, out uintvalue);
            bool typeint = int.TryParse(arg, out intvalue);
            bool typeulong = ulong.TryParse(arg, out ulongvalue);
            bool typelong = long.TryParse(arg, out longvalue);
            bool typefloat = float.TryParse(arg, out floatvalue);
            bool typedouble = double.TryParse(arg, out doublevalue);
            bool typechar = char.TryParse(arg, out chartvalue);

            switch (true)
            {
                case true when typesbyte:
                    obj = sbytevalue.GetType();
                    break;
                case true when typebyte:
                    obj = bytevalue.GetType();
                    break;
                case true when typeushort:
                    obj = shortvalue.GetType();
                    break;
                case true when typeshort:
                    obj = shortvalue.GetType();
                    break;
                case true when typeuint:
                    obj = uintvalue.GetType();
                    break;
                case true when typeint:
                    obj = intvalue.GetType();
                    break;
                case true when typeulong:
                    obj = ulongvalue.GetType();
                    break;
                case true when typelong:
                    obj = longvalue.GetType();
                    break;
                case true when typefloat:
                    obj = floatvalue.GetType();
                    break;
                case true when typedouble:
                    obj = doublevalue.GetType();
                    break;
                case true when typechar:
                    obj = chartvalue.GetType();
                    break;
                default:
                    obj = arg.GetType();
                    break;
            }
            type = obj.ToString();
            Console.WriteLine($"{arg} is {type}");

        }
        static void Main(string[] args)
        {
            string type = "";
            object obj = "";
            string stringvalue = Console.ReadLine();
            Type(stringvalue, obj, type);

            
            
            

        }
    }
}
