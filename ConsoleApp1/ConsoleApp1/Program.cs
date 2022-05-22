using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = {1,2,1};
            int[] secondArray = { 3, 2 };
            List<int> list = new List<int>();
            ConvertToList(firstArray,list);
            ConvertToList(secondArray, list);
            RemoveDoubles(list);
            ShowList(list);
        }

        static void ConvertToList(int [] arrayToConvert, List<int> list)
        {
            for (int i = 0; i < arrayToConvert.Length; i++)
            {
                list.Add(arrayToConvert[i]);
            }
        }

        static void RemoveDoubles(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i+1; j < list.Count; j++)
                {
                    if (list[i] == list[j])
                    {
                        list.RemoveAt(j);
                    }
                }
            }
        }

        static void ShowList(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}