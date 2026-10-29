using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// THE CLUB: who else is lighting lanterns this week, the shared progress, and the two
/// things a member may send - one ready-made reaction and one free gift a day.
///
/// There is no free text anywhere in this app: a reaction is one of four fixed phrases,
/// picked from a strip. Rule C.7 in full - sending one flies a chip onto the row, flashes
/// the row, spends the day's allowance and greys the button to SENT TODAY, so the result is
/// visible in a still frame rather than only in a label.
///
/// Rule C.25: the badge gutter, the text column and the two action buttons occupy four
/// horizontal bands that never share x-space.
/// </summary>
public sealed class _0xe3046d96 : MonoBehaviour
{
    private void _0x8951a0f9(_0xf23fcd8b _0xdce05cbd, _0x761f29fe _0xa2772060, int _0xc40f212e)
    {
        float _0x98e3570b = 196f;
        float _0xe3959774 = 250f - (_0xc40f212e * _0x98e3570b);
        this._0xc0cf2318[_0xc40f212e] = new Vector2(0f, _0xe3959774);
        RectTransform _0xdd8e4c11 = _0xdce05cbd._0x4a32d93b(this._0x9c81e137, _0xfc7b4ab8._0x77eac57c(new byte[9] { 235, 195, 203, 196, 195, 212, 244, 201, 209 }, 166), _0xbe939921._0x7f5aa638, new Vector2(0f, _0xe3959774), new Vector2(1060f, 180f));
        _0xdce05cbd._0xb3a779c2(_0xdd8e4c11, _0xfc7b4ab8._0x77eac57c(new byte[8] { 7, 58, 34, 5, 57, 52, 33, 48 }, 85), _0xb20acb45.Fade(_0xb20acb45.Mist, 0.88f), 1.6f);
        this._0x924eaae1[_0xc40f212e] = _0xdce05cbd._0xb3a779c2(_0xdd8e4c11, _0xfc7b4ab8._0x77eac57c(new byte[8] { 56, 5, 29, 44, 6, 11, 25, 2 }, 106), _0xb20acb45.Fade(_0xb20acb45.Teal, 0f), 1.6f);
        _0xdce05cbd._0x5ab12fd7(_0xdd8e4c11, _0xfc7b4ab8._0x77eac57c(new byte[5] { 59, 24, 29, 30, 28 }, 121), _0xa2772060._0x6605a8a9, _0xbe939921._0x7f5aa638, new Vector2(-420f, 0f), 140f);
        _0xdce05cbd._0xb8fb9383(_0xdd8e4c11, _0xfc7b4ab8._0x77eac57c(new byte[10] { 1, 41, 33, 46, 41, 62, 2, 45, 33, 41 }, 76), _0x6a15c49e[_0xc40f212e], _0xbe939921._0x7f5aa638, new Vector2(-104f, 34f), new Vector2(400f, 50f), 32f, _0xb20acb45.Ink, TextAlignmentOptions.Left);
        _0xdce05cbd._0xb8fb9383(_0xdd8e4c11, _0xfc7b4ab8._0x77eac57c(new byte[9] { 248, 208, 216, 215, 208, 199, 249, 220, 193 }, 181), _0xfc7b4ab8._0x77eac57c(new byte[4] { 163, 166, 187, 207 }, 239) + _0x500e7baf[_0xc40f212e] + _0xfc7b4ab8._0x77eac57c(new byte[10] { 248, 140, 144, 145, 139, 248, 143, 157, 157, 147 }, 216), _0xbe939921._0x7f5aa638, new Vector2(-104f, -26f), new Vector2(400f, 44f), 26f, _0xb20acb45.SlateText, TextAlignmentOptions.Left);
        this._0xe19889f5[_0xc40f212e] = _0xdce05cbd._0xeaf47c78(_0xdd8e4c11, _0xfc7b4ab8._0x77eac57c(new byte[5] { 177, 134, 130, 128, 151 }, 227), _0xfc7b4ab8._0x77eac57c(new byte[5] { 79, 88, 92, 94, 73 }, 29), _0xbe939921._0x7f5aa638, new Vector2(210f, 0f), new Vector2(160f, 120f), 26f, false);
        int _0xcfffaa07 = _0xc40f212e;
        this._0xe19889f5[_0xc40f212e]._0x442d0849.onClick.AddListener(() => this._0xc5480b1d(_0xcfffaa07));
        this._0x2b53d8fa[_0xc40f212e] = _0xdce05cbd._0xeaf47c78(_0xdd8e4c11, _0xfc7b4ab8._0x77eac57c(new byte[4] { 225, 207, 192, 210 }, 166), _0xfc7b4ab8._0x77eac57c(new byte[4] { 87, 89, 86, 68 }, 16), _0xbe939921._0x7f5aa638, new Vector2(400f, 0f), new Vector2(160f, 120f), 26f, true);
        int _0x4a06922e = _0xc40f212e;
        this._0x2b53d8fa[_0xc40f212e]._0x442d0849.onClick.AddListener(() => this._0x7a2dacdd(_0x4a06922e));
    }

