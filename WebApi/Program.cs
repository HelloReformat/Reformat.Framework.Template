using Reformat.Framework.Core;

var builder = WebApplication.CreateBuilder(args);
builder.AddBoostSupport();

var app = builder.Build();
app.AddBoostSupport();

app.AddBanner();

app.Run();