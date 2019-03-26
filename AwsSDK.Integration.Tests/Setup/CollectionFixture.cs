using Xunit;

namespace AwsSDK.Integration.Tests.Setup
{
    [CollectionDefinition("api")]
    public class CollectionFixture : ICollectionFixture<TestContext>, ICollectionFixture<TestDataSetup>
    {
    }
}