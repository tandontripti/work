using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DeveloperDashboard.web.Startup))]
namespace DeveloperDashboard.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
