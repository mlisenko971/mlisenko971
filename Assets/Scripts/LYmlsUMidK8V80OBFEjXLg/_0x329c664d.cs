using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The menu scene: the splash mark, the home screen, the club roster and the week map.
///
/// Everything is built into the template's OWN panels, addressed by SETTINGS.PANELS index -
/// splash 0, default 1, guide pages 13 and 14 - so navigation stays template code and
/// nothing here depends on an object name that obfuscation will rename.
///
/// Draw order inside the default panel is deliberate: the home content first, then the
/// template's own call-to-action button pulled to the end so its face is on top of the
/// backdrop, then the two overlays last of all so their scrim covers the button too
/// (rule E.1).
///
/// Set-up is in Start, never Awake, and nothing here declares a constructor (rule C.59).
/// </summary>
public sealed class _0x329c664d : MonoBehaviour
{
    [SerializeField]
    private _0xc2ebe50c _guide;
    [SerializeField]
    private _0xf22f47db _week;
    [SerializeField]
    private _0x761f29fe _art;
    [SerializeField]
    private _0x86262364 _cleaner;
    private void OnDestroy()
    {
        DOTween.Kill(this, false);
    }

    /// <summary>
    /// The template ships the bar white on a track at alpha 0.004 - invisible. Its SIZE is
    /// left exactly as the prefab authored it; only the two colours change, so the fill
    /// reads against the track (rule G, ANDROID-3578).
    /// </summary>
    private void _0x0fe17dc2()
    {
        if (_0x38d7193f.Instance == null)
            return;
        Slider _0xc41f8123 = _0x38d7193f.Instance.AnimationSlider;
        if (_0xc41f8123 == null)
            return;
        if (_0xc41f8123.fillRect != null)
        {
            Image _0x7edf144e = _0xc41f8123.fillRect.GetComponent<Image>();
            if (_0x7edf144e != null)
                _0x7edf144e.color = _0xb20acb45.Gold;
            if (_0xc41f8123.fillRect.parent != null)
            {
                Image _0x347b6ef8 = _0xc41f8123.fillRect.parent.GetComponent<Image>();
                if (_0x347b6ef8 != null)
                    _0x347b6ef8.color = _0xb20acb45.Fade(_0xb20acb45.Slate, 0.45f);
            }
        }
    }

    private _0x16d5455c _0xfe771215;
    private void _0x183e6ef0(_0xc9b630d4 _0xad791a2f, UnityEngine.Events.UnityAction _0xd61ef183)
    {
        if (_0xad791a2f == null || _0xad791a2f._0x442d0849 == null)
            return;
        _0xad791a2f._0x442d0849.onClick.AddListener(() => _0xd61ef183());
    }

    private _0xf23fcd8b _0xaf50e142;
    [SerializeField]
    private RectTransform _playSlot;
    /// <summary>
    /// Switches off whatever the template left in this panel body, except our own room and
    /// the call-to-action slot whose driver carries the transition into the session.
    /// </summary>
    private void _0xa9fcef95(Transform _0x33d20957, RectTransform _0x87a500c4)
    {
        for (int _0x55f7c44a = _0x33d20957.childCount - 1; _0x55f7c44a >= 0; _0x55f7c44a--)
        {
            Transform _0x99e78cc5 = _0x33d20957.GetChild(_0x55f7c44a);
            if (_0x99e78cc5 == (Transform)_0x87a500c4)
                continue;
            if (this._playSlot != null && _0x99e78cc5 == (Transform)this._playSlot)
                continue;
            if (_0x99e78cc5.GetComponentInChildren<_0x45251bed>(true) != null)
                continue;
            _0x99e78cc5.gameObject.SetActive(false);
        }
    }

