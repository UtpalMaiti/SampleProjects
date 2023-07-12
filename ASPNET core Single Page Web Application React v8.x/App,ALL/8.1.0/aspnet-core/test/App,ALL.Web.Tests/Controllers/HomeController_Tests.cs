using System.Threading.Tasks;
using App,ALL.Models.TokenAuth;
using App,ALL.Web.Controllers;
using Shouldly;
using Xunit;

namespace App,ALL.Web.Tests.Controllers
{
    public class HomeController_Tests: App,ALLWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}