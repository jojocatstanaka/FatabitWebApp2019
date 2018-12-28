using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FatabitWebApp2019.Startup))]
namespace FatabitWebApp2019
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
