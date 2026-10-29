using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The whole visual vocabulary of the app: a light mist sheet with a two-stop gradient, a
/// soft slate shadow, no border and medium corners - the SHEET archetype of rule G.2.
///
/// Everything is uGUI on the template's own canvases. There is not one SpriteRenderer in
/// this project, so the sorting corridor of rule C.21 has nothing to order: inside a
/// canvas the draw order is the hierarchy order, and the Win / Lose / Pause pops are the
/// last siblings. Inside every piece built here the order is background -> trim -> icon ->
/// text, so a caption is never covered by its own plate (rules E.1 and C.13).
///
/// One instance is built by each scene director and handed to its views, so there is no
/// static state and nothing is resolved by name.
/// </summary>
public sealed class _0xf23fcd8b
{
    public TextMeshProUGUI _0xb8fb9383(Transform _0x1a0135ca, string _0x8fdcba9a, string _0xf4d4dac1, Vector2 _0x3227724a, Vector2 _0x3ab48186, Vector2 _0x973a75fb, float _0x8d6dddf0, Color _0x888bcdc0, TextAlignmentOptions _0x5d2a8fc8)
    {
        RectTransform _0x62401b47 = this._0x4a32d93b(_0x1a0135ca, _0x8fdcba9a, _0x3227724a, _0x3ab48186, _0x973a75fb);
        TextMeshProUGUI _0xc192606d = _0x62401b47.gameObject.AddComponent<TextMeshProUGUI>();
        if (this._0x32f262fd != null)
            _0xc192606d.font = this._0x32f262fd;
        _0xc192606d.color = _0x888bcdc0;
        _0xc192606d.alignment = _0x5d2a8fc8;
        _0xc192606d.raycastTarget = false;
        _0xc192606d.text = _0xf4d4dac1;
        _0xd90280ba.Apply(_0xc192606d, _0x8d6dddf0);
        return _0xc192606d;
    }

    public Image _0xb3a779c2(Transform _0x0f8a0133, string _0x90989429, Color _0xb6cdffe1, float _0x884aa9b8)
    {
        RectTransform _0xd011c2c0 = this._0x6f23ed2a(_0x0f8a0133, _0x90989429);
        Image _0x9bfd37f0 = _0xd011c2c0.gameObject.AddComponent<Image>();
        _0x9bfd37f0.sprite = this._0xb5ef9023;
        _0x9bfd37f0.type = Image.Type.Sliced;
        _0x9bfd37f0.pixelsPerUnitMultiplier = _0x884aa9b8;
        _0x9bfd37f0.color = _0xb6cdffe1;
        _0x9bfd37f0.raycastTarget = false;
        return _0x9bfd37f0;
    }

    /// <summary>A nearly transparent, always-rendered hit surface; a fully clear one is culled.</summary>
    public Image _0x32cda798(Transform _0x29cc9b1d, string _0xe2f57d73, Color _0xdfe01a91)
    {
        RectTransform _0x0bdbd671 = this._0x6f23ed2a(_0x29cc9b1d, _0xe2f57d73);
        Image _0x2b524aa4 = _0x0bdbd671.gameObject.AddComponent<Image>();
        _0x2b524aa4.sprite = this._0xb5ef9023;
        _0x2b524aa4.type = Image.Type.Sliced;
        _0x2b524aa4.pixelsPerUnitMultiplier = 2.2f;
        _0x2b524aa4.color = _0xdfe01a91;
        _0x2b524aa4.raycastTarget = true;
        _0x2b524aa4.canvasRenderer.cullTransparentMesh = false;
        return _0x2b524aa4;
    }

