using System.Dynamic;
using System.Net;

namespace Domain.Models.DTO;

public class ResponseGenerico<T> where T : class
{
    public HttpStatusCode HttpStatus { get; set; }
    public T? Retorno { get; set; }
    public ExpandoObject? Erro { get; set; }
}
