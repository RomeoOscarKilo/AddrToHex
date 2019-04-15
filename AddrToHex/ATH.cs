using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATX
{
    class ATH
    {
        static void Main()
        {
            Console.Write("Please enter the hex offset: ");
            string input = Console.ReadLine();
            if(input.Length % 2  == 1)
            {
                input = "0" + input;
            }
            char[] address = input.ToCharArray();
            string output = "";
            for(int i = address.Length; i > 0; i -=2 )
            {
                output += "\\";
                output += @"x" + address[i - 2];
                output += address[i - 1];
            }
            Console.WriteLine(output);
            Main();
        }
    }
}
