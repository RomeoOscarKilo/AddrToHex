using System;
namespace ATX
{
    class ATH
    {
        static void Main()
        {
            Console.Write("Please enter the hex offset: ");
            string userI = Console.ReadLine();
            if(userI.Length % 2  == 1)
            {
                userI = "0" + userI;
            }
            char[] address = userI.ToCharArray();
            userI = "";
            for(int i = address.Length; i > 0; i -=2 )
            {
                userI += "\\";
                userI += @"x" + address[i - 2];
                userI += address[i - 1];
            }
            Console.WriteLine(userI);
            Main();
        }
    }
}
