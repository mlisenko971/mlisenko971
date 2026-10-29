using TMPro;
using UnityEngine;

/// <summary>
/// Wrapping, autosize and outline discipline for labels built from code.
///
/// Stage 5c3 reads scenes and prefabs; a label created at runtime is in neither file, so
/// everything rule C.10 asks for has to be applied here. Word wrap is OFF and every line
/// break is an explicit escape inside the string, so a caption occupies the same number
/// of lines on every device. Autosize is ON with the readability floor of rule C.12 as
/// its minimum - including on counters and timers, where the unity:optimize-text-mesh-pro
/// advice to switch autosize off is deliberately overridden.
///
/// This app is LIGHT, so the outline is light and every face colour is dark. The outline
/// is Mist for the dark faces this app uses, which measures far past the 4.5:1 rule C.14
/// asks for; the lum test below is the guard for anything that is ever tinted lighter.
/// </summary>
public static class _0xd90280ba
{
    public static void SetTint(TMP_Text _0x12213e4c, Color _0x94f83608)
    {
        if (_0x12213e4c == null)
            return;
        _0x12213e4c.color = _0x94f83608;
        ApplyOutline(_0x12213e4c);
    }

    public static void SetText(TMP_Text _0xa2191cd8, string _0x9cccae5a)
    {
        if (_0xa2191cd8 == null)
            return;
        _0xa2191cd8.text = _0x9cccae5a;
        ApplyOutline(_0xa2191cd8);
    }

    public const float UiFontFloor = 26f;
    public static void Apply(TMP_Text _0xcc63a72d, float _0x2ad8029d)
    {
        if (_0xcc63a72d == null)
            return;
        _0xcc63a72d.textWrappingMode = TextWrappingModes.NoWrap;
        _0xcc63a72d.overflowMode = TextOverflowModes.Overflow;
        _0xcc63a72d.enableAutoSizing = true;
        _0xcc63a72d.fontSizeMin = UiFontFloor;
        _0xcc63a72d.fontSizeMax = Mathf.Max(UiFontFloor, _0x2ad8029d);
        _0xcc63a72d.fontSize = Mathf.Max(UiFontFloor, _0x2ad8029d);
        _0xcc63a72d.richText = false;
        ApplyOutline(_0xcc63a72d);
    }

    /// <summary>
    /// Gives the label its own material instance carrying an outline that contrasts its
    /// face. Reading fontMaterial is what creates that instance; the shared asset the
    /// pipeline themes is left untouched.
    /// </summary>
    public static void ApplyOutline(TMP_Text _0x345d15be)
    {
        if (_0x345d15be == null)
            return;
        Material _0xbb0fa3ab = _0x345d15be.fontMaterial;
        if (_0xbb0fa3ab == null)
            return;
        Color _0x5d1532ee = _0x345d15be.color;
        float _0x59c839b6 = (0.299f * _0x5d1532ee.r) + (0.587f * _0x5d1532ee.g) + (0.114f * _0x5d1532ee.b);
        Color _0x9b9e5620 = _0x59c839b6 < 0.5f ? _0xb20acb45.Mist : _0xb20acb45.Ink;
        _0xbb0fa3ab.EnableKeyword(ShaderUtilities.Keyword_Outline);
        _0xbb0fa3ab.SetColor(ShaderUtilities.ID_OutlineColor, _0x9b9e5620);
        _0xbb0fa3ab.SetFloat(ShaderUtilities.ID_OutlineWidth, 0.22f);
        _0xbb0fa3ab.SetFloat(ShaderUtilities.ID_FaceDilate, 0.18f);
    }
}