    /// <summary>
    /// A cross drawn from two rotated bars. The art set is fixed and contains no cross, and
    /// an Image with no sprite is painted by Unity as a solid WHITE rectangle - the single
    /// most visible way a popup ships broken (rule B.1). Two plates cannot go missing.
    /// </summary>
    public RectTransform _0xf1859ad1(Transform _0xc6458774, string _0x382ab9b3, Vector2 _0x63a62d12, Vector2 _0x361fb4c7, float _0x44c560a8, float _0x792b594f, Color _0x0f809297)
    {
        RectTransform _0xdcccf139 = this._0x4a32d93b(_0xc6458774, _0x382ab9b3, _0x63a62d12, _0x361fb4c7, new Vector2(_0x44c560a8, _0x44c560a8));
        Image _0x64f16060 = this._0xa061d3cf(_0xdcccf139, _0x543a5156._0xb83bcdd8(new byte[4] { 205, 238, 253, 206 }, 143), _0xbe939921._0x7f5aa638, Vector2.zero, new Vector2(_0x44c560a8, _0x792b594f), _0x0f809297, 0.8f);
        Image _0x3c826073 = this._0xa061d3cf(_0xdcccf139, _0x543a5156._0xb83bcdd8(new byte[4] { 198, 229, 246, 198 }, 132), _0xbe939921._0x7f5aa638, Vector2.zero, new Vector2(_0x44c560a8, _0x792b594f), _0x0f809297, 0.8f);
        _0x64f16060.rectTransform.localEulerAngles = new Vector3(0f, 0f, 45f);
        _0x3c826073.rectTransform.localEulerAngles = new Vector3(0f, 0f, -45f);
        return _0xdcccf139;
    }

    private Sprite _0xb5ef9023;
    /// <summary>A node that fills its parent exactly.</summary>
    public RectTransform _0x6f23ed2a(Transform _0x958db16a, string _0x597df2c2)
    {
        GameObject _0x67c1471f = new GameObject(_0x597df2c2, typeof(RectTransform));
        RectTransform _0xfa93b5f6 = _0x67c1471f.GetComponent<RectTransform>();
        _0xfa93b5f6.SetParent(_0x958db16a, false);
        _0xfa93b5f6.anchorMin = Vector2.zero;
        _0xfa93b5f6.anchorMax = Vector2.one;
        _0xfa93b5f6.pivot = new Vector2(0.5f, 0.5f);
        _0xfa93b5f6.anchoredPosition = Vector2.zero;
        _0xfa93b5f6.sizeDelta = Vector2.zero;
        _0xfa93b5f6.localScale = Vector3.one;
        return _0xfa93b5f6;
    }

    public _0xf23fcd8b _0xb71699bf(Sprite _0x84608382, TMP_FontAsset _0x7e1b66c7)
    {
        this._0xb5ef9023 = _0x84608382;
        this._0x32f262fd = _0x7e1b66c7;
        return this;
    }

    /// <summary>
    /// A chip: small rounded pill with its own caption. Used for the ready-made reactions
    /// and the opened sections of the week.
    /// </summary>
    public _0xc9b630d4 _0x0d74b0c5(Transform _0xd42c9dd0, string _0x2980878d, string _0x02a6431c, Vector2 _0xd71f465f, Vector2 _0x00fa20a8, Vector2 _0xf7361d82, Color _0x03d3f0a4)
    {
        RectTransform _0xc07b7865 = this._0x4a32d93b(_0xd42c9dd0, _0x2980878d, _0xd71f465f, _0x00fa20a8, _0xf7361d82);
        Image _0xd291186a = this._0xb3a779c2(_0xc07b7865, _0x543a5156._0xb83bcdd8(new byte[3] { 63, 4, 0 }, 109), _0xb20acb45.Fade(_0xb20acb45.Slate, 0.30f), 0.9f);
        Image _0x2b07954a = this._0xb3a779c2(_0xd291186a.rectTransform, _0x543a5156._0xb83bcdd8(new byte[4] { 73, 110, 108, 106 }, 15), _0x03d3f0a4, 0.95f);
        _0x2b07954a.rectTransform.offsetMin = new Vector2(2f, 2f);
        _0x2b07954a.rectTransform.offsetMax = new Vector2(-2f, -2f);
        TextMeshProUGUI _0x989a2caa = this._0xb8fb9383(_0xc07b7865, _0x543a5156._0xb83bcdd8(new byte[7] { 209, 243, 226, 230, 251, 253, 252 }, 146), _0x02a6431c, _0xbe939921._0x7f5aa638, Vector2.zero, new Vector2(_0xf7361d82.x - 24f, _0xf7361d82.y - 16f), 28f, _0xb20acb45.Ink, TextAlignmentOptions.Center);
        _0x989a2caa.transform.SetAsLastSibling();
        Button _0xf48b28b1 = this._0x61f1617d(_0xc07b7865.gameObject, _0x2b07954a);
        return new _0xc9b630d4()._0x4b69e1d1(_0xc07b7865, _0xf48b28b1, _0x2b07954a, _0xd291186a, _0x989a2caa);
    }

