using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// One session of the club: a short intro, three of the four activities, then the shared
/// weekly map and a result card.
///
/// THE BASELINE RUN IS 78 SECONDS WITHOUT A SINGLE TAP (SessionConfig), because the review
/// capture takes its first gameplay frame around the fifteenth second and its last around
/// the thirtieth (rule C.5). Nothing can end the session early: an activity is time-boxed,
/// never fail-boxed, the only meter the player moves goes up, and if the map is left alone
/// the lowest legal lantern lights itself so the session always reaches its result.
///
/// Which three activities run, in which order, with which speeds and layouts, and the shape
/// of the club's starting cluster, all come from one seeded stream (rule C.11). Set-up is in
/// Start, never Awake, and nothing here declares a constructor (rule C.59).
/// </summary>
public sealed class _0xcb416fe2 : MonoBehaviour
{
    private void _0xe7f9e309()
    {
        this._0x1359fdc4(this._0xbf86e8f7._0x6e5feeb9, () => this._0x786eb06f());
        this._0x1359fdc4(this._0xbf86e8f7._0xe408460e, () => this._0x46e426de());
        this._0x1359fdc4(this._pops._0x79786d69, () => this._0x42e9865c());
        this._0x1359fdc4(this._pops._0x18d2cad7, () => this._0x786eb06f());
        this._0x1359fdc4(this._pops._0xe09f152a, () => this._0x42e9865c());
        this._0x1359fdc4(this._pops._0x0d3eb5d4, () => this._0x786eb06f());
        this._0x1359fdc4(this._pops._0x4c025de2, () => this._0xdf082e9d());
        this._0x1359fdc4(this._pops._0xdbed7b35, () => this._0x786eb06f());
        this._0x1359fdc4(this._pops._0x54bb1c7c, () => this._0xdf082e9d());
    }

    private _0x16d5455c _0x0fddcf65;
    private void _0xdf082e9d()
    {
        if (this._0x761a7066)
            return;
        this._0x961967f0 = false;
        _0x27521385.Instance._0x3385ed62();
        if (_0x199a02a5.Instance != null)
            _0x199a02a5.Instance._0x8e9fcba3(true);
    }

    private _0xb9a8a49e _0x1f7bea25;
    private int _0xd894c273;
    private readonly int[] _0xa991209b = new int[_0x2360e6ef.TasksPerSession];
    /// <summary>
    /// The template's ShowPopButton only raises a pop; nothing in it stops the run. So the
    /// session is frozen here, where every route into the pause card passes.
    /// </summary>
    private void _0x46e426de()
    {
        if (this._0x761a7066 || this._0x961967f0)
            return;
        this._0x961967f0 = true;
        this._pops._0x1550c01a(this._0xa23c5658 + 1, this._0xc8cdeaa4);
        _0x27521385.Instance._0xaed9ad35(_0xacc331e0._0xb6512ce8.PAUSE);
        if (_0x199a02a5.Instance != null)
            _0x199a02a5.Instance._0x8e9fcba3(false);
    }

    [SerializeField]
    private _0x86262364 _cleaner;
    private float _0x1e18cf5b;
    private float _0xf5021e50()
    {
        float _0xd0ca7ee2 = _0x2360e6ef.IntroSeconds + (_0x2360e6ef.TaskSeconds * _0x2360e6ef.TasksPerSession) + _0x2360e6ef.MapSeconds;
        float _0xd7bbf2d4 = _0x2360e6ef.IntroSeconds;
        if (this._0xf26b89ae == PhaseTask)
            _0xd7bbf2d4 = _0xd7bbf2d4 + (_0x2360e6ef.TaskSeconds * this._0xa23c5658) + this._0x1e18cf5b;
        else if (this._0xf26b89ae >= PhaseMap)
            _0xd7bbf2d4 = _0xd7bbf2d4 + (_0x2360e6ef.TaskSeconds * _0x2360e6ef.TasksPerSession) + this._0x1e18cf5b;
        return Mathf.Clamp01(_0xd7bbf2d4 / _0xd0ca7ee2);
    }

