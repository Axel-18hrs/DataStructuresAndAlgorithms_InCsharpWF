﻿using DataStructuresAndAlgorithms_InCSharp.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms_InCSharp.Classes.Stacks
{
    public class StaticStack<T> : ImethodStacks<T>
    {
        private T[] elements;
        private int capacity;
        private int count;

        public StaticStack(int capacity)
        {
            this.capacity = capacity;
            elements = new T[capacity];
            count = 0;
        }

        public void Push(T? element)
        {
            if (count < capacity)
            {
                elements[count] = element;
                count++;
                return;
            }
            Console.WriteLine("The stack is full. Cannot add more elements.");
            MessageBox.Show("The stack is full. Cannot add more elements.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public T Pop()
        {
            if (count > 0)
            {
                count--;
                T element = elements[count];
                elements[count] = default(T);
                return element;
            }

            Console.WriteLine("The stack is empty. Cannot pop more elements.");
            MessageBox.Show("The stack is empty. Cannot pop more elements.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return default;
        }

        public T Peek()
        {
            if (count > 0)
            {
                return elements[count - 1];
            }

            Console.WriteLine("The stack is empty. No elements to peek.");
            MessageBox.Show("The stack is empty. No elements to peek.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return default(T);
        }
        public int Count()
        {
            return count;
        }
        public IEnumerable<T> Show()
        {
            Console.WriteLine("\nElements in the stack:");
            for (int i = count - 1; i >= 0; i--)
            {
                yield return elements[i];
                Console.WriteLine(elements[i]);
            }
        }
    }
}
