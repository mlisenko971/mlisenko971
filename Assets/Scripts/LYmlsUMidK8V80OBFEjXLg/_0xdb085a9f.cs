using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The home screen: who you are in the club, today's goal, the lantern, and the way in.
///
/// The call to action is the template's OWN button - it already carries a LoadSceneButton
/// pointing at the game scene, so the transition stays template code and only the visible
/// face is ours, drawn as children of that same rect with raycastTarget off so a tap still
/// reaches the driver underneath (rules H and G.3). There is no second Play button beside
/// it: one slot, one button.
///
/// The app's name appears nowhere here. The branding is the abstract mark and the palette.
///
/// No constructor (rule C.59): Build fills the object and returns it.
/// </summary>
public sealed class _0xdb085a9f
{
    public _0xc9b630d4 _0xa0140247
    {
        get
        {
            return this._0xcd3dfb82;
        }
    }

    private const float GoalBarWidth = 860f;
    public _0xc9b630d4 _0xa7a225b0
    {
        get
        {
            return this._0x039919e5;
        }
    }

    public void _0x2dbdb537(string _0x62e22a3e)
    {
        _0xd90280ba.SetText(this._0xdceb6b07, _0x62e22a3e);
    }

    public void _0x24d1bae7(int _0x1f2f91cc, bool _0x28157576)
    {
        for (int _0xd22eded0 = 0; _0xd22eded0 < _0x2360e6ef.TasksPerSession; _0xd22eded0++)
            if (this._0x607e5ea9[_0xd22eded0] != null)
                this._0x607e5ea9[_0xd22eded0].color = _0xd22eded0 < _0x1f2f91cc ? _0xb20acb45.Teal : _0xb20acb45.Fade(_0xb20acb45.Haze, 0.95f);
        this._0x50d44bfb._0x49a09ed3(this._0x2b5e0e59, (float)_0x1f2f91cc / _0x2360e6ef.TasksPerSession, GoalBarWidth);
        _0xd90280ba.SetText(this._0xbbcbe7b7, _0x28157576 ? _0x94c4f98b._0x08b346e8(new byte[41] { 151, 152, 129, 150, 244, 146, 134, 149, 153, 145, 244, 129, 154, 152, 155, 151, 159, 145, 144, 222, 159, 145, 145, 132, 244, 128, 156, 145, 244, 131, 145, 145, 159, 244, 150, 129, 134, 154, 157, 154, 147 }, 212) : _0x94c4f98b._0x08b346e8(new byte[30] { 29, 18, 21, 18, 8, 19, 123, 104, 123, 15, 26, 8, 16, 8, 81, 23, 18, 28, 19, 15, 123, 106, 123, 23, 26, 21, 15, 30, 9, 21 }, 91));
        if (this._0xb731363b != null)
            this._0xb731363b.gameObject.SetActive(_0x28157576);
    }

