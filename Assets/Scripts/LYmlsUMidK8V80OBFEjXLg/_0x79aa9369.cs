using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// TRIM THE PANES. Six panes ring the lantern and some of them have gone sooty. Tap a
/// sooty pane to clean it - one spark each. A fresh set clouds over every few seconds, so
/// there is always something to do and never anything to lose (rule C.5).
///
/// Which panes are sooty, and how many, is drawn from the session's stream (rule C.11).
/// </summary>
public sealed class _0x79aa9369 : MonoBehaviour, _0x6055f8c5
{
    public void Finish()
    {
        this._0xe213fbe4 = false;
    }

    /// <summary>Clouds two to four panes, never all of them and never none.</summary>
    private void _0x1d37932f()
    {
        int _0x665627e5 = 2 + this._0x52ad5b55.Next(0, 3);
        for (int _0x4b5ab520 = 0; _0x4b5ab520 < _0x2360e6ef.SootyPaneCount; _0x4b5ab520++)
            this._0x58b4b14b[_0x4b5ab520] = false;
        int _0x56ac1d64 = 0;
        int _0xde62bb4a = 0;
        while (_0x56ac1d64 < _0x665627e5 && _0xde62bb4a < 60)
        {
            _0xde62bb4a = _0xde62bb4a + 1;
            int _0xa4d409a6 = this._0x52ad5b55.Next(_0x2360e6ef.SootyPaneCount);
            if (this._0x58b4b14b[_0xa4d409a6])
                continue;
            this._0x58b4b14b[_0xa4d409a6] = true;
            _0x56ac1d64 = _0x56ac1d64 + 1;
        }

        this._0x3c741d45();
    }

    public void Build(_0xf23fcd8b _0xfa37cd1d, _0x761f29fe _0x4d81c7bb, RectTransform _0x75d87c5c, _0xcb416fe2 _0xc7f0dbc3)
    {
        this._0xd4500ea1 = _0xfa37cd1d;
        this._0xc986d84f = _0x4d81c7bb;
        this._0xf4715d96 = _0xc7f0dbc3;
        this._0xf5b37ae0 = _0xfa37cd1d._0x6f23ed2a(_0x75d87c5c, _0x02dec3da._0x91d58e47(new byte[10] { 224, 209, 222, 213, 195, 227, 196, 209, 215, 213 }, 176));
        float _0xfe0ca9a5 = _0x75d87c5c.sizeDelta.x * 0.9f;
        float _0x0765313a = 28f;
        this._0x520708b2 = _0xbe939921.Cell(_0xfe0ca9a5, Columns, _0x0765313a);
        float _0x89eef8bc = this._0x520708b2 + _0x0765313a;
        float _0xd14d9ba2 = (((Rows - 1) * _0x89eef8bc) * 0.5f) + 40f;
        for (int _0xbdb819a7 = 0; _0xbdb819a7 < _0x2360e6ef.SootyPaneCount; _0xbdb819a7++)
        {
            int _0x522afa24 = _0xbdb819a7 % Columns;
            int _0xed1d88d0 = _0xbdb819a7 / Columns;
            Vector2 _0xbe73f55f = new Vector2(_0xbe939921.Column(_0xfe0ca9a5, Columns, _0x0765313a, _0x522afa24), _0xd14d9ba2 - (_0xed1d88d0 * _0x89eef8bc));
            RectTransform _0x6e4d0538 = _0xfa37cd1d._0x4a32d93b(this._0xf5b37ae0, _0x02dec3da._0x91d58e47(new byte[4] { 154, 171, 164, 175 }, 202), _0xbe939921._0x7f5aa638, _0xbe73f55f, new Vector2(this._0x520708b2, this._0x520708b2));
            Image _0x9f260b7d = _0xfa37cd1d._0xb3a779c2(_0x6e4d0538, _0x02dec3da._0x91d58e47(new byte[3] { 187, 128, 132 }, 233), _0xb20acb45.Fade(_0xb20acb45.Slate, 0.45f), 1.5f);
            Image _0x89b4364c = _0xfa37cd1d._0xb3a779c2(_0x9f260b7d.rectTransform, _0x02dec3da._0x91d58e47(new byte[4] { 26, 61, 63, 57 }, 92), _0xb20acb45.Fade(_0xb20acb45.Mist, 0.95f), 1.6f);
            _0x89b4364c.rectTransform.offsetMin = new Vector2(5f, 5f);
            _0x89b4364c.rectTransform.offsetMax = new Vector2(-5f, -5f);
            Image _0xa46db129 = _0xfa37cd1d._0x5ab12fd7(_0x89b4364c.rectTransform, _0x02dec3da._0x91d58e47(new byte[4] { 104, 89, 86, 93 }, 56), _0x4d81c7bb._0x4438f135, _0xbe939921._0x7f5aa638, Vector2.zero, this._0x520708b2 * 0.62f);
            Button _0x6cdcfdd1 = _0xfa37cd1d._0x61f1617d(_0x6e4d0538.gameObject, _0x89b4364c);
            int _0x53d201aa = _0xbdb819a7;
            _0x6cdcfdd1.onClick.AddListener(() => this._0x14901795(_0x53d201aa));
            this._0xbd4cc559[_0xbdb819a7] = _0x6e4d0538;
            this._0xf025e666[_0xbdb819a7] = _0x89b4364c;
            this._0xcdb94423[_0xbdb819a7] = _0xa46db129;
        }

        _0xfa37cd1d._0xb8fb9383(this._0xf5b37ae0, _0x02dec3da._0x91d58e47(new byte[6] { 210, 251, 249, 251, 240, 250 }, 158), _0x02dec3da._0x91d58e47(new byte[27] { 113, 126, 119, 115, 124, 18, 117, 126, 115, 97, 97, 18, 121, 119, 119, 98, 97, 18, 123, 102, 97, 18, 126, 123, 117, 122, 102 }, 50), _0xbe939921._0x11f50216, new Vector2(0f, 56f), new Vector2(_0xfe0ca9a5, 56f), 28f, _0xb20acb45.SlateText, TMPro.TextAlignmentOptions.Center);
    }

