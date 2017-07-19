using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(busykids_api.Startup))]
namespace busykids_api
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
