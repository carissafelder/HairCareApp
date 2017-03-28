using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HairCareWebApi.Startup))]
namespace HairCareWebApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
