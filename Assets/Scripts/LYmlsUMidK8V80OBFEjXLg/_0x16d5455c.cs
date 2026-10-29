using System;
using UnityEngine;

/// <summary>
/// Everything the club remembers between sessions, in PlayerPrefs.
///
/// Keys are written as plain literals at the point of use. A `const string` key would be
/// turned by the obfuscator into a runtime-decrypted `static readonly`, and the same pass
/// may move that declaration below a field that reads it - which is how a type dies with
/// a TypeInitializationException for the whole process (rule C.52). Literals cannot.
///
/// No constructor: `new ClubState().Load()` builds and fills the object (rule C.59).
/// </summary>
public sealed class _0x16d5455c
{
    public void _0x7a84db14()
    {
        this._0xb2034dfe = TodayIndex();
        this._0xf4f095d6();
    }

    /// <summary>One character per map cell: '1' lit, '0' unlit. Always 21 long.</summary>
    public string _0x2c8aa13e
    {
        get
        {
            return this._0xb03314be;
        }

        set
        {
            this._0xb03314be = value;
        }
    }

    private int _0x09fd539a;
    public static int WeekIndex()
    {
        return TodayIndex() / 7;
    }

    public void _0x7bf5c46b()
    {
        this._0x7a033bea = TodayIndex();
        this._0xf4f095d6();
    }

    /// <summary>A fresh day starts a new streak step; a gap of more than one day resets it.</summary>
    private void _0xdb40e760()
    {
        int _0xd6836a8d = TodayIndex();
        if (this._0xff8099a1 == _0xd6836a8d)
        {
            if (this._0xab24e0c1 < 1)
                this._0xab24e0c1 = 1;
            return;
        }

        this._0xab24e0c1 = this._0xff8099a1 == _0xd6836a8d - 1 ? this._0xab24e0c1 + 1 : 1;
        this._0xff8099a1 = _0xd6836a8d;
        this._0xf4f095d6();
    }

    private int _0xb2034dfe = -1;
    public bool _0x85f2457b()
    {
        return this._0xd90f6cf6() >= _0x2360e6ef.MapCells;
    }

    private int _0x33d92471 = -1;
    public bool _0x1f4d4dc1
    {
        get
        {
            return this._0xb2034dfe == TodayIndex();
        }
    }

    private int _0xe458bb17;
    public void _0xf9220b12()
    {
        this._0x33d92471 = TodayIndex();
        this._0xf4f095d6();
    }

    private int _0x9ff9ef84;
    private int _0xff8099a1;
    /// <summary>A new week clears the map and takes a new seed, so the cluster is new too.</summary>
    private void _0xc538f244()
    {
        int _0xe04adc8c = WeekIndex();
        bool _0xee0c0a0a = this._0xb03314be != null && this._0xb03314be.Length == _0x2360e6ef.MapCells;
        if (this._0x09fd539a == _0xe04adc8c && _0xee0c0a0a)
            return;
        this._0x09fd539a = _0xe04adc8c;
        this._0xe458bb17 = (_0xe04adc8c * 7919) ^ ((this._0x9ff9ef84 + 1) * 104729);
        this._0xb03314be = string.Empty;
        this._0xf4f095d6();
    }

    public int _0x47213ec2
    {
        get
        {
            return this._0xab24e0c1;
        }
    }

    public int _0xc0bf2ecf
    {
        get
        {
            return this._0xe3a48793;
        }

        set
        {
            this._0xe3a48793 = Mathf.Max(0, value);
        }
    }

    public int _0xfdb76575
    {
        get
        {
            return this._0xe458bb17;
        }
    }

    public int _0xd90f6cf6()
    {
        if (string.IsNullOrEmpty(this._0xb03314be))
            return 0;
        int _0x22c8b8f5 = 0;
        for (int _0x09c6c5bc = 0; _0x09c6c5bc < this._0xb03314be.Length; _0x09c6c5bc++)
            if (this._0xb03314be[_0x09c6c5bc] == '1')
                _0x22c8b8f5 = _0x22c8b8f5 + 1;
        return _0x22c8b8f5;
    }

    public int _0xd14ee3b9
    {
        get
        {
            return this._0x9ff9ef84;
        }
    }

