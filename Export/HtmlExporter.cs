/// <summary>
/// Экспорт документа в HTML
/// </summary>
/// <remarks>
/// Сохраняет подсветку синтаксиса и текущую тему оформления в виде CSS.
/// Генерирует отдельный HTML-файл.
/// </remarks>
/// <author>KUD6SN1K</author>
/// <version>1.0.0</version>
public class HtmlExporter
{
    /// <summary>
    /// Экспортирует документ в HTML-файл
    /// </summary>
    /// <param name="outputPath">Путь для сохранения</param>
    public void ExportToHtml(string outputPath) { }

    /// <summary>
    /// Генерирует CSS для текущей темы
    /// </summary>
    /// <returns>CSS-строка</returns>
    public string GenerateCssForTheme() { return ""; }

    /// <summary>
    /// Оборачивает содержимое в HTML-шаблон
    /// </summary>
    /// <param name="content">Содержимое документа</param>
    /// <param name="css">CSS-стили</param>
    /// <returns>Полный HTML-документ</returns>
    public string WrapInHtmlTemplate(string content, string css) { return ""; }
}