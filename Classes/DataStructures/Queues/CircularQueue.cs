﻿using DataStructuresAndAlgorithms_InCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms_InCSharp.Classes.Queues
{
    internal class CircularQueue<T> : ImethodQueues<T>
    {
        private T[] myCircularQueue;
        private int front;
        private int rear;
        private int capacity;

        public CircularQueue(int size)
        {
            myCircularQueue = new T[size];
            capacity = size;
            front = rear = -1;
        }

        public void Enqueue(T? value)
        {
            if (IsEmpty())
            {
                front = rear = 0;
                myCircularQueue[rear] = value;
                Console.WriteLine($"Enqueued: {value}");
                return;
            }

            if ((rear + 1) % capacity == front)
            {
                Console.WriteLine("Circular Queue is full. Unable to enqueue.");
                MessageBox.Show("Circular Queue is full. Unable to enqueue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            rear = (rear + 1) % capacity;
            myCircularQueue[rear] = value;
            Console.WriteLine($"Enqueued: {value}");
        }
        public void Enqueue(T? value, int capacity)
        {

        }
        public void EnqueueRear(T value)
        {
            
        }

        public void Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Circular Queue is empty. Unable to dequeue.");
                MessageBox.Show("Circular Queue is full. Unable to enqueue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (front == rear)
            {
                Console.WriteLine($"Dequeued: {myCircularQueue[front]}");
                front = rear = -1;
                return;
            }

            Console.WriteLine($"Dequeued: {myCircularQueue[front]}");
            front = (front + 1) % capacity;
        }

        public void DequeueRear()
        {

        }

        public void Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Circular Queue is empty. No elements to peek.");
                MessageBox.Show("Circular Queue is empty. No elements to peek.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Console.WriteLine($"Front element: {myCircularQueue[front]}");
            MessageBox.Show($"Front element: {myCircularQueue[front]}", "-*-*-*-", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void PeekRear()
        {

        }

        public IEnumerable<string> Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Circular Queue is empty.");
                MessageBox.Show("Circular Queue is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                yield break;
            }

            Console.Write("Circular Queue elements: ");
            int i = front;
            do
            {
                yield return myCircularQueue[i] + "";
                Console.Write($"{myCircularQueue[i]} ");
                i = (i + 1) % capacity;
            } while (i != (rear + 1) % capacity);
            Console.WriteLine();
        }

        public int Count()
        {
            if (IsEmpty())
            {
                return 0;
            }
            
            if (front <= rear)
            {
                return rear - front + 1;
            }

            return capacity - front + rear + 1;
        }

        public bool IsEmpty()
        {
            return front == -1 && rear == -1;
        }

    }
}
