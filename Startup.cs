using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReffAppT.Startup))]
namespace ReffAppT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
