using System;
using Y09.Energy.Gateway.Stw.PurtelApi.Actions;
using Y09.Energy.Gateway.Stw.PurtelApi.Models;

namespace Y09.Energy.Gateway.Stw.PurtelApi.Services;

/// <summary>
/// Call Purtel Api
/// </summary>
class ApiService
{
    //Api initialize value
    private static ApiParameterModel _initApiModel;


    /// <summary>
    /// start and Call Api
    /// </summary>
    /// <returns></returns>
    public static bool StartApi()
    {
        bool valRet = true;

        //Get and init Api parameter to call
        _initApiModel = Helpers.InitApplication.InitApi();

        //TODO : to test
        Factory.ConsoleTest(_initApiModel.Gateway);

        return valRet;

    }

}
