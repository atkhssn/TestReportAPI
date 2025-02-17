using QuestPDF;
using QuestPDF.Infrastructure;
namespace TestReport;
public class Program
{
    public static void Main(string[] args)
    {
        // Register the QuestPDF license
        Settings.License = LicenseType.Community;

        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllers();

        var app = builder.Build();
        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();
        app.Run();
    }
}