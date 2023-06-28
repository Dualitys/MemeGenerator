using Microsoft.AspNetCore.Http.HttpResults;

namespace MemeGenerator.EndpointDefinitions.Tests
{
    public class MemeEndpointDefinitionTests : IClassFixture<MemeEndpointDefinition>
    {
        private readonly MemeEndpointDefinition _endpointDefinition;
        public MemeEndpointDefinitionTests(MemeEndpointDefinition endpointDefinition)
        {
            _endpointDefinition = endpointDefinition;
        }

        [Fact]
        public void GetNewMeme_ShouldReturnCorrectValue()
        {
            // Arrange
            var expected = "All your base are belong to us";
            var expectedType = "text/plain";

            // Act
            var result = _endpointDefinition.GetNewMeme() as ContentHttpResult;

            //Assert
            Assert.False(result == null, $"Result is not of desired type, expected: [{typeof(ContentHttpResult)}]]");
            Assert.True(result.ContentType == expectedType, $"Result is of not expected type, expected: [{expectedType}], got: [{result.ContentType}]");
            Assert.True(expected == result.ResponseContent, $"GetNewMeme is Different, expected: [{expected}], got: [{result.ResponseContent}]");
        }
    }
}