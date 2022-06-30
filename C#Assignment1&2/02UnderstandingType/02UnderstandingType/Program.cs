// See https://aka.ms/new-console-template for more information
using System;

namespace Assignment1
{
    public class question1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("| Type \t|\tBytes of Memory \t|\t Min \t\t\t\t\t|\tMax \t\t\t\t\t|");
            Console.WriteLine($"| sbyte\t|\t {sizeof(sbyte)}\t\t\t|\t {sbyte.MinValue}\t\t\t\t\t|\t{sbyte.MaxValue} \t\t\t\t\t|");
            Console.WriteLine($"| byte \t|\t {sizeof(byte)} \t\t\t|\t {byte.MinValue} \t\t\t\t\t|\t {byte.MaxValue} \t\t\t\t\t|");
            Console.WriteLine($"| short\t|\t {sizeof(short)}\t\t\t|\t{short.MinValue}  \t\t\t\t|\t {short.MaxValue} \t\t\t\t\t|");
            Console.WriteLine($"| ushort|\t {sizeof(ushort)} \t\t\t|\t {ushort.MinValue} \t\t\t\t\t|\t {ushort.MaxValue} \t\t\t\t\t|");
            Console.WriteLine($"| int \t|\t {sizeof(int)} \t\t\t|\t {int.MinValue} \t\t\t\t|\t {int.MaxValue} \t\t\t\t|");
            Console.WriteLine($"| uint \t|\t {sizeof(uint)} \t\t\t|\t {uint.MinValue} \t\t\t\t\t|\t {uint.MaxValue} \t\t\t\t|");
            Console.WriteLine($"| long \t|\t {sizeof(long)} \t\t\t|\t {long.MinValue} \t\t\t|\t {long.MaxValue} \t\t\t|");
            Console.WriteLine($"| ulong\t|\t {sizeof(ulong)} \t\t\t|\t {ulong.MinValue} \t\t\t\t\t|\t {ulong.MaxValue} \t\t\t|");
            Console.WriteLine($"| float\t|\t {sizeof(float)} \t\t\t|\t {float.MinValue} \t\t\t\t|\t {float.MaxValue} \t\t\t\t|");
            Console.WriteLine($"| double|\t {sizeof(double)} \t\t\t|\t {double.MinValue} \t\t|\t{double.MaxValue} \t\t\t|");
            Console.WriteLine($"| decimal|\t {sizeof(decimal)} \t\t\t|\t {decimal.MinValue} \t|\t{decimal.MaxValue} \t\t|");
        }
    }
}
