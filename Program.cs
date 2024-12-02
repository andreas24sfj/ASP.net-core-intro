var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseDefaultFiles(); // gjør sånn at home redirecter til /index.html
app.UseStaticFiles();  // leter etter html og styling i default folder wwwroot


app.MapGet("/health", () =>
{
    return "Server OK";
});

app.Run();

