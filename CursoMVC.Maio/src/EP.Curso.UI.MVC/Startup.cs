using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EP.Curso.UI.MVC.Startup))]
namespace EP.Curso.UI.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
