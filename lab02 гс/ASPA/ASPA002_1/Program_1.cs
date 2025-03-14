var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseWelcomePage("/aspnetcore");

app.UseDefaultFiles(); //загрузка Index.html по умолчанию
app.UseStaticFiles();

app.Run();
