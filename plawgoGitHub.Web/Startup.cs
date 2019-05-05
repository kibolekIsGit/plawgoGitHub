using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(plawgoGitHub.Web.Startup))]
namespace plawgoGitHub.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
