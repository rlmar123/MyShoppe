using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyShoppe.WebUI.Startup))]
namespace MyShoppe.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
