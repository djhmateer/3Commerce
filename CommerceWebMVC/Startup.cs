using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CommerceWebMVC.Startup))]
namespace CommerceWebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
