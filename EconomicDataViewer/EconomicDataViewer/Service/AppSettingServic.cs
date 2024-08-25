using EconomicDataViewer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicDataViewer.Service
{
    public class AppSettingService
    {
        #region Constructor
        public AppSettingService()
        {

        }
        #endregion

        #region Public Property
        public Setting AppSetting { get; set; } = new Setting();
        #endregion
    }
}
