using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TMDT_Tuan3.Startup))]
namespace TMDT_Tuan3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
