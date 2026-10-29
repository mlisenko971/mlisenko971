using System;
using System.Collections.Generic;

/// <summary>
/// The club's shared weekly map: seven days across, three tiers down, twenty-one lanterns.
///
/// The starting cluster is GENERATED, not written out (rule C.11): a connected group of
/// six to nine lit cells grown from a random edge of the middle, so two weeks never look
/// the same. Generation can legitimately produce a layout nobody can play, so every
/// candidate is checked, regenerated up to twenty times and only then replaced by a
/// hardcoded fallback - which is a guarantee, not the game.
///
/// IsPlayable also insists that the MIDDLE cell is a frontier cell. That is a design
/// decision, not a convenience: only a frontier lantern can be lit, so the club's lit
/// cluster grows outward instead of scattering, and the one cell a player's thumb lands on
/// first is always a legal move.
///
/// No constructor (rule C.59): `new WeekMapModel().Init(...)`.
/// </summary>
public sealed class _0x93967577
{
    private int _0x371024a6;
    private bool _0x694c460d(bool[] _0xc7962d25, int _0x9588962a)
    {
        if (_0x9588962a < 0 || _0x9588962a >= _0x2360e6ef.MapCells || _0xc7962d25[_0x9588962a])
            return false;
        int[] _0x37b9a38a = this._0x2f4e7b57(_0x9588962a);
        for (int _0x2fe45616 = 0; _0x2fe45616 < _0x37b9a38a.Length; _0x2fe45616++)
            if (_0xc7962d25[_0x37b9a38a[_0x2fe45616]])
                return true;
        return false;
    }

    /// <summary>An unlit cell with a lit orthogonal neighbour: the only legal move.</summary>
    public bool _0x9ae7e109(int _0x092ef944)
    {
        return this._0x694c460d(this._0xbb637efc, _0x092ef944);
    }

    private int[] _0x2f4e7b57(int _0xb1e169ca)
    {
        int _0x133751e3 = ColumnOf(_0xb1e169ca);
        int _0x88eca7ae = RowOf(_0xb1e169ca);
        List<int> _0xdcf4cde2 = new List<int>();
        if (_0x133751e3 > 0)
            _0xdcf4cde2.Add(_0xb1e169ca - 1);
        if (_0x133751e3 < _0x2360e6ef.MapColumns - 1)
            _0xdcf4cde2.Add(_0xb1e169ca + 1);
        if (_0x88eca7ae > 0)
            _0xdcf4cde2.Add(_0xb1e169ca - _0x2360e6ef.MapColumns);
        if (_0x88eca7ae < _0x2360e6ef.MapRows - 1)
            _0xdcf4cde2.Add(_0xb1e169ca + _0x2360e6ef.MapColumns);
        return _0xdcf4cde2.ToArray();
    }

    public int _0x029bca9d()
    {
        int _0xd1823653 = 0;
        for (int _0x513c8f0d = 0; _0x513c8f0d < _0x2360e6ef.MapCells; _0x513c8f0d++)
            if (this._0xbb637efc[_0x513c8f0d])
                _0xd1823653 = _0xd1823653 + 1;
        return _0xd1823653;
    }

    private readonly bool[] _0xbb637efc = new bool[_0x2360e6ef.MapCells];
    private bool[] _0xbd73f1d2(string _0xceebc3aa)
    {
        bool[] _0xcbd9736e = new bool[_0x2360e6ef.MapCells];
        for (int _0x1ae3427c = 0; _0x1ae3427c < _0x2360e6ef.MapCells && _0x1ae3427c < _0xceebc3aa.Length; _0x1ae3427c++)
            _0xcbd9736e[_0x1ae3427c] = _0xceebc3aa[_0x1ae3427c] == '1';
        return _0xcbd9736e;
    }

    public List<int> _0xdae33905()
    {
        List<int> _0x9e2b85fa = new List<int>();
        for (int _0xc5bc7ba7 = 0; _0xc5bc7ba7 < _0x2360e6ef.MapCells; _0xc5bc7ba7++)
            if (this._0x694c460d(this._0xbb637efc, _0xc5bc7ba7))
                _0x9e2b85fa.Add(_0xc5bc7ba7);
        return _0x9e2b85fa;
    }

    public bool _0xa8b3e2d6(int _0x7978b649)
    {
        if (!this._0x9ae7e109(_0x7978b649))
            return false;
        this._0xbb637efc[_0x7978b649] = true;
        return true;
    }

    /// <summary>Row 1, column 3 - the exact middle of a 7 x 3 grid.</summary>
    public const int CentreIndex = 10;
    public static int ColumnOf(int _0x80abbb7e)
    {
        return _0x80abbb7e % _0x2360e6ef.MapColumns;
    }

    public static int RowOf(int _0x25458f9a)
    {
        return _0x25458f9a / _0x2360e6ef.MapColumns;
    }

    public string _0xa0347621()
    {
        char[] _0x96e9709f = new char[_0x2360e6ef.MapCells];
        for (int _0xab20ea84 = 0; _0xab20ea84 < _0x2360e6ef.MapCells; _0xab20ea84++)
            _0x96e9709f[_0xab20ea84] = this._0xbb637efc[_0xab20ea84] ? '1' : '0';
        return new string (_0x96e9709f);
    }

