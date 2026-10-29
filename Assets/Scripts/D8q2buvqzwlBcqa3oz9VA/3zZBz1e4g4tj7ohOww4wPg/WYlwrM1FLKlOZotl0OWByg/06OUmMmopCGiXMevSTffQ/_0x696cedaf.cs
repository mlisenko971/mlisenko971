using TMPro;
using UnityEngine;
using static _0xacc331e0;

public class _0x696cedaf : MonoBehaviour
{
    public void _0xbc098e62()
    {
        this.MoneyCountText.text = _0x3a483db8._0x8be7da54.ToString();
    }

    public TMP_Text MoneyCountText;
    private void Start()
    {
        if (this.MoneyCountText == null)
        {
            TMP_Text _0x24112488;
            if (this.gameObject.TryGetComponent(out _0x24112488))
                this.MoneyCountText = _0x24112488;
        }

        this._0xbc098e62();
    }
}