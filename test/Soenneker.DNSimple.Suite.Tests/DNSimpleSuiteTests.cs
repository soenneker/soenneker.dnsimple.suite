using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.DNSimple.Suite.Tests;

[Collection("Collection")]
public class DNSimpleSuiteTests : FixturedUnitTest
{
    public DNSimpleSuiteTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
