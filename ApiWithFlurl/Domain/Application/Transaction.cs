using ApiWithFlurl.Adapter.Flurl;
using ApiWithFlurl.Domain.core.Request;
using Microsoft.Extensions.Options;

namespace ApiWithFlurl.Domain.Application
{
    public class TransactionConsultar
    {
        private IOptions<Settings> _settings;
        public request body { get; set; }
        public HttpService rotaFlurl { get; set; }
        public TransactionConsultar(request req)
        {



            this.body = req;
            this.rotaFlurl = new HttpService()
            {
                endpoint = "https://localhost:7098/Consultar"
            };
            //  this.rotaFlurl = _settings.Value.GetService("150");
            Console.WriteLine(this.rotaFlurl);
        }
    }
}
