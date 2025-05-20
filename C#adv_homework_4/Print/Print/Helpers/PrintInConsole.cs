namespace Print.Helpers
{
    class PrintInConsole
    {
        public void Print<T>(T item)
        {
            Console.WriteLine($"Print: {item}");
        }
        public void PrintCollection<T>(List<T> collection)
        {

            foreach (T item in collection)
            {
                Console.WriteLine($"Print collection: {item}");
            }
        }

    }
}
