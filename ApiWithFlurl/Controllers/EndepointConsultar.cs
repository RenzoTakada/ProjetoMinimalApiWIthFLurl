using ApiWithFlurl.Domain.Application;
using ApiWithFlurl.Domain.Application.Usercase;
using ApiWithFlurl.Domain.core.Request;
using ApiWithFlurl.Domain.core.Response;
using Microsoft.AspNetCore.Mvc;

namespace ApiWithFlurl.Controllers
{
    [Route("api/ConsultaMongoDB")]
    [ApiController]
    public class EndepointConsultar : ControllerBase
    {
        public readonly IUSCConsultar _UscConsultar;
        public EndepointConsultar(IUSCConsultar flurl)
        {
            _UscConsultar = flurl;
        }

        [HttpPost]
        public async Task<response> Pessoa(request request)
        {
            var retT = new TransactionConsultar(request);
            return await _UscConsultar.Connsulta(retT);
        }

    }
}
