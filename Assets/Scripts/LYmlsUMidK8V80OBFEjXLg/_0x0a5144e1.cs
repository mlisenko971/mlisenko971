using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The club's shared weekly map, as it appears at the end of a session: twenty-one
/// lanterns, the ones the club has already lit burning, the frontier ones breathing to
/// show they can be lit. Only a frontier lantern takes a tap, so the lit cluster grows
/// outward instead of scattering.
///
/// Rule C.7 in full: lighting one crossfades the glass, punches the cell, sends motes up
/// and moves the shared counter - the change is visible in a still frame, not only in a
/// label. The sections strip under the map carries its own empty state, so the area is
/// never a blank band (rule G).
/// </summary>
public sealed class _0x0a5144e1 : MonoBehaviour
{
    private TextMeshProUGUI _0x525b0f45;
    private readonly Button[] _0xa50d6b16 = new Button[_0x2360e6ef.MapCells];
    private TextMeshProUGUI _0x7c337682;
    public void Finish()
    {
        this._0xe2e7f1ad = false;
        for (int _0x27371204 = 0; _0x27371204 < _0x2360e6ef.MapCells; _0x27371204++)
            if (this._0xa50d6b16[_0x27371204] != null)
                this._0xa50d6b16[_0x27371204].interactable = false;
    }

