using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y09.Energy.Gateway.Stw.PurtelApi.Dtos.Targets
{
    /// <summary>
    /// create contract model to CVS
    /// </summary>
    internal class CreateContractCVS
    {

        //Required
        public int anrede { get; set; }
        public string vorname { get; set; }
        public string nachname { get; set; }
        public string adresse { get; set; }
        public string plz { get; set; }
        public string ort { get; set; }
        public int land { get; set; }
        public string kundennummer_extern { get; set; }
        public string produkt { get; set; }

        //Optional
        public string firma { get; set; }
        public string geburtsdatum { get; set; }
        public string haus_nr { get; set; }
        public string zusatz { get; set; }
        public string ot { get; set; }

        public int max_channels { get; set; }
        public int max_channels_vertrag { get; set; }
        public int max_numbers { get; set; }
        public int max_numbers_vertrag { get; set; }
        public int max_fax { get; set; }
        public int max_fax_vertrag { get; set; }
        public int max_accounts_vertrag { get; set; }
        public int ip_eingeschraenkt { get; set; }
        public int skip_timeout { get; set; }
        public int billing { get; set; }




    }
}
