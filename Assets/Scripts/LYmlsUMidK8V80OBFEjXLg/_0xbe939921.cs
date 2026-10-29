using UnityEngine;

/// <summary>
/// Layout arithmetic for the one space every screen of this app lives in.
///
/// The template's CanvasScaler is Expand at 1242 x 2688, and under each canvas sits an
/// AspectRatioFitter pinned to that same ratio, so a panel's Content rect is always
/// exactly 1242 x 2688 logical units whatever the device is. Every number below is in
/// those units, and every position is derived from them rather than eyeballed: the
/// screen is the single source of size, exactly as rule C.0 asks of world sprites.
///
/// Nothing in this app is a world-space SpriteRenderer, so the -19..-1 sorting corridor
/// has nothing to order; a uGUI child is drawn by hierarchy order alone and the pops
/// are the last siblings of the canvas.
/// </summary>
public static class _0xbe939921
{
    public const float PanelHeight = 2688f;
    public static Vector2 _0x434f62f6
    {
        get
        {
            return new Vector2(0.5f, 1f);
        }
    }

    /// <summary>Centre of row i of a top-down stack, measured down from the stack's top edge.</summary>
    public static float Row(float _0xfde7b1ff, float _0x2827e1c5, int _0x595479fb)
    {
        return (_0xfde7b1ff * 0.5f) + (_0x595479fb * _0x2827e1c5);
    }

    public static Vector2 _0x692f102d
    {
        get
        {
            return new Vector2(1f, 0.5f);
        }
    }

    /// <summary>Smallest touch target this app ships, comfortably over a finger.</summary>
    public const float TouchFloor = 128f;
    /// <summary>A position for a TopCentre-anchored rect, given its distance from the top.</summary>
    public static Vector2 FromTop(float _0xc3e1dae8, float _0x13900607)
    {
        return new Vector2(_0xc3e1dae8, -_0x13900607);
    }

    public static Vector2 _0xcbafc4b5
    {
        get
        {
            return new Vector2(0f, 1f);
        }
    }

    public static Vector2 _0x11f50216
    {
        get
        {
            return new Vector2(0.5f, 0f);
        }
    }

    /// <summary>Side margin kept clear on every screen.</summary>
    public const float Gutter = 92f;
    /// <summary>Size of one cell of a grid that spans a given width, including the gaps.</summary>
    public static float Cell(float _0x67a4bd47, int _0xf721ec1f, float _0x6b661cba)
    {
        if (_0xf721ec1f < 1)
            return _0x67a4bd47;
        return (_0x67a4bd47 - (_0x6b661cba * (_0xf721ec1f - 1))) / _0xf721ec1f;
    }

    public static Vector2 _0xae0d23e9
    {
        get
        {
            return new Vector2(1f, 1f);
        }
    }

    /// <summary>Width of a full-width sheet.</summary>
    public const float SheetWidth = 1058f;
    public static Vector2 _0x6ab5ec46
    {
        get
        {
            return new Vector2(0f, 0.5f);
        }
    }

    /// <summary>A position for a BottomCentre-anchored rect, given its distance from the bottom.</summary>
    public static Vector2 FromBottom(float _0x6e100c79, float _0xfb60d2f0)
    {
        return new Vector2(_0x6e100c79, _0xfb60d2f0);
    }

    /// <summary>Centre of column i of such a grid, measured from the grid's own centre.</summary>
    public static float Column(float _0x5dbed748, int _0xd3325662, float _0x24b3405e, int _0x413c5284)
    {
        float _0x6a87c122 = Cell(_0x5dbed748, _0xd3325662, _0x24b3405e);
        float _0xc3e4284a = (-_0x5dbed748 * 0.5f) + (_0x6a87c122 * 0.5f);
        return _0xc3e4284a + (_0x413c5284 * (_0x6a87c122 + _0x24b3405e));
    }

    public const float PanelWidth = 1242f;
    public static Vector2 _0x7f5aa638
    {
        get
        {
            return new Vector2(0.5f, 0.5f);
        }
    }
}