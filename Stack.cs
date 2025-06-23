namespace RecentFiles
{
    class RecentFiles
    {
        static void Main()
        {
            Stack<string> recentFiles = new Stack<string>();
            HashSet<string> fileSet = new HashSet<string>();

            OpenFile(recentFiles, fileSet, "Doc1.txt");
            OpenFile(recentFiles, fileSet, "Doc2.txt");
            OpenFile(recentFiles, fileSet, "Doc1.txt"); // Reopens Doc1.txt

            Console.WriteLine("Recently Opened Files:");
            foreach (var file in recentFiles)
            {
                Console.WriteLine(file);
            }
        }
        static void OpenFile(Stack<string> stack, HashSet<string> set, string fileName)
        {
            if (set.Contains(fileName))
            {
                var tempStack = new Stack<string>();
                while (stack.Peek() != fileName)
                    tempStack.Push(stack.Pop());
                stack.Pop(); // Remove old instance
                while (tempStack.Count > 0)
                    stack.Push(tempStack.Pop());
            }
            stack.Push(fileName);
            set.Add(fileName);
        }
    }
    /*/class Program
    {
        static void Main()
        {
            Stack<string> history = new Stack<string>();

            history.Push("Page 1");
            history.Push("Page 2");
            history.Push("Page 3");
            Console.WriteLine("Back in history: " + history.Pop());  // Pops "Page 3"
            Console.WriteLine("Back in history: " + history.Pop());  // Pops "Page 2"
        }
    }/*/
    /*/
    class Program
    {
        static void Main()
        {
            Stack<int> numberStack = new Stack<int>();

            numberStack.Push(1);
            numberStack.Push(2);
            numberStack.Push(3);
            Console.WriteLine("Top element is: " + numberStack.Peek());  // Peek doesn't remove it
        }
    }/*/
}
