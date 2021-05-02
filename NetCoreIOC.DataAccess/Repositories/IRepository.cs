using System.Collections.Generic;

namespace NetCoreIOC.DataAccess.Repositories
{
    public interface IRepository<T>
    {
        List<T> GetAll();
    }
}