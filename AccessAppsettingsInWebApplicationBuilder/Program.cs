using AccessAppsettingsInWebApplicationBuilder.Services;

var builder = WebApplication.CreateBuilder(args);

//Settings of appsettings.json etc. can already
//be accessed here before building the app.
var settingForSampleService = builder.Configuration
    .GetValue<string>("Settings:SettingForSampleService");

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
