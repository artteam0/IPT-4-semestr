var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseWelcomePage("/aspnetcore");

app.UseDefaultFiles(); //�������� Index.html �� ���������
app.UseStaticFiles();

app.Run();
