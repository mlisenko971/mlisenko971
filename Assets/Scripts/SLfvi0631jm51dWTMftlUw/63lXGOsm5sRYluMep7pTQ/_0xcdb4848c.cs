using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
public class _0xcdb4848c : MonoBehaviour
{
    private static Rect _0xb8f7aa28 = Rect.zero;
    private RectTransform _0xf1e600f2;
    private static void OrientationChanged()
    {
        _0x9d750736 = Screen.orientation;
        _0xc5bc54ef.x = Screen.width;
        _0xc5bc54ef.y = Screen.height;
        _0xb8f7aa28 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x0a1fc3e1.Invoke();
    }

    private RectTransform _0xbf1a2e63;
    private void Update()
    {
        if (_0x68534279.Count == 0 || _0x68534279[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x9d750736)
            OrientationChanged();
        if (Screen.safeArea != _0xb8f7aa28)
            SafeAreaChanged();
        if (Screen.width != _0xc5bc54ef.x || Screen.height != _0xc5bc54ef.y)
            ResolutionChanged();
    }

    private void Awake()
    {
        if (!_0x68534279.Contains(this))
            _0x68534279.Add(this);
        this._0xa504e889 = this.GetComponent<Canvas>();
        this._0x583451a9 = this.GetComponent<CanvasScaler>();
        if (this._0x583451a9 != null)
            this._0x24bad3c8 = this._0x583451a9.referenceResolution;
        this._0xf1e600f2 = this.GetComponent<RectTransform>();
        this._0xbf1a2e63 = this.transform.Find(_0xe54ef54d._0x9e01ccd6(new byte[8] { 229, 215, 208, 211, 247, 196, 211, 215 }, 182)) as RectTransform;
        if (!_0x43794ca9)
        {
            _0x9d750736 = Screen.orientation;
            _0xc5bc54ef.x = Screen.width;
            _0xc5bc54ef.y = Screen.height;
            _0xb8f7aa28 = Screen.safeArea;
            _0x43794ca9 = true;
        }

        this._0xef8bc5fa();
    }

    private static void ResolutionChanged()
    {
        _0xc5bc54ef.x = Screen.width;
        _0xc5bc54ef.y = Screen.height;
        _0xb8f7aa28 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x0a1fc3e1.Invoke();
    }

    private Vector2 _0x24bad3c8;
    private void OnDestroy()
    {
        if (_0x68534279 != null && _0x68534279.Contains(this))
            _0x68534279.Remove(this);
    }

    private Canvas _0xa504e889;
    private static ScreenOrientation _0x9d750736 = ScreenOrientation.LandscapeLeft;
    private void Start()
    {
    }

    private static void SafeAreaChanged()
    {
        _0xb8f7aa28 = Screen.safeArea;
        ApplySafeAreaToAll();
    }

    private static readonly List<_0xcdb4848c> _0x68534279 = new();
    private void _0xef8bc5fa()
    {
        if (this._0xbf1a2e63 == null)
            return;
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;
        if (screenWidth <= 0f || screenHeight <= 0f)
            return;
        Rect _0xf829a452 = Screen.safeArea;
        Vector2 _0x0226629e = _0xf829a452.position;
        Vector2 _0x55e93567 = _0xf829a452.position + _0xf829a452.size;
        _0x0226629e.x /= screenWidth;
        _0x0226629e.y /= screenHeight;
        _0x55e93567.x /= screenWidth;
        _0x55e93567.y /= screenHeight;
        this._0xbf1a2e63.anchorMin = _0x0226629e;
        this._0xbf1a2e63.anchorMax = _0x55e93567;
        this._0xbf1a2e63.offsetMin = Vector2.zero;
        this._0xbf1a2e63.offsetMax = Vector2.zero;
        if (this._0x583451a9 == null)
            return;
        Vector2 _0x6e063b03 = _0x55e93567 - _0x0226629e;
        float _0x696dc092 = 2f - _0x6e063b03.x;
        float _0xe8ca65b5 = 2f - _0x6e063b03.y;
        this._0x583451a9.referenceResolution = this._0x24bad3c8 * new Vector2(_0x696dc092, _0xe8ca65b5);
    }

    private static bool _0x43794ca9;
    private CanvasScaler _0x583451a9;
    private static UnityEvent _0x0a1fc3e1 = new();
    private static Vector2 _0xc5bc54ef = Vector2.zero;
    private static void ApplySafeAreaToAll()
    {
        for (int _0xc7ca03f3 = 0; _0xc7ca03f3 < _0x68534279.Count; _0xc7ca03f3++)
            _0x68534279[_0xc7ca03f3]._0xef8bc5fa();
    }
}

internal static class _0xe54ef54d
{
    internal static string _0x9e01ccd6(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}