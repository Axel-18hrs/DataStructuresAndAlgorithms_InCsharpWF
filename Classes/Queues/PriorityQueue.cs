
using DataStructuresAndAlgorithms_InCSharp.Classes.Operations;
using DataStructuresAndAlgorithms_InCSharp.Interfaces;

namespace DataStructuresAndAlgorithms_InCSharp.Classes.Queues
{
    internal class PriorityQueue<T> : ImethodQueues<T>
    {
        private SortedDictionary<int, Queue<T>> myPriorityQueue = new SortedDictionary<int, Queue<T>>();

        public void Enqueue(T? value, int priority)
        {
            if (!myPriorityQueue.ContainsKey(priority))
            {
                myPriorityQueue[priority] = new Queue<T>();
            }

            myPriorityQueue[priority].Enqueue(value);

            Console.WriteLine($"Enqueued with priority {priority}: {value}");
        }
        public void Enqueue(T? value)
        {

        }
        public void EnqueueRear(T? priority)
        {

        }

        public void Dequeue()
        {
            if (myPriorityQueue.Count > 0)
            {
                var highestPriority = myPriorityQueue.First();
                var value = highestPriority.Value.Dequeue();

                if (highestPriority.Value.Count == 0)
                {
                    myPriorityQueue.Remove(highestPriority.Key);
                }

                Console.WriteLine($"Dequeued with priority {highestPriority.Key}: {value}");
                return;
            }

            Console.WriteLine("Priority Queue is empty. Unable to dequeue.");
            MessageBox.Show("Priority Queue is empty. Unable to dequeue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void DequeueRear()
        {

        }

        public void Peek()
        {
            if (myPriorityQueue.Count > 0)
            {
                var highestPriority = myPriorityQueue.First();
                var value = highestPriority.Value.Peek();

                Console.WriteLine($"Front element with priority {highestPriority.Key}: {value}");
                MessageBox.Show($"Front element with priority {highestPriority.Key}: {value}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Console.WriteLine("Priority Queue is empty. No elements to peek.");
            MessageBox.Show("Priority Queue is empty. No elements to peek.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void PeekRear()
        {

        }

        public IEnumerable<string> Display()
        {
            Console.Write("Priority Queue elements: ");
            foreach (var priorityGroup in myPriorityQueue)
            {
                foreach (var item in priorityGroup.Value)
                {
                    yield return $"{item} (Priority {priorityGroup.Key}) ";
                    Console.Write($"{item} (Priority {priorityGroup.Key}) ");
                }
            }
            Console.WriteLine();
        }

        public int Count()
        {
            return myPriorityQueue.Sum(priorityGroup => priorityGroup.Value.Count);
        }
    }
}
