﻿using DataStructuresAndAlgorithms_InCSharp.Classes.Nodes;
using Listas.Interfaces;
using System;

namespace DataStructuresAndAlgorithms_InCSharp.Classes.Lists
{
    public class DoublyListLinked<T> : ImethodLists<T>
    {
        private DoubleNode<T> Head { get; set; }
        private DoubleNode<T> LastNode { get; set; }

        public DoublyListLinked()
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
                return;
            }

            // Case 2: Prevent duplicate data
            if (Exist(NewNode.Data))
            {
                return;
            }

            // Case 3: The new data is inserted at the beginning
            if (NewNode.CompareTo(Head) <= 0)
            {
                Head.Back = NewNode;
                NewNode.Next = Head;
                Head = NewNode;
                return;
            }

            // Case 4: The new data is inserted at the end
            if (NewNode.CompareTo(LastNode) >= 0)
            {
                LastNode.Next = NewNode;
                NewNode.Back = LastNode;
                LastNode = NewNode;
                return;
            }

            // Case 5: Traverse the lists
            DoubleNode<T> CurrentNode = Head;
            while (CurrentNode.Next != null && CurrentNode.Next.CompareTo(NewNode) <= 0)
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

            // Case 2: The data to delete is at the beginning of the lists
            if (Head.CompareTo(data) == 0)
            {
                Head = Head.Next;
                Head.Back = null;
                Console.WriteLine($"- Data[{data}] deleted from the lists");
                return;
            }

            // Case 3: The data to delete is at the end of the lists
            if (LastNode.CompareTo(data) == 0)
            {
                LastNode = LastNode.Back;
                LastNode.Next = null;
                Console.WriteLine($"- Data[{data}] deleted from the lists");
                return;
            }

            // Case 4: Traverse the lists
            DoubleNode<T> CurrentNode = Head;
            while (CurrentNode.Next != null && CurrentNode.CompareTo(data) < 0)
            {
                CurrentNode = CurrentNode.Next;
            }

            // Case 5: The data is at X position in the lists
            if (CurrentNode.CompareTo(data) == 0 )
            {
                CurrentNode.Back.Next = CurrentNode.Next;
                CurrentNode.Next.Back = CurrentNode.Back;
                Console.WriteLine($"- Data[{data}] deleted from the lists");
                return;
            }

            // Case 6: The data was not found
            Console.WriteLine($"- Data[{data}] does not exist/deleted from the lists");
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
            if (Head.CompareTo(data) == 0 && Head.Equals(data))
            {
                Console.WriteLine($"- Data[{data}] exists in the lists");
                MessageBox.Show(Head.ToString(), "Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Case 3: If the data is at the end
            if (LastNode.CompareTo(data) == 0 && LastNode.Equals(data))
            {
                Console.WriteLine($"- Data[{data}] exists in the lists");
                MessageBox.Show(LastNode.ToString(), "Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Case 4: Traverse the lists
            DoubleNode<T> CurrentNode = Head;
            while (CurrentNode.Next != null && CurrentNode.CompareTo(data) < 0)
            {
                CurrentNode = CurrentNode.Next;
            }

            // Case 5: If the data exists at X position
            if (CurrentNode.CompareTo(data) == 0 && CurrentNode.Equals(data))
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
            Console.WriteLine("=== My Doubly Linked List ===");
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
                Console.WriteLine("Empty lists");
                yield break;
            }

            // Case 2: Traverse the lists
            DoubleNode<T> CurrentNode = LastNode;
            int i = 0;
            Console.WriteLine("=== My Reversed Doubly Linked List ===");
            do
            {
                Console.WriteLine($"- Node[{i}] and data: " + CurrentNode.Data is Person ? CurrentNode.Data.ToString() : CurrentNode.Data);
                yield return CurrentNode.Data;
                CurrentNode = CurrentNode.Back;
                i++;
            } while (CurrentNode != null);
        }

        public bool Exist(T data)
        {
            // Case 1: If the lists is empty
            if (IsEmpty())
            {
                Console.WriteLine("Empty lists");
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
            while (CurrentNode.Next != null && CurrentNode.CompareTo(data) < 0)
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