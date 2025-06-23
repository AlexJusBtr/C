namespace CallCenter
{
    class CallCenter
    {
        static void Main()
        {
            Queue<string> callQueue = new Queue<string>();
            callQueue.Enqueue("Alice");
            callQueue.Enqueue("Bob");
            callQueue.Enqueue("Charlie");
            Console.WriteLine($"Now serving: {callQueue.Dequeue()}");
            Console.WriteLine("Pending calls:");
            foreach (var caller in callQueue)
            {
                Console.WriteLine(caller);
            }
        }
    }
    /*/class Program
    {
        static void Main()
        {
            Queue<string> tasks = new Queue<string>();
            tasks.Enqueue("Task1");
            tasks.Enqueue("Task2");
            tasks.Enqueue("Task3");
            Console.WriteLine("Processing: " + tasks.Dequeue()); // Dequeues Task1
            Console.WriteLine("Processing: " + tasks.Dequeue()); // Dequeues Task2
        }
    }/*/
}