    private const int PhaseMap = 2;
    /// <summary>
    /// Switches off whatever the template put in this panel body, except our own room and
    /// the pops. Our HUD is our own objects, so nothing of ours hangs on a placeholder.
    /// </summary>
    private void _0x6c6ddcfa(Transform _0xcd2da673)
    {
        for (int _0x6baec6fe = _0xcd2da673.childCount - 1; _0x6baec6fe >= 0; _0x6baec6fe--)
        {
            Transform _0x059175ad = _0xcd2da673.GetChild(_0x6baec6fe);
            if (_0x059175ad == (Transform)this._0x752a4caf)
                continue;
            if (_0x059175ad.GetComponentInChildren<_0x45251bed>(true) != null)
                continue;
            _0x059175ad.gameObject.SetActive(false);
        }
    }

    private void _0x14cc4bb5(int _0x06984668)
    {
        this._0xf26b89ae = PhaseTask;
        this._0x1e18cf5b = 0f;
        this._0xa23c5658 = _0x06984668;
        this._0xd894c273 = 0;
        for (int _0xbe8acef6 = 0; _0xbe8acef6 < this._0x12e61913.Length; _0xbe8acef6++)
            this._0x12e61913[_0xbe8acef6].SetVisible(false);
        _0x6055f8c5 _0x56286b0d = this._0x12e61913[this._0xa991209b[_0x06984668]];
        _0x56286b0d.SetVisible(true);
        _0x56286b0d.Begin(this._0x1f7bea25._0xc62cfaff(11 + _0x06984668));
        this._0xbf86e8f7._0xb081fc77(_0x06984668 + 1, _0x56286b0d.Title);
        this._0xbf86e8f7._0xacc111d1(_0x56286b0d.Hint);
        this._0xbf86e8f7._0xeda1f68d(_0x28886b4e._0x8266073b(new byte[28] { 146, 129, 146, 133, 142, 247, 132, 135, 150, 133, 156, 247, 150, 147, 147, 132, 247, 131, 152, 247, 131, 159, 146, 247, 148, 155, 130, 149 }, 215));
        this._0xbf86e8f7._0x7663bf80(0);
        if (this._0xac9f7969 != null)
        {
            this._0xac9f7969.localScale = Vector3.one * 0.92f;
            this._0xac9f7969.DOScale(1f, 0.26f).SetEase(Ease.OutBack).SetLink(this._0xac9f7969.gameObject);
        }
    }

    private bool _0x961967f0;
    private bool _0x761a7066;
    private _0xbecc180a _0xbf86e8f7;
    private _0xf23fcd8b _0xf27ae21e;
    private void OnDestroy()
    {
        DOTween.Kill(this, false);
    }

    private const int PhaseResult = 3;
    private void _0x058235f3()
    {
        for (int _0x8219b4c3 = 0; _0x8219b4c3 < this._0x12e61913.Length; _0x8219b4c3++)
            this._0x12e61913[_0x8219b4c3].Finish();
        this._0xc62b593c.Finish();
    }

