# Access appsettings in WebApplicationBuilder

Settings of appsettings.json etc. can already be accessed before building the app.

Use WebApplicationBuilder.Configuration to configure the services.

<pre>
  var builder = WebApplication.CreateBuilder(args);
  
  var setting = builder.Configuration
    .GetValue<...>(key);
  
  //...use settings for configuring services etc.
  
  var app = builder.Build();

  ...
</pre>