    private Image _0x1022f653;
    private TextMeshProUGUI _0x1c5bf78e;
    /// <summary>
    /// Draws the face of the call to action onto the template's own button rect. The rect
    /// itself is sized in the scene (anchors collapsed to a point, 800 x 170 on the
    /// 1242 x 2688 canvas), so this never has to guess where it is.
    /// </summary>
    private Button _0xbb45d5c7(_0xf23fcd8b _0xbbec6cc0, _0x761f29fe _0x0149caf8, RectTransform _0x50311d71, RectTransform _0xb542e056)
    {
        if (_0xb542e056 == null)
        {
            // The scene always wires the template slot; this is the guard against shipping a
            // menu with no way into the session at all. It cannot double up with the template
            // button, because it runs only when that serialized reference is empty.
            _0xc9b630d4 _0xcee910a3 = _0xbbec6cc0._0xeaf47c78(_0x50311d71, _0x94c4f98b._0x08b346e8(new byte[8] { 44, 16, 29, 5, 63, 29, 16, 16 }, 124), _0x94c4f98b._0x08b346e8(new byte[13] { 202, 205, 216, 203, 205, 185, 202, 220, 202, 202, 208, 214, 215 }, 153), _0xbe939921._0x434f62f6, new Vector2(0f, -1989f), new Vector2(800f, 170f), 50f, true);
            this._0xdceb6b07 = _0xcee910a3._0xdb5976b8;
            return _0xcee910a3._0x442d0849;
        }

        Button _0xf7bbf4ba = _0xb542e056.GetComponent<Button>();
        if (_0xf7bbf4ba == null)
            _0xf7bbf4ba = _0xb542e056.GetComponentInChildren<Button>(true);
        RectTransform _0x65a7c406 = _0xbbec6cc0._0x6f23ed2a(_0xb542e056, _0x94c4f98b._0x08b346e8(new byte[8] { 30, 34, 47, 55, 8, 47, 45, 43 }, 78));
        Image _0xd6ab14ea = _0xbbec6cc0._0xb3a779c2(_0x65a7c406, _0x94c4f98b._0x08b346e8(new byte[10] { 179, 143, 130, 154, 176, 139, 130, 135, 140, 148 }, 227), _0xb20acb45.Fade(_0xb20acb45.Slate, 0.28f), 1.9f);
        _0xd6ab14ea.rectTransform.offsetMin = new Vector2(-2f, -12f);
        _0xd6ab14ea.rectTransform.offsetMax = new Vector2(2f, -4f);
        Image _0x58697f1d = _0xbbec6cc0._0xb3a779c2(_0x65a7c406, _0x94c4f98b._0x08b346e8(new byte[7] { 24, 36, 41, 49, 26, 33, 37 }, 72), _0xb20acb45.Fade(_0xb20acb45.GoldDeep, 0.95f), 1.9f);
        Image _0x09b3c6b0 = _0xbbec6cc0._0xb3a779c2(_0x58697f1d.rectTransform, _0x94c4f98b._0x08b346e8(new byte[8] { 107, 87, 90, 66, 121, 84, 95, 66 }, 59), _0xb20acb45.Gold, 1.95f);
        _0x09b3c6b0.rectTransform.offsetMin = new Vector2(5f, 5f);
        _0x09b3c6b0.rectTransform.offsetMax = new Vector2(-5f, -5f);
        Image _0x33610841 = _0xbbec6cc0._0xb3a779c2(_0x09b3c6b0.rectTransform, _0x94c4f98b._0x08b346e8(new byte[9] { 239, 211, 222, 198, 236, 215, 218, 218, 209 }, 191), _0xb20acb45.Fade(_0xb20acb45.Mist, 0.32f), 1.95f);
        _0x33610841.rectTransform.anchorMin = new Vector2(0f, 0.54f);
        _0x33610841.rectTransform.anchorMax = new Vector2(1f, 1f);
        _0x33610841.rectTransform.offsetMin = new Vector2(8f, 0f);
        _0x33610841.rectTransform.offsetMax = new Vector2(-8f, -6f);
        _0xbbec6cc0._0x5ab12fd7(_0x09b3c6b0.rectTransform, _0x94c4f98b._0x08b346e8(new byte[9] { 26, 38, 43, 51, 25, 58, 43, 56, 33 }, 74), _0x0149caf8._0x20f0f53d, _0xbe939921._0x6ab5ec46, new Vector2(104f, 0f), 72f);
        this._0xdceb6b07 = _0xbbec6cc0._0xb8fb9383(_0x65a7c406, _0x94c4f98b._0x08b346e8(new byte[11] { 182, 138, 135, 159, 165, 135, 150, 146, 143, 137, 136 }, 230), _0x94c4f98b._0x08b346e8(new byte[13] { 233, 238, 251, 232, 238, 154, 233, 255, 233, 233, 243, 245, 244 }, 186), _0xbe939921._0x7f5aa638, new Vector2(34f, 0f), new Vector2(560f, 104f), 50f, _0xb20acb45.Ink, TextAlignmentOptions.Center);
        this._0xdceb6b07.transform.SetAsLastSibling();
        return _0xf7bbf4ba;
    }

