using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The session's own HUD, built from this project's own objects.
///
/// Rule C.2: nothing here hangs on a template placeholder. The template's TopPanel keeps
/// its own slots and is switched off by stage 5da on every run, so Back and Pause are
/// authored here instead, at a rect of our own, and the panel ends up with exactly one set
/// of buttons rather than two in different styles.
///
/// No constructor (rule C.59): Build fills the object and returns it.
/// </summary>
public sealed class _0xbecc180a
{
    private Image _0x031bd112;
    public void _0x7663bf80(int _0x96e13173)
    {
        for (int _0x97016539 = 0; _0x97016539 < _0x2360e6ef.SparkCapPerTask; _0x97016539++)
            if (this._0x4009c71a[_0x97016539] != null)
                this._0x4009c71a[_0x97016539].color = _0x97016539 < _0x96e13173 ? _0xb20acb45.Gold : _0xb20acb45.Fade(_0xb20acb45.Haze, 0.95f);
    }

    private _0xc9b630d4 _0x98226f0e;
    private TextMeshProUGUI _0x7106c7ba;
    private TextMeshProUGUI _0x25112a6b;
    public void _0xb081fc77(int _0xcb90d2f1, string _0xdd4699e3)
    {
        _0xd90280ba.SetText(this._0x2941f668, _0x5176cfcb._0x91bd88ce(new byte[5] { 42, 63, 45, 53, 94 }, 126) + _0xcb90d2f1 + _0x5176cfcb._0x91bd88ce(new byte[3] { 159, 144, 159 }, 191) + _0x2360e6ef.TasksPerSession);
        _0xd90280ba.SetText(this._0xe850b77f, _0xdd4699e3);
    }

    private const float SessionWidth = 920f;
    private _0xf23fcd8b _0x5e8a659a;
    private Image _0xa2784058;
    private readonly Image[] _0x42240ae4 = new Image[_0x2360e6ef.TasksPerSession];
    private TextMeshProUGUI _0xe850b77f;
    public void _0xf93cd1b1(int _0xbe8cc8d4)
    {
        for (int _0x708d1b16 = 0; _0x708d1b16 < _0x2360e6ef.TasksPerSession; _0x708d1b16++)
            if (this._0x42240ae4[_0x708d1b16] != null)
                this._0x42240ae4[_0x708d1b16].color = _0x708d1b16 < _0xbe8cc8d4 ? _0xb20acb45.Teal : _0xb20acb45.Fade(_0xb20acb45.Haze, 0.95f);
    }

    private RectTransform _0xe3a54712;
    public void _0x053495ee(float _0xd7e20e4b)
    {
        this._0x5e8a659a._0x49a09ed3(this._0xa2784058, _0xd7e20e4b, TimerWidth);
    }

    private const float TimerWidth = 920f;
    public void _0xacc111d1(string _0x8dc27b78)
    {
        _0xd90280ba.SetText(this._0x14c904de, _0x8dc27b78);
    }

    public void _0xbbf24486(float _0x8f37d881)
    {
        this._0x5e8a659a._0x49a09ed3(this._0x031bd112, _0x8f37d881, SessionWidth);
    }

    private readonly Image[] _0x4009c71a = new Image[_0x2360e6ef.SparkCapPerTask];
    public _0xc9b630d4 _0x6e5feeb9
    {
        get
        {
            return this._0x9d27ec9f;
        }
    }

