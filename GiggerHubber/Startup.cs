using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GiggerHubber.Startup))]
namespace GiggerHubber
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
