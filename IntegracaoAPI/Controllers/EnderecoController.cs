using Domain.Interface.Service;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace WebApplication1.Controller;

/// <summary>
/// Obter Lista de Estados.
/// </summary>
/// <returns>Lista de Estados da federação </returns>

[ApiController]
[Route("api/endereco")]
public class EnderecoController : ControllerBase
{
    private readonly IEnderecoService _service;

    public EnderecoController(IEnderecoService service) =>
        _service = service;

    [HttpGet]
    [Route("buscar/{cep}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetEndereco(string cep)
    {
        var endereco = await _service.GetByCep(cep);
        if (endereco.HttpStatus != HttpStatusCode.OK)
            return StatusCode((int)endereco.HttpStatus, endereco.Erro);

        return Ok(endereco.Retorno);
    }
}
