/// <summary>
/// Строка состояния приложения
/// </summary>
/// <remarks>
/// Отображает текущий язык программирования, тему оформления, позицию курсора и кодировку файла
/// </remarks>
/// <author>KUD6SN1K</author>
/// <version>1.0.0</version>
public class StatusBar
{
    /// <summary>
    /// Обновляет отображаемый язык программирования
    /// </summary>
    /// <param name="language">Название языка (C#, Python, JavaScript...)</param>
    public void UpdateLanguage(string language) { }

    /// <summary>
    /// Обновляет отображаемую тему оформления
    /// </summary>
    /// <param name="themeName">Название темы (Light, Dark...)</param>
    public void UpdateTheme(string themeName) { }

    /// <summary>
    /// Обновляет позицию курсора
    /// </summary>
    /// <param name="line">Номер строки (начиная с 1)</param>
    /// <param name="column">Номер колонки (начиная с 1)</param>
    public void UpdateCursorPosition(int line, int column) { }

    /// <summary>
    /// Обновляет информацию о кодировке файла
    /// </summary>
    /// <param name="encoding">Кодировка (UTF-8, ANSI...)</param>
    public void UpdateEncoding(string encoding) { }
}