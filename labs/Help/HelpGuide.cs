/// <summary>
/// Встроенная справочная система
/// </summary>
/// <remarks>
/// Открывается по F1. Содержит описание всех функций, примеры подсветки синтаксиса, список горячих клавиш, информацию о версии.
/// </remarks>
/// <author>KUD6SN1K</author>
/// <version>1.0.0</version>
public class HelpGuide
{
    /// <summary>
    /// Открывает окно справки
    /// </summary>
    public void OpenHelp() { }

    /// <summary>
    /// Возвращает описание указанной функции
    /// </summary>
    /// <param name="featureName">Название функции</param>
    /// <returns>Текст описания</returns>
    public string GetFeatureDescription(string featureName) { return ""; }

    /// <summary>
    /// Показывает примеры кода для разных языков
    /// </summary>
    public void ShowSyntaxExamples() { }

    /// <summary>
    /// Возвращает список всех горячих клавиш
    /// </summary>
    /// <returns>Массив строк "Ctrl+S - Сохранить"</returns>
    public string[] GetHotkeysList() { return new string[] { }; }

    /// <summary>
    /// Показывает информацию о версии и авторе
    /// </summary>
    public void ShowAbout() { }
}