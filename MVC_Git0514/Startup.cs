using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Git0514.Startup))]
namespace MVC_Git0514
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
