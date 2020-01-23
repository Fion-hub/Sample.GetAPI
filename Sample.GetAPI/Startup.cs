using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sample.GetAPI.Startup))]
namespace Sample.GetAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
