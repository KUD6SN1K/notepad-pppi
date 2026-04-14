/// <summary>
/// Замена текста в документе
/// </summary>
/// <remarks>
/// Позволяет заменить одно вхождение, все вхождения или выполнить замену во всех открытых файлах.
/// </remarks>
/// <author>KUD6SN1K</author>
/// <version>1.0.0</version>
public class ReplaceEngine
{
    /// <summary>
    /// Заменяет текущее выделенное совпадение
    /// </summary>
    /// <param name="newText">Текст для замены</param>
    public void ReplaceCurrent(string newText) { }

    /// <summary>
    /// Заменяет все вхождения
    /// </summary>
    /// <param name="searchText">Искомый текст</param>
    /// <param name="replaceText">Текст замены</param>
    /// <returns>Количество произведённых замен</returns>
    public int ReplaceAll(string searchText, string replaceText) { return 0; }

    /// <summary>
    /// Заменяет во всех открытых вкладках
    /// </summary>
    /// <param name="searchText">Искомый текст</param>
    /// <param name="replaceText">Текст замены</param>
    /// <returns>Общее количество замен</returns>
    public int ReplaceInAllFiles(string searchText, string replaceText) { return 0; }

    /// <summary>
    /// Показывает предпросмотр замены до применения
    /// </summary>
    /// <param name="searchText">Искомый текст</param>
    /// <param name="replaceText">Текст замены</param>
    public void ShowReplacePreview(string searchText, string replaceText) { }
}