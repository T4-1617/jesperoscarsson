using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testDemo.Startup))]
namespace testDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
