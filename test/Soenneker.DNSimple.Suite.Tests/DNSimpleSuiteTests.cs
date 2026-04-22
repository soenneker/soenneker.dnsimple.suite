using Soenneker.Tests.HostedUnit;

namespace Soenneker.DNSimple.Suite.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class DNSimpleSuiteTests : HostedUnitTest
{
    public DNSimpleSuiteTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
