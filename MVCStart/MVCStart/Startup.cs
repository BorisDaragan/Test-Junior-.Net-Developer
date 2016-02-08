using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCStart.Startup))]
namespace MVCStart
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
