using System;

namespace number_fits
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = Console.ReadLine();
            string message = "";
            bool fits = false;
            try
            {
                sbyte data1 = sbyte.Parse(data);
                message += "* sbyte\n";
                fits = true;
            }
            catch 
            {

                
            }
            try
            {
                byte data1 = byte.Parse(data);
                message += "* byte\n";
                fits = true;
            }
            catch 
            {

                
            }
            try
            {
                short data1 = short.Parse(data);
                message += "* short\n";
                fits = true;
            }
            catch 
            {

                
            }
            try
            {
                ushort data1 = ushort.Parse(data);
                message += "* ushort\n";
                fits = true;
            }
            catch 
            {

                
            }
            try
            {
                int data1 = int.Parse(data);
                message += "* int\n";
                fits = true;
            }
            catch 
            {

                
            }
            try
            {
                uint data1 = uint.Parse(data);
                message += "* uint\n";
                fits = true;
            }
            catch 
            {

                
            }
            try
            {
                long data1 = long.Parse(data);
                message += "* long\n";
                fits = true;
            }
            catch 
            {

               
            }
            if (fits)
            {
                Console.WriteLine($"{data} can fit in:");
                Console.Write(message);
            }
            else
            {
                Console.WriteLine($"{data} can't fit in any type");
            }
        }
    }
}
