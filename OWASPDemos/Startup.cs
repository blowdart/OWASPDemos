using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OWASPDemos.Startup))]
namespace OWASPDemos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}