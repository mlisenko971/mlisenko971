using System.Collections.Generic;
using TMPro;
using UnityEngine;

// TmpContrastGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3, rule C.14 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TmpContrastGuard.cs.
//
// WHY: every TMP label gets an outline (C.10), and by default that outline is dark.
// A dark face colour on a dark outline merges into a smudge — the label is not
// readable on any backing (ANDROID-3627: PLAY drawn Deep #12151E on the #12151E
// outline read as a black blob). enforce-text-contrast.sh fixes colours SERIALISED
// in scenes/prefabs, but labels built at runtime from C# (UiKit.Cta, VaultUi.Caption,
// label.color = Palette.X ...) never reach a scene file, so that pass cannot see them.
//
// WHAT: after any TMP text is regenerated, compare its face colour with the outline
// colour of the material it actually renders with. Below WCAG 4.5:1 the face is
// blended toward white (dark outline) or black (light outline) until it reaches 7:1.
// Hue is kept; alpha is kept. A label whose outline was deliberately switched to a
// light colour (TextReadability-style per-label material) is measured against THAT
// outline, so intentionally dark text on a light rim is left alone. Labels without
// an outline are left alone too.
public sealed class _0x5b5aad63 : MonoBehaviour
{
    private const float TargetRatio = 7f;
    private const float MinOutlineWidth = 0.01f;
    // WCAG relative luminance of an sRGB colour, and the contrast ratio of two.
    private static float Luminance(Color _0x178b757e)
    {
        return 0.2126f * Linear(_0x178b757e.r) + 0.7152f * Linear(_0x178b757e.g) + 0.0722f * Linear(_0x178b757e.b);
    }

    private static _0x5b5aad63 _0x8050e819;
    private readonly List<TMP_Text> _0x360c49ea = new List<TMP_Text>();
    // The event fires from inside the canvas rebuild. Changing the colour right there
    // would re-dirty the graphic mid-rebuild, which Unity rejects — so queue it and
    // apply in LateUpdate, which runs before the next frame's rebuild.
    private void _0x8f976ffe(Object _0x6e0914ac)
    {
        TMP_Text _0x5960deda = _0x6e0914ac as TMP_Text;
        if (_0x5960deda != null)
            this._0x9839085b.Add(_0x5960deda);
    }

    private const float MinRatio = 4.5f;
    private static float Linear(float _0xd7aa6053)
    {
        _0xd7aa6053 = Mathf.Clamp01(_0xd7aa6053);
        return _0xd7aa6053 <= 0.03928f ? _0xd7aa6053 / 12.92f : Mathf.Pow((_0xd7aa6053 + 0.055f) / 1.055f, 2.4f);
    }

    private static float Ratio(Color _0x8ea134a2, Color _0x1e3ae383)
    {
        float _0xdc8e5107 = Luminance(_0x8ea134a2);
        float _0xd72e5e60 = Luminance(_0x1e3ae383);
        return (Mathf.Max(_0xdc8e5107, _0xd72e5e60) + 0.05f) / (Mathf.Min(_0xdc8e5107, _0xd72e5e60) + 0.05f);
    }

    // A lambda held in a field, never the bare method group: Plana renames the method
    // declaration but not a method-group reference (verify-unity-buttons.sh, CS0103).
    // The field keeps Add and Remove on the same delegate instance.
    private System.Action<Object> _0xb2d9e77c;
    private void OnDisable()
    {
        if (this._0xb2d9e77c != null)
            TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(this._0xb2d9e77c);
    }

    private void OnEnable()
    {
        if (this._0xb2d9e77c == null)
            this._0xb2d9e77c = _0x086cda66 => this._0x8f976ffe(_0x086cda66);
        TMPro_EventManager.TEXT_CHANGED_EVENT.Add(this._0xb2d9e77c);
    }

    private readonly HashSet<TMP_Text> _0x9839085b = new HashSet<TMP_Text>();
    private void LateUpdate()
    {
        if (this._0x9839085b.Count == 0)
            return;
        this._0x360c49ea.Clear();
        this._0x360c49ea.AddRange(this._0x9839085b);
        this._0x9839085b.Clear();
        for (int _0x8325ae44 = 0; _0x8325ae44 < this._0x360c49ea.Count; _0x8325ae44++)
            Fix(this._0x360c49ea[_0x8325ae44]);
    }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0x8050e819 != null)
            return;
        GameObject _0x5e817956 = new GameObject(_0x68a46edf._0x44101b4e(new byte[16] { 13, 52, 41, 26, 54, 55, 45, 43, 56, 42, 45, 30, 44, 56, 43, 61 }, 89));
        _0x5e817956.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0x5e817956);
        _0x8050e819 = _0x5e817956.AddComponent<_0x5b5aad63>();
    }

    private static void Fix(TMP_Text _0xd9c4f96f)
    {
        if (_0xd9c4f96f == null || !_0xd9c4f96f.isActiveAndEnabled)
            return;
        Material _0x854326d6 = _0xd9c4f96f.fontSharedMaterial;
        if (_0x854326d6 == null || !_0x854326d6.HasProperty(ShaderUtilities.ID_OutlineColor) || !_0x854326d6.HasProperty(ShaderUtilities.ID_OutlineWidth))
            return;
        if (_0x854326d6.GetFloat(ShaderUtilities.ID_OutlineWidth) < MinOutlineWidth)
            return;
        Color _0x841dd015 = _0xd9c4f96f.color;
        if (_0x841dd015.a <= 0f)
            return;
        Color _0xb98e74c3 = _0x854326d6.GetColor(ShaderUtilities.ID_OutlineColor);
        if (Ratio(_0x841dd015, _0xb98e74c3) >= MinRatio)
            return;
        Color _0x25522f66 = Luminance(_0xb98e74c3) < 0.5f ? Color.white : Color.black;
        Color _0xc013241b;
        if (Ratio(_0x25522f66, _0xb98e74c3) < TargetRatio)
        {
            _0xc013241b = _0x25522f66;
        }
        else
        {
            // Smallest blend that reaches the target: contrast grows monotonically
            // with t, so a short bisection keeps as much of the hue as possible.
            float _0xd5605f07 = 0f;
            float _0x1130a32d = 1f;
            for (int _0x3ba7b6d3 = 0; _0x3ba7b6d3 < 20; _0x3ba7b6d3++)
            {
                float _0x75c798c0 = (_0xd5605f07 + _0x1130a32d) * 0.5f;
                if (Ratio(Color.Lerp(_0x841dd015, _0x25522f66, _0x75c798c0), _0xb98e74c3) >= TargetRatio)
                    _0x1130a32d = _0x75c798c0;
                else
                    _0xd5605f07 = _0x75c798c0;
            }

            _0xc013241b = Color.Lerp(_0x841dd015, _0x25522f66, _0x1130a32d);
        }

        _0xc013241b.a = _0x841dd015.a;
        _0xd9c4f96f.color = _0xc013241b;
    }
}

internal static class _0x68a46edf
{
    internal static string _0x44101b4e(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}