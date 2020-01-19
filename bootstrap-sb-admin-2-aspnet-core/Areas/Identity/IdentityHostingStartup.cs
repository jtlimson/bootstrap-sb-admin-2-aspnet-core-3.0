using System;
using bootstrap_sb_admin_2_aspnet_core.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(bootstrap_sb_admin_2_aspnet_core.Areas.Identity.IdentityHostingStartup))]
namespace bootstrap_sb_admin_2_aspnet_core.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<dbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("dbContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<dbContext>().AddDefaultTokenProviders().AddDefaultUI();

              //  services.AddRazorPages();
            });
        }
    }
}