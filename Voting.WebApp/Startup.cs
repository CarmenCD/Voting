using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Voting.WebApp.Startup))]
namespace Voting.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
