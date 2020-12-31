using Operose.HelpersLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operose
{
    public class ApplicationConfig: SettingsBase<ApplicationConfig>
    {
        public DateTime FirstTimeRunDate = DateTime.Now;

        public ApplicationConfig()
        {
            this.ApplyDefaultPropertyValues();
        }

    }
}
