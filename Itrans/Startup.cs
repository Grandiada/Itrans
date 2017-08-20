using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Itrans.Startup))]
namespace Itrans
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
