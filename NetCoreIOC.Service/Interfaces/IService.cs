using System.Collections.Generic;

namespace NetCoreIOC.Service.Interfaces
{
    public interface IService<T>
    {
        List<T> GetAll();
    }
}