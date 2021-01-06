using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Intro
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // Ajoute le support des controlleurs et du moteur de Vues Razor
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseDefaultFiles(); // active la gestion des extensions standard
            app.UseStaticFiles(); // active la gestion des fichiers statiques stock�s dans le r�pertoire "wwwroot"

            app.UseRouting(); // active le routage (configuration ci-dessous)

            // ajout d'un point de terminaison HTTP
            // name = Nom de la route
            // pattern = format de l'url attendue
            //      controller : nom du contr�leur � invoquer
            //      action     : nom de la m�thode � ex�cuter dans le contr�leur invoqu�
            //      id         : valeur inject�e dans la m�thode ex�cut�e (la m�thode doit alors poss�der un argument nomm� "id")
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}
