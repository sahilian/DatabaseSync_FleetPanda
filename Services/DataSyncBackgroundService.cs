using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading;
using System.Threading.Tasks;
using DatabaseSync.Services;

public class DataSyncBackgroundService : BackgroundService
{
    private readonly IServiceProvider _serviceProvider;
    private int _syncIntervalInSeconds;

    public DataSyncBackgroundService(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
        _syncIntervalInSeconds = 60;       
    }

    public void UpdateSyncInterval(int syncInterval)
    {
        _syncIntervalInSeconds = syncInterval;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            using (var scope = _serviceProvider.CreateScope())
            {
                var dataSyncService = scope.ServiceProvider.GetRequiredService<DataSyncService>();

                DateTime lastSyncTime = DateTime.Now.AddSeconds(-_syncIntervalInSeconds);
                dataSyncService.SyncData(lastSyncTime);
            }

            await Task.Delay(_syncIntervalInSeconds * 1000, stoppingToken);
        }
    }
}
