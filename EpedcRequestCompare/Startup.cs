using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EpedcRequestCompare.Startup))]
namespace EpedcRequestCompare
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
