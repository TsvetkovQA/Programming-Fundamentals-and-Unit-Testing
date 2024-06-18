using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        int[] array1 = ReadArray();

       
        int[] array2 = ReadArray();

        
       
        FindCommonElements(array1, array2);
    }

    static int[] ReadArray()
    {
        string[] input = Console.ReadLine().Split();
        int[] array = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            array[i] = int.Parse(input[i]);
        }
        return array;
    }

    static void FindCommonElements(int[] arr1, int[] arr2)
    {
        HashSet<int> commonElements = new HashSet<int>(arr1);
        commonElements.IntersectWith(arr2);
        foreach (int element in commonElements)
        {
            Console.Write(element + " ");
        }
    }
}