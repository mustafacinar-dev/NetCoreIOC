namespace NetCoreIOC.DataAccess
{
    public class GenericFactory<T, K> where T : class, K, new()
    {
        public static K GetFactory()
        {
            return new T();
        }
    }
}