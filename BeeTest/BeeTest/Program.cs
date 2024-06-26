using BeeTest;
using BeeTest.Data;
using BeeTest.Authentication;
using BeeTest.Services.Classes;
using BeeTest.Services.Interfaces;
using BeeTest.Hubs;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.ResponseCompression;
using MudBlazor.Services;
using MudBlazor;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<Seed>();
builder.Services.AddAuthenticationCore();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddSignalR();
builder.Services.AddResponseCompression(options =>
{
    options.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(new[] {"application/octet-stream"});
});

builder.Services.AddScoped<IScrollManager, ScrollManager>();
builder.Services.AddScoped<IBrowserWindowSizeProvider, BrowserWindowSizeProvider>();
builder.Services.AddScoped<IBreakpointService, BreakpointService>();
builder.Services.AddScoped<IKeyInterceptorFactory, KeyInterceptorFactory>();
builder.Services.AddScoped<IMudPopoverService, MudPopoverService>();
builder.Services.AddScoped<ISnackbar, SnackbarService>();

builder.Services.AddScoped<ProtectedSessionStorage>();
builder.Services.AddScoped<AuthenticationStateProvider, AuthStateProvider>();

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IRoleService, RoleService>();
builder.Services.AddTransient<ITestService, TestService>();
builder.Services.AddTransient<IQuestionTypeService, QuestionTypeService>();
builder.Services.AddTransient<IQuestionService, QuestionService>();
builder.Services.AddTransient<IScheduleService, ScheduleService>();
builder.Services.AddTransient<IParticipant_ScheduleService, Participant_ScheduleService>();
builder.Services.AddTransient<ITemporaryAnswerService, TemporaryAnswerService>();

var app = builder.Build();

if (args.Length == 1 && args[0].ToLower() == "seed") SeedData(app);

void SeedData(IHost app)
{
    var scopedFactory = app.Services.GetService<IServiceScopeFactory>();

    using (var scope = scopedFactory.CreateScope())
    {
        var service = scope.ServiceProvider.GetService<Seed>();
        service.SeedDataContext();
    }
}

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapBlazorHub();
app.MapHub<ClockHub>("/clockhub");
app.MapFallbackToPage("/_Host");

app.Run();