    public void Build(_0xf23fcd8b _0x359648a4, _0x761f29fe _0xcd1b9d52, RectTransform _0x14cde584, _0xcb416fe2 _0x0a4c7302)
    {
        this._0xe4f4326b = _0x359648a4;
        this._0xa08dbcd0 = _0xcd1b9d52;
        this._0x0e361610 = _0x0a4c7302;
        this._0x1216acfc = _0x359648a4._0x6f23ed2a(_0x14cde584, _0x2768f991._0x74c4b04e(new byte[8] { 127, 83, 66, 97, 70, 83, 85, 87 }, 50));
        float _0x76fc3922 = _0x14cde584.sizeDelta.x * 0.98f;
        float _0xa20fb6ec = 10f;
        this._0x928640b7 = _0xbe939921.Cell(_0x76fc3922, _0x2360e6ef.MapColumns, _0xa20fb6ec);
        float _0xfe9919e8 = this._0x928640b7 + 18f;
        float _0x6f03e763 = (((_0x2360e6ef.MapRows - 1) * _0xfe9919e8) * 0.5f) + 150f;
        _0x359648a4._0xb8fb9383(this._0x1216acfc, _0x2768f991._0x74c4b04e(new byte[8] { 34, 14, 31, 59, 6, 27, 3, 10 }, 111), _0x2768f991._0x74c4b04e(new byte[17] { 60, 57, 55, 56, 36, 80, 63, 62, 53, 80, 60, 49, 62, 36, 53, 34, 62 }, 112), _0xbe939921._0x7f5aa638, new Vector2(0f, 470f), new Vector2(_0x76fc3922, 64f), 42f, _0xb20acb45.Ink, TextAlignmentOptions.Center);
        this._0x525b0f45 = _0x359648a4._0xb8fb9383(this._0x1216acfc, _0x2768f991._0x74c4b04e(new byte[10] { 88, 116, 101, 86, 122, 96, 123, 97, 112, 103 }, 21), _0x2768f991._0x74c4b04e(new byte[19] { 31, 18, 29, 7, 22, 1, 29, 0, 115, 31, 26, 7, 115, 99, 115, 124, 115, 97, 98 }, 83), _0xbe939921._0x7f5aa638, new Vector2(0f, 396f), new Vector2(_0x76fc3922, 56f), 32f, _0xb20acb45.SlateText, TextAlignmentOptions.Center);
        for (int _0x79ec8392 = 0; _0x79ec8392 < _0x2360e6ef.MapCells; _0x79ec8392++)
        {
            int _0xb3e4d233 = _0x93967577.ColumnOf(_0x79ec8392);
            int _0x726431a8 = _0x93967577.RowOf(_0x79ec8392);
            Vector2 _0x31fe29dc = new Vector2(_0xbe939921.Column(_0x76fc3922, _0x2360e6ef.MapColumns, _0xa20fb6ec, _0xb3e4d233), _0x6f03e763 - (_0x726431a8 * _0xfe9919e8));
            RectTransform _0x672b2ae6 = _0x359648a4._0x4a32d93b(this._0x1216acfc, _0x2768f991._0x74c4b04e(new byte[7] { 177, 156, 147, 137, 152, 143, 147 }, 253), _0xbe939921._0x7f5aa638, _0x31fe29dc, new Vector2(this._0x928640b7, this._0x928640b7));
            Image _0xd188523d = _0x359648a4._0xb3a779c2(_0x672b2ae6, _0x2768f991._0x74c4b04e(new byte[3] { 150, 173, 169 }, 196), _0xb20acb45.Fade(_0xb20acb45.Slate, 0.28f), 1.4f);
            Image _0x6664bc90 = _0x359648a4._0xb3a779c2(_0xd188523d.rectTransform, _0x2768f991._0x74c4b04e(new byte[4] { 17, 54, 52, 50 }, 87), _0xb20acb45.Fade(_0xb20acb45.Mist, 0.92f), 1.5f);
            _0x6664bc90.rectTransform.offsetMin = new Vector2(3f, 3f);
            _0x6664bc90.rectTransform.offsetMax = new Vector2(-3f, -3f);
            Image _0x8f31d59c = _0x359648a4._0xa061d3cf(_0x6664bc90.rectTransform, _0x2768f991._0x74c4b04e(new byte[4] { 113, 88, 85, 86 }, 57), _0xbe939921._0x7f5aa638, Vector2.zero, new Vector2(this._0x928640b7 * 0.8f, this._0x928640b7 * 0.8f), _0xb20acb45.Fade(_0xb20acb45.Gold, 0.35f), 0.2f);
            Image _0xdb81a1b6 = _0x359648a4._0x5ab12fd7(_0x6664bc90.rectTransform, _0x2768f991._0x74c4b04e(new byte[5] { 202, 225, 236, 254, 254 }, 141), _0xcd1b9d52._0x4438f135, _0xbe939921._0x7f5aa638, Vector2.zero, this._0x928640b7 * 0.72f);
            Button _0xfa0c2bca = _0x359648a4._0x61f1617d(_0x672b2ae6.gameObject, _0x6664bc90);
            int _0x7b16c4b4 = _0x79ec8392;
            _0xfa0c2bca.onClick.AddListener(() => this._0xbdf8985e(_0x7b16c4b4));
            this._0xc8eba9b8[_0x79ec8392] = _0x672b2ae6;
            this._0xb0fc664f[_0x79ec8392] = _0xdb81a1b6;
            this._0xc0d3df11[_0x79ec8392] = _0x8f31d59c;
            this._0xa50d6b16[_0x79ec8392] = _0xfa0c2bca;
        }

        _0x359648a4._0xb8fb9383(this._0x1216acfc, _0x2768f991._0x74c4b04e(new byte[12] { 176, 134, 128, 151, 138, 140, 141, 144, 171, 134, 130, 135 }, 227), _0x2768f991._0x74c4b04e(new byte[22] { 163, 176, 167, 163, 177, 194, 173, 178, 167, 172, 167, 166, 194, 182, 170, 171, 177, 194, 181, 167, 167, 169 }, 226), _0xbe939921._0x7f5aa638, new Vector2(0f, -180f), new Vector2(_0x76fc3922, 50f), 30f, _0xb20acb45.Ink, TextAlignmentOptions.Center);
        this._0x089a11ab = _0x359648a4._0x4a32d93b(this._0x1216acfc, _0x2768f991._0x74c4b04e(new byte[11] { 6, 48, 54, 33, 60, 58, 59, 38, 7, 58, 34 }, 85), _0xbe939921._0x7f5aa638, new Vector2(0f, -268f), new Vector2(_0x76fc3922, 96f));
        float _0x7bcc0522 = 22f;
        float _0x25444cdf = _0xbe939921.Cell(_0x76fc3922, 3, _0x7bcc0522);
        for (int _0x59fa5777 = 0; _0x59fa5777 < 3; _0x59fa5777++)
        {
            Vector2 _0xe34ceea4 = new Vector2(_0xbe939921.Column(_0x76fc3922, 3, _0x7bcc0522, _0x59fa5777), 0f);
            this._0xd1ba002b[_0x59fa5777] = _0x359648a4._0xa718d0a2(this._0x089a11ab, _0x2768f991._0x74c4b04e(new byte[7] { 6, 48, 54, 33, 60, 58, 59 }, 85), _0x107578c9[_0x59fa5777], _0xbe939921._0x7f5aa638, _0xe34ceea4, new Vector2(_0x25444cdf, 86f), _0xb20acb45.Fade(_0xb20acb45.Teal, 0.32f));
        }

        this._0x7c337682 = _0x359648a4._0xb8fb9383(this._0x1216acfc, _0x2768f991._0x74c4b04e(new byte[13] { 198, 240, 246, 225, 252, 250, 251, 230, 208, 248, 229, 225, 236 }, 149), _0x2768f991._0x74c4b04e(new byte[45] { 2, 3, 108, 13, 30, 9, 13, 31, 108, 3, 28, 9, 2, 108, 21, 9, 24, 70, 0, 5, 11, 4, 24, 108, 13, 108, 0, 13, 2, 24, 9, 30, 2, 108, 24, 3, 108, 3, 28, 9, 2, 108, 3, 2, 9 }, 76), _0xbe939921._0x7f5aa638, new Vector2(0f, -268f), new Vector2(_0x76fc3922, 110f), 32f, _0xb20acb45.SlateText, TextAlignmentOptions.Center);
        _0x359648a4._0xb8fb9383(this._0x1216acfc, _0x2768f991._0x74c4b04e(new byte[7] { 87, 123, 106, 92, 117, 117, 110 }, 26), _0x2768f991._0x74c4b04e(new byte[37] { 202, 171, 205, 217, 196, 197, 223, 194, 206, 217, 171, 199, 202, 197, 223, 206, 217, 197, 171, 201, 217, 206, 202, 223, 195, 206, 216, 171, 166, 171, 223, 202, 219, 171, 196, 197, 206 }, 139), _0xbe939921._0x7f5aa638, new Vector2(0f, -430f), new Vector2(_0x76fc3922, 56f), 28f, _0xb20acb45.SlateText, TextAlignmentOptions.Center);
    }

