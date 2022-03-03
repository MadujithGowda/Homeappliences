using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Homeappliences_application.Startup))]
namespace Homeappliences_application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
