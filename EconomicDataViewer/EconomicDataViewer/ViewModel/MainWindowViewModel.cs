using ConvMVVM.Core.Attributes;
using ConvMVVM.Core.Component;
using EconomicDataViewer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EconomicDataViewer.ViewModel
{
    public partial class MainWindowViewModel : NotifyObject
    {
        #region Private Property
        private readonly FedAPIService fedAPIService;
        #endregion

        #region Constructor
        public MainWindowViewModel(FedAPIService _fedAPIService)
        {
            this.fedAPIService = _fedAPIService;

        }
        #endregion


        #region Public Property

        #endregion

        #region Command


        [AsyncRelayCommand]
        public async Task Test()
        {
            try
            {

                var result = await this.fedAPIService.GetCategories();

                System.Diagnostics.Debug.WriteLine("test");

            }catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }

        }

        #endregion
    }
}
