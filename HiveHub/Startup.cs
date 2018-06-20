using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HiveHub.Startup))]
namespace HiveHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
