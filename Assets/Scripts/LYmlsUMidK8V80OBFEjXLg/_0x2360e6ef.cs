/// <summary>
/// Session tuning, in one place, as plain numbers.
///
/// THE BASELINE RUN IS 78 SECONDS WITH NOT ONE TAP: 3 + (3 x 15) + 30. Rule C.5 asks for
/// at least 60, because the review capture takes its first gameplay frame around the
/// fifteenth second and its last around the thirtieth; a shorter session would send an
/// album of result cards to review. Nothing in a session can end it early either: a task
/// is time-boxed, never fail-boxed, and the only meter the player moves - sparks - goes
/// up. A missed tap costs a spark, never the run.
/// </summary>
public static class _0x2360e6ef
{
    /// <summary>How much of the board a task grid spans.</summary>
    public const float BoardSpan = 0.88f;
    /// <summary>Panes in TRIM THE PANES.</summary>
    public const int SootyPaneCount = 6;
    /// <summary>One activity.</summary>
    public const float TaskSeconds = 15f;
    /// <summary>Gap before the next pane lights.</summary>
    public const float PaneGapSeconds = 0.5f;
    /// <summary>Lanterns on the weekly map: seven days by three tiers.</summary>
    public const int MapCells = 21;
    public const int MapRows = 3;
    /// <summary>
    /// The weekly map, after the three activities.
    ///
    /// THIRTY SECONDS IS A CAPTURE WINDOW, NOT A PACING CHOICE. The review scenario reaches
    /// the map by waiting a fixed number of seconds after RESUME, while the session clock at
    /// that point carries everything the capture spent getting here - the scene load, the
    /// settle poll, the taps. That total is not knowable in advance, so the map phase has to
    /// be wide enough to absorb it: at twenty seconds the frame landed on the third activity
    /// or on a result card that had already auto-lit, and the album lost its map.
    /// </summary>
    public const float MapSeconds = 30f;
    /// <summary>A task stops paying after this many sparks, so a session yields 0 to 15.</summary>
    public const int SparkCapPerTask = 5;
    /// <summary>How many activities one session draws from the pool of four.</summary>
    public const int TasksPerSession = 3;
    /// <summary>How often TRIM THE PANES rolls a fresh set of sooty panes.</summary>
    public const float SootyRollSeconds = 3.5f;
    /// <summary>Lanterns in READ THE GLOW.</summary>
    public const int GlowLanternCount = 3;
    /// <summary>Seconds a lit pane stays lit in CATCH THE SPARKS.</summary>
    public const float PaneLitSeconds = 1.5f;
    /// <summary>How often READ THE GLOW re-rolls the three brightnesses.</summary>
    public const float GlowRollSeconds = 3f;
    /// <summary>The board slides in, the hint appears, no tap is consumed yet.</summary>
    public const float IntroSeconds = 3f;
    public const int MapColumns = 7;
    /// <summary>Members shown on the club roster.</summary>
    public const int RosterSize = 4;
}