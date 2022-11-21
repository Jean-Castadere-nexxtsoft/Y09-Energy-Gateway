using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y09.Energy.Gateway.Stw.PurtelApi.Models;

/// <summary>
/// Api parameter to call
/// </summary>
 class ApiParameterModel
{

    //Api Url (sammple 
    public string Gateway { get; set; }

    //User name
    public string Username { get; set; }
    //Password
    public string Passwort { get; set; }
   
    //Api Url Template
    public string ApiUrlTemplate { get; set; }


}
