using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Canvas))]
public class _0x3e686ff4 : MonoBehaviour
{
    private static Rect _0x8635c1c7 = Rect.zero;
    private static ScreenOrientation _0xd6052177 = ScreenOrientation.LandscapeLeft;
    private RectTransform _0x797c9937;
    private static void ResolutionChanged()
    {
        _0x1fcc77c1.x = Screen.width;
        _0x1fcc77c1.y = Screen.height;
        _0xf18e7553.Invoke();
    }

    private RectTransform _0x3a513269;
    private Canvas _0x827572de;
    private static readonly List<_0x3e686ff4> _0xe05b8f4c = new();
    private static UnityEvent _0xf18e7553 = new();
    private void OnDestroy()
    {
        if (_0xe05b8f4c != null && _0xe05b8f4c.Contains(this))
            _0xe05b8f4c.Remove(this);
    }

    private void Awake()
    {
        if (!_0xe05b8f4c.Contains(this))
            _0xe05b8f4c.Add(this);
        this._0x827572de = this.GetComponent<Canvas>();
        this._0x797c9937 = this.GetComponent<RectTransform>();
        this._0x3a513269 = this.transform.Find(_0x9560ad15._0x1680a2a4(new byte[8] { 253, 207, 200, 203, 239, 220, 203, 207 }, 174)) as RectTransform;
        if (!_0x6b652935)
        {
            _0xd6052177 = Screen.orientation;
            _0x1fcc77c1.x = Screen.width;
            _0x1fcc77c1.y = Screen.height;
            _0x8635c1c7 = Screen.safeArea;
            _0x6b652935 = true;
        }

        this._0xc1348eb3();
    }

    private static void SafeAreaChanged()
    {
        _0x8635c1c7 = Screen.safeArea;
        for (int _0x8a508add = 0; _0x8a508add < _0xe05b8f4c.Count; _0x8a508add++)
            _0xe05b8f4c[_0x8a508add]._0xc1348eb3();
    }

    private static Vector2 _0x1fcc77c1 = Vector2.zero;
    private void Update()
    {
        if (_0xe05b8f4c[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0xd6052177)
            OrientationChanged();
        if (Screen.safeArea != _0x8635c1c7)
            SafeAreaChanged();
        if (Screen.width != _0x1fcc77c1.x || Screen.height != _0x1fcc77c1.y)
            ResolutionChanged();
    }

    private static void OrientationChanged()
    {
        _0xd6052177 = Screen.orientation;
        _0x1fcc77c1.x = Screen.width;
        _0x1fcc77c1.y = Screen.height;
        _0xf18e7553.Invoke();
    }

    private static bool _0x6b652935;
    private void _0xc1348eb3()
    {
        if (this._0x3a513269 == null)
            return;
        Rect _0x38da81a1 = Screen.safeArea;
        Vector2 _0x94e4dcd3 = _0x38da81a1.position;
        Vector2 _0xef46b54c = _0x38da81a1.position + _0x38da81a1.size;
        _0x94e4dcd3.x /= this._0x827572de.pixelRect.width;
        _0x94e4dcd3.y /= this._0x827572de.pixelRect.height;
        _0xef46b54c.x /= this._0x827572de.pixelRect.width;
        _0xef46b54c.y /= this._0x827572de.pixelRect.height;
        this._0x3a513269.anchorMin = _0x94e4dcd3;
        this._0x3a513269.anchorMax = _0xef46b54c;
    }
}

internal static class _0x9560ad15
{
    internal static string _0x1680a2a4(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}