using System;

/// <summary>
/// One deterministic seed per session, and independent streams off it.
///
/// System.Random, never UnityEngine.Random: the engine's generator carries global state,
/// so two systems drawing from it start steering each other and "the same seed" stops
/// meaning the same thing (rule C.11). Each subsystem takes its OWN stream, so adding a
/// draw in one place cannot shift the layout somewhere else.
///
/// No constructor (rule C.59): `new SessionSeed().Init(a, b)`.
/// </summary>
public sealed class _0xb9a8a49e
{
    private int _0x0617a1f0;
    public int _0xef3a9cf4
    {
        get
        {
            return this._0xafdc8a1f;
        }
    }

    public _0xb9a8a49e _0x17d151f6(int _0xd2e057af, int _0x3dd34a9b)
    {
        this._0x0617a1f0 = _0xd2e057af;
        this._0xafdc8a1f = (_0xd2e057af * 7919) ^ (_0x3dd34a9b * 104729);
        return this;
    }

    private int _0xafdc8a1f;
    /// <summary>An independent generator; `salt` names the subsystem that owns it.</summary>
    public Random _0xc62cfaff(int _0x6995cf81)
    {
        return new Random(this._0xafdc8a1f ^ (_0x6995cf81 * 486187739));
    }

    public int _0xbf9be3b3
    {
        get
        {
            return this._0x0617a1f0;
        }
    }
}