    /// <summary>
    /// A call-to-action button. Primary is a gold face with a warm rim; secondary is a mist
    /// face with a slate stroke. The caption is added LAST so it is drawn over its own
    /// background, and it is always Ink - rule C.14 allows no light label in this app.
    /// </summary>
    public _0xc9b630d4 _0xeaf47c78(Transform _0x3e29db7f, string _0x1877fb41, string _0x550a9262, Vector2 _0xa856af21, Vector2 _0xaecf589c, Vector2 _0x5d27473c, float _0xf89c679b, bool _0x1a900afb)
    {
        RectTransform _0xf06b8f66 = this._0x4a32d93b(_0x3e29db7f, _0x1877fb41, _0xa856af21, _0xaecf589c, _0x5d27473c);
        Image _0x5ef5a97c = this._0xb3a779c2(_0xf06b8f66, _0x543a5156._0xb83bcdd8(new byte[6] { 111, 84, 93, 88, 83, 75 }, 60), _0xb20acb45.Fade(_0xb20acb45.Slate, _0x1a900afb ? 0.26f : 0.16f), 1.9f);
        _0x5ef5a97c.rectTransform.offsetMin = new Vector2(-2f, -10f);
        _0x5ef5a97c.rectTransform.offsetMax = new Vector2(2f, -4f);
        Color _0xd31c004e = _0x1a900afb ? _0xb20acb45.Fade(_0xb20acb45.GoldDeep, 0.95f) : _0xb20acb45.Fade(_0xb20acb45.Slate, 0.55f);
        Color _0xdb749364 = _0x1a900afb ? _0xb20acb45.Gold : _0xb20acb45.Fade(_0xb20acb45.Mist, 0.94f);
        Image _0x901da2ea = this._0xb3a779c2(_0xf06b8f66, _0x543a5156._0xb83bcdd8(new byte[3] { 95, 100, 96 }, 13), _0xd31c004e, 1.9f);
        Image _0xbe031db2 = this._0xb3a779c2(_0x901da2ea.rectTransform, _0x543a5156._0xb83bcdd8(new byte[4] { 146, 181, 183, 177 }, 212), _0xdb749364, 1.95f);
        float _0xc6b73c59 = _0x1a900afb ? 4f : 3f;
        _0xbe031db2.rectTransform.offsetMin = new Vector2(_0xc6b73c59, _0xc6b73c59);
        _0xbe031db2.rectTransform.offsetMax = new Vector2(-_0xc6b73c59, -_0xc6b73c59);
        Image _0x53761b6b = this._0xb3a779c2(_0xbe031db2.rectTransform, _0x543a5156._0xb83bcdd8(new byte[5] { 205, 246, 251, 251, 240 }, 158), _0xb20acb45.Fade(_0xb20acb45.Mist, _0x1a900afb ? 0.30f : 0.42f), 1.95f);
        _0x53761b6b.rectTransform.anchorMin = new Vector2(0f, 0.54f);
        _0x53761b6b.rectTransform.anchorMax = new Vector2(1f, 1f);
        _0x53761b6b.rectTransform.offsetMin = new Vector2(6f, 0f);
        _0x53761b6b.rectTransform.offsetMax = new Vector2(-6f, -5f);
        TextMeshProUGUI _0x155313c6 = this._0xb8fb9383(_0xf06b8f66, _0x543a5156._0xb83bcdd8(new byte[7] { 155, 185, 168, 172, 177, 183, 182 }, 216), _0x550a9262, _0xbe939921._0x7f5aa638, Vector2.zero, new Vector2(_0x5d27473c.x - 48f, _0x5d27473c.y - 26f), _0xf89c679b, _0xb20acb45.Ink, TextAlignmentOptions.Center);
        _0x155313c6.transform.SetAsLastSibling();
        Button _0xf1ac9b69 = this._0x61f1617d(_0xf06b8f66.gameObject, _0xbe031db2);
        return new _0xc9b630d4()._0x4b69e1d1(_0xf06b8f66, _0xf1ac9b69, _0xbe031db2, _0x901da2ea, _0x155313c6);
    }

