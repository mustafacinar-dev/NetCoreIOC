using NetCoreIOC.Service.Interfaces;
using System;
using Microsoft.Extensions.Logging;

namespace NetCoreIOC.Service.Concrete
{
    public class DateService : ISingletonDateService, IScopedDateService, ITransientDateService
    {
        private readonly ILogger<DateService> _logger;
        public DateService(ILogger<DateService> logger)
        {
            _logger = logger;

            _logger.LogWarning($"A new instance of { nameof(DateService) } has been created.");
        }
        public DateTime DateTimeNow { get; } = DateTime.Now;
    }
}