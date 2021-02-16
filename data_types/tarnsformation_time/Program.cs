using System;
using System.Numerics;

namespace tarnsformation_time
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            long days = (long)Math.Floor(years * 365.2422);
            ulong hours = (ulong)days * 24;
            ulong minutes = hours * 60;
            ulong seconds = minutes * 60;
            BigInteger millieseconds = seconds * 1000;
            BigInteger microseconds = millieseconds * 1000;
            BigInteger nanoseconds = microseconds * 1000;
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {millieseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");



        }
    }
}
