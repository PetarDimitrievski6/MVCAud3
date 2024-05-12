using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCAud3.Startup))]
namespace MVCAud3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
