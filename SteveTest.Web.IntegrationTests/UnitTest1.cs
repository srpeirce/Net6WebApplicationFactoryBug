using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Xunit;

namespace SteveTest.Web.IntegrationTests;

public class UnitTest1 : IClassFixture<WebApplicationFactory<Startup>>
{
    private readonly TestServer _testServer;

    public UnitTest1(WebApplicationFactory<Startup> factory)
    {
        _testServer = factory.Server;
    }
    
    [Fact]
    public async Task Test1()
    {
        var request = _testServer.CreateRequest("home/index");

        var response = await request.GetAsync();
        
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }
}