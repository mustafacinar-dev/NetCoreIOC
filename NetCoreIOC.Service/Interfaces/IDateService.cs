using System;

namespace NetCoreIOC.Service.Interfaces
{
    public interface IDateService
    {
        DateTime DateTimeNow { get; }
    }
}