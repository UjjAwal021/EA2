using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(myAfe.Web.Startup))]
namespace myAfe.Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
