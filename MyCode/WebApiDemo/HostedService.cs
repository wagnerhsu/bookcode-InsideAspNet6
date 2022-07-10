using Microsoft.Extensions.Options;
using WebApiDemo.Settings;

namespace WebApiDemo
{
    public class HostedService: BackgroundService
    {
        private readonly ILogger<HostedService> _logger;

        public HostedService(IOptionsMonitor<Profile> profileOptions,ILogger<HostedService> logger)
        {
            _logger = logger;
            profileOptions.OnChange(profile =>
            {
                logger.LogDebug($"Gender: {profile.Gender}");
                logger.LogDebug($"Age: {profile.Age}");
                logger.LogDebug($"Email Address: {profile.ContactInfo?.EmailAddress}");
                logger.LogDebug($"Phone No: {profile.ContactInfo?.PhoneNo}");
            });
        }
        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Running...");
            return Task.CompletedTask;
        }
    }
}