    /// <summary>Lights the lowest legal cell, so a session always reaches its result.</summary>
    public void _0xdf97bfdf()
    {
        if (this._0x87fc842b == null)
            return;
        int _0x5a403fa7 = this._0x87fc842b._0x317a8fa5();
        if (_0x5a403fa7 >= 0)
            this._0xbdf8985e(_0x5a403fa7);
    }

    private void _0x3418eaf4()
    {
        if (this._0x87fc842b == null)
            return;
        for (int _0xe9fbc7f8 = 0; _0xe9fbc7f8 < _0x2360e6ef.MapCells; _0xe9fbc7f8++)
        {
            bool _0xf348923e = this._0x87fc842b._0x5dd2b129(_0xe9fbc7f8);
            bool _0x2db189b1 = this._0x87fc842b._0x9ae7e109(_0xe9fbc7f8);
            if (this._0xb0fc664f[_0xe9fbc7f8] != null)
            {
                this._0xb0fc664f[_0xe9fbc7f8].sprite = _0xf348923e ? this._0xa08dbcd0._0x43f281af : this._0xa08dbcd0._0x4438f135;
                this._0xb0fc664f[_0xe9fbc7f8].color = _0xf348923e ? Color.white : _0xb20acb45.Fade(Color.white, _0x2db189b1 ? 0.85f : 0.5f);
            }

            if (this._0xc0d3df11[_0xe9fbc7f8] != null)
                this._0xc0d3df11[_0xe9fbc7f8].color = _0xf348923e ? _0xb20acb45.Fade(_0xb20acb45.Gold, 0.65f) : _0xb20acb45.Fade(_0x2db189b1 ? _0xb20acb45.Teal : _0xb20acb45.Haze, _0x2db189b1 ? 0.3f : 0.14f);
            if (this._0xa50d6b16[_0xe9fbc7f8] != null)
                this._0xa50d6b16[_0xe9fbc7f8].interactable = this._0xe2e7f1ad && _0x2db189b1;
            if (this._0xc8eba9b8[_0xe9fbc7f8] != null)
            {
                DOTween.Kill(this._0xc8eba9b8[_0xe9fbc7f8], true);
                this._0xc8eba9b8[_0xe9fbc7f8].localScale = Vector3.one;
                if (this._0xe2e7f1ad && _0x2db189b1)
                    this._0xc8eba9b8[_0xe9fbc7f8].DOScale(1.08f, 0.9f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine).SetLink(this._0xc8eba9b8[_0xe9fbc7f8].gameObject);
            }
        }

        _0xd90280ba.SetText(this._0x525b0f45, _0x2768f991._0x74c4b04e(new byte[13] { 221, 208, 223, 197, 212, 195, 223, 194, 177, 221, 216, 197, 177 }, 145) + this._0x87fc842b._0x029bca9d() + _0x2768f991._0x74c4b04e(new byte[3] { 248, 247, 248 }, 216) + _0x2360e6ef.MapCells);
        this._0xbe333a6e();
    }

    private RectTransform _0x1216acfc;
    private readonly RectTransform[] _0xd1ba002b = new RectTransform[3];
    public void SetVisible(bool _0x6cacda8a)
    {
        if (this._0x1216acfc != null)
            this._0x1216acfc.gameObject.SetActive(_0x6cacda8a);
    }