    private string _0xb03314be = string.Empty;
    public _0x16d5455c Load()
    {
        this._0xe3a48793 = PlayerPrefs.GetInt(_0x2b1f4242._0x2fcf7495(new byte[17] { 140, 131, 154, 141, 193, 156, 159, 142, 157, 132, 156, 193, 155, 128, 155, 142, 131 }, 239), 0);
        this._0xab24e0c1 = PlayerPrefs.GetInt(_0x2b1f4242._0x2fcf7495(new byte[15] { 38, 41, 48, 39, 107, 33, 36, 60, 107, 54, 49, 55, 32, 36, 46 }, 69), 0);
        this._0xff8099a1 = PlayerPrefs.GetInt(_0x2b1f4242._0x2fcf7495(new byte[13] { 253, 242, 235, 252, 176, 250, 255, 231, 176, 242, 255, 237, 234 }, 158), -1);
        this._0x09fd539a = PlayerPrefs.GetInt(_0x2b1f4242._0x2fcf7495(new byte[15] { 35, 44, 53, 34, 110, 55, 37, 37, 43, 110, 51, 52, 33, 45, 48 }, 64), -1);
        this._0xe458bb17 = PlayerPrefs.GetInt(_0x2b1f4242._0x2fcf7495(new byte[14] { 97, 110, 119, 96, 44, 117, 103, 103, 105, 44, 113, 103, 103, 102 }, 2), 0);
        this._0x9ff9ef84 = PlayerPrefs.GetInt(_0x2b1f4242._0x2fcf7495(new byte[18] { 29, 18, 11, 28, 80, 13, 27, 13, 13, 23, 17, 16, 80, 23, 16, 26, 27, 6 }, 126), 0);
        this._0xb03314be = PlayerPrefs.GetString(_0x2b1f4242._0x2fcf7495(new byte[13] { 227, 236, 245, 226, 174, 247, 229, 229, 235, 174, 236, 233, 244 }, 128), string.Empty);
        this._0x33d92471 = PlayerPrefs.GetInt(_0x2b1f4242._0x2fcf7495(new byte[17] { 85, 90, 67, 84, 24, 82, 87, 79, 24, 68, 83, 87, 85, 66, 95, 89, 88 }, 54), -1);
        this._0xb2034dfe = PlayerPrefs.GetInt(_0x2b1f4242._0x2fcf7495(new byte[13] { 43, 36, 61, 42, 102, 44, 41, 49, 102, 47, 33, 46, 60 }, 72), -1);
        this._0x7a033bea = PlayerPrefs.GetInt(_0x2b1f4242._0x2fcf7495(new byte[16] { 172, 163, 186, 173, 225, 171, 174, 182, 225, 188, 170, 188, 188, 166, 160, 161 }, 207), -1);
        this._0xdb40e760();
        this._0xc538f244();
        return this;
    }

    public bool _0x5c77a0c0
    {
        get
        {
            return this._0x33d92471 == TodayIndex();
        }
    }

    public void _0xf4f095d6()
    {
        PlayerPrefs.SetInt(_0x2b1f4242._0x2fcf7495(new byte[17] { 135, 136, 145, 134, 202, 151, 148, 133, 150, 143, 151, 202, 144, 139, 144, 133, 136 }, 228), this._0xe3a48793);
        PlayerPrefs.SetInt(_0x2b1f4242._0x2fcf7495(new byte[15] { 182, 185, 160, 183, 251, 177, 180, 172, 251, 166, 161, 167, 176, 180, 190 }, 213), this._0xab24e0c1);
        PlayerPrefs.SetInt(_0x2b1f4242._0x2fcf7495(new byte[13] { 239, 224, 249, 238, 162, 232, 237, 245, 162, 224, 237, 255, 248 }, 140), this._0xff8099a1);
        PlayerPrefs.SetInt(_0x2b1f4242._0x2fcf7495(new byte[15] { 137, 134, 159, 136, 196, 157, 143, 143, 129, 196, 153, 158, 139, 135, 154 }, 234), this._0x09fd539a);
        PlayerPrefs.SetInt(_0x2b1f4242._0x2fcf7495(new byte[14] { 84, 91, 66, 85, 25, 64, 82, 82, 92, 25, 68, 82, 82, 83 }, 55), this._0xe458bb17);
        PlayerPrefs.SetInt(_0x2b1f4242._0x2fcf7495(new byte[18] { 86, 89, 64, 87, 27, 70, 80, 70, 70, 92, 90, 91, 27, 92, 91, 81, 80, 77 }, 53), this._0x9ff9ef84);
        PlayerPrefs.SetString(_0x2b1f4242._0x2fcf7495(new byte[13] { 191, 176, 169, 190, 242, 171, 185, 185, 183, 242, 176, 181, 168 }, 220), this._0xb03314be);
        PlayerPrefs.SetInt(_0x2b1f4242._0x2fcf7495(new byte[17] { 50, 61, 36, 51, 127, 53, 48, 40, 127, 35, 52, 48, 50, 37, 56, 62, 63 }, 81), this._0x33d92471);
        PlayerPrefs.SetInt(_0x2b1f4242._0x2fcf7495(new byte[13] { 43, 36, 61, 42, 102, 44, 41, 49, 102, 47, 33, 46, 60 }, 72), this._0xb2034dfe);
        PlayerPrefs.SetInt(_0x2b1f4242._0x2fcf7495(new byte[16] { 238, 225, 248, 239, 163, 233, 236, 244, 163, 254, 232, 254, 254, 228, 226, 227 }, 141), this._0x7a033bea);
        PlayerPrefs.Save();
    }

    /// <summary>Whole days in UTC, so the daily limits do not drift with the timezone.</summary>
    public static int TodayIndex()
    {
        return (int)(DateTime.UtcNow.Ticks / TimeSpan.TicksPerDay);
    }

    private int _0x7a033bea = -1;
    /// <summary>True once today's session has reached its result.</summary>
    public bool _0x30bb38ba
    {
        get
        {
            return this._0x7a033bea == TodayIndex();
        }
    }

    private int _0xab24e0c1;
    public void _0x706f4464()
    {
        this._0x9ff9ef84 = this._0x9ff9ef84 + 1;
        this._0xf4f095d6();
    }

    private int _0xe3a48793;
}

internal static class _0x2b1f4242
{
    internal static string _0x2fcf7495(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}