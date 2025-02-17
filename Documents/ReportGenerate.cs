using QuestPDF.Fluent;
using QuestPDF.Helpers;

namespace TestReport.Documents
{
    public class ReportGenerate
    {
        public static void GeneratePDF(string filePath)
        {
            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(20);
                    page.Header()
                        .Text("Test")
                        .FontSize(20)
                        .SemiBold()
                        .AlignCenter();

                    page.Content()
                        .Column(column =>
                        {
                            column.Item().Text("Hello");
                        });

                    page.Footer()
                        .Text($"Generated on {DateTime.Now}")
                        .AlignRight()
                        .FontSize(10);
                });
            })
            .GeneratePdf(filePath);
        }
    }
}
