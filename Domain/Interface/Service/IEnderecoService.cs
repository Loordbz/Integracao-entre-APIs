using Domain.Models.DTO;
using Domain.Models.ViewModels;

namespace Domain.Interface.Service;

public interface IEnderecoService
{
    Task<ResponseGenerico<EnderecoViewModel>> GetByCep(string cep);
}
