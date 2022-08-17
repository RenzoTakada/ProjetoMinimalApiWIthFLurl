using ApiWithFlurl.Domain.Application;
using ApiWithFlurl.Domain.core.Response;
using Flurl.Http;

namespace ApiWithFlurl.Adapter.Flurl
{
    public interface IFlurlService
    {
        Task<response> GetResponse(TransactionConsultar transaction);
    }
    public class FlurlService : IFlurlService
    {
        public async Task<response> GetResponse(TransactionConsultar transaction)
        {
            using (var flurClient = new FlurlClient())
            {
                return await transaction.rotaFlurl.endpoint.WithClient(flurClient)
                    .PostJsonAsync(transaction.body).ReceiveJson<response>();
            }
        }
    }
}