    /// <summary>
    /// A square picture. The art pipeline square-pads every generated sprite, so the rect
    /// stays square and preserveAspect keeps whatever shape the drawing actually has.
    /// </summary>
    public Image _0x5ab12fd7(Transform _0xa89ca0b1, string _0xe534fb03, Sprite _0x793a8207, Vector2 _0xd2983635, Vector2 _0xfdc75e22, float _0x40845e33)
    {
        RectTransform _0x41425d82 = this._0x4a32d93b(_0xa89ca0b1, _0xe534fb03, _0xd2983635, _0xfdc75e22, new Vector2(_0x40845e33, _0x40845e33));
        Image _0x2b820c70 = _0x41425d82.gameObject.AddComponent<Image>();
        _0x2b820c70.sprite = _0x793a8207;
        _0x2b820c70.preserveAspect = true;
        _0x2b820c70.type = Image.Type.Simple;
        _0x2b820c70.raycastTarget = false;
        if (_0x793a8207 == null)
            _0x2b820c70.enabled = false;
        return _0x2b820c70;
    }

    /// <summary>A thin rule. Used instead of outlined rings, haloes and star shapes.</summary>
    public Image _0x546a2744(Transform _0x4cf3cdc3, string _0xc8263896, Vector2 _0xeb85d44d, Vector2 _0x1dfd2cf8, float width, Color _0xf0078947)
    {
        return this._0xa061d3cf(_0x4cf3cdc3, _0xc8263896, _0xeb85d44d, _0x1dfd2cf8, new Vector2(width, 2f), _0xf0078947, 1f);
    }

    public TMP_FontAsset _0x57c47a47
    {
        get
        {
            return this._0x32f262fd;
        }
    }

    /// <summary>A small round disc used for the three-step task tracker.</summary>
    public Image _0x9a152850(Transform _0xf03beb73, string _0xd30df988, Vector2 _0x1059ae25, Vector2 _0xff112fe9, float _0xd0c7d63d, Color _0x483799f9)
    {
        return this._0xa061d3cf(_0xf03beb73, _0xd30df988, _0x1059ae25, _0xff112fe9, new Vector2(_0xd0c7d63d, _0xd0c7d63d), _0x483799f9, 0.2f);
    }

    public Sprite _0x6280fb17
    {
        get
        {
            return this._0xb5ef9023;
        }
    }

    private TMP_FontAsset _0x32f262fd;
    /// <summary>
    /// The SHEET: a soft slate shadow, a mist body, a haze band fading in from the bottom
    /// and a thin teal breath at the very bottom edge. Returns the BODY rect, so content
    /// added afterwards lands on top of the sheet rather than under it.
    /// </summary>
    public RectTransform _0xaa5a67ea(Transform _0xc0b2632a, string _0xfa33cb72, Vector2 _0x36fe988a, Vector2 _0x2e99eac1, Vector2 _0xc0f51430)
    {
        RectTransform _0x3f92d6e8 = this._0x4a32d93b(_0xc0b2632a, _0xfa33cb72, _0x36fe988a, _0x2e99eac1, _0xc0f51430);
        Image _0xee0929ae = this._0xb3a779c2(_0x3f92d6e8, _0x543a5156._0xb83bcdd8(new byte[6] { 174, 149, 156, 153, 146, 138 }, 253), _0xb20acb45.Fade(_0xb20acb45.Slate, 0.22f), 2.2f);
        _0xee0929ae.rectTransform.offsetMin = new Vector2(-6f, -14f);
        _0xee0929ae.rectTransform.offsetMax = new Vector2(6f, -2f);
        Image _0x2b92326d = this._0xb3a779c2(_0x3f92d6e8, _0x543a5156._0xb83bcdd8(new byte[4] { 215, 250, 241, 236 }, 149), _0xb20acb45.Fade(_0xb20acb45.Mist, 0.97f), 2.2f);
        Image _0x8c066cb9 = this._0xb3a779c2(_0x2b92326d.rectTransform, _0x543a5156._0xb83bcdd8(new byte[9] { 82, 113, 105, 123, 108, 77, 106, 113, 110 }, 30), _0xb20acb45.Fade(_0xb20acb45.Haze, 0.55f), 2.6f);
        _0x8c066cb9.rectTransform.anchorMin = new Vector2(0f, 0f);
        _0x8c066cb9.rectTransform.anchorMax = new Vector2(1f, 0.52f);
        _0x8c066cb9.rectTransform.offsetMin = new Vector2(3f, 3f);
        _0x8c066cb9.rectTransform.offsetMax = new Vector2(-3f, 0f);
        Image _0xc8448066 = this._0xb3a779c2(_0x2b92326d.rectTransform, _0x543a5156._0xb83bcdd8(new byte[6] { 183, 135, 144, 148, 129, 157 }, 245), _0xb20acb45.Fade(_0xb20acb45.Teal, 0.12f), 2.6f);
        _0xc8448066.rectTransform.anchorMin = new Vector2(0f, 0f);
        _0xc8448066.rectTransform.anchorMax = new Vector2(1f, 0.16f);
        _0xc8448066.rectTransform.offsetMin = new Vector2(3f, 3f);
        _0xc8448066.rectTransform.offsetMax = new Vector2(-3f, 0f);
        return _0x2b92326d.rectTransform;
    }

