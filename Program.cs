var builder = WebApplication.CreateBuilder(args);

var startup = new Startup(builder.Configuration);
startup.ConfigureServices(builder.Services);
startup.ConfigureApplication(builder.Build(), builder.Environment);