using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = new List<int>();
            firstList.Add(1);
            firstList.Add(2);
            firstList.Add(1);
            List<int> secondList = new List<int>();
            secondList.Add(3);
            secondList.Add(2);
            CompareList(firstList, secondList);
            CombineList(firstList, secondList);
            ShowList(firstList);
        }

        static void CompareList(List<int> firstList, List<int> secondList)
        {
            firstList = ChekList(firstList);
            secondList = ChekList(secondList);

            for (int i = 0; i < secondList.Count; i++)
            {
                for (int j = 0; j < secondList.Count; j++)
                {
                    if (firstList[i] == secondList[j])
                    {
                        secondList.RemoveAt(j);
                    }
                }
            }
        }

        static List<int> ChekList(List<int> listForCheck)
        {

            for (int i = 0; i < listForCheck.Count; i++)
            {
                for (int j = i+1; j < listForCheck.Count; j++)
                {
                    if (listForCheck[i] == listForCheck[j])
                    {
                        listForCheck.RemoveAt(j);
                    }
                }
            }

            return listForCheck;
        }

        static void CombineList(List<int> firstList, List<int> secondList)
        {
            for (int i = 0; i < secondList.Count; i++)
            {
                firstList.Add(secondList[i]);
            }
        }

        static void ShowList(List<int> firstList)
        {
            for (int i = 0; i < firstList.Count; i++)
            {
                Console.WriteLine(firstList[i]);
            }
        }
    }
}