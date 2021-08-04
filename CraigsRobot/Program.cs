using System;
using System.Security.Authentication.ExtendedProtection;
using System.Threading;
using System.Threading.Tasks;
using CraigsRobot.Core.Services;
using CraigsRobot.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CraigsRobot
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<IRobot, Robot>();

            var serviceProvider = serviceCollection.BuildServiceProvider();
            var robotService = serviceProvider.GetRequiredService<IRobot>();

            var cancellationTokenSource = new CancellationTokenSource();
            await robotService.WakeUp(cancellationTokenSource.Token);
        }
    }
}