    public _0xbecc180a Build(_0xf23fcd8b _0x8c87cdfa, _0x761f29fe _0x7272c8e0, RectTransform _0xdee735b8)
    {
        this._0x5e8a659a = _0x8c87cdfa;
        this._0x9d27ec9f = _0x8c87cdfa._0xaf1c28b6(_0xdee735b8, _0x5176cfcb._0x91bd88ce(new byte[10] { 157, 190, 188, 180, 157, 170, 171, 171, 176, 177 }, 223), _0x7272c8e0._0xebbf42ba, _0xbe939921._0xcbafc4b5, new Vector2(112f, -200f), 140f);
        this._0x98226f0e = _0x8c87cdfa._0xaf1c28b6(_0xdee735b8, _0x5176cfcb._0x91bd88ce(new byte[11] { 244, 197, 209, 215, 193, 230, 209, 208, 208, 203, 202 }, 164), _0x7272c8e0._0x6d3c1859, _0xbe939921._0xae0d23e9, new Vector2(-112f, -200f), 140f);
        this._0x2941f668 = _0x8c87cdfa._0xb8fb9383(_0xdee735b8, _0x5176cfcb._0x91bd88ce(new byte[9] { 160, 149, 135, 159, 184, 149, 150, 145, 152 }, 244), _0x5176cfcb._0x91bd88ce(new byte[10] { 227, 246, 228, 252, 151, 134, 151, 152, 151, 132 }, 183), _0xbe939921._0x434f62f6, new Vector2(0f, -160f), new Vector2(620f, 66f), 42f, _0xb20acb45.Ink, TextAlignmentOptions.Center);
        this._0xe850b77f = _0x8c87cdfa._0xb8fb9383(_0xdee735b8, _0x5176cfcb._0x91bd88ce(new byte[10] { 140, 171, 190, 184, 186, 147, 190, 189, 186, 179 }, 223), _0x5176cfcb._0x91bd88ce(new byte[9] { 225, 227, 242, 134, 244, 227, 231, 226, 255 }, 166), _0xbe939921._0x434f62f6, new Vector2(0f, -222f), new Vector2(760f, 54f), 30f, _0xb20acb45.SlateText, TextAlignmentOptions.Center);
        this._0xe3a54712 = _0x8c87cdfa._0x4a32d93b(_0xdee735b8, _0x5176cfcb._0x91bd88ce(new byte[10] { 40, 11, 26, 9, 16, 43, 23, 26, 15, 30 }, 123), _0xbe939921._0x434f62f6, new Vector2(0f, -330f), new Vector2(460f, 104f));
        _0x8c87cdfa._0xb3a779c2(this._0xe3a54712, _0x5176cfcb._0x91bd88ce(new byte[5] { 55, 11, 6, 19, 2 }, 103), _0xb20acb45.Fade(_0xb20acb45.Mist, 0.92f), 1.1f);
        _0x8c87cdfa._0x5ab12fd7(this._0xe3a54712, _0x5176cfcb._0x91bd88ce(new byte[9] { 170, 137, 152, 139, 146, 176, 154, 150, 151 }, 249), _0x7272c8e0._0x20f0f53d, _0xbe939921._0x6ab5ec46, new Vector2(66f, 0f), 72f);
        this._0x25112a6b = _0x8c87cdfa._0xb8fb9383(this._0xe3a54712, _0x5176cfcb._0x91bd88ce(new byte[10] { 47, 12, 29, 14, 23, 42, 29, 16, 9, 25 }, 124), _0x5176cfcb._0x91bd88ce(new byte[8] { 236, 239, 254, 237, 244, 236, 159, 143 }, 191), _0xbe939921._0x6ab5ec46, new Vector2(286f, 0f), new Vector2(300f, 72f), 36f, _0xb20acb45.Ink, TextAlignmentOptions.Left);
        this._0xa2784058 = _0x8c87cdfa._0x5961980a(_0xdee735b8, _0x5176cfcb._0x91bd88ce(new byte[8] { 237, 208, 212, 220, 203, 251, 216, 203 }, 185), _0xbe939921._0x434f62f6, new Vector2(0f, -430f), new Vector2(TimerWidth, 22f), _0xb20acb45.Teal);
        this._0x14c904de = _0x8c87cdfa._0xb8fb9383(_0xdee735b8, _0x5176cfcb._0x91bd88ce(new byte[4] { 118, 87, 80, 74 }, 62), _0x5176cfcb._0x91bd88ce(new byte[25] { 106, 107, 96, 5, 113, 100, 117, 5, 8, 5, 107, 106, 113, 109, 108, 107, 98, 5, 113, 106, 5, 105, 106, 118, 96 }, 37), _0xbe939921._0x434f62f6, new Vector2(0f, -500f), new Vector2(1120f, 72f), 34f, _0xb20acb45.Ink, TextAlignmentOptions.Center);
        _0x8c87cdfa._0xb8fb9383(_0xdee735b8, _0x5176cfcb._0x91bd88ce(new byte[13] { 36, 17, 3, 27, 32, 25, 0, 3, 60, 17, 18, 21, 28 }, 112), _0x5176cfcb._0x91bd88ce(new byte[10] { 13, 24, 10, 18, 10, 121, 29, 22, 23, 28 }, 89), _0xbe939921._0x434f62f6, new Vector2(-300f, -2148f), new Vector2(520f, 46f), 28f, _0xb20acb45.SlateText, TextAlignmentOptions.Center);
        RectTransform _0x5959746d = _0x8c87cdfa._0x4a32d93b(_0xdee735b8, _0x5176cfcb._0x91bd88ce(new byte[8] { 89, 108, 126, 102, 93, 100, 125, 126 }, 13), _0xbe939921._0x434f62f6, new Vector2(-300f, -2206f), new Vector2(520f, 56f));
        for (int _0xc7256cc6 = 0; _0xc7256cc6 < _0x2360e6ef.TasksPerSession; _0xc7256cc6++)
        {
            Vector2 _0x8cf8a773 = new Vector2(_0xbe939921.Column(300f, _0x2360e6ef.TasksPerSession, 24f, _0xc7256cc6), 0f);
            this._0x42240ae4[_0xc7256cc6] = _0x8c87cdfa._0x9a152850(_0x5959746d, _0x5176cfcb._0x91bd88ce(new byte[7] { 184, 141, 159, 135, 188, 133, 156 }, 236), _0xbe939921._0x7f5aa638, _0x8cf8a773, 44f, _0xb20acb45.Fade(_0xb20acb45.Haze, 0.95f));
        }

        _0x8c87cdfa._0xb8fb9383(_0xdee735b8, _0x5176cfcb._0x91bd88ce(new byte[14] { 81, 114, 99, 112, 105, 82, 107, 114, 113, 78, 99, 96, 103, 110 }, 2), _0x5176cfcb._0x91bd88ce(new byte[16] { 155, 152, 137, 154, 131, 155, 232, 156, 128, 129, 155, 232, 156, 137, 155, 131 }, 200), _0xbe939921._0x434f62f6, new Vector2(286f, -2148f), new Vector2(520f, 46f), 28f, _0xb20acb45.SlateText, TextAlignmentOptions.Center);
        RectTransform _0x910e953e = _0x8c87cdfa._0x4a32d93b(_0xdee735b8, _0x5176cfcb._0x91bd88ce(new byte[9] { 162, 129, 144, 131, 154, 161, 152, 129, 130 }, 241), _0xbe939921._0x434f62f6, new Vector2(286f, -2206f), new Vector2(520f, 56f));
        for (int _0xbacc3fcc = 0; _0xbacc3fcc < _0x2360e6ef.SparkCapPerTask; _0xbacc3fcc++)
        {
            Vector2 _0x63fff13c = new Vector2(_0xbe939921.Column(430f, _0x2360e6ef.SparkCapPerTask, 18f, _0xbacc3fcc), 0f);
            this._0x4009c71a[_0xbacc3fcc] = _0x8c87cdfa._0x9a152850(_0x910e953e, _0x5176cfcb._0x91bd88ce(new byte[8] { 208, 243, 226, 241, 232, 211, 234, 243 }, 131), _0xbe939921._0x7f5aa638, _0x63fff13c, 30f, _0xb20acb45.Fade(_0xb20acb45.Haze, 0.95f));
        }

        this._0x031bd112 = _0x8c87cdfa._0x5961980a(_0xdee735b8, _0x5176cfcb._0x91bd88ce(new byte[10] { 47, 25, 15, 15, 21, 19, 18, 62, 29, 14 }, 124), _0xbe939921._0x434f62f6, new Vector2(0f, -2290f), new Vector2(SessionWidth, 22f), _0xb20acb45.Gold);
        this._0x7106c7ba = _0x8c87cdfa._0xb8fb9383(_0xdee735b8, _0x5176cfcb._0x91bd88ce(new byte[6] { 237, 196, 196, 223, 206, 217 }, 171), _0x5176cfcb._0x91bd88ce(new byte[32] { 152, 151, 144, 151, 141, 150, 254, 237, 254, 138, 159, 141, 149, 141, 254, 243, 254, 146, 151, 153, 150, 138, 254, 239, 254, 146, 159, 144, 138, 155, 140, 144 }, 222), _0xbe939921._0x434f62f6, new Vector2(0f, -2380f), new Vector2(1120f, 64f), 30f, _0xb20acb45.SlateText, TextAlignmentOptions.Center);
        this._0x053495ee(1f);
        this._0xbbf24486(0f);
        return this;
    }

    public void _0xeda1f68d(string _0xd8ba77cb)
    {
        _0xd90280ba.SetText(this._0x7106c7ba, _0xd8ba77cb);
    }

    private _0xc9b630d4 _0x9d27ec9f;
    public void _0xef1ca004(int _0x7119f63c)
    {
        _0xd90280ba.SetText(this._0x25112a6b, _0x5176cfcb._0x91bd88ce(new byte[7] { 138, 137, 152, 139, 146, 138, 249 }, 217) + _0x7119f63c);
        if (this._0xe3a54712 != null)
            this._0xe3a54712.DOPunchScale(Vector3.one * 0.1f, 0.26f, 5, 0.8f).SetLink(this._0xe3a54712.gameObject);
    }

    private TextMeshProUGUI _0x2941f668;
    private TextMeshProUGUI _0x14c904de;
    public _0xc9b630d4 _0xe408460e
    {
        get
        {
            return this._0x98226f0e;
        }
    }
}

internal static class _0x5176cfcb
{
    internal static string _0x91bd88ce(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}