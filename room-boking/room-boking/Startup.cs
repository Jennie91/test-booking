using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(room_boking.Startup))]
namespace room_boking
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
