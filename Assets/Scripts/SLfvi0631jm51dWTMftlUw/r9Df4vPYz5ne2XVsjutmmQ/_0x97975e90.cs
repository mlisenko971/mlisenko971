using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x97975e90 : MonoBehaviour
{
    private TMP_Text _0xf049bc38;
    private void Update()
    {
        this._0x67d673b0();
    }

    private Image _0x7dfb40b8;
    private void _0x67d673b0()
    {
        if (this._0x7dfb40b8.canvasRenderer.GetColor() != this._0xf049bc38.canvasRenderer.GetColor())
            this._0xf049bc38.canvasRenderer.SetColor(this._0x7dfb40b8.canvasRenderer.GetColor());
    }
}