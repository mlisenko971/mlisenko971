using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class _0xc5c7e88f : MonoBehaviour
{
    private float _0x96869ee9 = 0.6f;
    private float _0x07271811 = 1.5f;
    private List<string> _0xfd641238 = new();
    private float _0xbabbfa55 = 4;
    private void Update()
    {
        int _0xb9a765bd = 1;
        if (this._0xfd641238.Count > 0)
        {
            string _0x645525aa = this._0xc1a9ccca.text;
            foreach (string _0xc5468fee in this._0xfd641238)
                while (_0x645525aa.Contains(_0xc5468fee))
                    _0x645525aa = _0x645525aa.Replace(_0xc5468fee, "");
            _0xb9a765bd = _0x645525aa.Length;
        }
        else
        {
            _0xb9a765bd = this._0xc1a9ccca.text.Length;
        }

        float _0x4cc1ecff = Mathf.Clamp(this._0x92a401a3 + this._0x96869ee9 * _0xb9a765bd, this._0x07271811, this._0xbabbfa55);
        if (!Mathf.Approximately(this._0x3131ad0b.aspectRatio, _0x4cc1ecff))
            this._0x3131ad0b.aspectRatio = _0x4cc1ecff;
    }

    private float _0x92a401a3;
    private AspectRatioFitter _0x3131ad0b;
    private TMP_Text _0xc1a9ccca;
}