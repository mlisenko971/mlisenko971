using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The week map as the menu shows it: read-only. Nothing here is a Button, because nothing
/// here can be pressed - a lantern is lit inside a session, not from the lobby, and a
/// button that does nothing is a silent defect (rule C.1).
///
/// The strip of opened areas carries its own empty state, so a quiet week shows a sentence
/// rather than a blank band (rule G).
/// </summary>
public sealed class _0xf22f47db : MonoBehaviour
{
    private _0xc9b630d4 _0x0d1d53f9;
    private const float BarWidth = 980f;
    public _0xc9b630d4 _0x5bd7de5b
    {
        get
        {
            return this._0x7dd74b79;
        }
    }

    private RectTransform _0xe3da3c33;
    private TextMeshProUGUI _0x2d409884;
    private RectTransform _0xe6e775f5;
    private RectTransform _0x07e32493;
    private _0x761f29fe _0x323f8c8a;
    private _0xc9b630d4 _0x7dd74b79;
    private void OnDestroy()
    {
        DOTween.Kill(this, false);
    }

    private readonly RectTransform[] _0x87a920ad = new RectTransform[3];
    public void SetVisible(bool _0xf509438a)
    {
        if (this._0x07e32493 == null)
            return;
        this._0x07e32493.gameObject.SetActive(_0xf509438a);
        if (!_0xf509438a)
            return;
        this._0xc031b50b();
        this._0xe3da3c33.localScale = Vector3.one * 0.96f;
        this._0xe3da3c33.DOScale(1f, 0.26f).SetEase(Ease.OutBack).SetLink(this._0xe3da3c33.gameObject);
    }

