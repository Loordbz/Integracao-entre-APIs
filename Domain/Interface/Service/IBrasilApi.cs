using Domain.Models;
using Domain.Models.DTO;

namespace Domain.Interface.Service;

public interface IBrasilApi
{
    Task<ResponseGenerico<Endereco>> GetByCep(string cep);
}
