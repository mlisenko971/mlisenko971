using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0xacc331e0;

public class _0xf449ad2c : MonoBehaviour
{
    public void _0x192e1309(int _0x31a87324)
    {
        this._0x293a41b2(_0x31a87324);
        this._0x96fdde59(_0x31a87324);
        this.CurrentPanelIndex = _0x31a87324;
        this.Panels[_0x31a87324].Show();
    }

    private void _0x10ea8c5f()
    {
        this._0x4a6bfdab(_0x89a71d4c.SPLASH);
        if (_0x199a02a5.Instance._0xe31cd776 == _0x1bb30693.SCENE_0)
        {
        }
        else
        {
            this.Invoke(nameof(this.SwitchSplash), _0x38d7193f.Instance.DefaultAnimationTime);
        }
    }

    public float ScaleDuration = 0.4f;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xf449ad2c>();
    }

    private void Start()
    {
        this._0x10ea8c5f();
    }

    private void SwitchSplash()
    {
        if (_0xdac21b78.Instance.IsTutorialEnabled && !_0x199a02a5._0xa7fcd2de._0xc9349668)
            this._0x192e1309(_0x89a71d4c.TUTORIAL0);
        else
            this._0x192e1309(_0x89a71d4c.DEFAULT);
    }

    public List<_0xa61c0277> Panels;
    public void _0x2f419027(int _0x53b5230a)
    {
        if (_0x53b5230a == _0x89a71d4c.SPLASH && _0x199a02a5.Instance._0xe31cd776 != _0x1bb30693.SCENE_0)
            _0x38d7193f.Instance._0xffbe92bb();
        if (_0x199a02a5.Instance._0xe31cd776 != _0x1bb30693.SCENE_0)
        {
            if (_0x53b5230a == _0x89a71d4c.SPLASH || _0x53b5230a == _0x89a71d4c.TUTORIAL0)
                _0x199a02a5.Instance._0x8e9fcba3(false);
            else if (_0x53b5230a == _0x89a71d4c.DEFAULT)
                _0x199a02a5.Instance._0x8e9fcba3(true);
        }
    }

    public int CurrentPanelIndex;
    public static _0xf449ad2c Instance;
    public bool IsShowSplashOnStart = true;
    private void _0x4a6bfdab(int _0xf7b14c60)
    {
        this._0x293a41b2(_0xf7b14c60);
        this._0x96fdde59(_0xf7b14c60);
        this.CurrentPanelIndex = _0xf7b14c60;
        this.Panels[_0xf7b14c60]._0xf4fb73bf();
    }

    public float StaticBlurMaterialInitialValue;
    private _0xa61c0277 _0x917418d0(int _0x4471b856)
    {
        return this.Panels[_0x4471b856];
    }

    [HideInInspector]
    public List<int> LastPanelIndexes = new()
    {
        1
    };
    private void _0x1aa2713c(int _0xb530dd8e)
    {
        this.LastPanelIndexes.Add(_0xb530dd8e);
        this.CurrentPanelIndex = _0xb530dd8e;
        for (int _0x145c9212 = 0; _0x145c9212 < this.Panels.Count; _0x145c9212++)
            if (_0x145c9212 != _0xb530dd8e && this.Panels[_0x145c9212] != null)
                this.Panels[_0x145c9212]._0x7ac1fa99();
    }

    private void _0x96fdde59(int _0x632f2bad)
    {
        if (_0x632f2bad == _0x89a71d4c.SPLASH)
            _0x38d7193f.Instance._0x44c7a0e3();
        if (_0x199a02a5.Instance._0xe31cd776 == _0x1bb30693.SCENE_0)
        {
        }
    }

    private void _0x293a41b2(int _0x3c93e0d8)
    {
        this.LastPanelIndexes.Add(_0x3c93e0d8);
        this.CurrentPanelIndex = _0x3c93e0d8;
        for (int _0xa18d5c8e = 0; _0xa18d5c8e < this.Panels.Count; _0xa18d5c8e++)
            if (_0xa18d5c8e != _0x3c93e0d8 && this.Panels[_0xa18d5c8e] != null)
                this.Panels[_0xa18d5c8e]._0x7ac1fa99();
    }

    public void _0xa02487ba()
    {
        this.LastPanelIndexes.RemoveAll(_0x6aa6f0a1 => _0x6aa6f0a1 == this.CurrentPanelIndex);
        int _0x9d45f67e = this.LastPanelIndexes.Last();
        this._0x96fdde59(_0x9d45f67e);
        this._0x1aa2713c(_0x9d45f67e);
        this.CurrentPanelIndex = _0x9d45f67e;
        this.Panels[_0x9d45f67e].Show();
    }
}