    [SerializeField]
    private _0x761f29fe _art;
    private RectTransform _0xac9f7969;
    private void Update()
    {
        if (this._0x761a7066 || this._0x961967f0)
            return;
        if (_0x199a02a5.Instance == null || !_0x199a02a5.Instance._0x407fb271)
            return;
        float _0xc507df68 = Time.deltaTime;
        this._0x1e18cf5b = this._0x1e18cf5b + _0xc507df68;
        if (this._0xf26b89ae == PhaseIntro)
        {
            this._0xbf86e8f7._0x053495ee(1f - Mathf.Clamp01(this._0x1e18cf5b / _0x2360e6ef.IntroSeconds));
            if (this._0x1e18cf5b >= _0x2360e6ef.IntroSeconds)
                this._0x14cc4bb5(0);
            return;
        }

        if (this._0xf26b89ae == PhaseTask)
        {
            _0x6055f8c5 _0x48efa6cd = this._0x12e61913[this._0xa991209b[this._0xa23c5658]];
            _0x48efa6cd.Tick(_0xc507df68);
            float _0x56d1c5ec = 1f - Mathf.Clamp01(this._0x1e18cf5b / _0x2360e6ef.TaskSeconds);
            this._0xbf86e8f7._0x053495ee(_0x56d1c5ec);
            this._0xbf86e8f7._0xbbf24486(this._0xf5021e50());
            if (this._0x1e18cf5b >= _0x2360e6ef.TaskSeconds)
            {
                _0x48efa6cd.Finish();
                _0x48efa6cd.SetVisible(false);
                this._0xbf86e8f7._0xf93cd1b1(this._0xa23c5658 + 1);
                if (this._0xa23c5658 + 1 < _0x2360e6ef.TasksPerSession)
                    this._0x14cc4bb5(this._0xa23c5658 + 1);
                else
                    this._0x9bca21ff();
            }

            return;
        }

        if (this._0xf26b89ae == PhaseMap)
        {
            this._0xbf86e8f7._0x053495ee(1f - Mathf.Clamp01(this._0x1e18cf5b / _0x2360e6ef.MapSeconds));
            this._0xbf86e8f7._0xbbf24486(this._0xf5021e50());
            if (this._0x1e18cf5b >= _0x2360e6ef.MapSeconds)
                this._0xc62b593c._0xdf97bfdf();
        }
    }

    private void _0x048214a6()
    {
        this._0xf26b89ae = PhaseIntro;
        this._0x1e18cf5b = 0f;
        this._0xa23c5658 = 0;
        this._0xd894c273 = 0;
        _0x6055f8c5 _0x605d7060 = this._0x12e61913[this._0xa991209b[0]];
        _0x605d7060.SetVisible(true);
        this._0xbf86e8f7._0xb081fc77(1, _0x28886b4e._0x8266073b(new byte[9] { 227, 225, 240, 132, 246, 225, 229, 224, 253 }, 164));
        this._0xbf86e8f7._0xacc111d1(_0x605d7060.Hint);
        this._0xbf86e8f7._0xeda1f68d(_0x28886b4e._0x8266073b(new byte[32] { 253, 242, 245, 242, 232, 243, 155, 136, 155, 239, 250, 232, 240, 232, 155, 150, 155, 247, 242, 252, 243, 239, 155, 138, 155, 247, 250, 245, 239, 254, 233, 245 }, 187));
        this._0xbf86e8f7._0xef1ca004(this._0xc8cdeaa4);
        this._0xbf86e8f7._0xf93cd1b1(0);
        this._0xbf86e8f7._0x7663bf80(0);
        if (this._0x752a4caf != null)
        {
            this._0x752a4caf.localScale = Vector3.one * 0.96f;
            this._0x752a4caf.DOScale(1f, 0.32f).SetEase(Ease.OutBack).SetLink(this._0x752a4caf.gameObject);
        }
    }

