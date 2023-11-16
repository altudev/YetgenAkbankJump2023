using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System.Globalization;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using YetGenAkbankJump.Persistence.Contexts;
using YetGenAkbankJump.Persistence.Utilities;
using YetGenAkbankJump.Shared;
using YetGenAkbankJump.Shared.Services;
using YetGenAkbankJump.Shared.Utilities;
using YetGenAkbankJump.WebApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
    .AddJsonOptions(opt =>
    {
        opt.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    });
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<PasswordGenerator>();

builder.Services.AddSingleton<RequestCountService>(new RequestCountService());

builder.Services.AddScoped<ExcelManager>();

builder.Services.AddScoped<FakeDataService>();

builder.Services.AddMemoryCache();


var textPath = builder.Configuration.GetSection("TextPath").Value;

builder.Services.AddSingleton<IIPService, IPService>();

builder.Services.AddSingleton<ITextService,TextService>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder => builder
            .AllowAnyMethod()
            .AllowCredentials()
            .SetIsOriginAllowed((host) => true)
            .AllowAnyHeader());
});

var connectionString = builder.Configuration.GetSection("YetgenPostgreSQLDB").Value;

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseNpgsql(connectionString);
});

builder.Services.AddLocalization(options =>
{
    options.ResourcesPath = "Resources";
});

builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    var trCulture = new CultureInfo("tr-TR");

    List<CultureInfo> cultureInfos = new()
    {
        trCulture,
        new("en-GB"),
    };

    options.SupportedCultures = cultureInfos;

    options.SupportedUICultures = cultureInfos;

    options.DefaultRequestCulture = new RequestCulture(trCulture);

    options.ApplyCurrentCultureToResponseHeaders = true;
});

builder.Services.AddSharedServices();

var app = builder.Build();

app.UseCors("AllowAll");


var requestLocalizationOptions = app.Services.GetService<IOptions<RequestLocalizationOptions>>();

if (requestLocalizationOptions is not null) app.UseRequestLocalization(requestLocalizationOptions.Value);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
