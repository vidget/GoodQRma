using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GoodQRma.Startup))]
namespace GoodQRma
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
