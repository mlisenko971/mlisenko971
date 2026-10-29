using TMPro;
using UnityEngine;

/// <summary>
/// The two how-to pages, built into the template's own panel slots TUTORIAL0 and TUTORIAL1.
///
/// Every control in this app is a single tap, so rule C.6 is already satisfied by the hint
/// that sits on the board for the whole of every activity; these pages are the long form,
/// reached from the menu on purpose rather than pushed at first launch. SETUP_OBJECT's
/// IsTutorialEnabled stays 0: on this template that flag does not add a tutorial to the
/// menu at all, it hijacks the GAME scene, which is the one place a player must not land
/// on a page of text instead of the board.
///
/// Panels are addressed by SETTINGS.PANELS index, never by name.
/// </summary>
public sealed class _0xc2ebe50c : MonoBehaviour
{
    private void Show(int _0x4086ae4c)
    {
        if (_0xf449ad2c.Instance != null)
            _0xf449ad2c.Instance._0x192e1309(_0x4086ae4c);
    }

    /// <summary>Clears the template page and returns our own sheet on it.</summary>
    private RectTransform _0x7be8dc03(_0xf23fcd8b _0xdcb389d4, _0x761f29fe _0x27d460c6, int _0x7e8310a4)
    {
        _0xf449ad2c _0x8b9eb389 = _0xf449ad2c.Instance;
        if (_0x8b9eb389 == null || _0x8b9eb389.Panels == null || _0x7e8310a4 < 0 || _0x7e8310a4 >= _0x8b9eb389.Panels.Count)
            return null;
        _0xa61c0277 _0x8d88aef4 = _0x8b9eb389.Panels[_0x7e8310a4];
        if (_0x8d88aef4 == null || _0x8d88aef4.Content == null)
            return null;
        Transform _0xbede99f1 = _0x8d88aef4.Content.transform;
        for (int _0x91bae7b8 = _0xbede99f1.childCount - 1; _0x91bae7b8 >= 0; _0x91bae7b8--)
            _0xbede99f1.GetChild(_0x91bae7b8).gameObject.SetActive(false);
        RectTransform _0xb156ab28 = _0xdcb389d4._0x6f23ed2a(_0xbede99f1, _0x5bfe74d3._0xf4f8e923(new byte[9] { 251, 201, 213, 216, 217, 238, 211, 211, 209 }, 188));
        _0xdcb389d4._0xcb95568b(_0xb156ab28, _0x27d460c6._0x4d16ad10, _0xb20acb45.Fade(_0xb20acb45.Mist, 0.72f));
        return _0xdcb389d4._0xaa5a67ea(_0xb156ab28, _0x5bfe74d3._0xf4f8e923(new byte[10] { 34, 16, 12, 1, 0, 54, 13, 0, 0, 17 }, 101), _0xbe939921._0x7f5aa638, new Vector2(0f, 0f), new Vector2(1120f, 1900f));
    }

    private bool _0x18758f96;
    private TextMeshProUGUI _0x5fd4e795(_0xf23fcd8b _0x50b9085d, RectTransform _0x66b268fb, float _0x34f10eef, string _0x30263a57)
    {
        return _0x50b9085d._0xb8fb9383(_0x66b268fb, _0x5bfe74d3._0xf4f8e923(new byte[9] { 156, 174, 178, 191, 190, 153, 180, 191, 162 }, 219), _0x30263a57, _0xbe939921._0x434f62f6, new Vector2(0f, _0x34f10eef), new Vector2(1000f, 200f), 34f, _0xb20acb45.SlateText, TextAlignmentOptions.Center);
    }

    private TextMeshProUGUI _0x9d521e64(_0xf23fcd8b _0x8d1ec748, RectTransform _0x52d4275b, string _0xca72124a)
    {
        return _0x8d1ec748._0xb8fb9383(_0x52d4275b, _0x5bfe74d3._0xf4f8e923(new byte[9] { 56, 10, 22, 27, 26, 55, 26, 30, 27 }, 127), _0xca72124a, _0xbe939921._0x434f62f6, new Vector2(0f, -150f), new Vector2(1000f, 110f), 48f, _0xb20acb45.Ink, TextAlignmentOptions.Center);
    }

