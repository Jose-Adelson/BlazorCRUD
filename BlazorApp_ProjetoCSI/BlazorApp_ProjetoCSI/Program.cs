using BlazorApp_ProjetoCSI.Components;
using BlazorApp_ProjetoCSI.Data;
using BlazorApp_ProjetoCSI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorApp_ProjetoCSI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Configuração do DbContext
            builder.Services.AddDbContextFactory<MyBlazorApp_ProjetoCSIContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("MyBlazorApp_ProjetoCSIContext") ?? throw new InvalidOperationException("Connection string 'MyBlazorApp_ProjetoCSIContext' not found.")));

            builder.Services.AddQuickGridEntityFrameworkAdapter();
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            // Registro do UserService
            builder.Services.AddSingleton<UserService>();

            // Configuração dos componentes Razor
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            var app = builder.Build();

            // Configuração do pipeline de requisições HTTP
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
                app.UseMigrationsEndPoint();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}
