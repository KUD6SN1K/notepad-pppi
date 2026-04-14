/// <summary>
/// Автодополнение кода
/// </summary>
/// <remarks>
/// Предлагает варианты завершения ключевых слов, имён переменных и функций.
/// Вызов по Ctrl+Space.
/// </remarks>
/// <author>KUD6SN1K</author>
/// <version>1.0.0</version>
public class Autocomplete
{
    /// <summary>
    /// Показывает выпадающий список подсказок
    /// </summary>
    /// <param name="currentWord">Частично введённое слово</param>
    public void ShowSuggestions(string currentWord) { }

    /// <summary>
    /// Возвращает ключевые слова для указанного языка
    /// </summary>
    /// <param name="language">Название языка</param>
    /// <returns>Массив ключевых слов</returns>
    public string[] GetKeywordsForLanguage(string language) { return new string[] { }; }

    /// <summary>
    /// Вставляет выбранную подсказку в документ
    /// </summary>
    /// <param name="suggestion">Выбранное слово</param>
    public void InsertSuggestion(string suggestion) { }

    /// <summary>
    /// Собирает имена переменных из текущего документа
    /// </summary>
    /// <returns>Массив имён переменных</returns>
    public string[] GetVariableNames() { return new string[] { }; }
}