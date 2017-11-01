using Xunit;

namespace TestProject
{
    [Collection("LocalCollection")]
    public class TestClassUsingLocalCollection
    {
        public TestClassUsingLocalCollection(LocalFixture fixture)
        {
        }

        [Fact]
        public void Test1()
        {

        }
    }

    [CollectionDefinition("LocalCollection")]
    public class LocalCollection: ICollectionFixture<LocalFixture>
    {
    }

    public class LocalFixture
    {

    }
}
