using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// READ THE GLOW. Three lanterns burn at different strengths; tap the brightest. A wrong
/// read costs nothing and the three are re-rolled every few seconds, so the activity keeps
/// offering chances for the whole of its window (rule C.5).
///
/// The three brightnesses are drawn from the session's stream and are always separated
/// enough to be told apart on a phone - a guess the player cannot make is not a game.
/// </summary>
public sealed class _0x93e5e2b8 : MonoBehaviour, _0x6055f8c5
{
    private void OnDestroy()
    {
        DOTween.Kill(this, false);
    }

    private void _0x3c3cfdcc(int _0xece5c36c)
    {
        if (!this._0x9e6e9306 || this._0xae873dc8 == null)
            return;
        if (_0xece5c36c != this._0xf623f1a9)
        {
            if (this._0x8c672267[_0xece5c36c] != null)
                this._0x8c672267[_0xece5c36c].DOPunchAnchorPos(new Vector2(0f, -10f), 0.2f, 6, 0.7f).SetLink(this._0x8c672267[_0xece5c36c].gameObject);
            _0xd90280ba.SetText(this._0x8c9ddb4a, _0x8d6803da._0xd97af71c(new byte[30] { 127, 99, 106, 127, 11, 100, 101, 110, 11, 98, 120, 11, 111, 98, 102, 102, 110, 121, 11, 6, 11, 127, 121, 114, 11, 106, 108, 106, 98, 101 }, 43));
            return;
        }

        Vector2 _0x97c19196 = this._0x8c672267[_0xece5c36c].anchoredPosition;
        _0x23cd2ede.Flash(this._0xca50d4d2, this._0x7e105cd2, _0x97c19196, new Vector2(this._0xd2674128, this._0xd2674128 * 1.25f));
        _0x23cd2ede.Play(this._0xca50d4d2, this._0x2e42148d._0x20f0f53d, this._0x7e105cd2, _0x97c19196);
        if (this._0x8c672267[_0xece5c36c] != null)
            this._0x8c672267[_0xece5c36c].DOPunchScale(Vector3.one * 0.12f, 0.28f, 5, 0.8f).SetLink(this._0x8c672267[_0xece5c36c].gameObject);
        _0xd90280ba.SetText(this._0x8c9ddb4a, _0x8d6803da._0xd97af71c(new byte[21] { 157, 138, 142, 139, 239, 155, 157, 154, 138, 239, 226, 239, 128, 129, 138, 239, 156, 159, 142, 157, 132 }, 207));
        this._0xae873dc8._0x26eb290e();
        this._0xf27608ec = 0f;
        this._0x0430bd2c();
    }

    public void SetVisible(bool _0xa668f30a)
    {
        if (this._0x7e105cd2 != null)
            this._0x7e105cd2.gameObject.SetActive(_0xa668f30a);
    }