    private _0x0a5144e1 _0xc62b593c;
    private int _0xf26b89ae = PhaseIntro;
    private void Start()
    {
        if (this._art == null)
            return;
        this._0x0fddcf65 = new _0x16d5455c().Load();
        this._0x1f7bea25 = new _0xb9a8a49e()._0x17d151f6(this._0x0fddcf65._0xd14ee3b9, _0x16d5455c.TodayIndex());
        this._0xe25587b9 = this._0x1f7bea25._0xc62cfaff(3);
        this._0xa7521185 = new _0x93967577()._0x6f34c695(this._0x0fddcf65._0xfdb76575, this._0x0fddcf65._0x2c8aa13e);
        this._0xf27ae21e = this._art._0xbebca28b();
        {
#if B_LOGS
            {
                Debug.Log(_0x28886b4e._0x8266073b(new byte[15] { 142, 166, 176, 166, 166, 188, 186, 187, 136, 245, 166, 176, 176, 177, 232 }, 213) + this._0x1f7bea25._0xef3a9cf4 + _0x28886b4e._0x8266073b(new byte[6] { 116, 35, 49, 49, 63, 105 }, 84) + this._0xa7521185._0x678c6f37 + _0x28886b4e._0x8266073b(new byte[5] { 254, 178, 183, 170, 227 }, 222) + this._0xa7521185._0x029bca9d());
            }
#endif
        }

        // The template fills panel slots 0 and 1 in both scenes - its own SwitchSplash
        // depends on it - but a missing slot would be a black screen on launch, which is
        // the one failure that leaves the review with nothing at all. Guard and leave.
        _0xf449ad2c _0xa0c7df75 = _0xf449ad2c.Instance;
        if (_0xa0c7df75 == null || _0xa0c7df75.Panels == null || _0xacc331e0._0x89a71d4c.DEFAULT >= _0xa0c7df75.Panels.Count)
            return;
        _0xa61c0277 _0x94438b1a = _0xa0c7df75.Panels[_0xacc331e0._0x89a71d4c.DEFAULT];
        if (_0x94438b1a == null || _0x94438b1a.Content == null)
            return;
        Transform _0x2799c923 = _0x94438b1a.Content.transform;
        this._0x752a4caf = this._0xf27ae21e._0x6f23ed2a(_0x2799c923, _0x28886b4e._0x8266073b(new byte[11] { 34, 20, 2, 2, 24, 30, 31, 35, 30, 30, 28 }, 113));
        this._0x6c6ddcfa(_0x2799c923);
        // The courtyard, a touch cooler here than in the menu, so the board reads first.
        this._0xf27ae21e._0xcb95568b(this._0x752a4caf, this._art._0x4d16ad10, _0xb20acb45.Fade(_0xb20acb45.Mist, 0.58f));
        RectTransform _0x8cd3237c = this._0xf27ae21e._0xaa5a67ea(this._0x752a4caf, _0x28886b4e._0x8266073b(new byte[5] { 195, 238, 224, 243, 229 }, 129), _0xbe939921._0x434f62f6, new Vector2(0f, -1360f), new Vector2(1080f, 1500f));
        this._0xac9f7969 = this._0xf27ae21e._0x4a32d93b(_0x8cd3237c, _0x28886b4e._0x8266073b(new byte[9] { 176, 157, 147, 128, 150, 179, 128, 151, 147 }, 242), _0xbe939921._0x7f5aa638, Vector2.zero, new Vector2(1000f, 1400f));
        this._0xbf86e8f7 = new _0xbecc180a().Build(this._0xf27ae21e, this._art, this._0x752a4caf);
        _0x45239c98 _0x9a8c84fc = this.gameObject.AddComponent<_0x45239c98>();
        _0x663f1558 _0x5b13c41a = this.gameObject.AddComponent<_0x663f1558>();
        _0x79aa9369 _0x3398fefb = this.gameObject.AddComponent<_0x79aa9369>();
        _0x93e5e2b8 _0x739bbde0 = this.gameObject.AddComponent<_0x93e5e2b8>();
        this._0x12e61913[0] = _0x9a8c84fc;
        this._0x12e61913[1] = _0x5b13c41a;
        this._0x12e61913[2] = _0x3398fefb;
        this._0x12e61913[3] = _0x739bbde0;
        for (int _0x7138cfc7 = 0; _0x7138cfc7 < this._0x12e61913.Length; _0x7138cfc7++)
        {
            this._0x12e61913[_0x7138cfc7].Build(this._0xf27ae21e, this._art, this._0xac9f7969, this);
            this._0x12e61913[_0x7138cfc7].SetVisible(false);
        }

        this._0xc62b593c = this.gameObject.AddComponent<_0x0a5144e1>();
        this._0xc62b593c.Build(this._0xf27ae21e, this._art, this._0xac9f7969, this);
        this._0xc62b593c.SetVisible(false);
        this._0x9c8eaa51();
        if (this._pops != null)
            this._pops._0x109d5ac0();
        if (this._cleaner != null)
            this._cleaner._0x7536cc00();
        this._0xe7f9e309();
        this._0x048214a6();
    }

