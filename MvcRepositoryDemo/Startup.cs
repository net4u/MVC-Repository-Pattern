using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcRepositoryDemo.Startup))]
namespace MvcRepositoryDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
