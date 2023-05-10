using Domain.Interface.Service;
using Domain.Models;
using Domain.Models.DTO;
using Domain.Models.ViewModels;
using System.Dynamic;
using System.Text.Json;

namespace Infra.Repository;

public class BrasilApiRepository : IBrasilApi
{
    public async Task<ResponseGenerico<Endereco>> GetByCep(string cep)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/cep/v1/{cep}");
        var response = new ResponseGenerico<Endereco>();

        using (var client = new HttpClient())
        {
            var responseApi = await client.SendAsync(request);
            var contentResp = await responseApi.Content.ReadAsStringAsync();

            var objResponse = JsonSerializer.Deserialize<Endereco>(contentResp);
            if (!responseApi.IsSuccessStatusCode)
            {
                response.HttpStatus = responseApi.StatusCode;
                response.Erro = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
            }

            response.HttpStatus = responseApi.StatusCode;
            response.Retorno = objResponse;
            return response;
        }
    }
}
