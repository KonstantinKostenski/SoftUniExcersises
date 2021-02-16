using System;
using System.Linq;

namespace arrays_excersises
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayText1 = Console.ReadLine().Split(" ").ToArray();
            string[] arrayText2 = Console.ReadLine().Split(" ").ToArray();
            int counter1 = 0;
            int counter2 = 0;
            string commonEnd1 = "";
            string commonEnd2 = "";

            for (int j = 0; j < arrayText1.Length; j++)
            {
                for (int k = 0; k < arrayText2.Length; k++)
                {
                    string element1 = arrayText1[j];
                    string element2 = arrayText2[k];
                    if (element1 == element2)
                    {
                        commonEnd1 += arrayText1[j];
                        counter1++;
                    }
                }
            }
            for (int j = arrayText1.Length - 1; j >= 0; j--)
            {
                for (int k = arrayText2.Length - 1; k >= 0; k--)
                {
                    string elementBackwards1 = arrayText1[j];
                    string elementBackwards2 = arrayText2[k];
                    if (elementBackwards1 == elementBackwards2)
                    {
                        commonEnd2 += arrayText1[j];
                        counter2++;
                    }
                }
            }
            if (counter1 > counter2)
            {
                Console.WriteLine($"The largest common end is {commonEnd1}");
            }
            else if (counter2 > counter1)
            {
                Console.WriteLine($"The largest common end is {commonEnd2}");
            }
            else
            {
                Console.WriteLine("No common wordds at the left or right");
            }
        }
    }
}
