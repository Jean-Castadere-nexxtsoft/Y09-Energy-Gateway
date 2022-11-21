using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Y09.Energy.Gateway.Stw.PurtelApi.Dtos.Targets;
using Y09.Energy.Gateway.Stw.PurtelApi.Interfaces;

namespace Y09.Energy.Gateway.Stw.PurtelApi;


/// <summary>
/// Programm starten 
/// </summary>
internal class Program
{

    //reference of AutoMapper object
    private static IMapper _mapper;

    static void Main(string[] args)
    {

        //Init mapper
        InitializeAutomapper(_mapper);

        ChangeContractJSON mappedObject = null;
        mappedObject = _mapper.Map<ChangeContractJSON>(mappedObject);



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


    //This method initializes and configures the AutoMapper
    private static void InitializeAutomapper(IMapper mapper)
    {
        var config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<ChangeContractCVS, ChangeContractJSON>().ReverseMap();
        });

        mapper = config.CreateMapper();

        mapper = new Mapper(config);

        //_mapper = config.CreateMapper();
    }



}
