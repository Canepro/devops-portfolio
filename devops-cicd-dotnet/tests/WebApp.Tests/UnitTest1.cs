using Xunit;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc.Testing;

namespace WebApp.Tests
{
    public class UnitTest1 : IClassFixture<WebApplicationFactory<WebApp.Program>>
    {
        private readonly HttpClient _client;

        public UnitTest1(WebApplicationFactory<WebApp.Program> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async void Test_Home()
        {
            var response = await _client.GetAsync("/");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            Assert.Equal("Hello, DevOps World!", content);
        }
    }
}
