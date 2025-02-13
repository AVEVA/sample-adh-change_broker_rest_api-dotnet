using System.Threading.Tasks;
using Xunit;

namespace ChangeBrokerRestApiTest
{
    public class UnitTests
    {
        [Fact]
        public async Task ChangeBrokerRestApiUnitTest()
        {
            Assert.True(await ChangeBrokerRestApi.Program.MainAsync(true));
        }
    }
}
