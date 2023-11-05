using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(amazon2.Startup))]
namespace amazon2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
