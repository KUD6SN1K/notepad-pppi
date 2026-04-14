/// <summary>
/// Перенос длинных строк (Word Wrap)
/// </summary>
/// <remarks>
/// Включает/выключает визуальный перенос строк без вставки символов новой строки.
/// </remarks>
/// <author>KUD6SN1K</author>
/// <version>1.0.0</version>
public class WordWrap
{
    private bool isWrapEnabled = false;

    /// <summary>
    /// Включает или выключает перенос строк
    /// </summary>
    public void ToggleWordWrap() { isWrapEnabled = !isWrapEnabled; }

    /// <summary>
    /// Проверяет, включён ли перенос
    /// </summary>
    /// <returns>true – включён, false – выключен</returns>
    public bool IsWrapEnabled() { return isWrapEnabled; }

    private void ApplyWordWrap() { }
}