    private void _0x786eb06f()
    {
        _0x199a02a5.Instance._0xecb8d952(_0xacc331e0._0x1bb30693.SCENE_0);
    }

    /// <summary>Called by the map when a lantern has been lit, by the player or by the clock.</summary>
    public void _0x5e983865(int _0x47df5db1)
    {
        if (this._0xf26b89ae == PhaseResult)
            return;
        this._0xf26b89ae = PhaseResult;
        this._0x761a7066 = true;
        this._0x0fddcf65._0x2c8aa13e = this._0xa7521185._0xa0347621();
        this._0x0fddcf65._0xc0bf2ecf = this._0x0fddcf65._0xc0bf2ecf + this._0xc8cdeaa4;
        this._0x0fddcf65._0x7bf5c46b();
        this._0x0fddcf65._0x706f4464();
        this._0x0fddcf65._0xf4f095d6();
        int _0x7a65a37d = this._0xa7521185._0x029bca9d();
        int _0x1b03ad28 = _0x2360e6ef.MapCells - _0x7a65a37d;
        this._0xbf86e8f7._0xeda1f68d(_0x28886b4e._0x8266073b(new byte[8] { 11, 6, 9, 19, 2, 21, 9, 103 }, 71) + (_0x47df5db1 + 1) + _0x28886b4e._0x8266073b(new byte[4] { 125, 18, 27, 125 }, 93) + _0x2360e6ef.MapCells + _0x28886b4e._0x8266073b(new byte[11] { 202, 163, 185, 202, 168, 191, 184, 164, 163, 164, 173 }, 234));
        this._0xbf86e8f7._0xbbf24486(1f);
        if (this._0xc8cdeaa4 > 0)
        {
            this._pops._0xbfb6a848(this._0xc8cdeaa4, _0x7a65a37d, !this._0x0fddcf65._0x1f4d4dc1, _0x1b03ad28, this._0x0fddcf65._0x85f2457b());
            _0x27521385.Instance._0xaed9ad35(_0xacc331e0._0xb6512ce8.WIN);
        }
        else
        {
            this._pops._0xf6f4ad7e(_0x7a65a37d);
            _0x27521385.Instance._0xaed9ad35(_0xacc331e0._0xb6512ce8.LOSE);
        }

        this._0x058235f3();
    }

    private RectTransform _0x752a4caf;
    private _0x93967577 _0xa7521185;
    private int _0xc8cdeaa4;
    private int _0xa23c5658;
    /// <summary>Called by an activity when the player earns a spark.</summary>
    public void _0x26eb290e()
    {
        if (this._0xf26b89ae != PhaseTask)
            return;
        if (this._0xd894c273 >= _0x2360e6ef.SparkCapPerTask)
            return;
        this._0xd894c273 = this._0xd894c273 + 1;
        this._0xc8cdeaa4 = this._0xc8cdeaa4 + 1;
        this._0xbf86e8f7._0xef1ca004(this._0xc8cdeaa4);
        this._0xbf86e8f7._0x7663bf80(this._0xd894c273);
        if (this._0xd894c273 >= _0x2360e6ef.SparkCapPerTask)
            this._0xbf86e8f7._0xeda1f68d(_0x28886b4e._0x8266073b(new byte[52] { 173, 177, 176, 170, 217, 174, 176, 186, 178, 217, 176, 170, 217, 191, 172, 181, 181, 160, 217, 173, 171, 176, 180, 180, 188, 189, 217, 212, 217, 173, 177, 188, 217, 183, 188, 161, 173, 217, 173, 184, 170, 178, 217, 176, 170, 217, 186, 182, 180, 176, 183, 190 }, 249));
    }

