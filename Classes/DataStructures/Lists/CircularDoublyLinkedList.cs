﻿
using DataStructuresAndAlgorithms_InCSharp.Classes.Nodes;
using Listas.Interfaces;
using System;
using System.ComponentModel;


namespace DataStructuresAndAlgorithms_InCSharp.Classes.Lists
{
    public class CircularDoublyLinkedList<T> : ImethodLists<T>
    {
        private DoubleNode<T> Head { get; set; }
        private DoubleNode<T> LastNode { get; set; }

        public CircularDoublyLinkedList()
        {
            Clear();
        }

        public void Add(T data)
        {
            // Case 0: Create a new node
            DoubleNode<T> NewNode = new DoubleNode<T>(data);

            // Case 1: Insert at the beginning
            if (IsEmpty())
            {
                Head = NewNode;
                LastNode = NewNode;
                Head.Back = LastNode;
                LastNode.Next = Head;
                return;
            }

            // Case 2: Prevent duplicate data
            if (Exist(NewNode.Data))
            {
                Console.WriteLine("// Already exists: " + data);
                MessageBox.Show($"{NewNode.Data} exist in the lists", "-*-*-*-", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Case 3: Insert at the beginning if the data is smaller
            if (NewNode.CompareTo(Head) <= 0)
            {
                NewNode.Next = Head;
                NewNode.Back = LastNode;
                Head.Back = NewNode;
                Head = NewNode;
                LastNode.Next = Head;
                return;
            }

            // Case 4: Insert at the end if the data is larger
            if (NewNode.CompareTo(LastNode) >= 0)
            {
                LastNode.Next = NewNode;
                NewNode.Back = LastNode;
                NewNode.Next = Head;
                LastNode = NewNode;
                Head.Back = LastNode;
                return;
            }

            // Case 5: Traverse the lists
            DoubleNode<T> CurrentNode = Head;
            while (CurrentNode.Next != Head && CurrentNode.Next.CompareTo(NewNode) <= 0)
            {
                CurrentNode = CurrentNode.Next;
            }

            // Case 6: Insert at X position
            NewNode.Next = CurrentNode.Next;
            NewNode.Back = CurrentNode;
            CurrentNode.Next.Back = NewNode;
            CurrentNode.Next = NewNode;
        }

        public void Delete(T data)
        {
            // Case 1: If the lists is empty
            if (IsEmpty())
            {
                Console.WriteLine("Empty lists");
                return;
            }

            // Case 2: Delete and check if there is only one element
            if (Head.CompareTo(LastNode) == 0)
            {
                Clear();
                Console.WriteLine($"- Data[{data}] deleted from the lists");
                return;
            }

            // Case 3: The data is at the beginning of the lists
            if (Head.CompareTo(data) == 0)
            {
                Head = Head.Next;
                Head.Back = LastNode;
                LastNode.Next = Head;
                Console.WriteLine($"- Data[{data}] deleted from the lists");
                return;
            }

            // Case 4: The data is at the end of the lists
            if (LastNode.CompareTo(data) == 0)
            {
                LastNode = LastNode.Back;
                LastNode.Next = Head;
                Head.Back = LastNode;
                Console.WriteLine($"- Data[{data}] deleted from the lists");
                return;
            }

            // Case 5: Traverse the lists
            DoubleNode<T> CurrentNode = Head;
            while (CurrentNode.Next != Head && CurrentNode.Next.CompareTo(data) < 0)
            {
                CurrentNode = CurrentNode.Next;
            }

            // Case 6: The data is at X position in the lists
            if (CurrentNode.Next.CompareTo(data) == 0)
            {
                CurrentNode.Next.Next.Back = CurrentNode;
                CurrentNode.Next = CurrentNode.Next.Next;
                Console.WriteLine($"- Data[{data}] deleted from the lists");
                return;
            }

            // Case 7: The data to delete was not found
            Console.WriteLine($"- Data[{data}] Not found/deleted from the lists");
        }

        public void Search(T data)
        {
            // Case 1: If the lists is empty
            if (IsEmpty())
            {
                Console.WriteLine("Empty lists");
                MessageBox.Show("The lists is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Case 2: If the data is at the beginning
            if (Head.CompareTo(data) == 0 && object.Equals(Head.Data, data))
            {
                Console.WriteLine($"- Data[{data}] exists in the lists");
                MessageBox.Show(Head.ToString(), "Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Case 3: If the data is at the end
            if (LastNode.CompareTo(data) == 0 && object.Equals(LastNode.Data, data))
            {
                Console.WriteLine($"- Data[{data}] exists in the lists");
                MessageBox.Show(LastNode.ToString(), "Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Case 4: Traverse the lists
            DoubleNode<T> CurrentNode = Head;
            while (CurrentNode.Next != Head && CurrentNode.Next.CompareTo(data) < 0)
            {
                CurrentNode = CurrentNode.Next;
            }

            // Case 5: If the data exists in the lists
            if (CurrentNode.CompareTo(data) == 0 && object.Equals(CurrentNode.Data, data))
            {
                Console.WriteLine($"- Data[{data}] exists in the lists");
                MessageBox.Show(CurrentNode.ToString(), "Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Case 6: The data does not exist in the lists
            Console.WriteLine($"- Data[{data}] Does not exist in the lists ");
            MessageBox.Show("Does not exist in the lists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public IEnumerable<T> Show()
        {
            // Case 1: If the lists is empty
            if (IsEmpty())
            {
                Console.WriteLine("Empty lists");
                yield break;
            }

            // Case 2: Traverse the lists
            DoubleNode<T> CurrentNode = Head;
            int i = 0;
            Console.WriteLine("=== My Circular Doubly Linked List ===");
            do
            {
                Console.WriteLine($"- Node[{i}] and data: " + CurrentNode.Data);
                yield return CurrentNode.Data;
                CurrentNode = CurrentNode.Next;
                i++;
            } while (CurrentNode != Head);
        }

        public IEnumerable<T> ShowRevers()
        {
            // Case 1: If the lists is empty
            if (IsEmpty())
            {
                Console.WriteLine("Empty lists");
                yield break;
            }

            // Case 2: Traverse the lists
            DoubleNode<T> CurrentNode = LastNode;
            int i = 0;
            Console.WriteLine("=== My Reversed Circular Doubly Linked List ===");
            do
            {
                Console.WriteLine($"- Node[{i}] and data: " + CurrentNode.Data);
                yield return CurrentNode.Data;
                CurrentNode = CurrentNode.Back;
                i++;
            } while (CurrentNode != LastNode);
        }

        public bool Exist(T data)
        {
            // Case 1: If the lists is empty
            if (IsEmpty())
            {
                return false;
            }

            // Case 2: If the first element already exists
            if (Head.CompareTo(data) == 0 && object.Equals(Head.Data, data))
            {
                return true;
            }

            // Case 3: If the data is at the end
            if (LastNode.CompareTo(data) == 0 && object.Equals(LastNode.Data, data))
            {
                return true;
            }

            // Case 4: Traverse the lists
            DoubleNode<T> CurrentNode = Head;
            while (CurrentNode.Next != Head && CurrentNode.Next.CompareTo(data) < 0)
            {
                CurrentNode = CurrentNode.Next;
            }

            // Case 5: The entered data exists at X position
            if (CurrentNode.CompareTo(data) == 0 && object.Equals(CurrentNode.Data, data))
            {
                return true;
            }

            // Case 6: The data does not exist in the lists
            return false;
        }

        public bool IsEmpty()
        {
            return Head == null;
        }

        public void Clear()
        {
            Head = null;
            LastNode = null;
        }
    }
}