    public void Build(_0xf23fcd8b _0xf0987a44, _0x761f29fe _0x71fb3550)
    {
        if (this._0x18758f96 || _0xf0987a44 == null || _0x71fb3550 == null)
            return;
        this._0x18758f96 = true;
        RectTransform _0x91d9cc63 = this._0x7be8dc03(_0xf0987a44, _0x71fb3550, _0xacc331e0._0x89a71d4c.TUTORIAL0);
        if (_0x91d9cc63 != null)
        {
            this._0x9d521e64(_0xf0987a44, _0x91d9cc63, _0x5bfe74d3._0xf4f8e923(new byte[18] { 98, 101, 125, 10, 107, 10, 121, 111, 121, 121, 99, 101, 100, 10, 109, 101, 111, 121 }, 42));
            _0xf0987a44._0x5ab12fd7(_0x91d9cc63, _0x5bfe74d3._0xf4f8e923(new byte[8] { 234, 216, 196, 201, 200, 236, 223, 217 }, 173), _0x71fb3550._0x20f0f53d, _0xbe939921._0x434f62f6, new Vector2(0f, -470f), 230f);
            this._0x5fd4e795(_0xf0987a44, _0x91d9cc63, -740f, _0x5bfe74d3._0xf4f8e923(new byte[82] { 104, 105, 98, 7, 116, 111, 104, 117, 115, 7, 116, 98, 116, 116, 110, 104, 105, 7, 102, 7, 99, 102, 126, 9, 45, 115, 111, 117, 98, 98, 7, 116, 106, 102, 107, 107, 7, 115, 102, 119, 7, 102, 100, 115, 110, 113, 110, 115, 110, 98, 116, 9, 45, 98, 113, 98, 117, 126, 7, 96, 104, 104, 99, 7, 115, 102, 119, 7, 98, 102, 117, 105, 116, 7, 102, 7, 116, 119, 102, 117, 108, 9 }, 39));
            this._0x5fd4e795(_0xf0987a44, _0x91d9cc63, -980f, _0x5bfe74d3._0xf4f8e923(new byte[77] { 54, 87, 58, 62, 36, 36, 50, 51, 87, 35, 54, 39, 87, 52, 56, 36, 35, 36, 87, 57, 56, 35, 63, 62, 57, 48, 89, 125, 35, 63, 50, 87, 54, 52, 35, 62, 33, 62, 35, 62, 50, 36, 87, 54, 37, 50, 87, 35, 62, 58, 50, 51, 91, 125, 36, 56, 87, 57, 56, 35, 63, 62, 57, 48, 87, 52, 54, 57, 87, 53, 50, 87, 59, 56, 36, 35, 89 }, 119));
            _0xc9b630d4 _0xaa90a53d = _0xf0987a44._0xeaf47c78(_0x91d9cc63, _0x5bfe74d3._0xf4f8e923(new byte[9] { 92, 110, 114, 127, 126, 85, 126, 99, 111 }, 27), _0x5bfe74d3._0xf4f8e923(new byte[9] { 246, 253, 224, 236, 152, 232, 249, 255, 253 }, 184), _0xbe939921._0x11f50216, new Vector2(0f, 400f), new Vector2(700f, 140f), 42f, true);
            _0xaa90a53d._0x442d0849.onClick.AddListener(() => this.Show(_0xacc331e0._0x89a71d4c.TUTORIAL1));
            _0xc9b630d4 _0x741390cb = _0xf0987a44._0xeaf47c78(_0x91d9cc63, _0x5bfe74d3._0xf4f8e923(new byte[9] { 250, 200, 212, 217, 216, 255, 220, 222, 214 }, 189), _0x5bfe74d3._0xf4f8e923(new byte[16] { 17, 18, 16, 24, 115, 7, 28, 115, 7, 27, 22, 115, 16, 31, 6, 17 }, 83), _0xbe939921._0x11f50216, new Vector2(0f, 250f), new Vector2(700f, 120f), 34f, false);
            _0x741390cb._0x442d0849.onClick.AddListener(() => this.Show(_0xacc331e0._0x89a71d4c.DEFAULT));
        }

        RectTransform _0x82e6ff2c = this._0x7be8dc03(_0xf0987a44, _0x71fb3550, _0xacc331e0._0x89a71d4c.TUTORIAL1);
        if (_0x82e6ff2c != null)
        {
            this._0x9d521e64(_0xf0987a44, _0x82e6ff2c, _0x5bfe74d3._0xf4f8e923(new byte[18] { 170, 181, 188, 169, 221, 169, 181, 184, 221, 174, 173, 188, 175, 182, 174, 221, 185, 178 }, 253));
            _0xf0987a44._0x5ab12fd7(_0x82e6ff2c, _0x5bfe74d3._0xf4f8e923(new byte[8] { 117, 71, 91, 86, 87, 115, 64, 70 }, 50), _0x71fb3550._0x43f281af, _0xbe939921._0x434f62f6, new Vector2(0f, -470f), 230f);
            this._0x5fd4e795(_0xf0987a44, _0x82e6ff2c, -740f, _0x5bfe74d3._0xf4f8e923(new byte[63] { 167, 164, 181, 166, 191, 167, 212, 184, 189, 179, 188, 160, 212, 187, 186, 177, 212, 184, 181, 186, 160, 177, 166, 186, 254, 187, 186, 212, 160, 188, 177, 212, 163, 177, 177, 191, 212, 185, 181, 164, 212, 160, 188, 177, 212, 163, 188, 187, 184, 177, 254, 183, 184, 161, 182, 212, 167, 188, 181, 166, 177, 167, 218 }, 244));
            this._0x5fd4e795(_0xf0987a44, _0x82e6ff2c, -980f, _0x5bfe74d3._0xf4f8e923(new byte[86] { 183, 182, 180, 161, 216, 185, 216, 180, 185, 182, 172, 189, 170, 182, 216, 182, 189, 160, 172, 216, 172, 183, 216, 185, 216, 180, 177, 172, 216, 183, 182, 189, 242, 187, 185, 182, 216, 186, 189, 216, 180, 177, 172, 212, 216, 171, 183, 216, 172, 176, 189, 216, 175, 185, 170, 181, 216, 168, 185, 172, 187, 176, 242, 191, 170, 183, 175, 171, 216, 183, 173, 172, 175, 185, 170, 188, 216, 172, 183, 191, 189, 172, 176, 189, 170, 214 }, 248));
            _0xc9b630d4 _0xcf8ebb6e = _0xf0987a44._0xeaf47c78(_0x82e6ff2c, _0x5bfe74d3._0xf4f8e923(new byte[9] { 174, 156, 128, 141, 140, 171, 136, 138, 130 }, 233), _0x5bfe74d3._0xf4f8e923(new byte[16] { 18, 17, 19, 27, 112, 4, 31, 112, 4, 24, 21, 112, 19, 28, 5, 18 }, 80), _0xbe939921._0x11f50216, new Vector2(0f, 400f), new Vector2(700f, 140f), 42f, true);
            _0xcf8ebb6e._0x442d0849.onClick.AddListener(() => this.Show(_0xacc331e0._0x89a71d4c.DEFAULT));
        }
    }
}

internal static class _0x5bfe74d3
{
    internal static string _0xf4f8e923(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}