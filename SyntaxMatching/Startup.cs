using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SyntaxMatching.Startup))]
namespace SyntaxMatching
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
