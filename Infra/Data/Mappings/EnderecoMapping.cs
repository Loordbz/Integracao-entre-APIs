using AutoMapper;
using Domain.Models;
using Domain.Models.DTO;
using Domain.Models.ViewModels;

namespace Infra.Data.Mappings;

public class EnderecoMapping : Profile
{
    public EnderecoMapping()
    {
        CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
        CreateMap<EnderecoViewModel, Endereco>();
        CreateMap<Endereco, EnderecoViewModel>();
    }
    
}
