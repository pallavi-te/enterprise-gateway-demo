using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(enterprise_gateway_demo.Startup))]
namespace enterprise_gateway_demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
