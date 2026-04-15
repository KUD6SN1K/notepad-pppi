/// <summary>
/// Реализация тёмной темы оформления
/// </summary>
/// <remarks>
/// Цвета: фон #1E1E1E, текст #D4D4D4, ключевые слова #569CD6, строки #CE9178, комментарии #6A9955
/// </remarks>
/// <author>KUD6SN1K</author>
/// <version>1.0.0</version>
public class DarkTheme
{
    /// <returns>Цвет фона в формате HEX (#1E1E1E)</returns>
    public string GetBackgroundColor() { return "#1E1E1E"; }

    /// <returns>Цвет текста в формате HEX (#D4D4D4)</returns>
    public string GetTextColor() { return "#D4D4D4"; }

    /// <returns>Цвет ключевых слов в формате HEX (#569CD6)</returns>
    public string GetKeywordColor() { return "#569CD6"; }

    /// <returns>Цвет строк в формате HEX (#CE9178)</returns>
    public string GetStringColor() { return "#CE9178"; }

    /// <returns>Цвет комментариев в формате HEX (#6A9955)</returns>
    public string GetCommentColor() { return "#6A9955"; }
}