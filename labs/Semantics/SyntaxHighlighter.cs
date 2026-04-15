/// <summary>
/// Выполняет подсветку синтаксиса для текущего документа
/// </summary>
/// <remarks>
/// Подсвечивает ключевые слова, строки, комментарии, числа, операторы.
/// Цвета зависят от выбранной темы оформления.
/// </remarks>
/// <author>KUD6SN1K</author>
/// <version>1.0.0</version>
public class SyntaxHighlighter
{
    /// <summary>
    /// Подсвечивает текущую строку (изменяет фон)
    /// </summary>
    /// <param name="lineNumber">Номер строки</param>
    public void HighlightCurrentLine(int lineNumber) { }

    /// <summary>
    /// Подсвечивает все ключевые слова в документе
    /// </summary>
    public void HighlightKeywords() { }

    /// <summary>
    /// Подсвечивает все строковые литералы
    /// </summary>
    public void HighlightStrings() { }

    /// <summary>
    /// Подсвечивает все комментарии
    /// </summary>
    public void HighlightComments() { }

    /// <summary>
    /// Переподсвечивает весь документ заново
    /// </summary>
    public void RehighlightAll() { }
}