    private int _0xf623f1a9;
    private _0x761f29fe _0x2e42148d;
    private float _0xd2674128;
    private readonly Image[] _0xa634f875 = new Image[_0x2360e6ef.GlowLanternCount];
    public void Build(_0xf23fcd8b _0x74d239f0, _0x761f29fe _0x046dc9ce, RectTransform _0x5be33546, _0xcb416fe2 _0x913026f0)
    {
        this._0xca50d4d2 = _0x74d239f0;
        this._0x2e42148d = _0x046dc9ce;
        this._0xae873dc8 = _0x913026f0;
        this._0x7e105cd2 = _0x74d239f0._0x6f23ed2a(_0x5be33546, _0x8d6803da._0xd97af71c(new byte[9] { 28, 55, 52, 44, 8, 47, 58, 60, 62 }, 91));
        float _0xe127856f = _0x5be33546.sizeDelta.x * 0.92f;
        float _0x0118bc7a = 36f;
        this._0xd2674128 = _0xbe939921.Cell(_0xe127856f, _0x2360e6ef.GlowLanternCount, _0x0118bc7a);
        for (int _0x1a9cd1dc = 0; _0x1a9cd1dc < _0x2360e6ef.GlowLanternCount; _0x1a9cd1dc++)
        {
            Vector2 _0x923cf883 = new Vector2(_0xbe939921.Column(_0xe127856f, _0x2360e6ef.GlowLanternCount, _0x0118bc7a, _0x1a9cd1dc), 60f);
            RectTransform _0xf0a41dda = _0x74d239f0._0x4a32d93b(this._0x7e105cd2, _0x8d6803da._0xd97af71c(new byte[7] { 239, 194, 205, 215, 198, 209, 205 }, 163), _0xbe939921._0x7f5aa638, _0x923cf883, new Vector2(this._0xd2674128, this._0xd2674128 * 1.25f));
            Image _0xd7cce657 = _0x74d239f0._0xb3a779c2(_0xf0a41dda, _0x8d6803da._0xd97af71c(new byte[3] { 204, 247, 243 }, 158), _0xb20acb45.Fade(_0xb20acb45.Slate, 0.34f), 1.5f);
            Image _0x43917cb5 = _0x74d239f0._0xb3a779c2(_0xd7cce657.rectTransform, _0x8d6803da._0xd97af71c(new byte[4] { 139, 172, 174, 168 }, 205), _0xb20acb45.Fade(_0xb20acb45.Mist, 0.94f), 1.6f);
            _0x43917cb5.rectTransform.offsetMin = new Vector2(4f, 4f);
            _0x43917cb5.rectTransform.offsetMax = new Vector2(-4f, -4f);
            Image _0xef70c4a2 = _0x74d239f0._0xa061d3cf(_0x43917cb5.rectTransform, _0x8d6803da._0xd97af71c(new byte[4] { 40, 1, 12, 15 }, 96), _0xbe939921._0x7f5aa638, Vector2.zero, new Vector2(this._0xd2674128 * 0.82f, this._0xd2674128 * 0.82f), _0xb20acb45.Fade(_0xb20acb45.Gold, 0.3f), 0.2f);
            Image _0x3834bc3c = _0x74d239f0._0x5ab12fd7(_0x43917cb5.rectTransform, _0x8d6803da._0xd97af71c(new byte[3] { 76, 127, 121 }, 13), _0x046dc9ce._0x43f281af, _0xbe939921._0x7f5aa638, Vector2.zero, this._0xd2674128 * 0.72f);
            Button _0x5971fc8e = _0x74d239f0._0x61f1617d(_0xf0a41dda.gameObject, _0x43917cb5);
            int _0x6525906c = _0x1a9cd1dc;
            _0x5971fc8e.onClick.AddListener(() => this._0x3c3cfdcc(_0x6525906c));
            this._0x8c672267[_0x1a9cd1dc] = _0xf0a41dda;
            this._0x2c063990[_0x1a9cd1dc] = _0x3834bc3c;
            this._0xa634f875[_0x1a9cd1dc] = _0xef70c4a2;
        }

        this._0x8c9ddb4a = _0x74d239f0._0xb8fb9383(this._0x7e105cd2, _0x8d6803da._0xd97af71c(new byte[7] { 18, 37, 33, 36, 47, 53, 52 }, 64), _0x8d6803da._0xd97af71c(new byte[23] { 141, 146, 147, 153, 146, 250, 149, 148, 159, 250, 152, 143, 136, 148, 137, 250, 146, 155, 136, 158, 159, 137, 142 }, 218), _0xbe939921._0x11f50216, new Vector2(0f, 60f), new Vector2(_0xe127856f, 62f), 30f, _0xb20acb45.SlateText, TextAlignmentOptions.Center);
    }

    private _0xcb416fe2 _0xae873dc8;
    public string Hint
    {
        get
        {
            return _0x8d6803da._0xd97af71c(new byte[25] { 173, 184, 169, 217, 173, 177, 188, 217, 187, 171, 176, 190, 177, 173, 188, 170, 173, 217, 181, 184, 183, 173, 188, 171, 183 }, 249);
        }
    }

    private bool _0x9e6e9306;
    private readonly RectTransform[] _0x8c672267 = new RectTransform[_0x2360e6ef.GlowLanternCount];
    public void Finish()
    {
        this._0x9e6e9306 = false;
    }

