using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHT.Banking.Infrastructure.Tasks.Scheduling
{
    public interface IScheduledTask
    {
        string Schedule { get; }

        Task ExecuteAsync(CancellationToken cancellationToken);
    }
}
