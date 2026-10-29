using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The one piece of feedback every earned spark shares: a mote that rises off whatever was
/// tapped, and a warm flash under it. Rule C.7 asks a tap to confirm itself in a way a
/// reviewer can see in a still frame, so both are large, bright and slow enough to catch.
///
/// Every tween ends with SetLink to the object it animates, on one line, so a scene change
/// cannot leave DOTween animating a destroyed Image (rule C.56).
/// </summary>
public static class _0x23cd2ede
{
    public static void Flash(_0xf23fcd8b _0x0179992f, RectTransform _0xc8c422f3, Vector2 _0x1a01f14e, Vector2 _0x4003a622)
    {
        if (_0x0179992f == null || _0xc8c422f3 == null)
            return;
        Image _0x8df01edf = _0x0179992f._0xa061d3cf(_0xc8c422f3, _0xf4fee972._0x7ee56fcd(new byte[10] { 132, 167, 182, 165, 188, 145, 187, 182, 164, 191 }, 215), _0xbe939921._0x7f5aa638, _0x1a01f14e, _0x4003a622, _0xb20acb45.Fade(_0xb20acb45.Gold, 0.55f), 1.2f);
        _0x8df01edf.transform.SetAsLastSibling();
        _0x8df01edf.DOFade(0f, 0.34f).SetEase(Ease.OutQuad).OnComplete(() => Discard(_0x8df01edf)).SetLink(_0x8df01edf.gameObject);
    }

    public static void Play(_0xf23fcd8b _0x84d6f021, Sprite _0x8ef88e1e, RectTransform _0xc8468fed, Vector2 _0xf7bb7529)
    {
        if (_0x84d6f021 == null || _0xc8468fed == null)
            return;
        Image _0x2fe55390 = _0x84d6f021._0x5ab12fd7(_0xc8468fed, _0xf4fee972._0x7ee56fcd(new byte[9] { 84, 119, 102, 117, 108, 74, 104, 115, 98 }, 7), _0x8ef88e1e, _0xbe939921._0x7f5aa638, _0xf7bb7529, 88f);
        if (_0x2fe55390 == null)
            return;
        _0x2fe55390.transform.SetAsLastSibling();
        _0x2fe55390.color = Color.white;
        _0x2fe55390.rectTransform.DOAnchorPosY(_0xf7bb7529.y + 150f, 0.62f).SetEase(Ease.OutCubic).SetLink(_0x2fe55390.gameObject);
        _0x2fe55390.DOFade(0f, 0.62f).SetEase(Ease.InQuad).OnComplete(() => Discard(_0x2fe55390)).SetLink(_0x2fe55390.gameObject);
    }

    private static void Discard(Image _0xd5882809)
    {
        if (_0xd5882809 != null)
            UnityEngine.Object.Destroy(_0xd5882809.gameObject);
    }
}

internal static class _0xf4fee972
{
    internal static string _0x7ee56fcd(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}