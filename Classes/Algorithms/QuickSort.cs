﻿using DataStructuresAndAlgorithms_InCSharp.Interfaces.Algorithms;
using System;
using System.Collections.Generic;

namespace DataStructuresAndAlgorithms_InCSharp.Classes.Algorithms
{
    public class QuickSort : ImethodAlgorithms
    {
        private static Random _Random = new Random();

        private static int _Option, _ContainExchange, _ContainPartition, _ContainRecursive;

        public QuickSort() { }

        private static void Swap(ref int IndexOne, ref int IndexTwo)
        {
            int Temporary = IndexOne;
            IndexOne = IndexTwo;
            IndexTwo = Temporary;
        }
        
        public void Sort(int[] arr, ListBox listBX)
        {
            Quicksort(ref arr, 0, arr.Length - 1, listBX);
        }

        public void Sort(double[] arr) 
        {

        }

        private int Partition(ref int[] Array, int FirstIndex, int LastIndex, ListBox listBX)
        {
            _ContainPartition++;
            int IndexPivot;
            switch (_Option)
            {
                case 1:
                    IndexPivot = FirstIndex;
                    break;

                case 2:
                    IndexPivot = (int)Math.Floor((double)(LastIndex + FirstIndex) / 2);
                    break;

                case 3:
                    IndexPivot = LastIndex;
                    break;

                default:
                    IndexPivot = _Random.Next(FirstIndex, LastIndex);
                    break;
            }
            Swap(ref Array[FirstIndex], ref Array[IndexPivot]);

            PrintSwap(ref Array, FirstIndex, IndexPivot, listBX);
            _ContainExchange++;
            int Pivot = Array[FirstIndex];
            int Left = FirstIndex + 1;
            int Right = LastIndex;
            while (true)
            {
                while (Left <= Right && Array[Left] <= Pivot)
                {
                    Left += 1;
                }
                while (Left <= Right && Array[Right] >= Pivot)
                {
                    Right -= 1;
                }
                if (Right < Left)
                {
                    break;
                }
                Swap(ref Array[Left], ref Array[Right]);
                PrintSwap(ref Array, Left, Right, listBX);
                _ContainExchange++;
                Left += 1;
                Right -= 1;
            }
            Swap(ref Array[FirstIndex], ref Array[Right]);
            PrintSwap(ref Array, FirstIndex, Right);
            _ContainExchange++;
            return Right;
        }

        public void Quicksort(ref int[] Array, int FirstIndex, int LastIndex, ListBox listBX)
        {
            if (FirstIndex < LastIndex)
            {
                _ContainRecursive++;
                int IndexPivot = Partition(ref Array, FirstIndex, LastIndex, listBX);
                Quicksort(ref Array, FirstIndex, IndexPivot - 1, listBX);
                Quicksort(ref Array, IndexPivot + 1, LastIndex, listBX);
            }
        }

        public string Print(ref int[] arr)
        {
            return "\nResult: [ " + string.Join(", ", arr) + " ]" + "\nSwaps: " + _ContainExchange + "\nPartitions: " + _ContainPartition + "\nRecursion: " + _ContainRecursive;
        }

        private static void PrintSwap(ref int[] array, int Left, int Right, ListBox listBX)
        {
            // Crear una cadena que represente todo el array
            string arrayString = "[ ";

            for (int i = 0; i < array.Length; i++)
            {
                if (Right == i && Left == i)
                {
                    arrayString += array[i];
                }
                else if (i == Left || i == Right)
                {
                    arrayString += array[i];
                }
                else
                {
                    arrayString += array[i];
                }

                if (i < array.Length - 1)
                {
                    arrayString += ", ";
                }
            }

            arrayString += " ]";

            // Agregar la cadena al ListBox
            listBX.Items.Add(arrayString);
        }
        private void PrintSwap(ref int[] array, int Left, int Right)
        {
            Console.Write("[ ");
            for (int i = 0; i < array.Length; i++)
            {
                if (Right == i && Left == i)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write(array[i]);
                    Console.ResetColor();
                }
                else if (i == Left || i == Right)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(array[i]);
                    Console.ResetColor();
                }
                else
                {
                    Console.Write(array[i]);
                }
                if (i < array.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.Write(" ]\n");
        }

        public void Sort(int[] array)
        {
            throw new NotImplementedException();
        }

        public void Sort(double[] array, ListBox listBX)
        {
            throw new NotImplementedException();
        }
    }
}
