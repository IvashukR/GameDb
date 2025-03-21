var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDb();
builder.Services.AddScoped<PlayerRepo>();
builder.Services.AddControllers();
var app = builder.Build();
app.UseRouting();
app.UseEndpoints(endpoints => {
    endpoints.MapControllers();
});
app.Run();
