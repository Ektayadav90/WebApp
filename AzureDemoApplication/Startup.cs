using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureDemoApplication.Startup))]
namespace AzureDemoApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
