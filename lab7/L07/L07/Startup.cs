using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(L07.Startup))]
namespace L07
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
