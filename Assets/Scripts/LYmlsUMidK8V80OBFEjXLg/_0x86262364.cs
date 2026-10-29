using TMPro;
using UnityEngine;

/// <summary>
/// Blanks the placeholder text the template ships on the panels this app does not dress.
///
/// The template declares more tutorial panels than any one game needs, and whatever is left
/// undressed keeps its "Lorem Ipsum" and its "HEADER" all the way into the store (rule
/// C.15). Template files are untouchable, so the cleaning happens at runtime, from here.
///
/// Panels are addressed by SETTINGS.PANELS index - TUTORIAL0, TUTORIAL1, TUTORIAL2,
/// TUTORIAL3, TUTORIAL4, TUTORIAL5, TUTORIAL6 - never by name, because obfuscation renames
/// every object in the scene but never touches an integer. The two pages this app really
/// uses are dressed by GuideView AFTER this pass, so they are blanked first and filled
/// second rather than special-cased here.
/// </summary>
public sealed class _0x86262364 : MonoBehaviour
{
    private bool _0x5e201ea6;
    private void _0x62c73337(_0xf449ad2c _0x538655b7, int _0x3597260a)
    {
        if (_0x3597260a < 0 || _0x3597260a >= _0x538655b7.Panels.Count)
            return;
        _0xa61c0277 _0xb935f0b8 = _0x538655b7.Panels[_0x3597260a];
        if (_0xb935f0b8 == null)
            return;
        if (_0xb935f0b8.HeaderText != null)
            _0xb935f0b8.HeaderText.text = string.Empty;
        if (_0xb935f0b8.MainText != null)
            _0xb935f0b8.MainText.text = string.Empty;
        if (_0xb935f0b8.Content == null)
            return;
        TMP_Text[] _0x27d37fcd = _0xb935f0b8.Content.GetComponentsInChildren<TMP_Text>(true);
        for (int _0xbed48772 = 0; _0xbed48772 < _0x27d37fcd.Length; _0xbed48772++)
            if (_0x27d37fcd[_0xbed48772] != null)
                _0x27d37fcd[_0xbed48772].text = string.Empty;
    }

    public void _0x7536cc00()
    {
        if (this._0x5e201ea6)
            return;
        this._0x5e201ea6 = true;
        _0xf449ad2c _0x560bcae6 = _0xf449ad2c.Instance;
        if (_0x560bcae6 == null || _0x560bcae6.Panels == null)
            return;
        int[] _0x74aad733 =
        {
            _0xacc331e0._0x89a71d4c.TUTORIAL0,
            _0xacc331e0._0x89a71d4c.TUTORIAL1,
            _0xacc331e0._0x89a71d4c.TUTORIAL2,
            _0xacc331e0._0x89a71d4c.TUTORIAL3,
            _0xacc331e0._0x89a71d4c.TUTORIAL4,
            _0xacc331e0._0x89a71d4c.TUTORIAL5,
            _0xacc331e0._0x89a71d4c.TUTORIAL6,
        };
        for (int _0xe079d7d3 = 0; _0xe079d7d3 < _0x74aad733.Length; _0xe079d7d3++)
            this._0x62c73337(_0x560bcae6, _0x74aad733[_0xe079d7d3]);
    }
}