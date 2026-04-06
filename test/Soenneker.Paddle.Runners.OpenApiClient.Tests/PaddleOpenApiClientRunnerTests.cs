using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Paddle.Runners.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class PaddleOpenApiClientRunnerTests : FixturedUnitTest
{
    public PaddleOpenApiClientRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
