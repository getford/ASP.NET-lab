using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(L11.Startup))]
namespace L11
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