    /// <summary>
    /// The splash, made the app's own: the abstract mark, a single LOADING caption and a
    /// themed loading bar. No title and no tagline - the name appears nowhere on screen.
    /// The mark goes in as the FIRST sibling so the template's own bar stays on top.
    /// </summary>
    private void _0x7a2dc986()
    {
        _0xf449ad2c _0x7d20d1b4 = _0xf449ad2c.Instance;
        if (_0x7d20d1b4 == null || _0x7d20d1b4.Panels == null || _0xacc331e0._0x89a71d4c.SPLASH >= _0x7d20d1b4.Panels.Count)
            return;
        _0xa61c0277 _0x7874cd78 = _0x7d20d1b4.Panels[_0xacc331e0._0x89a71d4c.SPLASH];
        if (_0x7874cd78 == null || _0x7874cd78.Content == null)
            return;
        RectTransform _0x77a0dd0d = this._0xaf50e142._0x6f23ed2a(_0x7874cd78.Content.transform, _0x7c546c59._0x6fb3b105(new byte[10] { 166, 133, 153, 148, 134, 157, 167, 154, 154, 152 }, 245));
        _0x77a0dd0d.SetAsFirstSibling();
        // The mistiest wash of the three screens, so the splash cannot be mistaken for the menu.
        this._0xaf50e142._0xcb95568b(_0x77a0dd0d, this._art._0x4d16ad10, _0xb20acb45.Fade(_0xb20acb45.Mist, 0.80f));
        RectTransform _0xc8a094dc = this._0xaf50e142._0x4a32d93b(_0x77a0dd0d, _0x7c546c59._0x6fb3b105(new byte[10] { 101, 70, 90, 87, 69, 94, 123, 87, 68, 93 }, 54), _0xbe939921._0x434f62f6, new Vector2(0f, -1150f), new Vector2(460f, 460f));
        this._0xaf50e142._0xa061d3cf(_0xc8a094dc, _0x7c546c59._0x6fb3b105(new byte[10] { 252, 223, 195, 206, 220, 199, 232, 195, 192, 216 }, 175), _0xbe939921._0x7f5aa638, Vector2.zero, new Vector2(440f, 440f), _0xb20acb45.Fade(_0xb20acb45.Gold, 0.20f), 0.2f);
        Image _0x7a243975 = this._0xaf50e142._0x5ab12fd7(_0xc8a094dc, _0x7c546c59._0x6fb3b105(new byte[9] { 87, 116, 104, 101, 119, 108, 69, 118, 112 }, 4), this._art._0x209c27fb, _0xbe939921._0x7f5aa638, Vector2.zero, 400f);
        _0x7a243975.color = Color.white;
        _0x7a243975.rectTransform.localScale = Vector3.one * 0.88f;
        _0x7a243975.rectTransform.DOScale(1f, 0.45f).SetEase(Ease.OutBack).SetLink(_0x7a243975.gameObject);
        this._0xaf50e142._0x546a2744(_0x77a0dd0d, _0x7c546c59._0x6fb3b105(new byte[10] { 199, 228, 248, 245, 231, 252, 198, 225, 248, 241 }, 148), _0xbe939921._0x434f62f6, new Vector2(0f, -1470f), 360f, _0xb20acb45.Fade(_0xb20acb45.Slate, 0.35f));
        this._0xaf50e142._0xb8fb9383(_0x77a0dd0d, _0x7c546c59._0x6fb3b105(new byte[13] { 84, 119, 107, 102, 116, 111, 68, 102, 119, 115, 110, 104, 105 }, 7), _0x7c546c59._0x6fb3b105(new byte[7] { 189, 190, 176, 181, 184, 191, 182 }, 241), _0xbe939921._0x434f62f6, new Vector2(0f, -2320f), new Vector2(800f, 70f), 34f, _0xb20acb45.Ink, TMPro.TextAlignmentOptions.Center);
        this._0x0fe17dc2();
    }

    private bool _0xd2f31328()
    {
        _0xf449ad2c _0x604a0d94 = _0xf449ad2c.Instance;
        if (_0x604a0d94 == null || _0x604a0d94.Panels == null)
            return false;
        if (_0xacc331e0._0x89a71d4c.TUTORIAL0 >= _0x604a0d94.Panels.Count)
            return false;
        return _0x604a0d94.Panels[_0xacc331e0._0x89a71d4c.TUTORIAL0] != null;
    }

    private _0x93967577 _0x979c870d;
    private void _0xc5608cfb()
    {
        int _0xe19a048f = this._0xfe771215._0xd90f6cf6();
        this._0x5bb4e2c6._0x9b46afc9(this._0xfe771215._0xc0bf2ecf, this._0xfe771215._0x47213ec2);
        this._0x5bb4e2c6._0x24d1bae7(this._0xfe771215._0x30bb38ba ? _0x2360e6ef.TasksPerSession : 0, this._0xfe771215._0x85f2457b());
        this._0x5bb4e2c6._0x4de0a470(_0xe19a048f);
        this._0x5bb4e2c6._0x2dbdb537(this._0xfe771215._0x30bb38ba ? _0x7c546c59._0x6fb3b105(new byte[16] { 171, 170, 161, 196, 169, 171, 182, 161, 196, 183, 161, 183, 183, 173, 171, 170 }, 228) : _0x7c546c59._0x6fb3b105(new byte[13] { 74, 77, 88, 75, 77, 57, 74, 92, 74, 74, 80, 86, 87 }, 25));
    }

    private void _0x013609e2()
    {
        _0x199a02a5.Instance._0xecb8d952(_0xacc331e0._0x1bb30693.SCENE_1);
    }

