namespace AccessAppsettingsInWebApplicationBuilder.Services;

public class SampleService() : ISampleService
{
    public string? Service { get; init; } = nameof(SampleService);
    public string? SettingValue { get; init; }
    public string? ConfiguredIn { get; init; }
}