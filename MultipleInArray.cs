using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class CandidateCode
{

    static void PrintMajorityInArray(int[] evenArr)
    {

        int retVal, valp = 0;
        decimal v = evenArr.Length;
        decimal n = v / 2;
        n = Math.Ceiling(n);
        int[] comapreArray = evenArr;
        foreach (var item in evenArr)
        {
            var element = item;
            retVal = CountOfNumber(element, comapreArray);
            if (retVal == n)
            {
                valp = item;
            }


        }
        if (valp != 0)
        {
            Console.Write(valp);
        }
        else
        {
            Console.Write(-1);
        }

        Console.ReadLine();
    }

    static int CountOfNumber(int varM, int[] compArr)
    {
        int count = 0;
        int temp = 0;
        foreach (var e in compArr)
        {
            if (e == varM)
            {
                temp = e;
                count++;
            }

        }
        return count;
    }
    static void Main(String[] args)
    {
        int i = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[i];
        for (int j = 0; j < arr.Length; j++)
        {
            arr[j] = Convert.ToInt32(Console.ReadLine());
        }
        PrintMajorityInArray(arr);
    }
}