    private void Start()
    {
        if (this._art == null)
            return;
        this._0xfe771215 = new _0x16d5455c().Load();
        this._0xaf50e142 = this._art._0xbebca28b();
        // The club's map is generated once a week and then kept, so the lobby and the
        // session always show the same cluster rather than two different guesses.
        this._0x979c870d = new _0x93967577()._0x6f34c695(this._0xfe771215._0xfdb76575, this._0xfe771215._0x2c8aa13e);
        if (string.IsNullOrEmpty(this._0xfe771215._0x2c8aa13e) || this._0xfe771215._0x2c8aa13e.Length != _0x2360e6ef.MapCells)
        {
            this._0xfe771215._0x2c8aa13e = this._0x979c870d._0xa0347621();
            this._0xfe771215._0xf4f095d6();
        }

        if (this._cleaner != null)
            this._cleaner._0x7536cc00();
        this._0x7a2dc986();
        _0xf449ad2c _0xd2641ce7 = _0xf449ad2c.Instance;
        if (_0xd2641ce7 == null || _0xd2641ce7.Panels == null || _0xacc331e0._0x89a71d4c.DEFAULT >= _0xd2641ce7.Panels.Count)
            return;
        _0xa61c0277 _0x9cb221f1 = _0xd2641ce7.Panels[_0xacc331e0._0x89a71d4c.DEFAULT];
        if (_0x9cb221f1 == null || _0x9cb221f1.Content == null)
            return;
        Transform _0xc5f9f956 = _0x9cb221f1.Content.transform;
        RectTransform _0xbe9d8ef7 = this._0xaf50e142._0x6f23ed2a(_0xc5f9f956, _0x7c546c59._0x6fb3b105(new byte[8] { 84, 115, 113, 121, 78, 115, 115, 113 }, 28));
        this._0xa9fcef95(_0xc5f9f956, _0xbe9d8ef7);
        this._0x5bb4e2c6 = new _0xdb085a9f().Build(this._0xaf50e142, this._art, _0xbe9d8ef7, this._playSlot);
        if (this._playSlot != null)
            this._playSlot.SetAsLastSibling();
        RectTransform _0x9be70281 = this._0xaf50e142._0x6f23ed2a(_0xc5f9f956, _0x7c546c59._0x6fb3b105(new byte[8] { 161, 152, 139, 156, 130, 143, 151, 157 }, 238));
        if (this._roster != null)
            this._roster.Build(this._0xaf50e142, this._art, this._0xfe771215, _0x9be70281);
        if (this._week != null)
            this._week.Build(this._0xaf50e142, this._art, this._0xfe771215, _0x9be70281);
        if (this._guide != null)
            this._guide.Build(this._0xaf50e142, this._art);
        this._0x4da44489();
        if (this._0x5bb4e2c6._0xa7a225b0 != null)
            this._0x5bb4e2c6._0xa7a225b0._0xfffedd69(this._0xd2f31328());
        this._0xc5608cfb();
    }

    private void _0x296f41e6()
    {
        if (this._roster != null)
            this._roster.SetVisible(false);
        if (this._week != null)
            this._week.SetVisible(false);
        this._0xc5608cfb();
    }

    private void _0xbddaae04()
    {
        this._0xfe771215._0xf4f095d6();
        if (this._playSlot == null)
            this._0x013609e2();
    }

    private void _0x51efe9ef()
    {
        if (this._roster != null)
            this._roster.SetVisible(false);
        if (this._week != null)
            this._week.SetVisible(true);
    }

    [SerializeField]
    private _0xe3046d96 _roster;
    private void _0xafa8b817()
    {
        if (this._week != null)
            this._week.SetVisible(false);
        if (this._roster != null)
            this._roster.SetVisible(true);
    }

    /// <summary>
    /// Opens the how-to pages. The template fills slots 13 and 14 in the menu scene, but the
    /// check is cheap and a missing slot would throw inside the template controller.
    /// </summary>
    private void _0x4a8e1b69()
    {
        if (!this._0xd2f31328())
            return;
        _0xf449ad2c.Instance._0x192e1309(_0xacc331e0._0x89a71d4c.TUTORIAL0);
    }

    private _0xdb085a9f _0x5bb4e2c6;
    private void _0x4da44489()
    {
        this._0x183e6ef0(this._0x5bb4e2c6._0xfe5786fe, () => this._0xafa8b817());
        this._0x183e6ef0(this._0x5bb4e2c6._0xa0140247, () => this._0x51efe9ef());
        this._0x183e6ef0(this._0x5bb4e2c6._0xa7a225b0, () => this._0x4a8e1b69());
        if (this._0x5bb4e2c6._0x8736c143 != null)
            this._0x5bb4e2c6._0x8736c143.onClick.AddListener(() => this._0xbddaae04());
        if (this._roster != null)
        {
            this._0x183e6ef0(this._roster._0x17124275, () => this._0x51efe9ef());
            this._0x183e6ef0(this._roster._0x447a35c9, () => this._0x296f41e6());
        }

        if (this._week != null)
        {
            this._0x183e6ef0(this._week._0x5bd7de5b, () => this._0x013609e2());
            this._0x183e6ef0(this._week._0x10278333, () => this._0x296f41e6());
        }
    }
}

internal static class _0x7c546c59
{
    internal static string _0x6fb3b105(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}