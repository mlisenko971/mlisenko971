using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static _0xacc331e0;

public class _0x199a02a5 : MonoBehaviour
{
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x199a02a5>();
        this.RootGameObject = GameObject.FindWithTag(_0xa84dcd43._0x6a696493(new byte[4] { 206, 243, 243, 232 }, 156));
        if (this._0xe31cd776 == _0x1bb30693.SCENE_0)
            this._0x8e9fcba3(true);
        else
            this._0x8e9fcba3(false);
        this.MoneyCountContainers = this.RootGameObject.GetComponentsInChildren<_0x696cedaf>(true).ToList();
    }

    public Button DeleteProgressDataButton;
    private static void ExitGame()
    {
        Application.Quit();
    }

    [HideInInspector]
    public List<_0x696cedaf> MoneyCountContainers = new();
    public Canvas MainCanvas;
    public void _0xecb8d952(int _0x30d36805)
    {
        //if (SceneManager.GetActiveScene().buildIndex == sceneIndex)
        //    AdsInitializer.Instance?.ShowAd();
        this.StartCoroutine(this._0x1710e588(_0x30d36805));
    }

    public void _0x1a26567d()
    {
        _0xa7fcd2de._0xc9349668 = true;
    }

    private IEnumerator _0x1710e588(int _0x4273083e)
    {
        _0xf449ad2c.Instance._0x192e1309(_0x89a71d4c.SPLASH);
        AsyncOperation _0x9a969022 = SceneManager.LoadSceneAsync(_0x4273083e);
        while (!_0x9a969022.isDone)
            yield return null;
    }

    public static _0x2745b791 _0xa7fcd2de => _0x2745b791.ALL_SCENES_SETTING_SINGLETONS[Instance._0xe31cd776];

    public static bool IsAfterLevelFailed = false;
    public void _0x5731e594()
    {
        this._0xecb8d952(SceneManager.GetActiveScene().buildIndex);
    }

    public bool _0x407fb271 { get; private set; }

    private static _0x2745b791 GAME_INDEX_SETTINGS(int _0x971e6f22)
    {
        return _0x2745b791.ALL_SCENES_SETTING_SINGLETONS[_0x971e6f22];
    }

    private void Start()
    {
        if (this._0xe31cd776 != _0x1bb30693.SCENE_0)
            Screen.orientation = ScreenOrientation.Portrait;
        this.DeleteProgressDataButton?.onClick.AddListener(() =>
        {
            PlayerPrefs.DeleteAll();
            //AudioController.Instance.UpdateMusics();
            //AudioController.Instance.UpdateSfxes();
            Instance._0xecb8d952(_0x1bb30693.SCENE_0);
        });
        this.ShowResetTutorialButton?.onClick.AddListener(() =>
        {
            _0xa7fcd2de._0xc9349668 = false;
            _0x27521385.Instance._0x3385ed62();
            _0xf449ad2c.Instance._0x192e1309(_0x89a71d4c.TUTORIAL0);
        });
    }

    public Transform EnvironmentWithTweensToToggle;
    private static _0x2745b791 _0x17862be0 => _0x2745b791.ALL_SCENES_SETTING_SINGLETONS[0];

    public static _0x199a02a5 Instance;
    public Transform Environment;
    public void _0x8e9fcba3(bool _0x8cf339be)
    {
        this._0x407fb271 = _0x8cf339be;
        this._0x9fa16dc4(!this._0x407fb271);
        Physics2D.simulationMode = this._0x407fb271 ? SimulationMode2D.FixedUpdate : SimulationMode2D.Script;
        if (this.EnvironmentWithTweensToToggle != null)
            this._0x6d92ce1a(this.EnvironmentWithTweensToToggle);
    }

    private IEnumerator _0xb526800d(string _0x4999c07a)
    {
        _0xf449ad2c.Instance._0x192e1309(_0x89a71d4c.SPLASH);
        //AudioController.Instance.SaveLastMusicTimes();
        AsyncOperation _0x7ae59d77 = SceneManager.LoadSceneAsync(_0x4999c07a);
        while (!_0x7ae59d77.isDone)
            yield return null;
    }

    public int _0xe31cd776 => SceneManager.GetActiveScene().buildIndex;

    private void _0x9005c627()
    {
        IsAfterLevelComplete = true;
        Instance._0xecb8d952(_0x1bb30693.SCENE_0);
    }

    private static void MakeGrid(List<RectTransform> _0x1a59db7a, AspectRatioFitter _0xd807de57, float _0x9a6532d9, int _0x9a57b896, int _0x72dcb325)
    {
        _0xd807de57.aspectMode = AspectRatioFitter.AspectMode.WidthControlsHeight;
        _0xd807de57.aspectRatio = _0x9a6532d9;
        foreach (RectTransform _0x7f694e47 in _0x1a59db7a)
        {
            int _0xf24318f8 = _0x7f694e47.transform.GetSiblingIndex();
            _0x7f694e47.anchorMin = new Vector3(Mathf.FloorToInt((float)_0xf24318f8 % _0x9a57b896) * (1f / _0x9a57b896), (_0x72dcb325 - (Mathf.FloorToInt((float)_0xf24318f8 / _0x9a57b896) % _0x72dcb325 + 1f)) * (1f / _0x72dcb325));
            _0x7f694e47.anchorMax = new Vector3(Mathf.FloorToInt((float)_0xf24318f8 % _0x9a57b896 + 1f) * (1f / _0x9a57b896), (_0x72dcb325 - Mathf.FloorToInt((float)_0xf24318f8 / _0x9a57b896) % _0x72dcb325) * (1f / _0x72dcb325));
            _0x7f694e47.offsetMin = Vector2.zero;
            _0x7f694e47.offsetMax = Vector2.zero;
        }
    }

    private void _0x6d92ce1a(Transform _0xa8026dc5)
    {
        Transform[] _0x9f6774d0 = _0xa8026dc5.GetComponentsInChildren<Transform>();
        foreach (Transform _0x90bee0c2 in _0x9f6774d0)
            if (_0x90bee0c2 != null && DOTween.IsTweening(_0x90bee0c2))
            {
                if (this._0x407fb271)
                    DOTween.Play(_0x90bee0c2);
                else
                    DOTween.Pause(_0x90bee0c2);
            }
    }

    private void _0x9fa16dc4(bool _0x69fd4174)
    {
        Rigidbody2D[] _0x934ecefc = this.RootGameObject.GetComponentsInChildren<Rigidbody2D>(true);
        foreach (Rigidbody2D _0xa326ce74 in _0x934ecefc)
            if (_0x69fd4174)
                _0xa326ce74.constraints = RigidbodyConstraints2D.FreezeAll;
            else
                _0xa326ce74.constraints = RigidbodyConstraints2D.None;
    }

    public Button ShowResetTutorialButton;
    [HideInInspector]
    public GameObject RootGameObject; // tag - "Root"
    public static bool IsAfterLevelComplete;
    public void _0x75fb8aa9()
    {
        foreach (_0x696cedaf _0xabf33e38 in this.MoneyCountContainers)
            _0xabf33e38._0xbc098e62();
    }
}

internal static class _0xa84dcd43
{
    internal static string _0x6a696493(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}