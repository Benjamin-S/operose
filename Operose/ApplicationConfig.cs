using Operose.HelpersLib;
using System;
using System.Collections.Generic;

namespace Operose
{
    public class ApplicationConfig : SettingsBase<ApplicationConfig>
    {
        public DateTime FirstTimeRunDate = DateTime.Now;
        public DatabaseEnv LastEnvironment { get; set; }

        #region Theme

        public bool UseCustomTheme = true;

        public List<OperoseTheme> Themes = OperoseTheme.GetDefaultThemes();
        public int SelectedTheme = 0;

        #endregion Theme

        public ApplicationConfig()
        {
            this.ApplyDefaultPropertyValues();
        }
    }
}