    private _0xf23fcd8b _0x1368e4d1;
    public void Build(_0xf23fcd8b _0x31eaee49, _0x761f29fe _0xf4efcec4, _0x16d5455c _0x9966b2e6, RectTransform _0xe935ea48)
    {
        this._0x1368e4d1 = _0x31eaee49;
        this._0x323f8c8a = _0xf4efcec4;
        this._0x7c78ee56 = _0x9966b2e6;
        this._0x07e32493 = _0x31eaee49._0x6f23ed2a(_0xe935ea48, _0x08127c75._0x7b45e32a(new byte[10] { 33, 13, 28, 35, 26, 9, 30, 0, 13, 21 }, 108));
        Image _0xc7a1ddb9 = _0x31eaee49._0x32cda798(this._0x07e32493, _0x08127c75._0x7b45e32a(new byte[5] { 254, 206, 223, 196, 192 }, 173), _0xb20acb45.Fade(_0xb20acb45.Ink, 0.22f));
        _0xc7a1ddb9.transform.SetAsFirstSibling();
        this._0xe3da3c33 = _0x31eaee49._0xaa5a67ea(this._0x07e32493, _0x08127c75._0x7b45e32a(new byte[8] { 131, 175, 190, 157, 166, 171, 171, 186 }, 206), _0xbe939921._0x434f62f6, new Vector2(0f, -1330f), new Vector2(1140f, 2000f));
        _0x31eaee49._0xb8fb9383(this._0xe3da3c33, _0x08127c75._0x7b45e32a(new byte[4] { 88, 117, 113, 116 }, 16), _0x08127c75._0x7b45e32a(new byte[8] { 67, 81, 81, 95, 52, 89, 85, 68 }, 20), _0xbe939921._0x7f5aa638, new Vector2(0f, 880f), new Vector2(1000f, 90f), 48f, _0xb20acb45.Ink, TextAlignmentOptions.Center);
        _0x31eaee49._0xb8fb9383(this._0xe3da3c33, _0x08127c75._0x7b45e32a(new byte[3] { 123, 93, 74 }, 40), _0x08127c75._0x7b45e32a(new byte[24] { 46, 53, 60, 47, 56, 57, 93, 63, 36, 93, 41, 53, 56, 93, 42, 53, 50, 49, 56, 93, 62, 49, 40, 63 }, 125), _0xbe939921._0x7f5aa638, new Vector2(0f, 812f), new Vector2(1000f, 50f), 30f, _0xb20acb45.SlateText, TextAlignmentOptions.Center);
        this._0x39c33ec1 = _0x31eaee49._0x5961980a(this._0xe3da3c33, _0x08127c75._0x7b45e32a(new byte[6] { 89, 117, 100, 86, 117, 102 }, 20), _0xbe939921._0x7f5aa638, new Vector2(0f, 742f), new Vector2(BarWidth, 32f), _0xb20acb45.Gold);
        this._0x2d409884 = _0x31eaee49._0xb8fb9383(this._0xe3da3c33, _0x08127c75._0x7b45e32a(new byte[10] { 147, 191, 174, 157, 177, 171, 176, 170, 187, 172 }, 222), _0x08127c75._0x7b45e32a(new byte[19] { 203, 198, 201, 211, 194, 213, 201, 212, 167, 203, 206, 211, 167, 183, 167, 168, 167, 181, 182 }, 135), _0xbe939921._0x7f5aa638, new Vector2(0f, 686f), new Vector2(1000f, 48f), 30f, _0xb20acb45.SlateText, TextAlignmentOptions.Center);
        float _0x277d708b = 980f;
        float _0x08f4b1aa = 10f;
        float _0xe06d386f = _0xbe939921.Cell(_0x277d708b, _0x2360e6ef.MapColumns, _0x08f4b1aa);
        float _0xafcfe4f5 = _0xe06d386f + 18f;
        float _0x86ee5897 = (((_0x2360e6ef.MapRows - 1) * _0xafcfe4f5) * 0.5f) + 330f;
        for (int _0xb2fd4964 = 0; _0xb2fd4964 < _0x2360e6ef.MapCells; _0xb2fd4964++)
        {
            int _0x79e71704 = _0x93967577.ColumnOf(_0xb2fd4964);
            int _0xb2d1e285 = _0x93967577.RowOf(_0xb2fd4964);
            Vector2 _0x246dd6fd = new Vector2(_0xbe939921.Column(_0x277d708b, _0x2360e6ef.MapColumns, _0x08f4b1aa, _0x79e71704), _0x86ee5897 - (_0xb2d1e285 * _0xafcfe4f5));
            RectTransform _0x09eb314a = _0x31eaee49._0x4a32d93b(this._0xe3da3c33, _0x08127c75._0x7b45e32a(new byte[7] { 198, 235, 228, 254, 239, 248, 228 }, 138), _0xbe939921._0x7f5aa638, _0x246dd6fd, new Vector2(_0xe06d386f, _0xe06d386f));
            Image _0x221e12ea = _0x31eaee49._0xb3a779c2(_0x09eb314a, _0x08127c75._0x7b45e32a(new byte[3] { 142, 181, 177 }, 220), _0xb20acb45.Fade(_0xb20acb45.Slate, 0.26f), 1.4f);
            Image _0x03ce4142 = _0x31eaee49._0xb3a779c2(_0x221e12ea.rectTransform, _0x08127c75._0x7b45e32a(new byte[4] { 148, 179, 177, 183 }, 210), _0xb20acb45.Fade(_0xb20acb45.Mist, 0.9f), 1.5f);
            _0x03ce4142.rectTransform.offsetMin = new Vector2(3f, 3f);
            _0x03ce4142.rectTransform.offsetMax = new Vector2(-3f, -3f);
            this._0x3abd7815[_0xb2fd4964] = _0x31eaee49._0xa061d3cf(_0x03ce4142.rectTransform, _0x08127c75._0x7b45e32a(new byte[4] { 137, 160, 173, 174 }, 193), _0xbe939921._0x7f5aa638, Vector2.zero, new Vector2(_0xe06d386f * 0.8f, _0xe06d386f * 0.8f), _0xb20acb45.Fade(_0xb20acb45.Haze, 0.2f), 0.2f);
            this._0x792f0589[_0xb2fd4964] = _0x31eaee49._0x5ab12fd7(_0x03ce4142.rectTransform, _0x08127c75._0x7b45e32a(new byte[5] { 249, 210, 223, 205, 205 }, 190), _0xf4efcec4._0x4438f135, _0xbe939921._0x7f5aa638, Vector2.zero, _0xe06d386f * 0.72f);
        }

        _0x31eaee49._0xb8fb9383(this._0xe3da3c33, _0x08127c75._0x7b45e32a(new byte[12] { 98, 84, 82, 69, 88, 94, 95, 66, 121, 84, 80, 85 }, 49), _0x08127c75._0x7b45e32a(new byte[22] { 73, 90, 77, 73, 91, 40, 71, 88, 77, 70, 77, 76, 40, 92, 64, 65, 91, 40, 95, 77, 77, 67 }, 8), _0xbe939921._0x7f5aa638, new Vector2(0f, -120f), new Vector2(1000f, 50f), 32f, _0xb20acb45.Ink, TextAlignmentOptions.Center);
        this._0xe6e775f5 = _0x31eaee49._0x4a32d93b(this._0xe3da3c33, _0x08127c75._0x7b45e32a(new byte[11] { 171, 157, 155, 140, 145, 151, 150, 139, 170, 151, 143 }, 248), _0xbe939921._0x7f5aa638, new Vector2(0f, -210f), new Vector2(1020f, 96f));
        float _0x446ac20a = 22f;
        float _0x49014db4 = _0xbe939921.Cell(1020f, 3, _0x446ac20a);
        for (int _0x7e94b4da = 0; _0x7e94b4da < 3; _0x7e94b4da++)
        {
            Vector2 _0x06854c48 = new Vector2(_0xbe939921.Column(1020f, 3, _0x446ac20a, _0x7e94b4da), 0f);
            this._0x87a920ad[_0x7e94b4da] = _0x31eaee49._0xa718d0a2(this._0xe6e775f5, _0x08127c75._0x7b45e32a(new byte[7] { 183, 129, 135, 144, 141, 139, 138 }, 228), _0x7777c0fd[_0x7e94b4da], _0xbe939921._0x7f5aa638, _0x06854c48, new Vector2(_0x49014db4, 86f), _0xb20acb45.Fade(_0xb20acb45.Teal, 0.32f));
        }

        this._0x224549a7 = _0x31eaee49._0xb8fb9383(this._0xe3da3c33, _0x08127c75._0x7b45e32a(new byte[13] { 92, 106, 108, 123, 102, 96, 97, 124, 74, 98, 127, 123, 118 }, 15), _0x08127c75._0x7b45e32a(new byte[45] { 2, 3, 108, 13, 30, 9, 13, 31, 108, 3, 28, 9, 2, 108, 21, 9, 24, 70, 0, 5, 11, 4, 24, 108, 13, 108, 0, 13, 2, 24, 9, 30, 2, 108, 24, 3, 108, 3, 28, 9, 2, 108, 3, 2, 9 }, 76), _0xbe939921._0x7f5aa638, new Vector2(0f, -210f), new Vector2(1000f, 120f), 32f, _0xb20acb45.SlateText, TextAlignmentOptions.Center);
        _0x31eaee49._0xb8fb9383(this._0xe3da3c33, _0x08127c75._0x7b45e32a(new byte[7] { 135, 171, 186, 152, 191, 166, 175 }, 202), _0x08127c75._0x7b45e32a(new byte[42] { 45, 44, 46, 59, 66, 35, 66, 46, 35, 44, 54, 39, 48, 44, 66, 32, 39, 49, 43, 38, 39, 66, 35, 66, 46, 43, 54, 66, 45, 44, 39, 66, 33, 35, 44, 66, 32, 39, 66, 46, 43, 54 }, 98), _0xbe939921._0x7f5aa638, new Vector2(0f, -400f), new Vector2(1020f, 54f), 28f, _0xb20acb45.SlateText, TextAlignmentOptions.Center);
        this._0x7dd74b79 = _0x31eaee49._0xeaf47c78(this._0xe3da3c33, _0x08127c75._0x7b45e32a(new byte[8] { 41, 5, 20, 55, 16, 5, 22, 16 }, 100), _0x08127c75._0x7b45e32a(new byte[13] { 91, 92, 73, 90, 92, 40, 91, 77, 91, 91, 65, 71, 70 }, 8), _0xbe939921._0x7f5aa638, new Vector2(0f, -700f), new Vector2(620f, 140f), 40f, true);
        this._0x0d1d53f9 = _0x31eaee49._0xeaf47c78(this._0xe3da3c33, _0x08127c75._0x7b45e32a(new byte[8] { 105, 69, 84, 103, 72, 75, 87, 65 }, 36), _0x08127c75._0x7b45e32a(new byte[5] { 63, 48, 51, 47, 57 }, 124), _0xbe939921._0x7f5aa638, new Vector2(0f, -860f), new Vector2(520f, 128f), 38f, false);
        this.SetVisible(false);
    }

