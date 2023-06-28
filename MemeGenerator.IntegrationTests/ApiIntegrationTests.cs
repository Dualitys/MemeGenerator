namespace MemeGenerator.IntegrationTests
{
    public class ApiIntegrationTests : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly WebApplicationFactory<Program> _factory;

        public ApiIntegrationTests(WebApplicationFactory<Program> factory)
        {
            _factory = factory;
        }

        [Fact(DisplayName = "newmeme endpoint should return correct content type and content")]
        public async Task Get_EndpointShouldReturnSuccessAndCorrectContent()
        {
            // Arrange
            var client = _factory.CreateClient();
            var expected = "All your base are belong to us";
            var expectedType = "text/plain";

            // Act
            var response = await client.GetAsync("/api/newmeme");

            //Assert
            response.EnsureSuccessStatusCode();
            var responseType = response.Content.Headers.ContentType?.MediaType;
            var responseContent = await response.Content.ReadAsStringAsync();

            Assert.True(expectedType == responseType, $"GetNewMeme response type is Different, expected: [{expectedType}], got: [{responseContent}]");
            Assert.True(expected == responseContent, $"GetNewMeme is Different, expected: [{expected}], got: [{responseContent}]");
        }
    }
}