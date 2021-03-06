namespace Rcon.Api
{
    using DSharpPlus;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Rcon.Core;
    using Rcon.Data;
    using Rcon.Services.Services;

    public class Startup
    {
        public Startup(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection _services)
        {
            _services.AddControllers();

            _services.AddHostedService<BotService>();

            _services.AddSingleton(FileReaderService.GetRconConfig());
            _services.AddSingleton(FileReaderService.GetBotConfig());
            _services.AddSingleton<DiscordClient>();
            _services.AddSingleton<RconService>();

            _services.AddScoped<IUnitOfWork, UnitOfWork>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder _app, IWebHostEnvironment _env)
        {
            if (_env.IsDevelopment())
            {
                _app.UseDeveloperExceptionPage();
            }

            _app.UseRouting();

            _app.UseAuthorization();

            _app.UseEndpoints(_endpoints =>
            {
                _endpoints.MapControllers();
            });
        }
    }
}
