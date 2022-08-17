using ApiWithFlurl.Adapter.Flurl;
using ApiWithFlurl.Domain.core.Request;
using ApiWithFlurl.Domain.core.Response;

namespace ApiWithFlurl.Domain.Application.Usercase
{
    public interface IUSCConsultar
    {
        public Task<response> Connsulta(TransactionConsultar req);
    }
    public class USCConsultar : IUSCConsultar
    {
        public readonly IFlurlService _flurl;
        public USCConsultar(IFlurlService flurl)
        {
            _flurl = flurl;
        }

        public async Task<response> Connsulta(TransactionConsultar req)
        {
            var result = _flurl.GetResponse(req);
            return await result;
        }
    }
}
