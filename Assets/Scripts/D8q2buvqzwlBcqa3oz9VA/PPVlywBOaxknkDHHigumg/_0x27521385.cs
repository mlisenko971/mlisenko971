using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0xacc331e0;

public class _0x27521385 : MonoBehaviour
{
    private void BackgroundHidden()
    {
        this.BlurBackground.gameObject.SetActive(false);
    }

    private void _0xe175f279(bool _0x085b2426 = false)
    {
        for (int _0x62c9546d = 0; _0x62c9546d < this.Pops.Count; ++_0x62c9546d)
            if (this.Pops[_0x62c9546d] != null && !(_0x62c9546d == this.CurrentPopIndex && _0x085b2426))
                this.Pops[_0x62c9546d]._0x91bc1f45();
    }

    public GameObject BlurBackground;
    public List<_0x45251bed> Pops;
    public _0x45251bed _0x524ce78b(int _0xfa37a454)
    {
        return this.Pops[_0xfa37a454];
    }

    private void _0xdbe6d16f()
    {
        this.BlurBackground.gameObject.SetActive(true);
    }

    public static _0x27521385 Instance;
    public void _0x95746113()
    {
        this.LastPopIndexes.RemoveAll(_0x6aa6f0a1 => _0x6aa6f0a1 == this.CurrentPopIndex);
        if (this.LastPopIndexes.Count <= 0)
            this._0x3385ed62();
        else
            this._0xaed9ad35(this.LastPopIndexes.Last());
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x27521385>();
    }

    private void _0xe5ad088a()
    {
        this.Invoke(nameof(this.BackgroundHidden), this.ScaleDuration);
    }

    public int CurrentPopIndex;
    private void Start()
    {
        this.BackgroundHidden();
        foreach (_0x45251bed _0x5878f873 in this.Pops)
            if (_0x5878f873 != null)
                _0x5878f873.gameObject.SetActive(true);
    }

    public void _0x3385ed62()
    {
        this.LastPopIndexes.Clear();
        this._0xe175f279();
        foreach (GameObject _0xd124c90c in this.GameObjectsToHide)
            if (_0xd124c90c != null)
                _0xd124c90c.SetActive(true);
        this._0xe5ad088a();
    }

    public float ScaleDuration = 0.4f;
    public List<GameObject> GameObjectsToHide;
    public List<int> LastPopIndexes = new();
    public void _0xaed9ad35(int _0x1547bcea)
    {
        this.CurrentPopIndex = _0x1547bcea;
        this.LastPopIndexes.Add(this.CurrentPopIndex);
        this._0xe175f279(true);
        this._0xdbe6d16f();
        this.Pops[_0x1547bcea].Show();
        foreach (GameObject _0x69ff2593 in this.GameObjectsToHide)
            _0x69ff2593.SetActive(false);
    }
}