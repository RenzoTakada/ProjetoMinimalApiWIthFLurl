namespace ApiWithFlurl.Adapter.Flurl
{
    public static class Extension
    {
        public static IServiceCollection AddFlurlAdapter(this IServiceCollection services, IConfiguration configuration)
        {
            //IConfiguration configuration = new ConfigurationBuilder()
            //         .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json")
            //         .Build();


            services.Configure<Settings>(options => configuration.GetSection("Transactions").Bind(options));
            services.AddSingleton<IFlurlService, FlurlService>();

            return services;
        }
    }
}
