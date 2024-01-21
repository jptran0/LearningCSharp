using System;

namespace VarsAndData
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare some basic value type variables
            int i = 10;
            float f = 2.0f;
            decimal d = 10.0m;
            bool b = true;
            char c = 'c';

            // Declare a string - it's a collection of characters
            string str = "a string";

            // Declare an implicit variable
            var x = 10;
            var z = "Hello!";

            // TODO: Declare an array of values
            // specify the data type, then specify that it's an array with [], then give the variable a name, the '=' to assign it a value, new int, then declare how many you want (5)
            int[] vals = new int[5]; // this is a new array with 5 integers in it

            string[] strs = {"one", "two", "three"}; // if you already know what values you want in the array you can just name them inside `{}`

            // TODO: Print the values using a Formatting String
            // in brackets are placemarkers, which will be filled with the following variables outside the quotes
            // Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7}",i,c,b,str,f,d,x,z);


            // TODO: "null" means "no value"
            object obj = null;
            // Console.WriteLine(obj);


            // TODO: Implicit conversion between types
            // long is a very large integer
            // we can implicitly convert i to a long because int and long are both integer types
            long bignum;
            bignum = i;

            // TODO: Explicit conversions
            // to explicitly convert you must include the datatype before it in parantheses 
            float i_to_f = (float)i;
            Console.WriteLine("{0}",i_to_f);

            int f_to_i = (int)f;
            Console.WriteLine("{0}", f_to_i);

        }
    }
}
