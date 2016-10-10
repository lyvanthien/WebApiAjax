using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApiAjax.Startup))]
namespace WebApiAjax
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
