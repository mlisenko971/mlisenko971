using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// CATCH THE SPARKS. Nine panes of lantern glass; one lights at a time. Tap the lit pane
/// for a spark. A tap on a dark pane costs nothing - the task is time-boxed, never
/// fail-boxed (rule C.5).
///
/// The order the panes light in is drawn from the session's stream, so the same activity
/// never repeats its pattern between runs (rule C.11).
/// </summary>
public sealed class _0x663f1558 : MonoBehaviour, _0x6055f8c5
{
    private float _0xa9b5337c;
    private void _0x636a9026(int _0x3caf90b5)
    {
        this._0xf16712a6 = _0x3caf90b5;
        for (int _0xb4bfc68b = 0; _0xb4bfc68b < PaneCount; _0xb4bfc68b++)
        {
            bool _0x1f1f7436 = _0xb4bfc68b == _0x3caf90b5;
            if (this._0xd36e5a01[_0xb4bfc68b] != null)
                this._0xd36e5a01[_0xb4bfc68b].color = _0x1f1f7436 ? _0xb20acb45.Gold : _0xb20acb45.Fade(_0xb20acb45.Haze, 0.92f);
            if (this._0x0d1c7ce1[_0xb4bfc68b] != null)
                this._0x0d1c7ce1[_0xb4bfc68b].gameObject.SetActive(_0x1f1f7436);
        }

        if (_0x3caf90b5 >= 0 && this._0x6e2d3e53[_0x3caf90b5] != null)
            this._0x6e2d3e53[_0x3caf90b5].DOPunchScale(Vector3.one * 0.08f, 0.26f, 5, 0.8f).SetLink(this._0x6e2d3e53[_0x3caf90b5].gameObject);
    }

    private bool _0x34b4f3cb;
    public void Begin(System.Random _0xbc0dd518)
    {
        this._0x7eace98b = _0xbc0dd518;
        this._0x34b4f3cb = true;
        this._0xa9b5337c = 0f;
        this._0x636a9026(_0xbc0dd518.Next(PaneCount));
    }

    private _0xcb416fe2 _0x60129a64;
    private const int PaneCount = 9;
    private int _0xf16712a6 = -1;
    private readonly Image[] _0xd36e5a01 = new Image[PaneCount];
    public void Tick(float _0x60dd116d)
    {
        if (!this._0x34b4f3cb)
            return;
        this._0xa9b5337c = this._0xa9b5337c + _0x60dd116d;
        if (this._0xf16712a6 >= 0 && this._0xa9b5337c >= _0x2360e6ef.PaneLitSeconds)
        {
            this._0x636a9026(-1);
            this._0xa9b5337c = 0f;
            return;
        }

        if (this._0xf16712a6 < 0 && this._0xa9b5337c >= _0x2360e6ef.PaneGapSeconds)
        {
            int _0xe2c1895a = this._0x7eace98b.Next(PaneCount);
            this._0x636a9026(_0xe2c1895a);
            this._0xa9b5337c = 0f;
        }
    }