    public void Build(_0xf23fcd8b _0x76233f5c, _0x761f29fe _0x0d6b087b, _0x16d5455c _0xa8926e65, RectTransform _0x20a876de)
    {
        this._0x9144870e = _0x76233f5c;
        this._0xff735d8f = _0x0d6b087b;
        this._0xc56ff617 = _0xa8926e65;
        this._0xf5c8d872 = _0x76233f5c._0x6f23ed2a(_0x20a876de, _0xfc7b4ab8._0x77eac57c(new byte[11] { 234, 197, 220, 203, 230, 223, 204, 219, 197, 200, 208 }, 169));
        Image _0x32e4e8f7 = _0x76233f5c._0x32cda798(this._0xf5c8d872, _0xfc7b4ab8._0x77eac57c(new byte[5] { 230, 214, 199, 220, 216 }, 181), _0xb20acb45.Fade(_0xb20acb45.Ink, 0.22f));
        _0x32e4e8f7.transform.SetAsFirstSibling();
        this._0x9a64afd7 = _0x76233f5c._0xaa5a67ea(this._0xf5c8d872, _0xfc7b4ab8._0x77eac57c(new byte[9] { 206, 225, 248, 239, 222, 229, 232, 232, 249 }, 141), _0xbe939921._0x434f62f6, new Vector2(0f, -1330f), new Vector2(1140f, 2000f));
        _0x76233f5c._0xb8fb9383(this._0x9a64afd7, _0xfc7b4ab8._0x77eac57c(new byte[4] { 187, 150, 146, 151 }, 243), _0xfc7b4ab8._0x77eac57c(new byte[8] { 198, 218, 215, 178, 209, 222, 199, 208 }, 146), _0xbe939921._0x7f5aa638, new Vector2(0f, 880f), new Vector2(1000f, 90f), 48f, _0xb20acb45.Ink, TextAlignmentOptions.Center);
        _0x76233f5c._0xb8fb9383(this._0x9a64afd7, _0xfc7b4ab8._0x77eac57c(new byte[3] { 37, 3, 20 }, 118), _0xfc7b4ab8._0x77eac57c(new byte[15] { 203, 208, 217, 202, 221, 220, 184, 200, 202, 215, 223, 202, 221, 203, 203 }, 152), _0xbe939921._0x7f5aa638, new Vector2(0f, 812f), new Vector2(1000f, 50f), 30f, _0xb20acb45.SlateText, TextAlignmentOptions.Center);
        this._0xbf90949f = _0x76233f5c._0x5961980a(this._0x9a64afd7, _0xfc7b4ab8._0x77eac57c(new byte[7] { 161, 142, 151, 128, 160, 131, 144 }, 226), _0xbe939921._0x7f5aa638, new Vector2(0f, 742f), new Vector2(BarWidth, 32f), _0xb20acb45.Gold);
        this._0xa6de4190 = _0x76233f5c._0xb8fb9383(this._0x9a64afd7, _0xfc7b4ab8._0x77eac57c(new byte[14] { 164, 139, 146, 133, 165, 134, 149, 164, 134, 151, 147, 142, 136, 137 }, 231), _0xfc7b4ab8._0x77eac57c(new byte[19] { 49, 60, 51, 41, 56, 47, 51, 46, 93, 49, 52, 41, 93, 77, 93, 82, 93, 79, 76 }, 125), _0xbe939921._0x7f5aa638, new Vector2(0f, 686f), new Vector2(1000f, 48f), 30f, _0xb20acb45.SlateText, TextAlignmentOptions.Center);
        this._0x2f342ef7 = _0x76233f5c._0xb8fb9383(this._0x9a64afd7, _0xfc7b4ab8._0x77eac57c(new byte[9] { 102, 75, 75, 72, 80, 70, 73, 68, 66 }, 39), _0xfc7b4ab8._0x77eac57c(new byte[28] { 226, 246, 225, 225, 132, 227, 237, 226, 240, 132, 149, 139, 149, 132, 137, 132, 246, 225, 229, 231, 240, 237, 235, 234, 132, 149, 139, 149 }, 164), _0xbe939921._0x7f5aa638, new Vector2(0f, 626f), new Vector2(1000f, 48f), 28f, _0xb20acb45.TealText, TextAlignmentOptions.Center);
        this._0x9c81e137 = _0x76233f5c._0x4a32d93b(this._0x9a64afd7, _0xfc7b4ab8._0x77eac57c(new byte[4] { 94, 99, 123, 127 }, 12), _0xbe939921._0x7f5aa638, new Vector2(0f, 230f), new Vector2(1060f, 860f));
        for (int _0x7dd12809 = 0; _0x7dd12809 < _0x2360e6ef.RosterSize; _0x7dd12809++)
            this._0x8951a0f9(_0x76233f5c, _0x0d6b087b, _0x7dd12809);
        this._0x180c7938 = _0x76233f5c._0xb8fb9383(this._0x9a64afd7, _0xfc7b4ab8._0x77eac57c(new byte[10] { 251, 211, 206, 202, 199, 237, 202, 223, 202, 219 }, 190), _0xfc7b4ab8._0x77eac57c(new byte[34] { 239, 238, 129, 236, 228, 236, 227, 228, 243, 242, 129, 248, 228, 245, 171, 241, 237, 224, 248, 129, 245, 238, 129, 235, 238, 232, 239, 129, 224, 129, 226, 237, 244, 227 }, 161), _0xbe939921._0x7f5aa638, new Vector2(0f, 230f), new Vector2(1000f, 150f), 34f, _0xb20acb45.SlateText, TextAlignmentOptions.Center);
        this._0x180c7938.gameObject.SetActive(false);
        this._0x978e24be = _0x76233f5c._0x4a32d93b(this._0x9a64afd7, _0xfc7b4ab8._0x77eac57c(new byte[13] { 47, 24, 28, 30, 9, 20, 18, 19, 46, 9, 15, 20, 13 }, 125), _0xbe939921._0x7f5aa638, new Vector2(0f, -420f), new Vector2(1060f, 110f));
        _0x76233f5c._0xb3a779c2(this._0x978e24be, _0xfc7b4ab8._0x77eac57c(new byte[10] { 215, 240, 246, 237, 244, 212, 232, 229, 240, 225 }, 132), _0xb20acb45.Fade(_0xb20acb45.Haze, 0.8f), 1.2f);
        float _0x73220b23 = 18f;
        float _0x97aed6d4 = _0xbe939921.Cell(1020f, 4, _0x73220b23);
        for (int _0xa2174e8c = 0; _0xa2174e8c < _0xb7ea9da0.Length; _0xa2174e8c++)
        {
            Vector2 _0x3b428fc4 = new Vector2(_0xbe939921.Column(1020f, 4, _0x73220b23, _0xa2174e8c), 0f);
            _0xc9b630d4 _0xabaed571 = _0x76233f5c._0x0d74b0c5(this._0x978e24be, _0xfc7b4ab8._0x77eac57c(new byte[12] { 109, 90, 94, 92, 75, 86, 80, 81, 124, 87, 86, 79 }, 63), _0xb7ea9da0[_0xa2174e8c], _0xbe939921._0x7f5aa638, _0x3b428fc4, new Vector2(_0x97aed6d4, 84f), _0xb20acb45.Fade(_0xb20acb45.Teal, 0.38f));
            int _0x93407c3b = _0xa2174e8c;
            _0xabaed571._0x442d0849.onClick.AddListener(() => this._0x05001abe(_0x93407c3b));
        }

        this._0x978e24be.gameObject.SetActive(false);
        _0x76233f5c._0xb8fb9383(this._0x9a64afd7, _0xfc7b4ab8._0x77eac57c(new byte[9] { 196, 227, 229, 254, 231, 223, 254, 249, 227 }, 151), _0xfc7b4ab8._0x77eac57c(new byte[49] { 164, 179, 183, 178, 175, 219, 187, 183, 178, 179, 214, 164, 179, 183, 181, 162, 191, 185, 184, 165, 214, 185, 184, 186, 175, 214, 219, 214, 184, 185, 214, 162, 175, 166, 191, 184, 177, 214, 191, 184, 214, 162, 190, 191, 165, 214, 183, 166, 166 }, 246), _0xbe939921._0x7f5aa638, new Vector2(0f, -540f), new Vector2(1020f, 54f), 28f, _0xb20acb45.SlateText, TextAlignmentOptions.Center);
        this._0xfd592b60 = _0x76233f5c._0xeaf47c78(this._0x9a64afd7, _0xfc7b4ab8._0x77eac57c(new byte[9] { 192, 239, 246, 225, 215, 236, 206, 226, 243 }, 131), _0xfc7b4ab8._0x77eac57c(new byte[8] { 127, 109, 109, 99, 8, 101, 105, 120 }, 40), _0xbe939921._0x7f5aa638, new Vector2(0f, -760f), new Vector2(520f, 128f), 38f, true);
        this._0x5890a59c = _0x76233f5c._0xeaf47c78(this._0x9a64afd7, _0xfc7b4ab8._0x77eac57c(new byte[9] { 34, 13, 20, 3, 34, 13, 14, 18, 4 }, 97), _0xfc7b4ab8._0x77eac57c(new byte[5] { 33, 46, 45, 49, 39 }, 98), _0xbe939921._0x7f5aa638, new Vector2(0f, -900f), new Vector2(520f, 128f), 38f, false);
        this.SetVisible(false);
    }

