using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(L08.Startup))]
namespace L08
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