    public void SetVisible(bool _0x739e7483)
    {
        if (this._0xf5b37ae0 != null)
            this._0xf5b37ae0.gameObject.SetActive(_0x739e7483);
    }

    private readonly Image[] _0xf025e666 = new Image[_0x2360e6ef.SootyPaneCount];
    private bool _0x439a1c62()
    {
        for (int _0x46725cd5 = 0; _0x46725cd5 < _0x2360e6ef.SootyPaneCount; _0x46725cd5++)
            if (this._0x58b4b14b[_0x46725cd5])
                return true;
        return false;
    }

    private System.Random _0x52ad5b55;
    private float _0x520708b2;
    private RectTransform _0xf5b37ae0;
    private float _0x8ad1e9c4;
    private void _0x14901795(int _0x6e3d1bca)
    {
        if (!this._0xe213fbe4 || this._0xf4715d96 == null)
            return;
        if (!this._0x58b4b14b[_0x6e3d1bca])
            return;
        this._0x58b4b14b[_0x6e3d1bca] = false;
        this._0x3c741d45();
        Vector2 _0x3a689114 = this._0xbd4cc559[_0x6e3d1bca].anchoredPosition;
        _0x23cd2ede.Flash(this._0xd4500ea1, this._0xf5b37ae0, _0x3a689114, new Vector2(this._0x520708b2, this._0x520708b2));
        _0x23cd2ede.Play(this._0xd4500ea1, this._0xc986d84f._0x20f0f53d, this._0xf5b37ae0, _0x3a689114);
        if (this._0xbd4cc559[_0x6e3d1bca] != null)
            this._0xbd4cc559[_0x6e3d1bca].DOPunchScale(Vector3.one * 0.1f, 0.26f, 5, 0.8f).SetLink(this._0xbd4cc559[_0x6e3d1bca].gameObject);
        this._0xf4715d96._0x26eb290e();
    }

    public void Tick(float _0x21d58f61)
    {
        if (!this._0xe213fbe4)
            return;
        this._0x8ad1e9c4 = this._0x8ad1e9c4 + _0x21d58f61;
        if (this._0x8ad1e9c4 < _0x2360e6ef.SootyRollSeconds && this._0x439a1c62())
            return;
        this._0x8ad1e9c4 = 0f;
        this._0x1d37932f();
    }

    private void OnDestroy()
    {
        DOTween.Kill(this, false);
    }

    private const int Columns = 3;
    private _0xcb416fe2 _0xf4715d96;
    private _0x761f29fe _0xc986d84f;
    private bool _0xe213fbe4;
    private const int Rows = 2;
    public string Title
    {
        get
        {
            return _0x02dec3da._0x91d58e47(new byte[14] { 12, 10, 17, 21, 120, 12, 16, 29, 120, 8, 25, 22, 29, 11 }, 88);
        }
    }

    private readonly Image[] _0xcdb94423 = new Image[_0x2360e6ef.SootyPaneCount];
    private readonly bool[] _0x58b4b14b = new bool[_0x2360e6ef.SootyPaneCount];
    private readonly RectTransform[] _0xbd4cc559 = new RectTransform[_0x2360e6ef.SootyPaneCount];
    public void Begin(System.Random _0x035f4b59)
    {
        this._0x52ad5b55 = _0x035f4b59;
        this._0xe213fbe4 = true;
        this._0x8ad1e9c4 = 0f;
        this._0x1d37932f();
    }

    private void _0x3c741d45()
    {
        for (int _0x6ccc3081 = 0; _0x6ccc3081 < _0x2360e6ef.SootyPaneCount; _0x6ccc3081++)
        {
            bool _0xab1db433 = this._0x58b4b14b[_0x6ccc3081];
            if (this._0xf025e666[_0x6ccc3081] != null)
                this._0xf025e666[_0x6ccc3081].color = _0xab1db433 ? _0xb20acb45.Fade(_0xb20acb45.Slate, 0.38f) : _0xb20acb45.Fade(_0xb20acb45.Mist, 0.95f);
            if (this._0xcdb94423[_0x6ccc3081] != null)
            {
                this._0xcdb94423[_0x6ccc3081].sprite = _0xab1db433 ? this._0xc986d84f._0x4438f135 : this._0xc986d84f._0x43f281af;
                this._0xcdb94423[_0x6ccc3081].color = _0xab1db433 ? _0xb20acb45.Fade(Color.white, 0.55f) : Color.white;
            }
        }
    }

    public string Hint
    {
        get
        {
            return _0x02dec3da._0x91d58e47(new byte[19] { 186, 175, 190, 206, 186, 166, 171, 206, 189, 161, 161, 186, 183, 206, 190, 175, 160, 171, 189 }, 238);
        }
    }

    private _0xf23fcd8b _0xd4500ea1;
}

internal static class _0x02dec3da
{
    internal static string _0x91d58e47(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}