    private TextMeshProUGUI _0x86c34179;
    public _0xdb085a9f Build(_0xf23fcd8b _0x74129c38, _0x761f29fe _0x9d206896, RectTransform _0x5d1d9d95, RectTransform _0x5a720c27)
    {
        this._0x50d44bfb = _0x74129c38;
        // The brightest wash of the three screens: the courtyard should read here.
        _0x74129c38._0xcb95568b(_0x5d1d9d95, _0x9d206896._0x4d16ad10, _0xb20acb45.Fade(_0xb20acb45.Mist, 0.46f));
        RectTransform _0x739d545c = _0x74129c38._0x4a32d93b(_0x5d1d9d95, _0x94c4f98b._0x08b346e8(new byte[4] { 154, 182, 165, 188 }, 215), _0xbe939921._0x434f62f6, new Vector2(0f, -300f), new Vector2(280f, 280f));
        _0x74129c38._0xa061d3cf(_0x739d545c, _0x94c4f98b._0x08b346e8(new byte[8] { 125, 81, 66, 91, 119, 92, 95, 71 }, 48), _0xbe939921._0x7f5aa638, Vector2.zero, new Vector2(272f, 272f), _0xb20acb45.Fade(_0xb20acb45.Gold, 0.22f), 0.2f);
        Image _0x2180132b = _0x74129c38._0x5ab12fd7(_0x739d545c, _0x94c4f98b._0x08b346e8(new byte[7] { 134, 170, 185, 160, 138, 185, 191 }, 203), _0x9d206896._0x209c27fb, _0xbe939921._0x7f5aa638, Vector2.zero, 226f);
        _0x2180132b.rectTransform.DOScale(1.04f, 2.2f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine).SetLink(_0x2180132b.gameObject);
        _0x74129c38._0xb8fb9383(_0x5d1d9d95, _0x94c4f98b._0x08b346e8(new byte[11] { 197, 233, 250, 227, 203, 233, 248, 252, 225, 231, 230 }, 136), _0x94c4f98b._0x08b346e8(new byte[20] { 227, 230, 232, 231, 251, 143, 224, 225, 234, 143, 227, 238, 226, 255, 143, 238, 143, 235, 238, 246 }, 175), _0xbe939921._0x434f62f6, new Vector2(0f, -452f), new Vector2(900f, 58f), 32f, _0xb20acb45.SlateText, TextAlignmentOptions.Center);
        // -- profile sheet ---------------------------------------------------
        RectTransform _0x416c5742 = _0x74129c38._0xaa5a67ea(_0x5d1d9d95, _0x94c4f98b._0x08b346e8(new byte[12] { 109, 79, 82, 91, 84, 81, 88, 110, 85, 88, 88, 73 }, 61), _0xbe939921._0x434f62f6, new Vector2(0f, -660f), new Vector2(_0xbe939921.SheetWidth, 280f));
        this._0xb731363b = _0x74129c38._0xb3a779c2(_0x416c5742, _0x94c4f98b._0x08b346e8(new byte[9] { 130, 173, 180, 163, 135, 179, 160, 172, 164 }, 193), _0xb20acb45.Fade(_0xb20acb45.Gold, 0.55f), 1.8f);
        this._0xb731363b.rectTransform.offsetMin = new Vector2(-8f, -8f);
        this._0xb731363b.rectTransform.offsetMax = new Vector2(8f, 8f);
        this._0xb731363b.transform.SetAsFirstSibling();
        this._0xb731363b.gameObject.SetActive(false);
        _0x74129c38._0x5ab12fd7(_0x416c5742, _0x94c4f98b._0x08b346e8(new byte[6] { 23, 32, 55, 34, 55, 36 }, 86), _0x9d206896._0x6605a8a9, _0xbe939921._0x7f5aa638, new Vector2(-419f, 0f), 140f);
        this._0x86c34179 = _0x74129c38._0xb8fb9383(_0x416c5742, _0x94c4f98b._0x08b346e8(new byte[10] { 231, 207, 199, 200, 207, 216, 230, 195, 196, 207 }, 170), _0x94c4f98b._0x08b346e8(new byte[20] { 236, 228, 236, 227, 228, 243, 129, 140, 129, 237, 224, 236, 241, 237, 232, 230, 233, 245, 228, 243 }, 161), _0xbe939921._0x7f5aa638, new Vector2(-103f, 40f), new Vector2(400f, 56f), 36f, _0xb20acb45.Ink, TextAlignmentOptions.Left);
        this._0x1c5bf78e = _0x74129c38._0xb8fb9383(_0x416c5742, _0x94c4f98b._0x08b346e8(new byte[10] { 238, 201, 207, 216, 220, 214, 241, 212, 211, 216 }, 189), _0x94c4f98b._0x08b346e8(new byte[12] { 231, 226, 250, 131, 240, 247, 241, 230, 226, 232, 131, 146 }, 163), _0xbe939921._0x7f5aa638, new Vector2(-103f, -22f), new Vector2(400f, 50f), 30f, _0xb20acb45.SlateText, TextAlignmentOptions.Left);
        _0x74129c38._0x5ab12fd7(_0x416c5742, _0x94c4f98b._0x08b346e8(new byte[9] { 101, 70, 87, 68, 93, 127, 85, 89, 88 }, 54), _0x9d206896._0x20f0f53d, _0xbe939921._0x7f5aa638, new Vector2(170f, -10f), 72f);
        _0x74129c38._0xb8fb9383(_0x416c5742, _0x94c4f98b._0x08b346e8(new byte[10] { 0, 35, 50, 33, 56, 31, 50, 49, 54, 63 }, 83), _0x94c4f98b._0x08b346e8(new byte[6] { 93, 94, 79, 92, 69, 93 }, 14), _0xbe939921._0x7f5aa638, new Vector2(360f, 48f), new Vector2(260f, 44f), 26f, _0xb20acb45.SlateText, TextAlignmentOptions.Center);
        this._0x814c09d6 = _0x74129c38._0xb8fb9383(_0x416c5742, _0x94c4f98b._0x08b346e8(new byte[10] { 130, 161, 176, 163, 186, 135, 176, 189, 164, 180 }, 209), _0x94c4f98b._0x08b346e8(new byte[1] { 235 }, 219), _0xbe939921._0x7f5aa638, new Vector2(360f, -16f), new Vector2(260f, 72f), 46f, _0xb20acb45.Ink, TextAlignmentOptions.Center);
        // -- daily goal sheet ------------------------------------------------
        RectTransform _0x4569fa17 = _0x74129c38._0xaa6a3c9e(_0x5d1d9d95, _0x94c4f98b._0x08b346e8(new byte[9] { 220, 244, 250, 247, 200, 243, 254, 254, 239 }, 155), _0xbe939921._0x434f62f6, new Vector2(0f, -1000f), new Vector2(_0xbe939921.SheetWidth, 330f));
        _0x74129c38._0xb8fb9383(_0x4569fa17, _0x94c4f98b._0x08b346e8(new byte[8] { 185, 145, 159, 146, 182, 155, 159, 154 }, 254), _0x94c4f98b._0x08b346e8(new byte[12] { 111, 116, 127, 122, 98, 28, 104, 27, 124, 116, 122, 119 }, 59), _0xbe939921._0x7f5aa638, new Vector2(0f, 118f), new Vector2(900f, 52f), 36f, _0xb20acb45.Ink, TextAlignmentOptions.Center);
        this._0xbbcbe7b7 = _0x74129c38._0xb8fb9383(_0x4569fa17, _0x94c4f98b._0x08b346e8(new byte[8] { 37, 13, 3, 14, 32, 13, 6, 27 }, 98), _0x94c4f98b._0x08b346e8(new byte[30] { 98, 109, 106, 109, 119, 108, 4, 23, 4, 112, 101, 119, 111, 119, 46, 104, 109, 99, 108, 112, 4, 21, 4, 104, 101, 106, 112, 97, 118, 106 }, 36), _0xbe939921._0x7f5aa638, new Vector2(0f, 28f), new Vector2(900f, 106f), 32f, _0xb20acb45.SlateText, TextAlignmentOptions.Center);
        for (int _0x653e85ab = 0; _0x653e85ab < _0x2360e6ef.TasksPerSession; _0x653e85ab++)
        {
            Vector2 _0x3d6203ec = new Vector2(_0xbe939921.Column(300f, _0x2360e6ef.TasksPerSession, 24f, _0x653e85ab), -58f);
            this._0x607e5ea9[_0x653e85ab] = _0x74129c38._0x9a152850(_0x4569fa17, _0x94c4f98b._0x08b346e8(new byte[7] { 90, 114, 124, 113, 89, 114, 105 }, 29), _0xbe939921._0x7f5aa638, _0x3d6203ec, 44f, _0xb20acb45.Fade(_0xb20acb45.Haze, 0.95f));
        }

        this._0x2b5e0e59 = _0x74129c38._0x5961980a(_0x4569fa17, _0x94c4f98b._0x08b346e8(new byte[7] { 205, 229, 235, 230, 200, 235, 248 }, 138), _0xbe939921._0x7f5aa638, new Vector2(0f, -122f), new Vector2(GoalBarWidth, 24f), _0xb20acb45.Teal);
        // -- the lantern itself ----------------------------------------------
        RectTransform _0x157800c9 = _0x74129c38._0x4a32d93b(_0x5d1d9d95, _0x94c4f98b._0x08b346e8(new byte[4] { 212, 249, 238, 243 }, 156), _0xbe939921._0x434f62f6, new Vector2(0f, -1390f), new Vector2(380f, 380f));
        _0x74129c38._0xa061d3cf(_0x157800c9, _0x94c4f98b._0x08b346e8(new byte[8] { 201, 228, 243, 238, 198, 237, 238, 246 }, 129), _0xbe939921._0x7f5aa638, Vector2.zero, new Vector2(330f, 330f), _0xb20acb45.Fade(_0xb20acb45.Gold, 0.18f), 0.2f);
        _0x74129c38._0x5ab12fd7(_0x157800c9, _0x94c4f98b._0x08b346e8(new byte[7] { 232, 197, 210, 207, 225, 210, 212 }, 160), _0x9d206896._0x43f281af, _0xbe939921._0x7f5aa638, Vector2.zero, 350f);
        _0x157800c9.DOAnchorPosY(-1378f, 2.4f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine).SetLink(_0x157800c9.gameObject);
        // -- the club's shared week ------------------------------------------
        RectTransform _0x80397571 = _0x74129c38._0xaa5a67ea(_0x5d1d9d95, _0x94c4f98b._0x08b346e8(new byte[9] { 83, 124, 101, 114, 67, 120, 117, 117, 100 }, 16), _0xbe939921._0x434f62f6, new Vector2(0f, -1760f), new Vector2(_0xbe939921.SheetWidth, 210f));
        _0x74129c38._0xb8fb9383(_0x80397571, _0x94c4f98b._0x08b346e8(new byte[8] { 27, 52, 45, 58, 16, 61, 57, 60 }, 88), _0x94c4f98b._0x08b346e8(new byte[18] { 176, 172, 161, 196, 167, 168, 177, 166, 196, 176, 172, 173, 183, 196, 179, 161, 161, 175 }, 228), _0xbe939921._0x7f5aa638, new Vector2(0f, 62f), new Vector2(900f, 48f), 32f, _0xb20acb45.Ink, TextAlignmentOptions.Center);
        this._0x1022f653 = _0x74129c38._0x5961980a(_0x80397571, _0x94c4f98b._0x08b346e8(new byte[7] { 173, 130, 155, 140, 172, 143, 156 }, 238), _0xbe939921._0x7f5aa638, new Vector2(0f, 4f), new Vector2(ClubBarWidth, 26f), _0xb20acb45.Gold);
        this._0x18db474d = _0x74129c38._0xb8fb9383(_0x80397571, _0x94c4f98b._0x08b346e8(new byte[11] { 87, 120, 97, 118, 87, 117, 100, 96, 125, 123, 122 }, 20), _0x94c4f98b._0x08b346e8(new byte[19] { 95, 82, 93, 71, 86, 65, 93, 64, 51, 95, 90, 71, 51, 35, 51, 60, 51, 33, 34 }, 19), _0xbe939921._0x7f5aa638, new Vector2(0f, -56f), new Vector2(900f, 48f), 30f, _0xb20acb45.SlateText, TextAlignmentOptions.Center);
        // -- the call to action, drawn onto the template's own button --------
        this._0x130af1ed = this._0xbb45d5c7(_0x74129c38, _0x9d206896, _0x5d1d9d95, _0x5a720c27);
        // -- secondary row ---------------------------------------------------
        this._0x5d3cc71e = _0x74129c38._0xeaf47c78(_0x5d1d9d95, _0x94c4f98b._0x08b346e8(new byte[8] { 109, 66, 91, 76, 109, 79, 66, 66 }, 46), _0x94c4f98b._0x08b346e8(new byte[8] { 17, 13, 0, 101, 6, 9, 16, 7 }, 69), _0xbe939921._0x434f62f6, new Vector2(-311f, -2271f), new Vector2(520f, 128f), 38f, false);
        this._0xcd3dfb82 = _0x74129c38._0xeaf47c78(_0x5d1d9d95, _0x94c4f98b._0x08b346e8(new byte[7] { 124, 80, 65, 114, 80, 93, 93 }, 49), _0x94c4f98b._0x08b346e8(new byte[8] { 77, 95, 95, 81, 58, 87, 91, 74 }, 26), _0xbe939921._0x434f62f6, new Vector2(311f, -2271f), new Vector2(520f, 128f), 38f, false);
        this._0x039919e5 = _0x74129c38._0xeaf47c78(_0x5d1d9d95, _0x94c4f98b._0x08b346e8(new byte[9] { 214, 228, 248, 245, 244, 210, 240, 253, 253 }, 145), _0x94c4f98b._0x08b346e8(new byte[11] { 161, 166, 190, 201, 189, 166, 201, 185, 165, 168, 176 }, 233), _0xbe939921._0x434f62f6, new Vector2(0f, -2440f), new Vector2(520f, 104f), 32f, false);
        return this;
    }

