using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(L09.Startup))]
namespace L09
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