    /// <summary>
    /// The same pill without a Button. A decorative chip must NOT carry one: a button that
    /// does nothing is a silent defect, and switching one to non-interactive only hides it.
    /// </summary>
    public RectTransform _0xa718d0a2(Transform _0x7daeae50, string _0x57c885ec, string _0x29c79424, Vector2 _0xa86cd652, Vector2 _0x81eeb6ac, Vector2 _0x91045e2f, Color _0x3fffde2c)
    {
        RectTransform _0x60eb12c9 = this._0x4a32d93b(_0x7daeae50, _0x57c885ec, _0xa86cd652, _0x81eeb6ac, _0x91045e2f);
        Image _0xb3a029a6 = this._0xb3a779c2(_0x60eb12c9, _0x543a5156._0xb83bcdd8(new byte[3] { 38, 29, 25 }, 116), _0xb20acb45.Fade(_0xb20acb45.Slate, 0.30f), 0.9f);
        Image _0x8972d786 = this._0xb3a779c2(_0xb3a029a6.rectTransform, _0x543a5156._0xb83bcdd8(new byte[4] { 199, 224, 226, 228 }, 129), _0x3fffde2c, 0.95f);
        _0x8972d786.rectTransform.offsetMin = new Vector2(2f, 2f);
        _0x8972d786.rectTransform.offsetMax = new Vector2(-2f, -2f);
        TextMeshProUGUI _0x012800d4 = this._0xb8fb9383(_0x60eb12c9, _0x543a5156._0xb83bcdd8(new byte[7] { 26, 56, 41, 45, 48, 54, 55 }, 89), _0x29c79424, _0xbe939921._0x7f5aa638, Vector2.zero, new Vector2(_0x91045e2f.x - 24f, _0x91045e2f.y - 16f), 28f, _0xb20acb45.Ink, TextAlignmentOptions.Center);
        _0x012800d4.transform.SetAsLastSibling();
        return _0x60eb12c9;
    }

    /// <summary>
    /// The full-screen background and its wash. The art pipeline draws exactly ONE
    /// background, so every screen uses it and they are told apart by how strong this wash
    /// is - the courtyard brightest in the menu, a touch cooler on the board, mistiest on
    /// the splash. preserveAspect is deliberately off: a backdrop must cover the device.
    /// </summary>
    public Image _0xcb95568b(Transform _0x5d04e73f, Sprite _0x02fa3e39, Color _0x326740b8)
    {
        RectTransform _0xd2ad27ea = this._0x6f23ed2a(_0x5d04e73f, _0x543a5156._0xb83bcdd8(new byte[8] { 40, 11, 9, 1, 14, 24, 5, 26 }, 106));
        Image _0x6e629bc5 = _0xd2ad27ea.gameObject.AddComponent<Image>();
        _0x6e629bc5.sprite = _0x02fa3e39;
        _0x6e629bc5.type = Image.Type.Simple;
        _0x6e629bc5.preserveAspect = false;
        _0x6e629bc5.color = Color.white;
        _0x6e629bc5.raycastTarget = false;
        if (_0x02fa3e39 == null)
            _0x6e629bc5.enabled = false;
        this._0xb3a779c2(_0xd2ad27ea, _0x543a5156._0xb83bcdd8(new byte[12] { 179, 144, 146, 154, 149, 131, 158, 129, 166, 144, 130, 153 }, 241), _0x326740b8, 4f);
        _0xd2ad27ea.SetAsFirstSibling();
        return _0x6e629bc5;
    }

