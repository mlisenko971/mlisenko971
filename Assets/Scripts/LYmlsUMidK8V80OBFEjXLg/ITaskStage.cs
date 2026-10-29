using UnityEngine;

/// <summary>
/// What the session director needs from an activity, so the four activities stay four
/// small independent components rather than one branching class. Composition, not
/// inheritance: every implementation derives from MonoBehaviour directly and is sealed.
///
/// The pair Begin / Finish replaces a constructor (rule C.59): a stage is built once by
/// Build, then armed and disarmed as many times as the session needs.
/// </summary>
public interface _0x6055f8c5
{
    /// <summary>The on-screen instruction. It names the gesture and what it does (rule C.6).</summary>
    string Hint { get; }

    /// <summary>The short name shown above the board.</summary>
    string Title { get; }

    /// <summary>Builds the stage's own objects inside the board. Called once.</summary>
    void Build(_0xf23fcd8b _0xd61c2632, _0x761f29fe _0x44187637, RectTransform _0xdfc04581, _0xcb416fe2 _0x70ab1431);
    /// <summary>Arms the stage for one run with its own stream of randomness.</summary>
    void Begin(System.Random _0x7ea51d77);
    /// <summary>Advances the stage. Not called while the session is paused.</summary>
    void Tick(float _0x79dc61b9);
    /// <summary>Disarms the stage and stops it reacting to taps.</summary>
    void Finish();
    /// <summary>Shows or hides the stage's own objects.</summary>
    void SetVisible(bool _0x2e392a13);
}