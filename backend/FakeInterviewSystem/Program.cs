using FakeInterviewSystem.Services.Data;
using Microsoft.EntityFrameworkCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Host.UseSerilog((ctx, lc) => lc.WriteTo.Console());
    builder.Services.AddSpaStaticFiles(configure => configure.RootPath = "wwwroot");
    builder.Services.AddControllers();
    builder.Services.AddDbContext<InterviewSystemDbContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("InterviewSystemDb")));
}
var app = builder.Build();
{
    app.UseStaticFiles();
    app.UseSerilogRequestLogging();
    app.UseRouting();
    app.MapControllers();
    app.UseSpa(configuration => configuration.Options.DefaultPage = new Microsoft.AspNetCore.Http.PathString("/index.html"));
}
app.Run();
