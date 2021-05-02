namespace NetCoreIOC.DataAccess
{
    public class GenericFactory<T> where T : class, new()
    {
        public static T GetFactory()
        {
            return new T();
        }
    }
}