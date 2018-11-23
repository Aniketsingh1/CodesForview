using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class CandidateCode
{

    static void GetEvenAndOddNumbers(int[] evenArr)
    {
        int sumEven = 0;
        int sumOdd = 0;
        foreach (var item in evenArr)
        {
            if (item % 2 == 0)
            {
                sumEven += item;
            }
            else
            {
                sumOdd += item;
            }

        }
        PrintResult(sumEven, sumOdd);
    }

    static void PrintResult(int resultEven, int resultOdd)
    {
        if (resultEven > resultOdd)
        {
            Console.Write("Even");
        }
        else if (resultEven == resultOdd)
        {
            Console.Write("Tied");
        }
        else
        {
            Console.Write("odd");
        }
        Console.ReadLine();

    }



    static void Main(String[] args)
    {
        int i = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[i];
        for (int j = 0; j < arr.Length; j++)
        {
            arr[j] = Convert.ToInt32(Console.ReadLine());
        }
        GetEvenAndOddNumbers(arr);
    }
}
