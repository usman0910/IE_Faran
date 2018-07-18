using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ThemeEmbeding.Startup))]
namespace ThemeEmbeding
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
