using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The parts of one built button, kept together so a caller can recolour or recaption it
/// later without looking anything up by name.
///
/// No constructor anywhere in this project (rule C.59): the fields are set by Init, which
/// returns the object, so `new ClubButton().Init(...)` reads like a constructor and never
/// runs while the serializer is building the scene.
/// </summary>
public sealed class _0xc9b630d4
{
    public Image _0x5f86f711
    {
        get
        {
            return this._0x2d6efc60;
        }
    }

    private Image _0x4ce2f68c;
    public TextMeshProUGUI _0xdb5976b8
    {
        get
        {
            return this._0x8c252043;
        }
    }

    public void _0x4b8bccd2(Color _0x4d2ffd98, Color _0xb38d6694)
    {
        if (this._0x4ce2f68c != null)
            this._0x4ce2f68c.color = _0x4d2ffd98;
        if (this._0x2d6efc60 != null)
            this._0x2d6efc60.color = _0xb38d6694;
    }

    public Image _0x2cce3e3d
    {
        get
        {
            return this._0x4ce2f68c;
        }
    }

    public void _0xfffedd69(bool _0x8359be27)
    {
        if (this._0xb5902098 != null)
            this._0xb5902098.gameObject.SetActive(_0x8359be27);
    }

    /// <summary>The spent look of a once-per-day action: muted fill, no further taps.</summary>
    public void _0xc2cf9cb9(string _0xc8984ecd)
    {
        this._0x1479164b(_0xc8984ecd);
        this._0x4b8bccd2(_0xb20acb45.Haze, _0xb20acb45.Fade(_0xb20acb45.Slate, 0.35f));
        _0xd90280ba.SetTint(this._0x8c252043, _0xb20acb45.SlateText);
        if (this._0x1c33ed97 != null)
            this._0x1c33ed97.interactable = false;
    }

    private TextMeshProUGUI _0x8c252043;
    public RectTransform _0x9a5bbdd6
    {
        get
        {
            return this._0xb5902098;
        }
    }

    public Button _0x442d0849
    {
        get
        {
            return this._0x1c33ed97;
        }
    }

    public void _0x1479164b(string _0xe717292d)
    {
        _0xd90280ba.SetText(this._0x8c252043, _0xe717292d);
    }

    private Button _0x1c33ed97;
    private Image _0x2d6efc60;
    public _0xc9b630d4 _0x4b69e1d1(RectTransform _0x80207721, Button _0x8381a289, Image _0x1f8f8461, Image _0x1640e094, TextMeshProUGUI _0x84e392df)
    {
        this._0xb5902098 = _0x80207721;
        this._0x1c33ed97 = _0x8381a289;
        this._0x4ce2f68c = _0x1f8f8461;
        this._0x2d6efc60 = _0x1640e094;
        this._0x8c252043 = _0x84e392df;
        return this;
    }

    private RectTransform _0xb5902098;
}