    /// <summary>
    /// A rounded tinted plate. radius is the 9-slice multiplier of the template's own
    /// rounded sprite: LOWER is rounder. It is the only corner lever in this project.
    /// </summary>
    public Image _0xa061d3cf(Transform _0xb7128a9d, string _0xea6fcb0c, Vector2 _0xe29b2e9a, Vector2 _0x3ad854ee, Vector2 _0x46f7f81f, Color _0xa4fa8a48, float _0xa4e54b78)
    {
        RectTransform _0x71976a33 = this._0x4a32d93b(_0xb7128a9d, _0xea6fcb0c, _0xe29b2e9a, _0x3ad854ee, _0x46f7f81f);
        Image _0x734f526f = _0x71976a33.gameObject.AddComponent<Image>();
        _0x734f526f.sprite = this._0xb5ef9023;
        _0x734f526f.type = Image.Type.Sliced;
        _0x734f526f.pixelsPerUnitMultiplier = _0xa4e54b78;
        _0x734f526f.color = _0xa4fa8a48;
        _0x734f526f.raycastTarget = false;
        return _0x734f526f;
    }

    /// <summary>
    /// A square glyph button for the HUD. The glyph is a generated sprite and sits on its
    /// own plate; if the art is missing the plate still reads as a button rather than as a
    /// white square, because the plate carries a real sprite of its own.
    /// </summary>
    public _0xc9b630d4 _0xaf1c28b6(Transform _0x5121403a, string _0x0fc621a3, Sprite _0x4d2cb293, Vector2 _0x676b3332, Vector2 _0x487ab4b8, float _0x79649a12)
    {
        RectTransform _0xd82e084e = this._0x4a32d93b(_0x5121403a, _0x0fc621a3, _0x676b3332, _0x487ab4b8, new Vector2(_0x79649a12, _0x79649a12));
        Image _0x18474116 = this._0xb3a779c2(_0xd82e084e, _0x543a5156._0xb83bcdd8(new byte[3] { 31, 36, 32 }, 77), _0xb20acb45.Fade(_0xb20acb45.Slate, 0.42f), 1.2f);
        Image _0x53b34a29 = this._0xb3a779c2(_0x18474116.rectTransform, _0x543a5156._0xb83bcdd8(new byte[4] { 244, 211, 209, 215 }, 178), _0xb20acb45.Fade(_0xb20acb45.Mist, 0.95f), 1.25f);
        _0x53b34a29.rectTransform.offsetMin = new Vector2(3f, 3f);
        _0x53b34a29.rectTransform.offsetMax = new Vector2(-3f, -3f);
        this._0x5ab12fd7(_0x53b34a29.rectTransform, _0x543a5156._0xb83bcdd8(new byte[5] { 221, 246, 227, 234, 242 }, 154), _0x4d2cb293, _0xbe939921._0x7f5aa638, Vector2.zero, _0x79649a12 * 0.52f);
        Button _0xe4db5f46 = this._0x61f1617d(_0xd82e084e.gameObject, _0x53b34a29);
        return new _0xc9b630d4()._0x4b69e1d1(_0xd82e084e, _0xe4db5f46, _0x53b34a29, _0x18474116, null);
    }

    /// <summary>Makes a drawn face clickable without the ColorTint washing the face away.</summary>
    public Button _0x61f1617d(GameObject _0x53953311, Graphic _0xa56870a0)
    {
        Button _0x48c63d8d = _0x53953311.GetComponent<Button>();
        if (_0x48c63d8d == null)
            _0x48c63d8d = _0x53953311.AddComponent<Button>();
        _0x48c63d8d.transition = Selectable.Transition.ColorTint;
        _0x48c63d8d.targetGraphic = _0xa56870a0;
        ColorBlock _0xd2495158 = _0x48c63d8d.colors;
        _0xd2495158.normalColor = Color.white;
        _0xd2495158.highlightedColor = Color.white;
        _0xd2495158.selectedColor = Color.white;
        _0xd2495158.pressedColor = new Color(0.86f, 0.88f, 0.92f, 1f);
        _0xd2495158.disabledColor = new Color(0.78f, 0.80f, 0.84f, 1f);
        _0xd2495158.colorMultiplier = 1f;
        _0xd2495158.fadeDuration = 0.08f;
        _0x48c63d8d.colors = _0xd2495158;
        if (_0xa56870a0 != null)
            _0xa56870a0.raycastTarget = true;
        return _0x48c63d8d;
    }

