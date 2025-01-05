public class ConfigureApplication(WebApplication app)
{
    private WebApplication _app {get; set;} = app;

    public void Configure()
    {
        _app.MapControllers();
        // Configure the HTTP request pipeline.
        if (_app.Environment.IsDevelopment())
        {
            _app.UseSwagger();
            _app.UseSwaggerUI();
        }

        _app.UseHttpsRedirection();

        _app.Run();
    }
    
}