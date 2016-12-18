using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeamProject2_Part1.Startup))]
namespace TeamProject2_Part1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
