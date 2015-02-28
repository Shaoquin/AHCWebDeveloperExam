using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AHCWebDeveloperExam.Startup))]
namespace AHCWebDeveloperExam
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
