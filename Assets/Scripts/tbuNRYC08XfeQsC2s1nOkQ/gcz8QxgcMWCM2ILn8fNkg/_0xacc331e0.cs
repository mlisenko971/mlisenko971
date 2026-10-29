using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public static class _0xacc331e0
{
    public static class _0xb6512ce8
    {
        public static readonly int PAUSE = 6;
        public static readonly int WIN = 7;
        public static readonly int LOSE = 8;
    }

    public static class _0x89a71d4c
    {
        public static readonly int SPLASH = 0;
        public static readonly int DEFAULT = 1;
        public static readonly int EMPTY = 2;
        public static readonly int TUTORIAL0 = 13;
        public static readonly int TUTORIAL1 = 14;
        public static readonly int TUTORIAL2 = 15;
        public static readonly int TUTORIAL3 = 16;
        public static readonly int TUTORIAL4 = 17;
        public static readonly int TUTORIAL5 = 18;
        public static readonly int TUTORIAL6 = 19;
    }

    public static class _0x1bb30693
    {
        public static readonly int SCENE_0 = 0;
        public static readonly int SCENE_1 = 1;
    }

    public class _0x2745b791
    {
        private static readonly _0x2745b791 _0xa777bef3 = new();
        public static readonly _0x2745b791[] ALL_SCENES_SETTING_SINGLETONS =
        {
            _0xa777bef3,
            _0xa777bef3,
            _0xa777bef3,
        };
        private int _0x37b78e08 => 0;
        private int _0x56d772f8 => 10;
        private string _0x4736ae4c => _0xa6a61fad._0x104d398b(new byte[4] { 22, 62, 53, 46 }, 91);
        private string _0xedd4b624 => _0xa6a61fad._0x104d398b(new byte[8] { 63, 54, 37, 54, 63, 8, 67, 14 }, 115);

        private int _0xf4e1b8ce
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0xa6a61fad._0x104d398b(new byte[25] { 237, 219, 220, 220, 203, 192, 218, 233, 194, 193, 204, 207, 194, 237, 198, 207, 222, 218, 203, 220, 231, 192, 202, 203, 214 }, 174)))
                    PlayerPrefs.SetInt(_0xa6a61fad._0x104d398b(new byte[25] { 0, 54, 49, 49, 38, 45, 55, 4, 47, 44, 33, 34, 47, 0, 43, 34, 51, 55, 38, 49, 10, 45, 39, 38, 59 }, 67), 0);
                return PlayerPrefs.GetInt(_0xa6a61fad._0x104d398b(new byte[25] { 243, 197, 194, 194, 213, 222, 196, 247, 220, 223, 210, 209, 220, 243, 216, 209, 192, 196, 213, 194, 249, 222, 212, 213, 200 }, 176));
            }

            set => PlayerPrefs.SetInt(_0xa6a61fad._0x104d398b(new byte[25] { 48, 6, 1, 1, 22, 29, 7, 52, 31, 28, 17, 18, 31, 48, 27, 18, 3, 7, 22, 1, 58, 29, 23, 22, 11 }, 115), value);
        }

        public int _0x94ccf660
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x4736ae4c}CurrentLevelIndex"))
                    PlayerPrefs.SetInt($"{this._0x4736ae4c}CurrentLevelIndex", 0);
                return PlayerPrefs.GetInt($"{this._0x4736ae4c}CurrentLevelIndex");
            }

            set => PlayerPrefs.SetInt($"{this._0x4736ae4c}CurrentLevelIndex", value);
        }

        public int _0x6de1184f
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x4736ae4c}BestScore"))
                    this._0x6de1184f = 0;
                return PlayerPrefs.GetInt($"{this._0x4736ae4c}BestScore");
            }

            set => PlayerPrefs.SetInt($"{this._0x4736ae4c}BestScore", value);
        }

        public bool _0xc9349668
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x4736ae4c}IsGameTutorPassed"))
                    PlayerPrefs.SetInt($"{this._0x4736ae4c}IsGameTutorPassed", Convert.ToInt32(false));
                return PlayerPrefs.GetInt($"{this._0x4736ae4c}IsGameTutorPassed") == 1;
            }

            set => PlayerPrefs.SetInt($"{this._0x4736ae4c}IsGameTutorPassed", Convert.ToInt32(value));
        }
    }

    public static class _0x3a483db8
    {
        public static int _0x8be7da54
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0xa6a61fad._0x104d398b(new byte[5] { 131, 175, 169, 174, 179 }, 192)))
                    PlayerPrefs.SetInt(_0xa6a61fad._0x104d398b(new byte[5] { 226, 206, 200, 207, 210 }, 161), 0);
                return PlayerPrefs.GetInt(_0xa6a61fad._0x104d398b(new byte[5] { 8, 36, 34, 37, 56 }, 75));
            }

            set
            {
                PlayerPrefs.SetInt(_0xa6a61fad._0x104d398b(new byte[5] { 41, 5, 3, 4, 25 }, 106), value);
                _0x199a02a5.Instance._0x75fb8aa9();
            }
        }
    }
}

internal static class _0xa6a61fad
{
    internal static string _0x104d398b(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}