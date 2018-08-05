using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tramites.Startup))]
namespace Tramites
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
