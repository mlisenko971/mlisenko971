using UnityEngine;
using UnityEngine.UI;

public class _0xdd6a0ddc : MonoBehaviour
{
    private int _0x4c25ff04;
    private void Awake()
    {
        if (this._0x55df25b9 == null)
            if (!this.TryGetComponent(out this._0x55df25b9))
                this._0x55df25b9 = this.GetComponentInChildren<Button>();
    }

    private Button _0x55df25b9;
    private void Start()
    {
        if (this._0x947ffae2)
            this._0x55df25b9.onClick.AddListener(() => _0xf449ad2c.Instance._0xa02487ba());
        else
            this._0x55df25b9.onClick.AddListener(() => _0xf449ad2c.Instance._0x192e1309(this._0x4c25ff04));
    }

    private bool _0x947ffae2;
}