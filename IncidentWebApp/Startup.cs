using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IncidentWebApp.Startup))]
namespace IncidentWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
