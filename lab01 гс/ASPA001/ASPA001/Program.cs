using Microsoft.AspNetCore.HttpLogging;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args); //объект для управления веб-приложением


        builder.Services.AddHttpLogging(options => //добавляем службу логирования HTTP-запросов
        {
            options.LoggingFields = HttpLoggingFields.All; //указываем, что нужно логировать все поля HTTP-запросов
        });
        var app = builder.Build(); //экземпляр приложения
        app.UseHttpLogging(); //включаем логирование HTTP-запросов

        app.MapGet("/", () => "Мое первая ASPA");

        app.Run();
    }
}