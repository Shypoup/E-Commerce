using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IA_PM.Startup))]
namespace IA_PM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
