using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MessageBoardAtea.Startup))]
namespace MessageBoardAtea
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
