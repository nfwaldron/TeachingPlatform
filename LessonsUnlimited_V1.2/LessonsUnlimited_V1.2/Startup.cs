using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LessonsUnlimited_V1._2.Startup))]
namespace LessonsUnlimited_V1._2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
