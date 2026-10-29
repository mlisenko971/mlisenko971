using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// STEADY THE WICK. A bead of light sweeps the rail; a warm frame sits somewhere along it.
/// Tap while the bead is inside the frame and the wick steadies - one spark, and the frame
/// moves somewhere new. A miss costs a spark the player never had: the task is time-boxed,
/// never fail-boxed (rule C.5).
///
/// The sweep speed, the width of the frame and where it sits are all drawn from the
/// session's own stream, so no two runs of this task look the same (rule C.11).
/// </summary>
public sealed class _0x45239c98 : MonoBehaviour, _0x6055f8c5
{
    public string Title
    {
        get
        {
            return _0xf19326d8._0xd9cebe66(new byte[15] { 115, 116, 101, 97, 100, 121, 0, 116, 104, 101, 0, 119, 105, 99, 107 }, 32);
        }
    }

    private int _0xbf040c89 = 1;
    private float _0x4ca9299c = 260f;
    private _0xcb416fe2 _0x6478e4a5;
    private float _0xee2bf16f;
    private Image _0x5713f3a7;
    public void Finish()
    {
        this._0x5f9c565d = false;
    }

    public void SetVisible(bool _0x260819ba)
    {
        if (this._0xd59d182a != null)
            this._0xd59d182a.gameObject.SetActive(_0x260819ba);
    }

    private _0xf23fcd8b _0x9b7fff9e;
    private bool _0x5f9c565d;
    public void Tick(float _0x28134bcc)
    {
        if (!this._0x5f9c565d)
            return;
        this._0x73efc005 = this._0x73efc005 + (this._0x4ca9299c * _0x28134bcc * this._0xbf040c89);
        if (this._0x73efc005 > this._0xee2bf16f)
        {
            this._0x73efc005 = this._0xee2bf16f;
            this._0xbf040c89 = -1;
        }
        else if (this._0x73efc005 < -this._0xee2bf16f)
        {
            this._0x73efc005 = -this._0xee2bf16f;
            this._0xbf040c89 = 1;
        }

        this._0x94c63c4b();
    }

    private void _0xf17e4cc1()
    {
        if (!this._0x5f9c565d || this._0x6478e4a5 == null)
            return;
        bool _0x10affb20 = Mathf.Abs(this._0x73efc005 - this._0xbcfcb926) <= (this._0x4a5253c4 * 0.5f);
        if (!_0x10affb20)
        {
            if (this._0xbbb4f56d != null)
                this._0xbbb4f56d.rectTransform.DOPunchAnchorPos(new Vector2(0f, -8f), 0.18f, 6, 0.6f).SetLink(this._0xbbb4f56d.gameObject);
            return;
        }

        _0x23cd2ede.Flash(this._0x9b7fff9e, this._0xd59d182a, new Vector2(this._0x73efc005, 40f), new Vector2(this._0x4a5253c4, 148f));
        _0x23cd2ede.Play(this._0x9b7fff9e, this._0xe5e3ba93._0x20f0f53d, this._0xd59d182a, new Vector2(this._0x73efc005, 60f));
        if (this._0x5713f3a7 != null)
            this._0x5713f3a7.rectTransform.DOPunchScale(Vector3.one * 0.22f, 0.26f, 6, 0.7f).SetLink(this._0x5713f3a7.gameObject);
        this._0x6478e4a5._0x26eb290e();
        this._0xd5d64a1a();
        this._0x94c63c4b();
    }

    private void _0xd5d64a1a()
    {
        float _0x2cf67f80 = Mathf.Max(20f, this._0xee2bf16f - (this._0x4a5253c4 * 0.5f));
        this._0xbcfcb926 = (float)((this._0xdf99bc94.NextDouble() * 2.0) - 1.0) * _0x2cf67f80;
    }

    public void Begin(System.Random _0x0319927c)
    {
        this._0xdf99bc94 = _0x0319927c;
        this._0x5f9c565d = true;
        this._0x4ca9299c = 240f + (float)(_0x0319927c.NextDouble() * 150.0);
        this._0x4a5253c4 = 190f + (float)(_0x0319927c.NextDouble() * 110.0);
        this._0xbf040c89 = _0x0319927c.Next(2) == 0 ? -1 : 1;
        this._0x73efc005 = (float)((_0x0319927c.NextDouble() * 2.0) - 1.0) * this._0xee2bf16f * 0.6f;
        this._0xd5d64a1a();
        this._0x94c63c4b();
    }

    private void _0x94c63c4b()
    {
        if (this._0xba51616d != null)
            this._0xba51616d.anchoredPosition = new Vector2(this._0x73efc005, 40f);
        if (this._0xe1f3b98f != null)
        {
            this._0xe1f3b98f.rectTransform.anchoredPosition = new Vector2(this._0xbcfcb926, 40f);
            this._0xe1f3b98f.rectTransform.sizeDelta = new Vector2(this._0x4a5253c4, 148f);
        }
    }

    private float _0x73efc005;
    private Image _0xbbb4f56d;
    public string Hint
    {
        get
        {
            return _0xf19326d8._0xd9cebe66(new byte[34] { 15, 26, 11, 123, 12, 19, 30, 21, 123, 15, 19, 30, 123, 23, 18, 28, 19, 15, 123, 18, 8, 123, 18, 21, 123, 15, 19, 30, 123, 29, 9, 26, 22, 30 }, 91);
        }
    }

