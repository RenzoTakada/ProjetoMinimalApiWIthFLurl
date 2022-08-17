namespace ApiWithFlurl.Adapter.Flurl
{
    public record Settings
    {
        public List<HttpService> Services { get; set; }

        //public void AddService(GrpcService service) => Services.Add(service);

        public void Dispose()
        {
            this.Services.Clear();
        }

        public HttpService GetService(string code) => Services.Find(x => x.code == code);

    }

    public struct HttpService //: IDisposable
    {
        public string code { get; set; }
        public string name { get; set; }
        public string endpoint { get; set; }
        public string method { get; set; }



        public void Dispose()
        {
            this.code = null;
            this.name = null;
            this.endpoint = null;
            this.method = null;
        }

    }
}
