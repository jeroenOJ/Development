using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Testpush.Startup))]
namespace Testpush
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
