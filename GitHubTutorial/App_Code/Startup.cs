using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitHubTutorial.Startup))]
namespace GitHubTutorial
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
