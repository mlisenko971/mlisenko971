using TMPro;
using UnityEngine;

/// <summary>
/// Every sprite and the font asset, wired as serialized {fileID, guid} references in BOTH
/// scenes. Obfuscation renames classes, members, objects and files, but it cannot touch a
/// serialized reference - so nothing here is found by name, loaded from Resources or
/// resolved by type.
///
/// THE ART SET IS FIXED AND IS NOT OURS TO NAME. The image generator runs in parallel with
/// code generation, never reads the code, and always produces the same list: one
/// background, an emblem, a home glyph, a pause glyph and five interchangeable sprites. So
/// the five are referenced by ROLE here, once, and the rest of the project asks for a role
/// rather than for a file. Anything the generator does not draw - a cross, a rule, a
/// progress bar - is composed from plates, so no Image in this app can end up without a
/// sprite and be painted as a white rectangle (rule B.1).
/// </summary>
public sealed class _0x761f29fe : MonoBehaviour
{
    public Sprite _0x43f281af
    {
        get
        {
            return this._lanternLit;
        }
    }

    [SerializeField]
    private Sprite _mark;
    public Sprite _0x6d3c1859
    {
        get
        {
            return this._glyphPause;
        }
    }

    /// <summary>The abstract mark. It carries no lettering, here or anywhere.</summary>
    public Sprite _0x209c27fb
    {
        get
        {
            return this._mark;
        }
    }

    public _0xf23fcd8b _0xbebca28b()
    {
        return new _0xf23fcd8b()._0xb71699bf(this._plate, this._font);
    }

    [SerializeField]
    private Sprite _backdrop;
    public TMP_FontAsset _0x65b5d0c5
    {
        get
        {
            return this._font;
        }
    }

    public Sprite _0x6605a8a9
    {
        get
        {
            return this._memberBadge;
        }
    }

    [SerializeField]
    private Sprite _memberBadge;
    /// <summary>The courtyard, used in both scenes under washes of different strength.</summary>
    public Sprite _0x4d16ad10
    {
        get
        {
            return this._backdrop;
        }
    }

    [SerializeField]
    private Sprite _plate;
    public Sprite _0x4438f135
    {
        get
        {
            return this._lanternDim;
        }
    }

    /// <summary>The template's rounded 9-slice plate: the one surface every panel is cut from.</summary>
    public Sprite _0x3de8caa3
    {
        get
        {
            return this._plate;
        }
    }

    [SerializeField]
    private Sprite _glyphBack;
    [SerializeField]
    private Sprite _lanternDim;
    public Sprite _0xfaa5a37e
    {
        get
        {
            return this._gift;
        }
    }

    public Sprite _0xebbf42ba
    {
        get
        {
            return this._glyphBack;
        }
    }

    [SerializeField]
    private Sprite _glyphPause;
    [SerializeField]
    private Sprite _gift;
    [SerializeField]
    private Sprite _lanternLit;
    [SerializeField]
    private Sprite _spark;
    [SerializeField]
    private TMP_FontAsset _font;
    public Sprite _0x20f0f53d
    {
        get
        {
            return this._spark;
        }
    }
}