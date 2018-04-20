using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BeekClone.Web.Startup))]
namespace BeekClone.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
