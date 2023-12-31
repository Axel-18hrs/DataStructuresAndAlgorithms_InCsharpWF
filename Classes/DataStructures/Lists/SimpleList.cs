using DataStructuresAndAlgorithms_InCSharp.Classes.Nodes;
using Listas.Interfaces;
using System;
using System.Collections.Generic;

namespace DataStructuresAndAlgorithms_InCSharp.Classes.Lists
{
    public class SimpleList<T> : ImethodLists<T>
    {
        private static Node<T> Head { get; set; }
        private static Random r;

        public SimpleList()
        {
            Clear();
            r = new Random();
        }

        public void Add(T data)
        {
            // Case 0: Create a new node
            Node<T> NewNode = new Node<T>(data);

            // Case 1: Insert at the beginning
            if (IsEmpty())
            {
                Head = NewNode;
                return;
            }

            // Case 2: Prevent duplicate data
            if (Exist(NewNode.Data))
            {
                return;
            }

            // Case 3: Insert the data at the beginning of the lists
            if (NewNode.CompareTo(Head) <= 0)
            {
                NewNode.Next = Head;
                Head = NewNode;
                return;
            }

            // Case 4: Traverse the lists
            Node<T> CurrentNode = Head;
            while (CurrentNode.Next != null && CurrentNode.Next.CompareTo(NewNode) <= 0)
            {
                CurrentNode = CurrentNode.Next;
            }

            // Case 5: Insert at X position or at the end of the lists
            NewNode.Next = CurrentNode.Next;
            CurrentNode.Next = NewNode;
        }

        public void Delete(T data)
        {
            // Case 1: If the lists is empty
            if (IsEmpty())
            {
                Console.WriteLine("Empty lists.");
                return;
            }

            // Case 2: If the data is at the beginning
            if (Head.CompareTo(data) == 0 && Head.Equals(data))
            {
                Head = Head.Next;
                Console.WriteLine($"- Data[{data}] deleted from the lists");
                return;
            }

            // Case 3: Traverse the lists
            Node<T> CurrentNode = Head;
            while (CurrentNode.Next != null && !object.Equals(CurrentNode.Next.Data, data))
            {
                CurrentNode = CurrentNode.Next;
            }

            // Case 4: If the data is at X position
            if (CurrentNode.Next != null && object.Equals(CurrentNode.Next.Data, data))
            {
                CurrentNode.Next = CurrentNode.Next.Next;
                Console.WriteLine($"- Data[{data}] deleted from the lists");
                return;
            }

            // Case 5: The data was not found
            Console.WriteLine($"- Data[{data}] not found/deleted from the lists");
        }

        public void Search(T data)
        {
            // Case 1: If the lists is empty
            if (IsEmpty())
            {
                Console.WriteLine("Empty lists.");
                MessageBox.Show("The lists is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Case 2: If the data is at the beginning
            if (Head.CompareTo(data) == 0)
            {
                Console.WriteLine($"- Data[{data}] exists in the lists");
                MessageBox.Show(Head.ToString(), "Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Case 3: Traverse the lists
            Node<T> CurrentNode = Head;
            while (CurrentNode.Next != null && CurrentNode.Next.CompareTo(data) <= 0)
            {
                CurrentNode = CurrentNode.Next;
            }

            // Case 4: If the data is at X position
            if (CurrentNode.CompareTo(data) == 0)
            {
                Console.WriteLine($"- Data[{data}] exists in the lists");
                MessageBox.Show(Head.ToString(), "Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Case 5: The data does not exist
            Console.WriteLine($"- Data[{data}] does not exist in the lists ");
            MessageBox.Show("Does not exist in the lists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public IEnumerable<T> Show()
        {
            // Case 1: If the lists is empty
            if (IsEmpty())
            {
                Console.WriteLine("Empty lists.");
                yield break;
            }

            // Case 2: Traverse the lists
            int i = 0;
            Node<T> CurrentNode = Head;
            Console.WriteLine("=== My simple lists ===");
            while (CurrentNode != null)
            {
                Console.WriteLine($"- Node[{i}] and data: " + CurrentNode.Data is Person ? CurrentNode.Data.ToString() : CurrentNode.Data);
                yield return CurrentNode.Data;
                CurrentNode = CurrentNode.Next;
                i++;
            }
        }

        public IEnumerable<T> ShowRevers()
        {
            // Case 1: If the lists is empty
            if (IsEmpty())
            {
                Console.WriteLine("Empty lists.");
                yield break;
            }

            Stack<T> stack = new Stack<T>();
            Node<T> CurrentNode = Head;

            int i = 0;
            while (CurrentNode != null)
            {
                i++;
                stack.Push(CurrentNode.Data);
                
                CurrentNode = CurrentNode.Next;
            }

            T[] stackArray = stack.ToArray();

            foreach (T node in stackArray)
            {
                yield return node;
                Console.WriteLine($"- Node[{--i}] and data: " + node.ToString());
            }
        }

        public bool Exist(T data)
        {
            // Case 1: If the lists is empty
            if (IsEmpty())
            {
                return false;
            }

            // Case 2: If the first node contains the data
            if (Head.CompareTo(data) == 0 && object.Equals(Head.Data, data))
            {
                return true;
            }

            // Case 3: Start traversing the lists
            Node<T> CurrentNode = Head;
            while (CurrentNode.Next != null && CurrentNode.CompareTo(data) < 0)
            {
                CurrentNode = CurrentNode.Next;
            }

            // Case 4: The data exists in the last element
            if (CurrentNode.CompareTo(data) == 0 && object.Equals(CurrentNode.Data, data))
            {
                return true;
            }

            // Case 5: The data does not exist in the lists
            return false;
        }

        public bool IsEmpty()
        {
            return Head == null;
        }

        public void Clear()
        {
            Head = null;
        }
    }
}