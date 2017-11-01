using Xunit;

namespace TestHelpers
{
    [Collection("HelperCollection")]
    public abstract class HelperCollectionTestBase
    {
        protected HelperCollectionTestBase(HelperFixture fixture)
        {

        }
    }

    [CollectionDefinition("HelperCollection")]
    public class HelperCollection : ICollectionFixture<HelperFixture>
    {

    }
}
