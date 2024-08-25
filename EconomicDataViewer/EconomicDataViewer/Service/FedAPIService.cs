using EconomicDataViewer.Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;

namespace EconomicDataViewer.Service
{
    public class FedAPIService
    {
        #region Private Property
        private readonly AppSettingService appSettingService;
        readonly RestClient _client;
        #endregion

        #region Constructor
        public FedAPIService(AppSettingService _appSettingService)
        {
            this.appSettingService = _appSettingService;



            var setting = this.appSettingService.AppSetting;

            var options = new RestClientOptions(setting.FredURL);
            _client = new RestClient(options);
        }
        #endregion


        #region Public Functions
        public async Task<CategoriesToken> GetBusinessInventory()
        {
            try
            {

                var api_key = this.appSettingService.AppSetting.FedAPIKey;


                var request = new RestRequest("series");
                request.AddParameter("series_id", "BUSINV");
                request.AddParameter("api_key", api_key);
                request.AddParameter("file_type", "json");

                var response = await this._client.ExecuteAsync<CategoriesToken>(request);
                // handle error
                if (!response.IsSuccessful)
                {
                    throw new Exception(response.ErrorException?.Message);
                }

                return response.Data;
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }
        #endregion
    }
}