    private TextMeshProUGUI _0x224549a7;
    private Image _0x39c33ec1;
    private static readonly string[] _0x7777c0fd =
    {
        _0x08127c75._0x7b45e32a(new byte[9] { 126, 122, 104, 111, 27, 108, 122, 119, 112 }, 59),
        _0x08127c75._0x7b45e32a(new byte[8] { 190, 189, 181, 209, 182, 176, 165, 180 }, 241),
        _0x08127c75._0x7b45e32a(new byte[10] { 209, 215, 196, 210, 211, 216, 182, 196, 217, 193 }, 150)
    };
    private _0x16d5455c _0x7c78ee56;
    private readonly Image[] _0x792f0589 = new Image[_0x2360e6ef.MapCells];
    public void _0xc031b50b()
    {
        string _0x11f12919 = this._0x7c78ee56._0x2c8aa13e;
        int _0xf6404401 = 0;
        for (int _0xf1c98bae = 0; _0xf1c98bae < _0x2360e6ef.MapCells; _0xf1c98bae++)
        {
            bool _0xf924a684 = _0x11f12919 != null && _0x11f12919.Length == _0x2360e6ef.MapCells && _0x11f12919[_0xf1c98bae] == '1';
            if (_0xf924a684)
                _0xf6404401 = _0xf6404401 + 1;
            if (this._0x792f0589[_0xf1c98bae] != null)
            {
                this._0x792f0589[_0xf1c98bae].sprite = _0xf924a684 ? this._0x323f8c8a._0x43f281af : this._0x323f8c8a._0x4438f135;
                this._0x792f0589[_0xf1c98bae].color = _0xf924a684 ? Color.white : _0xb20acb45.Fade(Color.white, 0.5f);
            }

            if (this._0x3abd7815[_0xf1c98bae] != null)
                this._0x3abd7815[_0xf1c98bae].color = _0xf924a684 ? _0xb20acb45.Fade(_0xb20acb45.Gold, 0.6f) : _0xb20acb45.Fade(_0xb20acb45.Haze, 0.2f);
        }

        this._0x1368e4d1._0x49a09ed3(this._0x39c33ec1, (float)_0xf6404401 / _0x2360e6ef.MapCells, BarWidth);
        _0xd90280ba.SetText(this._0x2d409884, _0x08127c75._0x7b45e32a(new byte[13] { 144, 157, 146, 136, 153, 142, 146, 143, 252, 144, 149, 136, 252 }, 220) + _0xf6404401 + _0x08127c75._0x7b45e32a(new byte[3] { 212, 219, 212 }, 244) + _0x2360e6ef.MapCells);
        int _0xf6ec7c00 = _0xf6404401 >= 16 ? 3 : (_0xf6404401 >= 12 ? 2 : (_0xf6404401 >= 8 ? 1 : 0));
        for (int _0xe0379101 = 0; _0xe0379101 < 3; _0xe0379101++)
            if (this._0x87a920ad[_0xe0379101] != null)
                this._0x87a920ad[_0xe0379101].gameObject.SetActive(_0xe0379101 < _0xf6ec7c00);
        if (this._0xe6e775f5 != null)
            this._0xe6e775f5.gameObject.SetActive(_0xf6ec7c00 > 0);
        if (this._0x224549a7 != null)
            this._0x224549a7.gameObject.SetActive(_0xf6ec7c00 <= 0);
    }

    private readonly Image[] _0x3abd7815 = new Image[_0x2360e6ef.MapCells];
    public _0xc9b630d4 _0x10278333
    {
        get
        {
            return this._0x0d1d53f9;
        }
    }
}

internal static class _0x08127c75
{
    internal static string _0x7b45e32a(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}