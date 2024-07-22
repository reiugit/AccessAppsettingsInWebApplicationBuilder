namespace AccessAppsettingsInWebApplicationBuilder.Services;

internal interface ISampleService
{
    string? Service { get; init; }
    string? SettingValue { get; init; }
    string? ConfiguredIn { get; init; }
}