    private readonly _0x6055f8c5[] _0x12e61913 = new _0x6055f8c5[4];
    private void _0x9bca21ff()
    {
        this._0xf26b89ae = PhaseMap;
        this._0x1e18cf5b = 0f;
        for (int _0x2cc54cca = 0; _0x2cc54cca < this._0x12e61913.Length; _0x2cc54cca++)
        {
            this._0x12e61913[_0x2cc54cca].Finish();
            this._0x12e61913[_0x2cc54cca].SetVisible(false);
        }

        this._0xc62b593c.SetVisible(true);
        this._0xc62b593c.Begin(this._0xa7521185);
        this._0xbf86e8f7._0xb081fc77(_0x2360e6ef.TasksPerSession, _0x28886b4e._0x8266073b(new byte[12] { 233, 245, 248, 157, 234, 248, 248, 246, 157, 240, 252, 237 }, 189));
        this._0xbf86e8f7._0xacc111d1(_0x28886b4e._0x8266073b(new byte[35] { 66, 87, 70, 54, 87, 54, 84, 68, 83, 87, 66, 94, 95, 88, 81, 54, 90, 87, 88, 66, 83, 68, 88, 54, 66, 89, 54, 90, 95, 81, 94, 66, 54, 95, 66 }, 22));
        this._0xbf86e8f7._0xeda1f68d(_0x28886b4e._0x8266073b(new byte[49] { 61, 60, 55, 82, 62, 51, 60, 38, 55, 32, 60, 82, 34, 55, 32, 82, 33, 55, 33, 33, 59, 61, 60, 82, 95, 82, 38, 58, 55, 82, 49, 62, 39, 48, 82, 33, 58, 51, 32, 55, 33, 82, 38, 58, 55, 82, 63, 51, 34 }, 114));
        this._0xbf86e8f7._0xf93cd1b1(_0x2360e6ef.TasksPerSession);
        if (this._0xac9f7969 != null)
        {
            this._0xac9f7969.localScale = Vector3.one * 0.92f;
            this._0xac9f7969.DOScale(1f, 0.3f).SetEase(Ease.OutBack).SetLink(this._0xac9f7969.gameObject);
        }
    }

    private System.Random _0xe25587b9;
    /// <summary>Draws three of the four activities, shuffled, with no repeat inside a session.</summary>
    private void _0x9c8eaa51()
    {
        int[] _0x1e228d00 =
        {
            0,
            1,
            2,
            3
        };
        for (int _0xe6a44c01 = _0x1e228d00.Length - 1; _0xe6a44c01 > 0; _0xe6a44c01--)
        {
            int _0x25ef4b67 = this._0xe25587b9.Next(_0xe6a44c01 + 1);
            int _0x063ff10e = _0x1e228d00[_0xe6a44c01];
            _0x1e228d00[_0xe6a44c01] = _0x1e228d00[_0x25ef4b67];
            _0x1e228d00[_0x25ef4b67] = _0x063ff10e;
        }

        for (int _0x45245449 = 0; _0x45245449 < _0x2360e6ef.TasksPerSession; _0x45245449++)
            this._0xa991209b[_0x45245449] = _0x1e228d00[_0x45245449];
    }

    private void _0x1359fdc4(_0xc9b630d4 _0xe7da9903, UnityEngine.Events.UnityAction _0x96549c21)
    {
        if (_0xe7da9903 == null || _0xe7da9903._0x442d0849 == null)
            return;
        _0xe7da9903._0x442d0849.onClick.AddListener(() => _0x96549c21());
    }

    private const int PhaseIntro = 0;
    private void _0x42e9865c()
    {
        _0x199a02a5.Instance._0xecb8d952(_0xacc331e0._0x1bb30693.SCENE_1);
    }

    [SerializeField]
    private _0xe7a34503 _pops;
    private const int PhaseTask = 1;
}

internal static class _0x28886b4e
{
    internal static string _0x8266073b(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}