using System;
using System.Threading;
using System.Threading.Tasks;
using CraigsRobot.Core.Services;

namespace CraigsRobot.Infrastructure.Services
{
    public class Robot :IRobot
    {
        public Task WakeUp(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                Console.WriteLine($"{DateTime.Now}");
            }

            return Task.CompletedTask;
        }
    }
}