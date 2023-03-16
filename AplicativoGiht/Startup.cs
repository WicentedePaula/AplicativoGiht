using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AplicativoGiht.Startup))]
namespace AplicativoGiht
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
