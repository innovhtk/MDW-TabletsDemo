using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MDWlite
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static string applicationSettings = "application.config";
        public static AppSettings appSetting;
        
        //[STAThread]
        [MTAThread]
        static void Main()
        {
            //Load Setting
            appSetting = new AppSettings();
            if (!System.IO.File.Exists(applicationSettings))
            {
                SaveSettings();
                LoadSettings();
            }
            else
            {
                LoadSettings();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TabletMonitor());
        }

        #region Setting
        public static void LoadSettings()
        {
            appSetting = appSetting.Load();
        }
        public static bool SaveSettings()
        {
            //appSetting.Channel_number = ReaderCE.SelectedChannel;
            //appSetting.Lbt = ReaderCE.LBT_ON == LBT.ON;
            //appSetting.Link_profile = ReaderCE.SelectedLinkProfile;
            //appSetting.Power = ReaderCE.SelectedPowerLevel;
            //appSetting.Region = ReaderCE.SelectedRegionCode;
            //appSetting.FixedChannel = ReaderCE.IsFixedChannel;
            return appSetting.Save();
        }
        #endregion

    }
}
