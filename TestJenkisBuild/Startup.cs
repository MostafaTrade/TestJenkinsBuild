using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestJenkisBuild.Startup))]
namespace TestJenkisBuild
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
