using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(L03.Startup))]
namespace L03
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
