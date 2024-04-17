using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApplication_L2V2.Data;
using WebApplication_L2V2.Models;
namespace WebApplication_L2V2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            /*builder.Services.AddDbContext<WebApplication_L2V2Context>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("WebApplication_L2V2Context") ?? throw new InvalidOperationException("Connection string 'WebApplication_L2V2Context' not found.")));*/
            builder.Services.AddDbContext<WebApplication_L2V2Context>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("WebApplication_L2V2Context")));

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            //ConfigHelper.Initialize(builder.Configuration);

            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                SeedData.Initialize(services);
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                //pattern: "{controller=HelloWorld}/{action=Index}/{id?}");
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
