using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(L12.Startup))]
namespace L12
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