    private _0xc9b630d4 _0xfd592b60;
    private RectTransform _0x978e24be;
    private readonly Image[] _0x924eaae1 = new Image[_0x2360e6ef.RosterSize];
    private _0x761f29fe _0xff735d8f;
    private TextMeshProUGUI _0x2f342ef7;
    public _0xc9b630d4 _0x17124275
    {
        get
        {
            return this._0xfd592b60;
        }
    }

    private void _0xc5480b1d(int _0x75ad2f27)
    {
        if (this._0xc56ff617._0x5c77a0c0)
            return;
        this._0xae788faa = _0x75ad2f27;
        this._0x978e24be.gameObject.SetActive(true);
        this._0x978e24be.localScale = Vector3.one * 0.94f;
        this._0x978e24be.DOScale(1f, 0.22f).SetEase(Ease.OutBack).SetLink(this._0x978e24be.gameObject);
    }

    private _0x16d5455c _0xc56ff617;
    private static readonly string[] _0xb7ea9da0 =
    {
        _0xfc7b4ab8._0x77eac57c(new byte[8] { 245, 231, 238, 238, 130, 238, 235, 246 }, 162),
        _0xfc7b4ab8._0x77eac57c(new byte[9] { 235, 247, 254, 241, 244, 159, 230, 240, 234 }, 191),
        _0xfc7b4ab8._0x77eac57c(new byte[9] { 154, 157, 151, 145, 244, 131, 155, 134, 159 }, 212),
        _0xfc7b4ab8._0x77eac57c(new byte[9] { 231, 239, 239, 228, 128, 247, 229, 229, 235 }, 160)
    };
    /// <summary>The chip is the confirmation, not a permanent row element: it leaves again.</summary>
    private void _0xe50da9e1(RectTransform _0x287fecb8)
    {
        Sequence _0xfcd72000 = DOTween.Sequence().SetLink(_0x287fecb8.gameObject);
        _0xfcd72000.AppendInterval(1.8f);
        _0xfcd72000.Append(_0x287fecb8.DOScale(0.86f, 0.3f).SetEase(Ease.InQuad));
        _0xfcd72000.OnComplete(() => this._0x622c99b6(_0x287fecb8));
    }

