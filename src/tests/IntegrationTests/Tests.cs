namespace Triverse.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static TriverseClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("TRIVERSE_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("TRIVERSE_API_KEY environment variable is not found.");

        var client = new TriverseClient(apiKey);
        
        return client;
    }
}
