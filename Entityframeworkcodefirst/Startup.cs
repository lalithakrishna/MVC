using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Entityframeworkcodefirst.Startup))]
namespace Entityframeworkcodefirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
