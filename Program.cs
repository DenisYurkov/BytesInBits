using System;

namespace ByteInBits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Byte In Bits---");
            Console.Write("Write bytes: ");
           
            int bytes = Convert.ToInt32(Console.ReadLine());
            int bits = 0;

            if (bytes != 0)
            {
                if (bytes == 1)
                {
                    bits = 8;
                    Console.WriteLine("{0} Bytes: {1} Bits.", bytes, bits);
                    Console.ReadLine(); // does not close the application until the user presses enter.
                }
                else 
                {
                    bits = 8;
                    bits *= bytes;
                    Console.WriteLine("{0} Bytes: {1} Bits.", bytes, bits);
                    Console.ReadLine(); // does not close the application until the user presses enter.
                }
            }
        }
    }
}
