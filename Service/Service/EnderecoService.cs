using AutoMapper;
using Domain.Interface.Service;
using Domain.Models.DTO;
using Domain.Models.ViewModels;

namespace Service.Service;

public class EnderecoService : IEnderecoService
{
    private readonly IBrasilApi _service;
    private readonly IMapper _mapper;

    public EnderecoService(IBrasilApi service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }
    
    public async Task<ResponseGenerico<EnderecoViewModel>> GetByCep(string cep)
    {
        var endereco = await _service.GetByCep(cep);
        return _mapper.Map<ResponseGenerico<EnderecoViewModel>>(endereco);
    }
}