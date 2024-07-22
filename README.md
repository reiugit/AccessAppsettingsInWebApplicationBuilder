# AccessAppsettingsInWebApplicationBuilder

Settings of appsettings.json etc. can already be accessed before building the app.

<pre>
  var builder = WebApplication.CreateBuilder(args);
  
  var setting = builder.Configuration
    .GetValue<...>(key);
  
  //...use settings for configuring services etc.
  
  var app = builder.Build();
</pre>
