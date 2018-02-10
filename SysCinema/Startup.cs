using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SysCinema.Startup))]
namespace SysCinema
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
