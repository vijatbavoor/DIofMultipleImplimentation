public class ConfigureServices(IConfiguration configuration, IServiceCollection services)
{
    private IServiceCollection Services {get; set;} = services;
    private IConfiguration Configuration {get; set;} = configuration;

    public void Configure()
    {
        Services.AddControllers();
        Services.AddSingleton<IFisClient, SctFisClient>();
        Services.AddSingleton<IFisClient, XctFisClient>();
        Services.Configure<SctFisEndpoints>(Configuration.GetSection("SctFisEndPoints"));
        Services.Configure<XctFisEndpoints>(Configuration.GetSection("XctFisEndPoints"));
        
        // Add services to the container.
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        Services.AddEndpointsApiExplorer();
        Services.AddSwaggerGen();
    }
}