    private void _0x05001abe(int _0xccb91a56)
    {
        if (this._0xae788faa < 0 || this._0xc56ff617._0x5c77a0c0)
            return;
        int _0x55a922ba = this._0xae788faa;
        this._0xae788faa = -1;
        this._0x978e24be.gameObject.SetActive(false);
        this._0x306da277(_0x55a922ba, _0xb7ea9da0[_0xccb91a56], _0xb20acb45.Fade(_0xb20acb45.Teal, 0.5f));
        this._0xe19889f5[_0x55a922ba]._0xc2cf9cb9(_0xfc7b4ab8._0x77eac57c(new byte[4] { 97, 119, 124, 102 }, 50));
        this._0xc56ff617._0xf9220b12();
        this._0x40ce5afd();
    }

    private void _0x7a2dacdd(int _0x130ebb5b)
    {
        if (this._0xc56ff617._0x1f4d4dc1)
            return;
        this._0x306da277(_0x130ebb5b, _0xfc7b4ab8._0x77eac57c(new byte[17] { 182, 215, 187, 182, 185, 163, 178, 165, 185, 215, 177, 184, 165, 215, 174, 184, 162 }, 247), _0xb20acb45.Fade(_0xb20acb45.Gold, 0.65f));
        this._0x2b53d8fa[_0x130ebb5b]._0xc2cf9cb9(_0xfc7b4ab8._0x77eac57c(new byte[4] { 107, 125, 118, 108 }, 56));
        this._0xc56ff617._0x7a84db14();
        this._0x40ce5afd();
    }

