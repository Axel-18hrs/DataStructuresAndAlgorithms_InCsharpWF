using DataStructuresAndAlgorithms_InCSharp.Interfaces;

namespace DataStructuresAndAlgorithms_InCSharp.Classes.Queues
{
    internal class RegularQueue<T> : ImethodQueues<T>
    {
        private Queue<T> myQueue = new Queue<T>();

        public void Enqueue(T? value)
        {
            myQueue.Enqueue(value);
            Console.WriteLine($"Enqueued: {value}");
        } 

        public void Enqueue(T value, int count)
        {

        }

        public void EnqueueRear(T? value)
        {

        }

        public void Dequeue()
        {
            if (myQueue.Count > 0)
            {
                T value = myQueue.Dequeue();
                Console.WriteLine($"Dequeued: {value}");
                return;
            }

            Console.WriteLine("Queue is empty. Unable to dequeue.");
            MessageBox.Show("Queue is empty. Unable to dequeue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void DequeueRear()
        {

        }

        public void Peek()
        {
            if (myQueue.Count > 0)
            {
                T frontValue = myQueue.Peek();
                Console.WriteLine($"Front element: {frontValue}");
                MessageBox.Show($"Front element: {frontValue}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Console.WriteLine("Queue is empty. No elements to peek.");
            MessageBox.Show("Queue is empty. No elements to peek.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void PeekRear()
        {

        }

        public IEnumerable<string> Display()
        {
            Console.Write("Queue elements: ");
            foreach (var item in myQueue)
            {
                yield return item + "";
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        public int Count()
        {
            return myQueue.Count;
        }

    }
}
