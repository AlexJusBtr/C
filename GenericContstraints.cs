namespace GenericConstraints
{
    public class Factory<T> where T : new()
    {
        public T CreateInstance()
        {
            return new T();
        }
    }
    class Sample
    {
        public string Text = "Created";
    }
    public class ReferenceHandler<T> where T : class
    {
        public void PrintTypeName()
        {
            Console.WriteLine(typeof(T).Name);
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            var factory = new Factory<Sample>();
            var instance = factory.CreateInstance();
            Console.WriteLine(instance.Text);
            var handler = new ReferenceHandler<string>();
            handler.PrintTypeName();
        }
    }
}
