using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Webform.Startup))]
namespace Webform
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
