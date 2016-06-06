using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OSHelpLine.Startup))]
namespace OSHelpLine
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
