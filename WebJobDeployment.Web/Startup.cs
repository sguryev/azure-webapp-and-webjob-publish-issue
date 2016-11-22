using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebJobDeployment.Web.Startup))]
namespace WebJobDeployment.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
