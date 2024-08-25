using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicDataViewer.Model
{
    public class Setting
    {

        #region Public Property
        public string FredURL { get; set; } = "https://api.stlouisfed.org/fred/";
        public string FedAPIKey { get; set; } = "91612041df13ea1f4313f1d4162baa7f";
        #endregion
    }
}
