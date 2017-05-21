using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(L10.Startup))]
namespace L10
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
