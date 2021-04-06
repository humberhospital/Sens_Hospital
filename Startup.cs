using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sens_Hospital.Startup))]
namespace Sens_Hospital
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