    public void _0x49a09ed3(Image _0xa8271c02, float _0x63267afb, float _0x89cf11c8)
    {
        if (_0xa8271c02 == null)
            return;
        float _0x643bad96 = Mathf.Clamp01(_0x63267afb);
        _0xa8271c02.rectTransform.sizeDelta = new Vector2(Mathf.Max(6f, _0x89cf11c8 * _0x643bad96), _0xa8271c02.rectTransform.sizeDelta.y);
    }

    /// <summary>A sheet with a gold edge, for the one block that must read as the warm one.</summary>
    public RectTransform _0xaa6a3c9e(Transform _0xfbc05b7a, string _0x354b01ba, Vector2 _0xc164d0fc, Vector2 _0xde226645, Vector2 _0xce1595db)
    {
        RectTransform _0xa3be5402 = this._0xaa5a67ea(_0xfbc05b7a, _0x354b01ba, _0xc164d0fc, _0xde226645, _0xce1595db);
        Image _0x857cff88 = this._0xb3a779c2(_0xa3be5402, _0x543a5156._0xb83bcdd8(new byte[8] { 220, 234, 249, 230, 206, 239, 236, 238 }, 139), _0xb20acb45.Fade(_0xb20acb45.Gold, 0.22f), 2.4f);
        _0x857cff88.rectTransform.anchorMin = new Vector2(0f, 0.86f);
        _0x857cff88.rectTransform.anchorMax = new Vector2(1f, 1f);
        _0x857cff88.rectTransform.offsetMin = new Vector2(3f, 0f);
        _0x857cff88.rectTransform.offsetMax = new Vector2(-3f, -3f);
        return _0xa3be5402;
    }

    /// <summary>
    /// A progress bar: haze track, coloured fill pinned to the left edge. The fill rect is
    /// returned so the caller can set its width from a real ratio rather than a guess.
    /// </summary>
    public Image _0x5961980a(Transform _0x2ab898aa, string _0x2384c59e, Vector2 _0x09f8e602, Vector2 _0x3122f899, Vector2 _0x35568691, Color _0x00fdba59)
    {
        RectTransform _0x93b93176 = this._0x4a32d93b(_0x2ab898aa, _0x2384c59e, _0x09f8e602, _0x3122f899, _0x35568691);
        this._0xb3a779c2(_0x93b93176, _0x543a5156._0xb83bcdd8(new byte[5] { 214, 240, 227, 225, 233 }, 130), _0xb20acb45.Fade(_0xb20acb45.Haze, 0.95f), 1.1f);
        Image _0x43d1f144 = this._0xa061d3cf(_0x93b93176, _0x543a5156._0xb83bcdd8(new byte[4] { 251, 212, 209, 209 }, 189), _0xbe939921._0x6ab5ec46, new Vector2(0f, 0f), _0x35568691, _0x00fdba59, 1.1f);
        _0x43d1f144.rectTransform.pivot = new Vector2(0f, 0.5f);
        _0x43d1f144.rectTransform.anchoredPosition = new Vector2(0f, 0f);
        return _0x43d1f144;
    }

    /// <summary>A point-anchored node: anchoredPosition is measured from that corner.</summary>
    public RectTransform _0x4a32d93b(Transform _0xbb4ddde8, string _0x3a3990e5, Vector2 _0x4a2876df, Vector2 _0x54b8f2b8, Vector2 _0xb4f684d2)
    {
        GameObject _0xa316ce7d = new GameObject(_0x3a3990e5, typeof(RectTransform));
        RectTransform _0x687e15dd = _0xa316ce7d.GetComponent<RectTransform>();
        _0x687e15dd.SetParent(_0xbb4ddde8, false);
        _0x687e15dd.anchorMin = _0x4a2876df;
        _0x687e15dd.anchorMax = _0x4a2876df;
        _0x687e15dd.pivot = new Vector2(0.5f, 0.5f);
        _0x687e15dd.anchoredPosition = _0x54b8f2b8;
        _0x687e15dd.sizeDelta = _0xb4f684d2;
        _0x687e15dd.localScale = Vector3.one;
        return _0x687e15dd;
    }
}

internal static class _0x543a5156
{
    internal static string _0xb83bcdd8(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}