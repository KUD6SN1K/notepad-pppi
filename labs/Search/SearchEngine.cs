/// <summary>
/// Поиск текста в документе
/// </summary>
/// <remarks>
/// Поддерживает учёт регистра, поиск целых слов, регулярные выражения.
/// Подсвечивает все найденные совпадения.
/// </remarks>
/// <author>KUD6SN1K</author>
/// <version>1.0.0</version>
public class SearchEngine
{
    /// <summary>
    /// Ищет следующее вхождение
    /// </summary>
    /// <param name="searchText">Искомый текст</param>
    /// <param name="startPosition">Позиция начала поиска</param>
    /// <returns>Позиция найденного совпадения или -1</returns>
    public int FindNext(string searchText, int startPosition) { return -1; }

    /// <summary>
    /// Находит все вхождения
    /// </summary>
    /// <param name="searchText">Искомый текст</param>
    /// <returns>Массив позиций всех совпадений</returns>
    public int[] FindAllMatches(string searchText) { return new int[] { }; }

    /// <summary>
    /// Подсвечивает все найденные совпадения в документе
    /// </summary>
    /// <param name="searchText">Искомый текст</param>
    public void HighlightAllMatches(string searchText) { }

    /// <summary>
    /// Включает/выключает учёт регистра
    /// </summary>
    /// <param name="enabled">true – учитывать регистр</param>
    public void SetCaseSensitive(bool enabled) { }

    /// <summary>
    /// Включает/выключает режим регулярных выражений
    /// </summary>
    /// <param name="enabled">true – использовать regex</param>
    public void SetUseRegex(bool enabled) { }
}