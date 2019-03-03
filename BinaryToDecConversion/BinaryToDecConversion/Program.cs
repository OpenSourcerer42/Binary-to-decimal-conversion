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
            //Prompts for user input to choose either decimal to binary or binary to decimal
            Console.WriteLine("Convert decimal to binary(1) or convert binary to decimal(2)");
            int ans = int.Parse(Console.ReadLine());
            int num = 0;
            int binaryNum = 0;
            if (ans == 1)
            {
                //prompts user for a decimal value to convert
                Console.WriteLine("enter a decimal to convert to binary");
                num = int.Parse(Console.ReadLine());
                DecimalConversion(num);
            }
            else if (ans == 2)
            {
                //prompts user for a binary value to convert
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
                //divides decimal value by 2 until 0, stores remainder in string result and outputs to console
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
            string binaryString = Convert.ToString(binaryNum);
            double power = 0;
            //array for all powers needed for calculation based on num of binary values
            string[] powerArray = new string[binaryString.Length];

            for (int i = 0; i < binaryString.Length; i++)
            {
                //stores each power needed in the array
                powerResult = Math.Pow(2.0, power);
                power += 1;
                powerArray[i] = Convert.ToString(powerResult);
            }

            Array.Reverse(powerArray);
            // 16-8-4-2-0 instead of 0-2-4-8-16
            int result = 0;
            int pow = 0;
            for (int j = 0; j < powerArray.Length; j++)
            {
                //compare the array of power results to the binary values, if value = 1 add power result and store in integer to print
                if (binaryString[j] == '1')
                {
                    pow = int.Parse(powerArray[j]);
                    result += pow;
                }
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