    private static readonly string[] _0x107578c9 =
    {
        _0x2768f991._0x74c4b04e(new byte[9] { 43, 47, 61, 58, 78, 57, 47, 34, 37 }, 110),
        _0x2768f991._0x74c4b04e(new byte[8] { 61, 62, 54, 82, 53, 51, 38, 55 }, 114),
        _0x2768f991._0x74c4b04e(new byte[10] { 120, 126, 109, 123, 122, 113, 31, 109, 112, 104 }, 63)
    };
    private void _0xbdf8985e(int _0x8899d5ff)
    {
        if (!this._0xe2e7f1ad || this._0x87fc842b == null || this._0x0e361610 == null)
            return;
        if (!this._0x87fc842b._0xa8b3e2d6(_0x8899d5ff))
            return;
        this._0xe2e7f1ad = false;
        if (this._0xc8eba9b8[_0x8899d5ff] != null)
        {
            DOTween.Kill(this._0xc8eba9b8[_0x8899d5ff], true);
            this._0xc8eba9b8[_0x8899d5ff].localScale = Vector3.one;
            this._0xc8eba9b8[_0x8899d5ff].DOPunchScale(Vector3.one * 0.18f, 0.38f, 6, 0.7f).SetLink(this._0xc8eba9b8[_0x8899d5ff].gameObject);
        }

        if (this._0xb0fc664f[_0x8899d5ff] != null)
        {
            this._0xb0fc664f[_0x8899d5ff].sprite = this._0xa08dbcd0._0x43f281af;
            this._0xb0fc664f[_0x8899d5ff].color = _0xb20acb45.Fade(Color.white, 0.2f);
            this._0xb0fc664f[_0x8899d5ff].DOFade(1f, 0.26f).SetLink(this._0xb0fc664f[_0x8899d5ff].gameObject);
        }

        if (this._0xc0d3df11[_0x8899d5ff] != null)
        {
            this._0xc0d3df11[_0x8899d5ff].color = _0xb20acb45.Fade(_0xb20acb45.Gold, 0f);
            this._0xc0d3df11[_0x8899d5ff].DOFade(0.7f, 0.32f).SetLink(this._0xc0d3df11[_0x8899d5ff].gameObject);
        }

        Vector2 _0x609381df = this._0xc8eba9b8[_0x8899d5ff].anchoredPosition;
        for (int _0xce6e9b5a = 0; _0xce6e9b5a < 6; _0xce6e9b5a++)
            _0x23cd2ede.Play(this._0xe4f4326b, this._0xa08dbcd0._0x20f0f53d, this._0x1216acfc, _0x609381df + new Vector2((_0xce6e9b5a - 2.5f) * 22f, 0f));
        _0xd90280ba.SetText(this._0x525b0f45, _0x2768f991._0x74c4b04e(new byte[13] { 37, 40, 39, 61, 44, 59, 39, 58, 73, 37, 32, 61, 73 }, 105) + this._0x87fc842b._0x029bca9d() + _0x2768f991._0x74c4b04e(new byte[3] { 59, 52, 59 }, 27) + _0x2360e6ef.MapCells);
        this._0xbe333a6e();
        this.Finish();
        this._0x0e361610._0x5e983865(_0x8899d5ff);
    }

    private bool _0xe2e7f1ad;
    private void _0xbe333a6e()
    {
        int _0x9f4b9ec8 = this._0x87fc842b._0x7095138f();
        for (int _0x45aa5b7a = 0; _0x45aa5b7a < 3; _0x45aa5b7a++)
            if (this._0xd1ba002b[_0x45aa5b7a] != null)
                this._0xd1ba002b[_0x45aa5b7a].gameObject.SetActive(_0x45aa5b7a < _0x9f4b9ec8);
        if (this._0x089a11ab != null)
            this._0x089a11ab.gameObject.SetActive(_0x9f4b9ec8 > 0);
        if (this._0x7c337682 != null)
            this._0x7c337682.gameObject.SetActive(_0x9f4b9ec8 <= 0);
    }

    private _0x761f29fe _0xa08dbcd0;
    private RectTransform _0x089a11ab;
    private _0x93967577 _0x87fc842b;
    private readonly RectTransform[] _0xc8eba9b8 = new RectTransform[_0x2360e6ef.MapCells];
    public void Begin(_0x93967577 _0x9d38d804)
    {
        this._0x87fc842b = _0x9d38d804;
        this._0xe2e7f1ad = true;
        this._0x3418eaf4();
    }

    private _0xf23fcd8b _0xe4f4326b;
    private readonly Image[] _0xc0d3df11 = new Image[_0x2360e6ef.MapCells];
    private void OnDestroy()
    {
        DOTween.Kill(this, false);
    }

    private float _0x928640b7;
    private _0xcb416fe2 _0x0e361610;
    private readonly Image[] _0xb0fc664f = new Image[_0x2360e6ef.MapCells];
}

internal static class _0x2768f991
{
    internal static string _0x74c4b04e(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}