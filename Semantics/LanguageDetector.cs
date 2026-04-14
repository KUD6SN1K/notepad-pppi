/// <summary>
/// Определитель языка программирования по расширению файла
/// </summary>
/// <remarks>
/// Поддерживаемые расширения: .py (Python), .js (JavaScript), .cpp (C++), .java, .cs (C#), .html, .css
/// </remarks>
/// <author>KUD6SN1K</author>
/// <version>1.0.0</version>
public class LanguageDetector
{
    /// <summary>
    /// Определяет язык по имени файла
    /// </summary>
    /// <param name="fileName">Имя файла с расширением</param>
    /// <returns>Название языка (например, "C#") или "Unknown"</returns>
    public string DetectLanguage(string fileName) { return "Unknown"; }

    /// <summary>
    /// Устанавливает язык вручную (переопределяет автоматическое определение)
    /// </summary>
    /// <param name="language">Название языка</param>
    public void SetManualLanguage(string language) { }

    /// <summary>
    /// Возвращает список всех поддерживаемых языков
    /// </summary>
    /// <returns>Массив названий языков</returns>
    public string[] GetSupportedLanguages() { return new string[] { }; }
}