    private readonly _0xc9b630d4[] _0x2b53d8fa = new _0xc9b630d4[_0x2360e6ef.RosterSize];
    private void _0x622c99b6(RectTransform _0x028a05fe)
    {
        if (_0x028a05fe != null)
            UnityEngine.Object.Destroy(_0x028a05fe.gameObject);
    }

    private TextMeshProUGUI _0x180c7938;
    private RectTransform _0xf5c8d872;
    private _0xc9b630d4 _0x5890a59c;
    private RectTransform _0x9a64afd7;
    private readonly _0xc9b630d4[] _0xe19889f5 = new _0xc9b630d4[_0x2360e6ef.RosterSize];
    public _0xc9b630d4 _0x447a35c9
    {
        get
        {
            return this._0x5890a59c;
        }
    }

    private void OnDestroy()
    {
        DOTween.Kill(this, false);
    }

    private Image _0xbf90949f;
    private static readonly string[] _0x6a15c49e =
    {
        _0xfc7b4ab8._0x77eac57c(new byte[13] { 223, 201, 218, 204, 205, 198, 168, 197, 201, 218, 196, 199, 223 }, 136),
        _0xfc7b4ab8._0x77eac57c(new byte[10] { 47, 33, 33, 52, 33, 54, 68, 37, 32, 37 }, 100),
        _0xfc7b4ab8._0x77eac57c(new byte[16] { 71, 74, 70, 91, 92, 89, 66, 76, 67, 95, 43, 88, 68, 89, 78, 69 }, 11),
        _0xfc7b4ab8._0x77eac57c(new byte[11] { 18, 21, 4, 22, 0, 19, 5, 97, 8, 15, 0 }, 65)
    };
    private int _0xae788faa = -1;
    /// <summary>The visible confirmation: a chip flies onto the row and the row warms up.</summary>
    private void _0x306da277(int _0xae27d3d8, string _0x4f2127ea, Color _0x76173254)
    {
        RectTransform _0xa9fb66af = this._0x9144870e._0xa718d0a2(this._0x9c81e137, _0xfc7b4ab8._0x77eac57c(new byte[8] { 113, 71, 76, 86, 97, 74, 75, 82 }, 34), _0x4f2127ea, _0xbe939921._0x7f5aa638, new Vector2(300f, this._0xc0cf2318[_0xae27d3d8].y), new Vector2(420f, 86f), _0x76173254);
        _0xa9fb66af.SetAsLastSibling();
        _0xa9fb66af.DOAnchorPosX(-120f, 0.42f).SetEase(Ease.OutCubic).SetLink(_0xa9fb66af.gameObject);
        Image _0xe4d631a8 = this._0x924eaae1[_0xae27d3d8];
        if (_0xe4d631a8 != null)
        {
            _0xe4d631a8.color = _0xb20acb45.Fade(_0xb20acb45.Teal, 0.28f);
            _0xe4d631a8.DOFade(0f, 0.6f).SetEase(Ease.OutQuad).SetLink(_0xe4d631a8.gameObject);
        }

        Image _0xd1253e26 = this._0x9144870e._0x5ab12fd7(_0xa9fb66af, _0xfc7b4ab8._0x77eac57c(new byte[7] { 27, 45, 38, 60, 9, 58, 60 }, 72), this._0xff735d8f._0xfaa5a37e, _0xbe939921._0x692f102d, new Vector2(-38f, 0f), 62f);
        _0xd1253e26.transform.SetAsLastSibling();
        this._0xe50da9e1(_0xa9fb66af);
    }

