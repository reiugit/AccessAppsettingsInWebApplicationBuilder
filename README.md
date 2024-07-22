# Access appsettings in WebApplicationBuilder

Settings of appsettings.json etc. can already be accessed before building the app.

1. Access settings via WebApplicationBuilder.Configuration.
2. Configure services using these settings.

<pre>
  var builder = WebApplication.CreateBuilder(args);
  
  var setting = builder.Configuration
    .GetValue<...>(key);
  
  //...use settings for configuring services etc.
  
  var app = builder.Build();

  ...
</pre>
