using Microsoft.AspNetCore.HttpLogging;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args); //������ ��� ���������� ���-�����������


        builder.Services.AddHttpLogging(options => //��������� ������ ����������� HTTP-��������
        {
            options.LoggingFields = HttpLoggingFields.All; //���������, ��� ����� ���������� ��� ���� HTTP-��������
        });
        var app = builder.Build(); //��������� ����������
        app.UseHttpLogging(); //�������� ����������� HTTP-��������

        app.MapGet("/", () => "��� ������ ASPA");

        app.Run();
    }
}