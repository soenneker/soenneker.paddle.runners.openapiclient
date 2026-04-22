using Soenneker.Tests.HostedUnit;

namespace Soenneker.Paddle.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class PaddleOpenApiClientRunnerTests : HostedUnitTest
{
    public PaddleOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
