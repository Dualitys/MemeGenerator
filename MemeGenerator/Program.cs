using MemeGenerator.Infrastructure.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointDefinitions(typeof(Program));

var app = builder.Build();
app.UsePathBase(new PathString("/api"));

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseEndpointDefinitions();
app.Run();

public partial class Program
{
}