    private RectTransform _0xd59d182a;
    private _0x761f29fe _0xe5e3ba93;
    private RectTransform _0xba51616d;
    private void OnDestroy()
    {
        DOTween.Kill(this, false);
    }

    private float _0xbcfcb926;
    private System.Random _0xdf99bc94;
    private float _0x4a5253c4 = 240f;
    private Image _0xe1f3b98f;
    public void Build(_0xf23fcd8b _0x2da78eaf, _0x761f29fe _0xfd079ccc, RectTransform _0xfb249962, _0xcb416fe2 _0xe2e9d576)
    {
        this._0x9b7fff9e = _0x2da78eaf;
        this._0xe5e3ba93 = _0xfd079ccc;
        this._0x6478e4a5 = _0xe2e9d576;
        this._0xd59d182a = _0x2da78eaf._0x6f23ed2a(_0xfb249962, _0xf19326d8._0xd9cebe66(new byte[9] { 246, 200, 194, 202, 242, 213, 192, 198, 196 }, 161));
        float _0xf9e4de24 = _0xfb249962.sizeDelta.x * 0.92f;
        this._0xee2bf16f = (_0xf9e4de24 * 0.5f) - 70f;
        this._0xbbb4f56d = _0x2da78eaf._0xa061d3cf(this._0xd59d182a, _0xf19326d8._0xd9cebe66(new byte[4] { 186, 137, 129, 132 }, 232), _0xbe939921._0x7f5aa638, new Vector2(0f, 40f), new Vector2(_0xf9e4de24, 148f), _0xb20acb45.Fade(_0xb20acb45.Haze, 0.95f), 1.2f);
        _0x2da78eaf._0x546a2744(this._0xd59d182a, _0xf19326d8._0xd9cebe66(new byte[8] { 72, 123, 115, 118, 86, 115, 116, 127 }, 26), _0xbe939921._0x7f5aa638, new Vector2(0f, 40f), _0xf9e4de24 - 60f, _0xb20acb45.Fade(_0xb20acb45.Slate, 0.25f));
        this._0xe1f3b98f = _0x2da78eaf._0xa061d3cf(this._0xd59d182a, _0xf19326d8._0xd9cebe66(new byte[5] { 65, 117, 102, 106, 98 }, 7), _0xbe939921._0x7f5aa638, new Vector2(0f, 40f), new Vector2(this._0x4a5253c4, 148f), _0xb20acb45.Fade(_0xb20acb45.Gold, 0.45f), 1.1f);
        RectTransform _0xcfd5fba1 = _0x2da78eaf._0x4a32d93b(this._0xd59d182a, _0xf19326d8._0xd9cebe66(new byte[4] { 173, 138, 142, 139 }, 239), _0xbe939921._0x7f5aa638, new Vector2(0f, 40f), new Vector2(132f, 132f));
        this._0xba51616d = _0xcfd5fba1;
        this._0x5713f3a7 = _0x2da78eaf._0xa061d3cf(_0xcfd5fba1, _0xf19326d8._0xd9cebe66(new byte[8] { 100, 67, 71, 66, 97, 74, 73, 81 }, 38), _0xbe939921._0x7f5aa638, Vector2.zero, new Vector2(132f, 132f), _0xb20acb45.Fade(_0xb20acb45.Gold, 0.9f), 0.2f);
        _0x2da78eaf._0x5ab12fd7(_0xcfd5fba1, _0xf19326d8._0xd9cebe66(new byte[7] { 144, 183, 179, 182, 147, 160, 166 }, 210), _0xfd079ccc._0x20f0f53d, _0xbe939921._0x7f5aa638, Vector2.zero, 96f);
        _0x2da78eaf._0xb8fb9383(this._0xd59d182a, _0xf19326d8._0xd9cebe66(new byte[6] { 240, 217, 219, 217, 210, 216 }, 188), _0xf19326d8._0xd9cebe66(new byte[36] { 46, 32, 32, 53, 69, 49, 45, 32, 69, 41, 44, 34, 45, 49, 69, 44, 43, 54, 44, 33, 32, 69, 49, 45, 32, 69, 50, 36, 55, 40, 69, 35, 55, 36, 40, 32 }, 101), _0xbe939921._0x7f5aa638, new Vector2(0f, -140f), new Vector2(_0xf9e4de24, 58f), 30f, _0xb20acb45.SlateText, TMPro.TextAlignmentOptions.Center);
        Image _0x2fd84d92 = _0x2da78eaf._0x32cda798(this._0xd59d182a, _0xf19326d8._0xd9cebe66(new byte[7] { 46, 16, 26, 18, 49, 16, 13 }, 121), _0xb20acb45.Fade(_0xb20acb45.Mist, 0.01f));
        Button _0x123f9bb3 = _0x2da78eaf._0x61f1617d(_0x2fd84d92.gameObject, _0x2fd84d92);
        _0x123f9bb3.onClick.AddListener(() => this._0xf17e4cc1());
        _0x2fd84d92.transform.SetAsFirstSibling();
    }
}

internal static class _0xf19326d8
{
    internal static string _0xd9cebe66(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}