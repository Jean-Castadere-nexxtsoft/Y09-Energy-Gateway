using AutoMapper;
using Y09.Energy.Gateway.Stw.PurtelApi.Actions;
using Y09.Energy.Gateway.Stw.PurtelApi.Dtos.Targets;

namespace Y09.Energy.Gateway.Stw.PurtelApi;


/// <summary>
/// Programm starten 
/// </summary>
internal class Program
{
    static void Main(string[] args)
    {

        //Call console mamagement
        //Factory.ConsoleStart();


        //TODO: move code
        //Initialize the mapper
        var config = new MapperConfiguration(cfg => cfg.CreateMap<ChangeContractCVS, ChangeContractJSON>());

        ChangeContractCVS ChangeContractMapped = new ChangeContractCVS
        {
            anrede = 1,
            vorname = "Jean",
            nachname = "Castadere"
        };

        //Using automapper
        var mapper = new Mapper(config);
        var ChangeContractDTO = mapper.Map<ChangeContractJSON>(ChangeContractMapped);



    }
}