    public void Tick(float _0x743fca51)
    {
        if (!this._0x9e6e9306)
            return;
        this._0xf27608ec = this._0xf27608ec + _0x743fca51;
        if (this._0xf27608ec < _0x2360e6ef.GlowRollSeconds)
            return;
        this._0xf27608ec = 0f;
        this._0x0430bd2c();
    }

    private readonly Image[] _0x2c063990 = new Image[_0x2360e6ef.GlowLanternCount];
    public string Title
    {
        get
        {
            return _0x8d6803da._0xd97af71c(new byte[13] { 234, 253, 249, 252, 152, 236, 240, 253, 152, 255, 244, 247, 239 }, 184);
        }
    }

    private System.Random _0x153969c0;
    /// <summary>
    /// Three clearly separated levels, shuffled. Separation is the point: the brightest is
    /// always at least a fifth brighter than the next, so the read is possible on a phone.
    /// </summary>
    private void _0x0430bd2c()
    {
        float[] _0xb1f74167 = new float[_0x2360e6ef.GlowLanternCount];
        _0xb1f74167[0] = 0.30f + ((float)this._0x153969c0.NextDouble() * 0.08f);
        _0xb1f74167[1] = 0.58f + ((float)this._0x153969c0.NextDouble() * 0.08f);
        _0xb1f74167[2] = 0.92f + ((float)this._0x153969c0.NextDouble() * 0.06f);
        for (int _0xcc4433a6 = _0x2360e6ef.GlowLanternCount - 1; _0xcc4433a6 > 0; _0xcc4433a6--)
        {
            int _0xaa5e4865 = this._0x153969c0.Next(_0xcc4433a6 + 1);
            float _0x8046d022 = _0xb1f74167[_0xcc4433a6];
            _0xb1f74167[_0xcc4433a6] = _0xb1f74167[_0xaa5e4865];
            _0xb1f74167[_0xaa5e4865] = _0x8046d022;
        }

        this._0xf623f1a9 = 0;
        for (int _0xb0e54873 = 0; _0xb0e54873 < _0x2360e6ef.GlowLanternCount; _0xb0e54873++)
        {
            this._0x873ac860[_0xb0e54873] = _0xb1f74167[_0xb0e54873];
            if (_0xb1f74167[_0xb0e54873] > _0xb1f74167[this._0xf623f1a9])
                this._0xf623f1a9 = _0xb0e54873;
        }

        this._0x985c9517();
    }

    private RectTransform _0x7e105cd2;
    public void Begin(System.Random _0xfd1b0774)
    {
        this._0x153969c0 = _0xfd1b0774;
        this._0x9e6e9306 = true;
        this._0xf27608ec = 0f;
        this._0x0430bd2c();
    }

    private _0xf23fcd8b _0xca50d4d2;
    private float _0xf27608ec;
    private TextMeshProUGUI _0x8c9ddb4a;
    private readonly float[] _0x873ac860 = new float[_0x2360e6ef.GlowLanternCount];
    private void _0x985c9517()
    {
        for (int _0x360b3f2e = 0; _0x360b3f2e < _0x2360e6ef.GlowLanternCount; _0x360b3f2e++)
        {
            float _0x438e6a35 = this._0x873ac860[_0x360b3f2e];
            if (this._0xa634f875[_0x360b3f2e] != null)
                this._0xa634f875[_0x360b3f2e].color = _0xb20acb45.Fade(_0xb20acb45.Gold, 0.12f + (_0x438e6a35 * 0.6f));
            if (this._0x2c063990[_0x360b3f2e] != null)
            {
                this._0x2c063990[_0x360b3f2e].sprite = _0x438e6a35 > 0.5f ? this._0x2e42148d._0x43f281af : this._0x2e42148d._0x4438f135;
                this._0x2c063990[_0x360b3f2e].color = _0xb20acb45.Fade(Color.white, 0.55f + (_0x438e6a35 * 0.45f));
            }
        }
    }
}

internal static class _0x8d6803da
{
    internal static string _0xd97af71c(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}