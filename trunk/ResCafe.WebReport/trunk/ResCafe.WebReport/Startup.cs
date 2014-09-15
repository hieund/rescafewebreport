using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ResCafe.WebReport.Startup))]
namespace ResCafe.WebReport
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
