using MemeGenerator.Infrastructure.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointDefinitions(typeof(Program));

var app = builder.Build();
app.UsePathBase(new PathString("/api"));
app.UseEndpointDefinitions();
app.Run();

public partial class Program
{
}
