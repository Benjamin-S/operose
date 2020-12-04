using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operose
{
    public static class Extensions
    {
        public static Task ContinueInCurrentContext(this Task task, Action action)
        {
            TaskScheduler scheduler = TaskScheduler.FromCurrentSynchronizationContext();
            return task.ContinueWith(t => action(), scheduler);
        }
    }
}
