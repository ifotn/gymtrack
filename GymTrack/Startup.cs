using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GymTrack.Startup))]
namespace GymTrack
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
