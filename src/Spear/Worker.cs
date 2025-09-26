namespace Spear
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {            
            try
            {
                using (var timer = new PeriodicTimer(TimeSpan.FromSeconds(15)))
                {
                    while (!stoppingToken.IsCancellationRequested)
                    {
                        while(await timer.WaitForNextTickAsync())
                        {
                            await RunJobAsync(stoppingToken);
                        }                        
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Unhandled exception in the core Worker Class");
                throw;
            }            
        }

        private async Task RunJobAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Processing tasks at: {time}", DateTimeOffset.Now);

            await Task.Delay(1000);
        }
    }
}
