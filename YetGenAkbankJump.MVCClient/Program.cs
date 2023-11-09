using OpenAI.Extensions;
using YetGenAkbankJump.MVCClient.Services;
using YetGenAkbankJump.Shared.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//builder.Services.AddOpenAIService(settings => settings.ApiKey = "");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7030/api/") });

builder.Services.AddSingleton<ITextService, MvcTextService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