    private _0xf23fcd8b _0x49ebe5ce;
    private RectTransform _0xd6b78776;
    private readonly Image[] _0x0d1c7ce1 = new Image[PaneCount];
    public void Build(_0xf23fcd8b _0x2ee6ded9, _0x761f29fe _0xe00f63a9, RectTransform _0x815a8549, _0xcb416fe2 _0xef44e4ea)
    {
        this._0x49ebe5ce = _0x2ee6ded9;
        this._0xccdb0d66 = _0xe00f63a9;
        this._0x60129a64 = _0xef44e4ea;
        this._0xd6b78776 = _0x2ee6ded9._0x6f23ed2a(_0x815a8549, _0xe0b86423._0x33654762(new byte[11] { 40, 11, 26, 9, 16, 8, 40, 15, 26, 28, 30 }, 123));
        float _0x256e806f = _0x815a8549.sizeDelta.x * 0.9f;
        float _0x6652ac8c = 26f;
        this._0xc3613ddf = _0xbe939921.Cell(_0x256e806f, Columns, _0x6652ac8c);
        float _0x640aa597 = this._0xc3613ddf + _0x6652ac8c;
        float _0x3e392352 = ((Rows - 1) * _0x640aa597) * 0.5f;
        for (int _0xc07b76a2 = 0; _0xc07b76a2 < PaneCount; _0xc07b76a2++)
        {
            int _0x4febac8a = _0xc07b76a2 % Columns;
            int _0x0282ee96 = _0xc07b76a2 / Columns;
            Vector2 _0x5844776c = new Vector2(_0xbe939921.Column(_0x256e806f, Columns, _0x6652ac8c, _0x4febac8a), _0x3e392352 - (_0x0282ee96 * _0x640aa597));
            RectTransform _0xbcf4f7f9 = _0x2ee6ded9._0x4a32d93b(this._0xd6b78776, _0xe0b86423._0x33654762(new byte[4] { 105, 88, 87, 92 }, 57), _0xbe939921._0x7f5aa638, _0x5844776c, new Vector2(this._0xc3613ddf, this._0xc3613ddf));
            Image _0x48f52871 = _0x2ee6ded9._0xb3a779c2(_0xbcf4f7f9, _0xe0b86423._0x33654762(new byte[3] { 234, 209, 213 }, 184), _0xb20acb45.Fade(_0xb20acb45.Slate, 0.40f), 1.6f);
            Image _0xd22a5ef9 = _0x2ee6ded9._0xb3a779c2(_0x48f52871.rectTransform, _0xe0b86423._0x33654762(new byte[4] { 193, 230, 228, 226 }, 135), _0xb20acb45.Fade(_0xb20acb45.Haze, 0.92f), 1.7f);
            _0xd22a5ef9.rectTransform.offsetMin = new Vector2(4f, 4f);
            _0xd22a5ef9.rectTransform.offsetMax = new Vector2(-4f, -4f);
            Image _0x0af8cf57 = _0x2ee6ded9._0x5ab12fd7(_0xd22a5ef9.rectTransform, _0xe0b86423._0x33654762(new byte[4] { 231, 204, 207, 215 }, 160), _0xe00f63a9._0x20f0f53d, _0xbe939921._0x7f5aa638, Vector2.zero, this._0xc3613ddf * 0.58f);
            _0x0af8cf57.gameObject.SetActive(false);
            Button _0x2aa76d53 = _0x2ee6ded9._0x61f1617d(_0xbcf4f7f9.gameObject, _0xd22a5ef9);
            int _0xc88d7dd6 = _0xc07b76a2;
            _0x2aa76d53.onClick.AddListener(() => this._0xdc2846f6(_0xc88d7dd6));
            this._0x6e2d3e53[_0xc07b76a2] = _0xbcf4f7f9;
            this._0xd36e5a01[_0xc07b76a2] = _0xd22a5ef9;
            this._0x0d1c7ce1[_0xc07b76a2] = _0x0af8cf57;
        }

        _0x2ee6ded9._0xb8fb9383(this._0xd6b78776, _0xe0b86423._0x33654762(new byte[6] { 248, 209, 211, 209, 218, 208 }, 180), _0xe0b86423._0x33654762(new byte[46] { 41, 40, 35, 70, 54, 39, 40, 35, 70, 39, 50, 70, 39, 70, 50, 47, 43, 35, 70, 75, 70, 40, 41, 50, 46, 47, 40, 33, 70, 47, 53, 70, 42, 41, 53, 50, 70, 36, 63, 70, 39, 70, 43, 47, 53, 53 }, 102), _0xbe939921._0x11f50216, new Vector2(0f, 56f), new Vector2(_0x256e806f, 56f), 28f, _0xb20acb45.SlateText, TMPro.TextAlignmentOptions.Center);
    }

    private readonly RectTransform[] _0x6e2d3e53 = new RectTransform[PaneCount];
    private void OnDestroy()
    {
        DOTween.Kill(this, false);
    }

    private System.Random _0x7eace98b;
    public string Hint
    {
        get
        {
            return _0xe0b86423._0x33654762(new byte[20] { 75, 94, 79, 63, 75, 87, 90, 63, 88, 83, 80, 72, 86, 81, 88, 63, 79, 94, 81, 90 }, 31);
        }
    }

    public void Finish()
    {
        this._0x34b4f3cb = false;
        this._0x636a9026(-1);
    }

    public void SetVisible(bool _0x7986dabb)
    {
        if (this._0xd6b78776 != null)
            this._0xd6b78776.gameObject.SetActive(_0x7986dabb);
    }

    private const int Rows = 3;
    private _0x761f29fe _0xccdb0d66;
    private const int Columns = 3;
    public string Title
    {
        get
        {
            return _0xe0b86423._0x33654762(new byte[16] { 205, 207, 218, 205, 198, 174, 218, 198, 203, 174, 221, 222, 207, 220, 197, 221 }, 142);
        }
    }

    private void _0xdc2846f6(int _0x9f759fa0)
    {
        if (!this._0x34b4f3cb || this._0x60129a64 == null)
            return;
        if (_0x9f759fa0 != this._0xf16712a6)
            return;
        Vector2 _0x7e449699 = this._0x6e2d3e53[_0x9f759fa0].anchoredPosition;
        _0x23cd2ede.Flash(this._0x49ebe5ce, this._0xd6b78776, _0x7e449699, new Vector2(this._0xc3613ddf, this._0xc3613ddf));
        _0x23cd2ede.Play(this._0x49ebe5ce, this._0xccdb0d66._0x20f0f53d, this._0xd6b78776, _0x7e449699);
        this._0x60129a64._0x26eb290e();
        this._0x636a9026(-1);
        this._0xa9b5337c = 0f;
    }

    private float _0xc3613ddf;
}

internal static class _0xe0b86423
{
    internal static string _0x33654762(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}