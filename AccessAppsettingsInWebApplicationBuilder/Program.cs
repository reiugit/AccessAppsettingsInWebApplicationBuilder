using AccessAppsettingsInWebApplicationBuilder.Services;

var builder = WebApplication.CreateBuilder(args);

// 1.) Access settings via builder.Configuration
var settingForSampleService = builder.Configuration
    .GetValue<string>("Settings:SettingForSampleService");

// 2.) Configure services using these settings
builder.Services.AddSingleton<ISampleService>(new SampleService
{
    SettingValue = settingForSampleService,
    ConfiguredIn = "WebApplication-Builder"
});

var app = builder.Build();


app.MapGet("/", (ISampleService sampleService) =>
{
    return Results.Ok(sampleService);
});

app.Run();
