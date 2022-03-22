namespace FilzenConsolePlayground.Types.Generics.Method
{
    //List of valid overloads:
    //public void AddOrUpdate(int index, T data) { }
    //public void AddOrUpdate(T data1, T data2) { }
    //public void AddOrUpdate<U>(T data1, U data2) { }
    //public void AddOrUpdate(T data) { }

    class DataStore<T>
    {
        private T[] _data = new T[10];

        public void AddOrUpdate(int index, T item)
        {
            if (index >= 0 && index < 10)
                _data[index] = item;
        }

        public T? GetData(int index)
        {
            if (index >= 0 && index < 10)
                return _data[index];
            else
                return default;
        }
    }
    class Printer
    {
        public void Print<T>(T data)
        {
            Console.WriteLine(data);
        }
    }
}