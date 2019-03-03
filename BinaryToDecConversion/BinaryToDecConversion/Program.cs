using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Convert decimal to binary(1) or convert binary to decimal(2)");
            int ans = int.Parse(Console.ReadLine());
            int num = 0;
            int binaryNum = 0;
            if (ans == 1)
            {
                Console.WriteLine("enter a decimal to convert to binary");
                num = int.Parse(Console.ReadLine());
                DecimalConversion(num);
            }
            else if (ans == 2)
            {
                Console.WriteLine("enter a binary value to convert to decimal");
                binaryNum = int.Parse(Console.ReadLine());
                BinaryConversion(binaryNum);
            }
        }
        static void DecimalConversion(int dec)
        {
            string result = "";
            int remainder = 0;
            while (dec > 0)
            {
                dec /= 2;
                remainder = dec % 2;
                result += remainder;
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
        static void BinaryConversion(int binaryNum)
        {
            double powerResult = 0;
            string binaryArray = Convert.ToString(binaryNum);
            double power = 0;
            string[] resArray = new string[binaryArray.Length];

            for (int i = 0; i < binaryArray.Length; i++)
            {
                char c = binaryArray[i];
                powerResult = Math.Pow(2.0, power);
                power += 1;
                resArray[i] = Convert.ToString(powerResult);
            }

            Array.Reverse(resArray);
            int result = 0;
            int pow = 0;
            for (int j = 0; j < resArray.Length; j++)
            {
                //compare the resarray to the binary values, if value = 2 multiply by power and store in integer to print
                if (binaryArray[j] == '0')
                {
                    pow = int.Parse(resArray[j]);
                    result += pow;
                }
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
