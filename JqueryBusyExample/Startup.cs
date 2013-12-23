using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JqueryBusyExample.Startup))]
namespace JqueryBusyExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
