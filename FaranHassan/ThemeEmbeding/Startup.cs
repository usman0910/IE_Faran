using Microsoft.Owin;
using Owin;
using ThemeEmbeding.Models;

[assembly: OwinStartupAttribute(typeof(ThemeEmbeding.Startup))]
namespace ThemeEmbeding
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            LocalCart.LocalProducts = new System.Collections.Generic.List<Products>();
        }
    }
}
