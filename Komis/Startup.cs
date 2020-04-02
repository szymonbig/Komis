using Komis.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Komis
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)        //wstrzyknięcie zależności
        {
            Configuration = configuration;
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddTransient<ISamochodRepository, SamochodRepository>();       //gdy ktoś zapyta o ISamochodRepository to zostanie zwórcone MockSamochodReposiotry            
            services.AddMvc();                                                          //rejestracja usuług
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();           //obsługa ew. wyświetlenia numeru błędu 
            app.UseStaticFiles();               //obsługa plików statycznych
            app.UseMvcWithDefaultRoute();       //obsługa "przepływu"
        }
    }
}
