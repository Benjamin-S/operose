using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public static void ApplyDefaultPropertyValues(this object self)
        {
            foreach (PropertyDescriptor prop in TypeDescriptor.GetProperties(self))
            {
                DefaultValueAttribute attr = prop.Attributes[typeof(DefaultValueAttribute)] as DefaultValueAttribute;
                if (attr != null) prop.SetValue(self, attr.Value);
            }
        }
    }
}
