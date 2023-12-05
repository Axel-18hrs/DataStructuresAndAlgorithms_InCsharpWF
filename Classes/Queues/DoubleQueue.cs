using DataStructuresAndAlgorithms_InCSharp.Interfaces;


namespace DataStructuresAndAlgorithms_InCSharp.Classes.Queues
{
    internal class DoubleQueue<T> : ImethodQueues<T>
    {
        private LinkedList<T> myDeque = new LinkedList<T>();

        public void Enqueue(T? value)
        {
            myDeque.AddFirst(value);
            Console.WriteLine($"Enqueued at the front: {value}");
        }
        public void Enqueue(T? value, int count)
        {

        }
        public void EnqueueRear(T? value)
        {
            myDeque.AddLast(value);
            Console.WriteLine($"Enqueued at the rear: {value}");
        }

        public void Dequeue()
        {
            if (myDeque.Count > 0)
            {
                T value = myDeque.First.Value;
                myDeque.RemoveFirst();
                Console.WriteLine($"Dequeued from the front: {value}");

                return;
            }

            Console.WriteLine("Deque is empty. Unable to dequeue from the front.");
            MessageBox.Show("Deque is empty. Unable to dequeue from the front.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void DequeueRear()
        {
            if (myDeque.Count > 0)
            {
                T value = myDeque.Last.Value;
                myDeque.RemoveLast();
                Console.WriteLine($"Dequeued from the rear: {value}");
                return;
            }

            Console.WriteLine("Deque is empty. Unable to dequeue from the rear.");
            MessageBox.Show("Deque is empty. Unable to dequeue from the front.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Peek()
        {
            if (myDeque.Count > 0)
            {
                T frontValue = myDeque.First.Value;
                Console.WriteLine($"Front element: {frontValue}");
                return;
            }

            Console.WriteLine("Deque is empty. No elements at the front to peek.");
            MessageBox.Show("Deque is empty. No elements at the front to peek.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void PeekRear()
        {
            if (myDeque.Count > 0)
            {
                T rearValue = myDeque.Last.Value;
                Console.WriteLine($"Rear element: {rearValue}");
                return;
            }

            Console.WriteLine("Deque is empty. No elements at the rear to peek.");
            MessageBox.Show("Deque is empty. No elements at the rear to peek.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public IEnumerable<string> Display()
        {
            Console.Write("Deque elements: ");
            foreach (var item in myDeque)
            {
                yield return item + "";
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        public int Count()
        {
            return myDeque.Count;
        }
    }
}
