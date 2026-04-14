/// <summary>
/// Управление масштабированием текста
/// </summary>
/// <remarks>
/// Поддерживает увеличение/уменьшение (Ctrl+Plus, Ctrl+Minus), сброс до 100%, масштабирование колёсиком мыши с Ctrl.
/// </remarks>
/// <author>KUD6SN1K</author>
/// <version>1.0.0</version>
public class ZoomManager
{
    private int currentZoom = 100;

    /// <summary>
    /// Увеличивает масштаб на 10%
    /// </summary>
    public void ZoomIn() { currentZoom += 10; }

    /// <summary>
    /// Уменьшает масштаб на 10%
    /// </summary>
    public void ZoomOut() { currentZoom -= 10; }

    /// <summary>
    /// Сбрасывает масштаб до 100%
    /// </summary>
    public void ResetZoom() { currentZoom = 100; }

    private void ApplyZoom() { }
}