    private bool _0xb8717433(bool[] _0x71ae2e6b)
    {
        int _0x502a409b = 0;
        int _0x3946b67e = 0;
        for (int _0xb3cec57c = 0; _0xb3cec57c < _0x2360e6ef.MapCells; _0xb3cec57c++)
        {
            if (_0x71ae2e6b[_0xb3cec57c])
                _0x502a409b = _0x502a409b + 1;
            else if (this._0x694c460d(_0x71ae2e6b, _0xb3cec57c))
                _0x3946b67e = _0x3946b67e + 1;
        }

        if (_0x502a409b < 1 || _0x502a409b > 16)
            return false;
        if (_0x502a409b >= _0x2360e6ef.MapCells)
            return false;
        if (_0x3946b67e < 3)
            return false;
        return this._0x694c460d(_0x71ae2e6b, CentreIndex);
    }

    private static readonly string FallbackLayout = _0x3fb86c51._0xed0adbcf(new byte[21] { 216, 217, 216, 216, 216, 216, 216, 217, 217, 217, 216, 216, 216, 216, 217, 217, 217, 216, 216, 216, 216 }, 232);
    public _0x93967577 _0x6f34c695(int _0x90632270, string _0x6cc5b77d)
    {
        this._0x371024a6 = _0x90632270;
        if (!string.IsNullOrEmpty(_0x6cc5b77d) && _0x6cc5b77d.Length == _0x2360e6ef.MapCells)
        {
            for (int _0x0ea44c52 = 0; _0x0ea44c52 < _0x2360e6ef.MapCells; _0x0ea44c52++)
                this._0xbb637efc[_0x0ea44c52] = _0x6cc5b77d[_0x0ea44c52] == '1';
            if (this._0xb8717433(this._0xbb637efc))
                return this;
        }

        Random _0xfa007651 = new Random(_0x90632270);
        bool[] _0x87dd0c71 = this._0x187166af(_0xfa007651);
        for (int _0x52943b59 = 0; _0x52943b59 < 20 && !this._0xb8717433(_0x87dd0c71); _0x52943b59++)
            _0x87dd0c71 = this._0x187166af(_0xfa007651);
        if (!this._0xb8717433(_0x87dd0c71))
            _0x87dd0c71 = this._0xbd73f1d2(FallbackLayout);
        for (int _0x2de86db6 = 0; _0x2de86db6 < _0x2360e6ef.MapCells; _0x2de86db6++)
            this._0xbb637efc[_0x2de86db6] = _0x87dd0c71[_0x2de86db6];
        return this;
    }

    /// <summary>The lowest-numbered legal move, used when the player lets the map run out.</summary>
    public int _0x317a8fa5()
    {
        for (int _0x41b4716e = 0; _0x41b4716e < _0x2360e6ef.MapCells; _0x41b4716e++)
            if (this._0x694c460d(this._0xbb637efc, _0x41b4716e))
                return _0x41b4716e;
        return -1;
    }

    public bool _0x5dd2b129(int _0x157d227e)
    {
        return _0x157d227e >= 0 && _0x157d227e < _0x2360e6ef.MapCells && this._0xbb637efc[_0x157d227e];
    }

    public int _0x678c6f37
    {
        get
        {
            return this._0x371024a6;
        }
    }

    /// <summary>How many areas of the courtyard the week has opened so far.</summary>
    public int _0x7095138f()
    {
        int _0xc484eab7 = this._0x029bca9d();
        if (_0xc484eab7 >= 16)
            return 3;
        if (_0xc484eab7 >= 12)
            return 2;
        if (_0xc484eab7 >= 8)
            return 1;
        return 0;
    }

    // -- generation -----------------------------------------------------------
    /// <summary>
    /// Grows a connected cluster from one of the middle cell's own neighbours, never
    /// taking the middle itself, so the middle always ends up a frontier cell.
    /// </summary>
    private bool[] _0x187166af(Random _0x886e2dca)
    {
        bool[] _0xa5179736 = new bool[_0x2360e6ef.MapCells];
        int[] _0x36c59c16 = this._0x2f4e7b57(CentreIndex);
        int _0x58ede4bb = _0x36c59c16[_0x886e2dca.Next(_0x36c59c16.Length)];
        _0xa5179736[_0x58ede4bb] = true;
        int _0xf4eed44d = 6 + _0x886e2dca.Next(0, 4);
        List<int> _0x345e8ba4 = new List<int>();
        _0x345e8ba4.Add(_0x58ede4bb);
        int _0xfa8a4f06 = 1;
        int _0x0924b76f = 0;
        while (_0xfa8a4f06 < _0xf4eed44d && _0x345e8ba4.Count > 0 && _0x0924b76f < 400)
        {
            _0x0924b76f = _0x0924b76f + 1;
            int _0x4f1f4f28 = _0x345e8ba4[_0x886e2dca.Next(_0x345e8ba4.Count)];
            int[] _0xb8cf0e83 = this._0x2f4e7b57(_0x4f1f4f28);
            int _0x739c6a1a = -1;
            int _0xd16dc9c5 = _0x886e2dca.Next(_0xb8cf0e83.Length);
            for (int _0x703245a9 = 0; _0x703245a9 < _0xb8cf0e83.Length; _0x703245a9++)
            {
                int _0x2995cafe = _0xb8cf0e83[(_0x703245a9 + _0xd16dc9c5) % _0xb8cf0e83.Length];
                if (_0x2995cafe == CentreIndex || _0xa5179736[_0x2995cafe])
                    continue;
                _0x739c6a1a = _0x2995cafe;
                break;
            }

            if (_0x739c6a1a < 0)
            {
                _0x345e8ba4.Remove(_0x4f1f4f28);
                continue;
            }

            _0xa5179736[_0x739c6a1a] = true;
            _0x345e8ba4.Add(_0x739c6a1a);
            _0xfa8a4f06 = _0xfa8a4f06 + 1;
        }

        return _0xa5179736;
    }
}

internal static class _0x3fb86c51
{
    internal static string _0xed0adbcf(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}