    public Button _0x8736c143
    {
        get
        {
            return this._0x130af1ed;
        }
    }

    private TextMeshProUGUI _0x18db474d;
    private _0xc9b630d4 _0xcd3dfb82;
    private _0xc9b630d4 _0x5d3cc71e;
    private Image _0xb731363b;
    private TextMeshProUGUI _0xdceb6b07;
    private Image _0x2b5e0e59;
    private const float ClubBarWidth = 900f;
    private readonly Image[] _0x607e5ea9 = new Image[_0x2360e6ef.TasksPerSession];
    private _0xc9b630d4 _0x039919e5;
    private _0xf23fcd8b _0x50d44bfb;
    public void _0x9b46afc9(int _0x1520bccb, int _0x1413c300)
    {
        _0xd90280ba.SetText(this._0x814c09d6, _0x1520bccb.ToString());
        _0xd90280ba.SetText(this._0x1c5bf78e, _0x94c4f98b._0x08b346e8(new byte[11] { 54, 51, 43, 82, 33, 38, 32, 55, 51, 57, 82 }, 114) + _0x1413c300);
        _0xd90280ba.SetText(this._0x86c34179, _0x94c4f98b._0x08b346e8(new byte[20] { 74, 66, 74, 69, 66, 85, 39, 42, 39, 75, 70, 74, 87, 75, 78, 64, 79, 83, 66, 85 }, 7));
    }

    private TextMeshProUGUI _0x814c09d6;
    private TextMeshProUGUI _0xbbcbe7b7;
    public _0xc9b630d4 _0xfe5786fe
    {
        get
        {
            return this._0x5d3cc71e;
        }
    }

    private Button _0x130af1ed;
    public void _0x4de0a470(int _0x149537ba)
    {
        this._0x50d44bfb._0x49a09ed3(this._0x1022f653, (float)_0x149537ba / _0x2360e6ef.MapCells, ClubBarWidth);
        _0xd90280ba.SetText(this._0x18db474d, _0x94c4f98b._0x08b346e8(new byte[13] { 151, 154, 149, 143, 158, 137, 149, 136, 251, 151, 146, 143, 251 }, 219) + _0x149537ba + _0x94c4f98b._0x08b346e8(new byte[3] { 23, 24, 23 }, 55) + _0x2360e6ef.MapCells);
    }
}

internal static class _0x94c4f98b
{
    internal static string _0x08b346e8(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}