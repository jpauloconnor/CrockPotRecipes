using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CrockPotRecipes.WebMvc.Startup))]
namespace CrockPotRecipes.WebMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
