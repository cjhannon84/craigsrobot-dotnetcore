using System.Threading;
using System.Threading.Tasks;

namespace CraigsRobot.Core.Services
{
    public interface IRobot
    {
        Task WakeUp(CancellationToken cancellationToken);
    }
}