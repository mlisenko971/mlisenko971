using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x569df99f : MonoBehaviour
{
    private static _0x569df99f _0xad5767bd;
    [HideInInspector]
    public int TimeLeft;
    public int CustomTimeInitial = 30;
    private void _0xca72f908()
    {
        this.IsGameEnd = true;
        _0x199a02a5.IsAfterLevelComplete = true;
    }

    private void Awake()
    {
        _0xad5767bd = this.gameObject.GetComponent<_0x569df99f>();
    }

    private int _0xbbcb79fc => this.ScoreCurrent;

    public void _0xf05cef3d()
    {
        if (_0xdac21b78.Instance.IsOnlyWinGameEndEnabled)
            this._0x301539f0();
        if (!this.IsGameEnd)
        {
            this._0xca72f908();
            _0x199a02a5.IsAfterLevelComplete = false;
            _0x199a02a5.IsAfterLevelFailed = true;
            _0x45251bed _0x286bc7be = _0x27521385.Instance._0x524ce78b(_0xacc331e0._0xb6512ce8.LOSE).GetComponent<_0x45251bed>();
            if (_0xdac21b78.Instance.IsCheckScoreEnabled)
                _0x286bc7be.ContentMainText.text = $"{this.ScoreCurrent}/{this._0x116bbdd4}";
            else
                _0x286bc7be.ContentMainText.text = $"{this.ScoreCurrent}";
            _0x286bc7be.ContentAdditionalText.text = $"{0}";
            _0xacc331e0._0x3a483db8._0x8be7da54 += 0;
            _0x27521385.Instance._0xaed9ad35(_0xacc331e0._0xb6512ce8.LOSE);
        }
    }

    public void _0x301539f0()
    {
        if (!this.IsGameEnd)
        {
            this._0xca72f908();
            _0x199a02a5.IsAfterLevelComplete = true;
            _0x199a02a5.IsAfterLevelFailed = false;
            _0x45251bed _0xe20b4e75 = _0x27521385.Instance._0x524ce78b(_0xacc331e0._0xb6512ce8.WIN).GetComponent<_0x45251bed>();
            if (_0xdac21b78.Instance.IsCheckScoreEnabled)
                _0xe20b4e75.ContentMainText.text = $"{this.ScoreCurrent}/{this._0x116bbdd4}";
            else
                _0xe20b4e75.ContentMainText.text = $"{this.ScoreCurrent}";
            if (_0xdac21b78.Instance.IsBestScoreEnabled)
            {
                if (this.ScoreCurrent > _0xacc331e0._0x3a483db8._0x8be7da54)
                    _0xacc331e0._0x3a483db8._0x8be7da54 = this.ScoreCurrent;
                _0xe20b4e75.ContentAdditionalText.text = $"{_0xacc331e0._0x3a483db8._0x8be7da54}";
            }
            else
            {
                _0xe20b4e75.ContentAdditionalText.text = $"{this._0xbbcb79fc}";
                _0xacc331e0._0x3a483db8._0x8be7da54 += this._0xbbcb79fc;
            }

            if (_0xdac21b78.Instance.IsLevelIncrementOnWin)
                ++_0x199a02a5._0xa7fcd2de._0x94ccf660;
            _0x27521385.Instance._0xaed9ad35(_0xacc331e0._0xb6512ce8.WIN);
        }
    }

    public List<TMP_Text> TimerText = new();
    public void _0x957ad87b()
    {
        _0x199a02a5.Instance._0x8e9fcba3(true);
        _0x199a02a5.Instance._0xecb8d952(_0xacc331e0._0x1bb30693.SCENE_0);
    }

    private IEnumerator _0xcf0d4d07()
    {
        this._0xf09ae786();
        while (!this.IsGameEnd && this.TimeLeft > 0 && _0x199a02a5.Instance._0xe31cd776 == this.CurrentGameIndex)
        {
            yield return new WaitForSeconds(1f);
            if (_0x199a02a5.Instance._0x407fb271)
            {
                if (this.IsGameEnd)
                    break;
                this.TimeLeft--;
                this._0xf09ae786();
            }
        }

        if (!this.IsGameEnd)
            this._0xf05cef3d();
    }

    public List<Button> HomeButtons = new();
    private void _0x399821d4()
    {
        if (this.ScoreCurrent >= this._0x116bbdd4)
            this._0x301539f0();
        else
            this._0xf05cef3d();
    }

    private int _0x7e85d3b8 => this.CustomTimeInitial + _0x199a02a5._0xa7fcd2de._0x94ccf660 * 10;

    private void Start()
    {
        this.IsGameEnd = false;
        this.TimeLeft = this._0x7e85d3b8;
        this.CurrentGameIndex = _0x199a02a5.Instance._0xe31cd776;
        foreach (Button _0x94968360 in this.HomeButtons)
            _0x94968360.onClick.AddListener(() =>
            {
                this._0x957ad87b();
            });
        foreach (Button _0x1a7d5dd6 in this.PauseButtons)
            _0x1a7d5dd6.onClick.AddListener(() =>
            {
                _0x199a02a5.Instance._0x8e9fcba3(false);
                _0x27521385.Instance._0xaed9ad35(_0xacc331e0._0xb6512ce8.PAUSE);
            });
        this._0x5eb0bbc0();
        this.LevelNumberText.ForEach(_0xf823d0d8 => _0xf823d0d8.text = $"LVL {_0x199a02a5._0xa7fcd2de._0x94ccf660 + 1}");
        if (_0xdac21b78.Instance.IsTimerEnabled)
        {
            this._0xf09ae786();
            this.StartCoroutine(this._0xcf0d4d07());
        }
    }

    [HideInInspector]
    public bool IsGameEnd;
    public List<Button> PauseButtons = new();
    public void _0x1c8110a3(int scoreToAdd)
    {
        if (!this.IsGameEnd)
        {
            this.ScoreCurrent += scoreToAdd;
            this._0x5eb0bbc0();
            this._0x498ffd32();
        }
    }

    public List<TMP_Text> LevelNumberText = new();
    private int _0x116bbdd4 => this.CustomTargetScore + _0x199a02a5._0xa7fcd2de._0x94ccf660 * 10;

    public int CustomTargetScore = 10;
    private void _0xf09ae786()
    {
        this.TimerText.ForEach(_0xf823d0d8 => _0xf823d0d8.text = TimeSpan.FromSeconds(this.TimeLeft).ToString(_0x8bb6ae08._0x183d3af1(new byte[6] { 107, 107, 90, 60, 117, 117 }, 6)));
    }

    public List<TMP_Text> ScoreText = new();
    [HideInInspector]
    public int ScoreCurrent;
    [HideInInspector]
    public int CurrentGameIndex;
    public List<TMP_Text> SubtitleText = new();
    private void _0x5eb0bbc0()
    {
        if (_0xdac21b78.Instance.IsCheckScoreEnabled)
            this.ScoreText.ForEach(_0xf823d0d8 => _0xf823d0d8.text = $"{this.ScoreCurrent}/{this._0x116bbdd4}");
        else
            this.ScoreText.ForEach(_0xf823d0d8 => _0xf823d0d8.text = $"{this.ScoreCurrent}");
    }

    private void _0x498ffd32()
    {
        if (this.ScoreCurrent > _0x199a02a5._0xa7fcd2de._0x6de1184f)
            _0x199a02a5._0xa7fcd2de._0x6de1184f = this.ScoreCurrent;
        if (_0xdac21b78.Instance.IsCheckScoreEnabled)
            if (this.ScoreCurrent >= this._0x116bbdd4)
                this._0x301539f0();
    }
}

internal static class _0x8bb6ae08
{
    internal static string _0x183d3af1(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}