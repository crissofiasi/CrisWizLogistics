using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CrisWizLogistics.Startup))]
namespace CrisWizLogistics
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
