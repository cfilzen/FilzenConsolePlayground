namespace FilzenConsolePlayground.Types.Generics.Class
{
    class DataStore<T>
    {
        //The type below is nullable.
        public T? Data { get; set; }
    }

    class KeyValuePair<TKey, TValue>
    {
        public TKey? Key { get; set; }
        public TValue? Value { get; set; }
    }
}