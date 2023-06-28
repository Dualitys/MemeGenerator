using MemeGenerator.Infrastructure.Endpoints;

namespace MemeGenerator.EndpointDefinitions
{
    public class MemeEndpointDefinition : IEndpointDefinition
    {
        public void DefineEndpoints(WebApplication app)
        {
            app.MapGet("/newmeme", GetNewMeme).WithTags("Memes");
        }

        public void DefineServices(IServiceCollection services)
        {
        }

        internal IResult GetNewMeme()
        {
            return Results.Content("All your base are belong to us", contentType: "text/plain");
        }
    }
}
