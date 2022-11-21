using System.Configuration;
using Y09.Energy.Gateway.Stw.PurtelApi.Models;

namespace Y09.Energy.Gateway.Stw.PurtelApi.Helpers
{
    /// <summary>
    /// Initialize Application
    /// </summary>
    class InitApplication
    {

        /// <summary>
        /// Initialize API parameter 
        /// </summary>
        /// <returns></returns>
        public static ApiParameterModel InitApi()
        {

            //Set API parameter
            ApiParameterModel retInitApi = new ApiParameterModel
            {
                // Get Api end Point
                Gateway = ConfigurationManager.AppSettings["Gateway"],
                //Authentification
                Username = ConfigurationManager.AppSettings["Username"],
                Passwort = ConfigurationManager.AppSettings["Passwort"],
            
                //Api url template
                ApiUrlTemplate = ConfigurationManager.AppSettings["ApiUrlTemplate"],
            };


            //Check default value
            if (string.IsNullOrEmpty(retInitApi.ApiUrlTemplate))
            {
                retInitApi.ApiUrlTemplate = @"{0}?super_username={1}&super_passwort={2}&action={3}";
            }

            return retInitApi;

        }

    }
}
