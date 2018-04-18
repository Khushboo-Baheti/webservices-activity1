using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Webact7.Startup))]
namespace Webact7
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
