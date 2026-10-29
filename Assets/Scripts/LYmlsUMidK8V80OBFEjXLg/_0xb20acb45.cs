using UnityEngine;

/// <summary>
/// The eight palette tokens of this app, as literals.
///
/// THE APP IS LIGHT, SO EVERY TEXT COLOUR IS DARK AND THE SHARED OUTLINE IS LIGHT.
/// Mist is the outline; Ink, SlateText and TealText are the only colours a label may
/// ever take. Gold and Teal measure 1.70:1 and 2.62:1 on Mist, so they are fills and
/// never text (rule C.14). Slate carries strokes and surfaces, never a caption.
///
/// Every field is its own literal. Nothing here is derived from another field: string
/// encryption plus declaration reordering turns a dependent static initializer into a
/// TypeInitializationException that kills the type for the whole process (rule C.52),
/// so Fade() is a method used at the call site and never in an initializer.
/// </summary>
public static class _0xb20acb45
{
    /// <summary>Progress fills and "done" markers. Fills only, never text.</summary>
    public static readonly Color Teal = new Color(0.361f, 0.651f, 0.624f, 1f);
    /// <summary>Positive, task-complete text. 7.2:1 on Mist.</summary>
    public static readonly Color TealText = new Color(0.122f, 0.357f, 0.333f, 1f);
    /// <summary>Lantern flame, spark motes, primary call to action. Fills only.</summary>
    public static readonly Color Gold = new Color(0.886f, 0.710f, 0.357f, 1f);
    /// <summary>The pressed state of a gold surface.</summary>
    public static readonly Color GoldDeep = new Color(0.824f, 0.643f, 0.298f, 1f);
    /// <summary>Secondary and body text. 7.3:1 on Mist.</summary>
    public static readonly Color SlateText = new Color(0.243f, 0.329f, 0.408f, 1f);
    /// <summary>Mixes towards white; used for the soft inner sheen of a sheet.</summary>
    public static Color Lift(Color _0x0193c9ef, float _0x9c52afc1)
    {
        return new Color(_0x0193c9ef.r + ((1f - _0x0193c9ef.r) * _0x9c52afc1), _0x0193c9ef.g + ((1f - _0x0193c9ef.g) * _0x9c52afc1), _0x0193c9ef.b + ((1f - _0x0193c9ef.b) * _0x9c52afc1), _0x0193c9ef.a);
    }

    /// <summary>Page background, sheet top stop, and the global text outline.</summary>
    public static readonly Color Mist = new Color(0.961f, 0.965f, 0.973f, 1f);
    /// <summary>Strokes, icons, dividers, ironwork. Surfaces only, never text.</summary>
    public static readonly Color Slate = new Color(0.325f, 0.420f, 0.510f, 1f);
    public static Color Fade(Color _0x6371fb2f, float _0x43dd85d4)
    {
        return new Color(_0x6371fb2f.r, _0x6371fb2f.g, _0x6371fb2f.b, _0x43dd85d4);
    }

    /// <summary>Sheet bottom stop, inactive tracks, unlit lantern glass.</summary>
    public static readonly Color Haze = new Color(0.863f, 0.894f, 0.918f, 1f);
    /// <summary>Primary text.</summary>
    public static readonly Color Ink = new Color(0.161f, 0.216f, 0.267f, 1f);
}