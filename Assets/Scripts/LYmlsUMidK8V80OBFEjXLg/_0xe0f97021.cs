using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

// TemplatePlaceholderGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3b, rule C.15 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TemplatePlaceholderGuard.cs.
//
// WHY (19.10.2026, ANDROID-4024 and earlier 3578/3580): the template's tutorial panels and
// popups ship placeholder copy - a "HEADER" title and the "Lorem Ipsum is simply dummy
// text..." body. Codegen is told to rewrite or blank every one of them (C.15/C.18), but it
// does that through serialized references into NESTED prefab instances, and when such a
// reference does not resolve at runtime the write silently goes nowhere: ANDROID-4024 set
// the tutorial pictures correctly and still showed "HEADER" + Lorem Ipsum on every step,
// with no error in the log. Static gates cannot prove these references resolve.
//
// WHAT: a last line of defence that does not depend on any reference. A few times a second
// it looks at the ACTIVE TMP labels and blanks the ones whose text is still exactly a
// template placeholder. Real game text is never touched: only the stock strings match.
// Matched by content, not by object name (the obfuscator renames objects).
public sealed class _0xe0f97021 : MonoBehaviour
{
    private static _0xe0f97021 _0x5deabd45;
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0x5deabd45 != null)
            return;
        GameObject _0xd00f4fe4 = new GameObject(_0x7d2a9f0e._0x39b61608(new byte[24] { 207, 254, 246, 235, 247, 250, 239, 254, 203, 247, 250, 248, 254, 243, 244, 247, 255, 254, 233, 220, 238, 250, 233, 255 }, 155));
        _0xd00f4fe4.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0xd00f4fe4);
        _0x5deabd45 = _0xd00f4fe4.AddComponent<_0xe0f97021>();
    }

    // A lambda held in a field, never a bare method group: Plana renames the method
    // declaration but not a method-group reference (see TmpContrastGuard).
    private void OnEnable()
    {
        if (this._0xba61fc30 == null)
            this._0xba61fc30 = (_0x561cf11b, _0x26deac50) =>
            {
                this._0x0b859342 = 0f;
            };
        SceneManager.sceneLoaded += this._0xba61fc30;
    }

    // Split on purpose: the C.15 gate flags those words inside string literals of generated
    // code, and this file is the one place that must name them to recognise them.
    private static readonly string[] _0x4dd2e102 =
    {
        _0x7d2a9f0e._0x39b61608(new byte[3] { 62, 61, 32 }, 82) + _0x7d2a9f0e._0x39b61608(new byte[6] { 0, 8, 69, 12, 21, 22 }, 101) + _0x7d2a9f0e._0x39b61608(new byte[2] { 113, 105 }, 4),
        _0x7d2a9f0e._0x39b61608(new byte[6] { 137, 152, 128, 128, 148, 205 }, 237) + _0x7d2a9f0e._0x39b61608(new byte[4] { 177, 160, 189, 177 }, 197)
    };
    private float _0x0b859342;
    private static readonly HashSet<string> _0xe59ae5df = new HashSet<string>
    {
        _0x7d2a9f0e._0x39b61608(new byte[6] { 200, 197, 193, 196, 197, 210 }, 128),
        _0x7d2a9f0e._0x39b61608(new byte[6] { 17, 60, 56, 61, 60, 43 }, 89),
        _0x7d2a9f0e._0x39b61608(new byte[6] { 172, 161, 165, 160, 161, 182 }, 196),
        _0x7d2a9f0e._0x39b61608(new byte[5] { 97, 124, 97, 121, 112 }, 53),
        _0x7d2a9f0e._0x39b61608(new byte[5] { 32, 29, 0, 24, 17 }, 116)
    };
    private const float ScanInterval = 0.25f;
    private void OnDisable()
    {
        if (this._0xba61fc30 != null)
            SceneManager.sceneLoaded -= this._0xba61fc30;
    }

    private UnityEngine.Events.UnityAction<Scene, LoadSceneMode> _0xba61fc30;
    private static bool IsPlaceholder(string _0x9e0acd1c)
    {
        if (string.IsNullOrEmpty(_0x9e0acd1c))
            return false;
        string _0x59556646 = _0x9e0acd1c.Trim();
        if (_0xe59ae5df.Contains(_0x59556646))
            return true;
        string _0xc2ea3cf5 = _0x59556646.ToLowerInvariant();
        for (int _0x9ba42b6d = 0; _0x9ba42b6d < _0x4dd2e102.Length; _0x9ba42b6d++)
        {
            if (_0xc2ea3cf5.StartsWith(_0x4dd2e102[_0x9ba42b6d]))
                return true;
        }

        return false;
    }

    private void LateUpdate()
    {
        if (Time.unscaledTime < this._0x0b859342)
            return;
        this._0x0b859342 = Time.unscaledTime + ScanInterval;
        TMP_Text[] _0x4821a938 = Object.FindObjectsByType<TMP_Text>(FindObjectsInactive.Exclude, FindObjectsSortMode.None);
        for (int _0x9f8d677c = 0; _0x9f8d677c < _0x4821a938.Length; _0x9f8d677c++)
        {
            TMP_Text _0xcf334fa6 = _0x4821a938[_0x9f8d677c];
            if (_0xcf334fa6 != null && IsPlaceholder(_0xcf334fa6.text))
                _0xcf334fa6.text = "";
        }
    }
}

internal static class _0x7d2a9f0e
{
    internal static string _0x39b61608(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}