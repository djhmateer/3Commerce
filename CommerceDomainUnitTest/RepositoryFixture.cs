using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoMoq;

namespace CommerceDomainUnitTest
{
    internal class RepositoryFixture : Fixture
    {
        public RepositoryFixture()
        {
            this.Customize(new AutoMoqCustomization());
        }
    }
}
