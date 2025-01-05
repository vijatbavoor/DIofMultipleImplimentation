public class Startup
{
    public Startup(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    private IConfiguration _configuration { get; set; }

    public void ConfigureServices(IServiceCollection services)    
    {
        services.AddControllers();
        services.AddSingleton<IFisClient, SctFisClient>();
        services.AddSingleton<IFisClient, XctFisClient>();
        services.Configure<SctFisEndpoints>(_configuration.GetSection("SctFisEndPoints"));
        services.Configure<XctFisEndpoints>(_configuration.GetSection("XctFisEndPoints"));
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
    }

    public void ConfigureApplication(WebApplication app, IWebHostEnvironment env)
    {
        app.MapControllers();
        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.Run();
    }
}