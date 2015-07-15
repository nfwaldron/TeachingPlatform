using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LessonsUnlimited.Startup))]
namespace LessonsUnlimited
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
