using Microsoft.AspNetCore.Builder;
using AdventureWorksNS.Data;

namespace AdventureWorksWeb
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AdventureWorksDBContext();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
            if (!env.IsDevelopment())
            {
                app.UseHsts();
            }
            app.UseRouting(); // usar paths
            app.UseDefaultFiles(); // usar index.cshtml
            app.UseStaticFiles(); // Carpeta wwwroot
            app.UseHttpsRedirection();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages(); //Carpeta Pages
                //endpoints.MapGet("/Hola", () => "Hola como estan");
            });
        }
    }
}
