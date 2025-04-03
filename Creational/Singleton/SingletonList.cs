namespace Creational.Singleton
{
    internal sealed class SingletonList<T> : List<T>
    {
        private static readonly object _lock = new();
        private static SingletonList<T>? _instance;

        private SingletonList() { }

        public static SingletonList<T> Instance
        {
            get
            {
                lock (_lock)
                {
                    return _instance ??= new SingletonList<T>();
                }
            }
        }
    }
}