    private static readonly int[] _0x500e7baf =
    {
        5,
        4,
        3,
        2
    };
    private readonly Vector2[] _0xc0cf2318 = new Vector2[_0x2360e6ef.RosterSize];
    private const float BarWidth = 980f;
    private TextMeshProUGUI _0xa6de4190;
    public void SetVisible(bool _0x5f9f1a54)
    {
        if (this._0xf5c8d872 == null)
            return;
        this._0xf5c8d872.gameObject.SetActive(_0x5f9f1a54);
        if (!_0x5f9f1a54)
            return;
        this._0x40ce5afd();
        this._0x9a64afd7.localScale = Vector3.one * 0.96f;
        this._0x9a64afd7.DOScale(1f, 0.26f).SetEase(Ease.OutBack).SetLink(this._0x9a64afd7.gameObject);
    }

    private RectTransform _0x9c81e137;
    public void _0x40ce5afd()
    {
        int _0x5a7b21f0 = 0;
        if (!string.IsNullOrEmpty(this._0xc56ff617._0x2c8aa13e))
            _0x5a7b21f0 = this._0xc56ff617._0xd90f6cf6();
        this._0x9144870e._0x49a09ed3(this._0xbf90949f, (float)_0x5a7b21f0 / _0x2360e6ef.MapCells, BarWidth);
        _0xd90280ba.SetText(this._0xa6de4190, _0xfc7b4ab8._0x77eac57c(new byte[13] { 113, 124, 115, 105, 120, 111, 115, 110, 29, 113, 116, 105, 29 }, 61) + _0x5a7b21f0 + _0xfc7b4ab8._0x77eac57c(new byte[3] { 79, 64, 79 }, 111) + _0x2360e6ef.MapCells);
        _0xd90280ba.SetText(this._0x2f342ef7, _0xfc7b4ab8._0x77eac57c(new byte[10] { 244, 224, 247, 247, 146, 245, 251, 244, 230, 146 }, 178) + (this._0xc56ff617._0x1f4d4dc1 ? _0xfc7b4ab8._0x77eac57c(new byte[3] { 17, 14, 16 }, 33) : _0xfc7b4ab8._0x77eac57c(new byte[3] { 196, 218, 196 }, 245)) + _0xfc7b4ab8._0x77eac57c(new byte[12] { 29, 16, 29, 111, 120, 124, 126, 105, 116, 114, 115, 29 }, 61) + (this._0xc56ff617._0x5c77a0c0 ? _0xfc7b4ab8._0x77eac57c(new byte[3] { 26, 5, 27 }, 42) : _0xfc7b4ab8._0x77eac57c(new byte[3] { 31, 1, 31 }, 46)));
        bool _0x132d7ee2 = _0x2360e6ef.RosterSize > 0;
        if (this._0x9c81e137 != null)
            this._0x9c81e137.gameObject.SetActive(_0x132d7ee2);
        if (this._0x180c7938 != null)
            this._0x180c7938.gameObject.SetActive(!_0x132d7ee2);
        for (int _0x702862a9 = 0; _0x702862a9 < _0x2360e6ef.RosterSize; _0x702862a9++)
        {
            if (this._0xe19889f5[_0x702862a9] != null && this._0xc56ff617._0x5c77a0c0)
                this._0xe19889f5[_0x702862a9]._0xc2cf9cb9(_0xfc7b4ab8._0x77eac57c(new byte[4] { 151, 129, 138, 144 }, 196));
            if (this._0x2b53d8fa[_0x702862a9] != null && this._0xc56ff617._0x1f4d4dc1)
                this._0x2b53d8fa[_0x702862a9]._0xc2cf9cb9(_0xfc7b4ab8._0x77eac57c(new byte[4] { 61, 43, 32, 58 }, 110));
        }
    }

    private _0xf23fcd8b _0x9144870e;
}

internal static class _0xfc7b4ab8
{
    internal static string _0x77eac57c(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}