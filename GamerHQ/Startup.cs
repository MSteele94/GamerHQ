using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GamerHQ.Startup))]
namespace GamerHQ
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
