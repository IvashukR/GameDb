var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDb();
builder.Services.AddScoped<PlayerRepo>();
builder.Services.AddControllers();
var app = builder.Build();
app.Urls.Add("http://0.0.0.0:10000"); 
app.UseRouting();
app.UseEndpoints(endpoints => {
    endpoints.MapControllers();
});
app.Run();
