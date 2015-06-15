using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Model_Study.Startup))]
namespace Model_Study
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
