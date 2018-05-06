using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VentasMVC.Startup))]
namespace VentasMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
