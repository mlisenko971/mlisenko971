using DG.Tweening;
using TMPro;
using UnityEngine;

/// <summary>
/// The three result cards, dressed in this game's own words (rule C.3).
///
/// Every template branch inside a pop body is switched off first and replaced by one card
/// of ours, so no leftover "Score:" row, no empty label and no sprite-less close square can
/// reach a screen - Unity paints an Image with no sprite as a solid WHITE rectangle, which
/// is the single most visible way a popup ships broken.
///
/// The close cross exists only on the pause card, where closing means "resume"; on a result
/// card there is nothing to close back to, so there is no cross rather than a cross that
/// does nothing. Every action button is built one at a time with its own caption, never
/// stamped in a loop (rule C.17), and each is wired by the session director with a lambda.
/// </summary>
public sealed class _0xe7a34503 : MonoBehaviour
{
    public void _0xf6f4ad7e(int _0xa918ebb7)
    {
        _0xd90280ba.SetText(this._0x8dcbfd61, _0xbc4410b7._0xdb42a08b(new byte[39] { 212, 200, 197, 160, 204, 193, 205, 208, 160, 211, 212, 193, 217, 197, 196, 160, 196, 201, 205, 138, 206, 207, 160, 211, 208, 193, 210, 203, 211, 160, 195, 207, 204, 204, 197, 195, 212, 197, 196 }, 128));
        _0xd90280ba.SetText(this._0xd4a2035c, _0xbc4410b7._0xdb42a08b(new byte[41] { 15, 19, 30, 123, 22, 26, 11, 123, 16, 30, 30, 11, 8, 123, 2, 20, 14, 9, 123, 11, 9, 20, 28, 9, 30, 8, 8, 81, 23, 26, 21, 15, 30, 9, 21, 8, 123, 23, 18, 15, 123 }, 91) + _0xa918ebb7 + _0xbc4410b7._0xdb42a08b(new byte[3] { 30, 17, 30 }, 62) + _0x2360e6ef.MapCells);
    }

    public void _0x109d5ac0()
    {
        if (this._0x7a4828cd || this._art == null)
            return;
        this._0x7a4828cd = true;
        this._0x73e6e9be = this._art._0xbebca28b();
        RectTransform _0xd635bb27 = this._0x50fada63(_0x27521385.Instance._0x524ce78b(_0xacc331e0._0xb6512ce8.WIN));
        if (_0xd635bb27 != null)
        {
            this._0x767d452f = this._0x16d3f89d(_0xd635bb27, _0xbc4410b7._0xdb42a08b(new byte[11] { 97, 108, 99, 121, 104, 127, 99, 13, 97, 100, 121 }, 45));
            this._0x73e6e9be._0x5ab12fd7(_0xd635bb27, _0xbc4410b7._0xdb42a08b(new byte[6] { 30, 32, 39, 8, 59, 61 }, 73), this._art._0x43f281af, _0xbe939921._0x434f62f6, new Vector2(0f, -300f), 200f);
            this._0xfe4a6dde = this._0x73e6e9be._0xb8fb9383(_0xd635bb27, _0xbc4410b7._0xdb42a08b(new byte[7] { 143, 177, 182, 154, 183, 188, 161 }, 216), _0xbc4410b7._0xdb42a08b(new byte[17] { 127, 105, 115, 116, 6, 101, 105, 104, 114, 116, 111, 100, 115, 114, 111, 105, 104 }, 38), _0xbe939921._0x434f62f6, new Vector2(0f, -470f), new Vector2(880f, 104f), 48f, _0xb20acb45.Ink, TextAlignmentOptions.Center);
            // Three lines at week completion (gift, next goal, reward), so the box is sized
            // for three: 140 still clears the metric plates below, which start 18 units down.
            this._0x24562b83 = this._0x73e6e9be._0xb8fb9383(_0xd635bb27, _0xbc4410b7._0xdb42a08b(new byte[8] { 143, 177, 182, 157, 160, 172, 170, 185 }, 216), _0xbc4410b7._0xdb42a08b(new byte[21] { 94, 74, 93, 93, 56, 95, 81, 94, 76, 56, 74, 93, 89, 92, 65, 56, 53, 56, 41, 55, 41 }, 24), _0xbe939921._0x434f62f6, new Vector2(0f, -592f), new Vector2(900f, 140f), 32f, _0xb20acb45.SlateText, TextAlignmentOptions.Center);
            this._0xc30d2889 = this._0x25d99378(_0xd635bb27, _0xbc4410b7._0xdb42a08b(new byte[9] { 209, 239, 232, 213, 246, 231, 244, 237, 245 }, 134), -232f, _0xbc4410b7._0xdb42a08b(new byte[13] { 54, 53, 36, 55, 46, 54, 69, 32, 36, 55, 43, 32, 33 }, 101), _0xb20acb45.TealText);
            this._0x9d752f9b = this._0x25d99378(_0xd635bb27, _0xbc4410b7._0xdb42a08b(new byte[11] { 55, 9, 14, 44, 1, 14, 20, 5, 18, 14, 19 }, 96), 232f, _0xbc4410b7._0xdb42a08b(new byte[12] { 14, 3, 12, 22, 7, 16, 12, 17, 98, 14, 11, 22 }, 66), _0xb20acb45.Ink);
            this._0xa80adb02 = this._0x73e6e9be._0xeaf47c78(_0xd635bb27, _0xbc4410b7._0xdb42a08b(new byte[8] { 213, 235, 236, 195, 229, 227, 235, 236 }, 130), _0xbc4410b7._0xdb42a08b(new byte[12] { 44, 39, 58, 54, 66, 49, 39, 49, 49, 43, 45, 44 }, 98), _0xbe939921._0x11f50216, new Vector2(0f, 300f), new Vector2(760f, 150f), 46f, true);
            this._0x5007ef65 = this._0x73e6e9be._0xeaf47c78(_0xd635bb27, _0xbc4410b7._0xdb42a08b(new byte[7] { 223, 225, 230, 197, 237, 230, 253 }, 136), _0xbc4410b7._0xdb42a08b(new byte[16] { 163, 160, 162, 170, 193, 181, 174, 193, 181, 169, 164, 193, 162, 173, 180, 163 }, 225), _0xbe939921._0x11f50216, new Vector2(0f, 140f), new Vector2(760f, 120f), 36f, false);
        }

        RectTransform _0x011ef9df = this._0x50fada63(_0x27521385.Instance._0x524ce78b(_0xacc331e0._0xb6512ce8.LOSE));
        if (_0x011ef9df != null)
        {
            this._0x16d3f89d(_0x011ef9df, _0xbc4410b7._0xdb42a08b(new byte[11] { 198, 197, 212, 199, 222, 181, 211, 212, 209, 208, 209 }, 149));
            this._0x73e6e9be._0x5ab12fd7(_0x011ef9df, _0xbc4410b7._0xdb42a08b(new byte[7] { 86, 117, 105, 127, 91, 104, 110 }, 26), this._art._0x4438f135, _0xbe939921._0x434f62f6, new Vector2(0f, -300f), 200f);
            this._0x8dcbfd61 = this._0x73e6e9be._0xb8fb9383(_0x011ef9df, _0xbc4410b7._0xdb42a08b(new byte[8] { 125, 94, 66, 84, 115, 94, 85, 72 }, 49), _0xbc4410b7._0xdb42a08b(new byte[39] { 154, 134, 139, 238, 130, 143, 131, 158, 238, 157, 154, 143, 151, 139, 138, 238, 138, 135, 131, 196, 128, 129, 238, 157, 158, 143, 156, 133, 157, 238, 141, 129, 130, 130, 139, 141, 154, 139, 138 }, 206), _0xbe939921._0x434f62f6, new Vector2(0f, -500f), new Vector2(880f, 150f), 44f, _0xb20acb45.Ink, TextAlignmentOptions.Center);
            this._0xd4a2035c = this._0x73e6e9be._0xb8fb9383(_0x011ef9df, _0xbc4410b7._0xdb42a08b(new byte[9] { 243, 208, 204, 218, 250, 199, 203, 205, 222 }, 191), _0xbc4410b7._0xdb42a08b(new byte[27] { 253, 225, 236, 137, 228, 232, 249, 137, 226, 236, 236, 249, 250, 137, 240, 230, 252, 251, 137, 249, 251, 230, 238, 251, 236, 250, 250 }, 169), _0xbe939921._0x434f62f6, new Vector2(0f, -630f), new Vector2(900f, 90f), 32f, _0xb20acb45.SlateText, TextAlignmentOptions.Center);
            this._0x436357da = this._0x73e6e9be._0xeaf47c78(_0x011ef9df, _0xbc4410b7._0xdb42a08b(new byte[9] { 147, 176, 172, 186, 158, 184, 190, 182, 177 }, 223), _0xbc4410b7._0xdb42a08b(new byte[9] { 138, 140, 135, 254, 159, 153, 159, 151, 144 }, 222), _0xbe939921._0x11f50216, new Vector2(0f, 300f), new Vector2(760f, 150f), 46f, true);
            this._0xc72b1a54 = this._0x73e6e9be._0xeaf47c78(_0x011ef9df, _0xbc4410b7._0xdb42a08b(new byte[8] { 12, 47, 51, 37, 13, 37, 46, 53 }, 64), _0xbc4410b7._0xdb42a08b(new byte[16] { 96, 99, 97, 105, 2, 118, 109, 2, 118, 106, 103, 2, 97, 110, 119, 96 }, 34), _0xbe939921._0x11f50216, new Vector2(0f, 140f), new Vector2(760f, 120f), 36f, false);
        }

        RectTransform _0x06bb55a5 = this._0x50fada63(_0x27521385.Instance._0x524ce78b(_0xacc331e0._0xb6512ce8.PAUSE));
        if (_0x06bb55a5 != null)
        {
            this._0x16d3f89d(_0x06bb55a5, _0xbc4410b7._0xdb42a08b(new byte[14] { 73, 95, 73, 73, 83, 85, 84, 58, 74, 91, 79, 73, 95, 94 }, 26));
            this._0x73e6e9be._0x5ab12fd7(_0x06bb55a5, _0xbc4410b7._0xdb42a08b(new byte[8] { 207, 254, 234, 236, 250, 222, 237, 235 }, 159), this._art._0x20f0f53d, _0xbe939921._0x434f62f6, new Vector2(0f, -300f), 200f);
            this._0x1c7ee866 = this._0x73e6e9be._0xb8fb9383(_0x06bb55a5, _0xbc4410b7._0xdb42a08b(new byte[9] { 165, 148, 128, 134, 144, 183, 154, 145, 140 }, 245), _0xbc4410b7._0xdb42a08b(new byte[11] { 123, 110, 124, 100, 15, 30, 15, 96, 105, 15, 28 }, 47), _0xbe939921._0x434f62f6, new Vector2(0f, -470f), new Vector2(880f, 104f), 46f, _0xb20acb45.Ink, TextAlignmentOptions.Center);
            this._0xc953a8cc = this._0x73e6e9be._0xb8fb9383(_0x06bb55a5, _0xbc4410b7._0xdb42a08b(new byte[10] { 19, 34, 54, 48, 38, 6, 59, 55, 49, 34 }, 67), _0xbc4410b7._0xdb42a08b(new byte[15] { 190, 174, 221, 222, 207, 220, 197, 221, 174, 221, 193, 174, 200, 207, 220 }, 142), _0xbe939921._0x434f62f6, new Vector2(0f, -592f), new Vector2(900f, 110f), 32f, _0xb20acb45.SlateText, TextAlignmentOptions.Center);
            this._0x5dc43caa = this._0x73e6e9be._0xeaf47c78(_0x06bb55a5, _0xbc4410b7._0xdb42a08b(new byte[11] { 118, 71, 83, 85, 67, 116, 67, 85, 83, 75, 67 }, 38), _0xbc4410b7._0xdb42a08b(new byte[6] { 142, 153, 143, 137, 145, 153 }, 220), _0xbe939921._0x11f50216, new Vector2(0f, 300f), new Vector2(760f, 150f), 46f, true);
            this._0xac91559d = this._0x73e6e9be._0xeaf47c78(_0x06bb55a5, _0xbc4410b7._0xdb42a08b(new byte[10] { 7, 54, 34, 36, 50, 27, 50, 54, 33, 50 }, 87), _0xbc4410b7._0xdb42a08b(new byte[13] { 34, 43, 47, 56, 43, 78, 61, 43, 61, 61, 39, 33, 32 }, 110), _0xbe939921._0x11f50216, new Vector2(0f, 140f), new Vector2(760f, 120f), 36f, false);
            this._0x90ad5196 = this._0x508b063d(_0x06bb55a5);
        }
    }

    public _0xc9b630d4 _0x79786d69
    {
        get
        {
            return this._0xa80adb02;
        }
    }

    public _0xc9b630d4 _0x54bb1c7c
    {
        get
        {
            return this._0x90ad5196;
        }
    }

    private _0xc9b630d4 _0x436357da;
    private _0xc9b630d4 _0x5dc43caa;
    /// <summary>
    /// One metric plate. The template's static Score / Reward rows went off with the rest of
    /// the body; these carry this game's own two numbers instead, and they are always filled.
    /// </summary>
    private TextMeshProUGUI _0x25d99378(RectTransform _0x120c4c9b, string _0x55a69997, float _0xa7cbfe24, string _0xcbb33adf, Color _0xf27c44c0)
    {
        RectTransform _0xaa8d57e3 = this._0x73e6e9be._0x4a32d93b(_0x120c4c9b, _0x55a69997, _0xbe939921._0x11f50216, new Vector2(_0xa7cbfe24, 500f), new Vector2(416f, 150f));
        this._0x73e6e9be._0xb3a779c2(_0xaa8d57e3, _0xbc4410b7._0xdb42a08b(new byte[5] { 166, 154, 151, 130, 147 }, 246), _0xb20acb45.Fade(_0xb20acb45.Haze, 0.75f), 2.2f);
        this._0x73e6e9be._0x9a152850(_0xaa8d57e3, _0xbc4410b7._0xdb42a08b(new byte[3] { 249, 210, 201 }, 189), _0xbe939921._0x434f62f6, new Vector2(0f, -18f), 16f, _0xf27c44c0);
        return this._0x73e6e9be._0xb8fb9383(_0xaa8d57e3, _0xbc4410b7._0xdb42a08b(new byte[5] { 19, 36, 41, 48, 32 }, 69), _0xcbb33adf + _0xbc4410b7._0xdb42a08b(new byte[2] { 11, 49 }, 1), _0xbe939921._0x7f5aa638, new Vector2(0f, -8f), new Vector2(392f, 118f), 34f, _0xf27c44c0, TextAlignmentOptions.Center);
    }

    /// <summary>
    /// The pause card's cross, drawn from two bars. It carries no caption (rule C.17) and no
    /// sprite reference, so it cannot ship as a white square.
    /// </summary>
    private _0xc9b630d4 _0x508b063d(RectTransform _0x95a3bf15)
    {
        RectTransform _0x1501b6ef = this._0x73e6e9be._0x4a32d93b(_0x95a3bf15, _0xbc4410b7._0xdb42a08b(new byte[5] { 136, 167, 164, 184, 174 }, 203), _0xbe939921._0xae0d23e9, new Vector2(-78f, -78f), new Vector2(112f, 112f));
        UnityEngine.UI.Image _0x55adde8d = this._0x73e6e9be._0xb3a779c2(_0x1501b6ef, _0xbc4410b7._0xdb42a08b(new byte[3] { 196, 255, 251 }, 150), _0xb20acb45.Fade(_0xb20acb45.Slate, 0.38f), 1.1f);
        UnityEngine.UI.Image _0x728cbc83 = this._0x73e6e9be._0xb3a779c2(_0x55adde8d.rectTransform, _0xbc4410b7._0xdb42a08b(new byte[4] { 169, 142, 140, 138 }, 239), _0xb20acb45.Fade(_0xb20acb45.Mist, 0.96f), 1.15f);
        _0x728cbc83.rectTransform.offsetMin = new Vector2(3f, 3f);
        _0x728cbc83.rectTransform.offsetMax = new Vector2(-3f, -3f);
        RectTransform _0x92c843f5 = this._0x73e6e9be._0xf1859ad1(_0x728cbc83.rectTransform, _0xbc4410b7._0xdb42a08b(new byte[10] { 69, 106, 105, 117, 99, 65, 106, 127, 118, 110 }, 6), _0xbe939921._0x7f5aa638, Vector2.zero, 52f, 9f, _0xb20acb45.Slate);
        _0x92c843f5.SetAsLastSibling();
        UnityEngine.UI.Button _0x2e7a1519 = this._0x73e6e9be._0x61f1617d(_0x1501b6ef.gameObject, _0x728cbc83);
        return new _0xc9b630d4()._0x4b69e1d1(_0x1501b6ef, _0x2e7a1519, _0x728cbc83, _0x55adde8d, null);
    }

    private bool _0x7a4828cd;
    private _0xc9b630d4 _0x90ad5196;
    private _0xc9b630d4 _0xa80adb02;
    private TextMeshProUGUI _0x8dcbfd61;
    private void OnDestroy()
    {
        DOTween.Kill(this, false);
    }

    public _0xc9b630d4 _0x0d3eb5d4
    {
        get
        {
            return this._0xc72b1a54;
        }
    }

    private _0xc9b630d4 _0xac91559d;
    private TextMeshProUGUI _0x767d452f;
    private _0xc9b630d4 _0x5007ef65;
    private TextMeshProUGUI _0x1c7ee866;
    private _0xf23fcd8b _0x73e6e9be;
    private _0xc9b630d4 _0xc72b1a54;
    /// <summary>
    /// The week-complete reward gets its OWN line and never joins the header. Two of this
    /// app's own words, put side by side in one string, spell out the name the app is not
    /// allowed to show anywhere on screen, so the header stays the result and the reward
    /// sits where the brief puts it - under the gift and the next goal.
    /// </summary>
    public void _0xbfb6a848(int _0xafdd51fb, int _0xdceceed2, bool _0xc4889a43, int _0x5836a661, bool _0x73ca4938)
    {
        _0xd90280ba.SetText(this._0x767d452f, _0xbc4410b7._0xdb42a08b(new byte[11] { 245, 248, 247, 237, 252, 235, 247, 153, 245, 240, 237 }, 185));
        _0xd90280ba.SetText(this._0xfe4a6dde, _0xbc4410b7._0xdb42a08b(new byte[18] { 192, 214, 204, 203, 185, 218, 214, 215, 205, 203, 208, 219, 204, 205, 208, 214, 215, 147 }, 153) + _0xafdd51fb + _0xbc4410b7._0xdb42a08b(new byte[7] { 235, 152, 155, 138, 153, 128, 152 }, 203));
        string _0x0a621818 = _0xc4889a43 ? _0xbc4410b7._0xdb42a08b(new byte[21] { 233, 253, 234, 234, 143, 232, 230, 233, 251, 143, 253, 234, 238, 235, 246, 143, 130, 143, 158, 128, 158 }, 175) : _0xbc4410b7._0xdb42a08b(new byte[20] { 96, 116, 99, 99, 6, 97, 111, 96, 114, 6, 117, 99, 104, 114, 6, 114, 105, 98, 103, 127 }, 38);
        string _0xb330a699 = _0x5836a661 > 0 ? _0xbc4410b7._0xdb42a08b(new byte[18] { 231, 236, 241, 253, 137, 238, 230, 232, 229, 137, 132, 137, 229, 224, 238, 225, 253, 137 }, 169) + _0x5836a661 + _0xbc4410b7._0xdb42a08b(new byte[5] { 89, 52, 54, 43, 60 }, 121) : _0xbc4410b7._0xdb42a08b(new byte[21] { 7, 27, 22, 115, 4, 22, 22, 24, 115, 26, 0, 115, 21, 6, 31, 31, 10, 115, 31, 26, 7 }, 83);
        string _0x453783b2 = _0x73ca4938 ? _0xbc4410b7._0xdb42a08b(new byte[22] { 191, 225, 253, 240, 149, 243, 231, 244, 248, 240, 149, 252, 230, 149, 224, 251, 249, 250, 246, 254, 240, 241 }, 181) : string.Empty;
        _0xd90280ba.SetText(this._0x24562b83, _0x0a621818 + _0xbc4410b7._0xdb42a08b(new byte[1] { 72 }, 66) + _0xb330a699 + _0x453783b2);
        _0xd90280ba.SetText(this._0xc30d2889, _0xbc4410b7._0xdb42a08b(new byte[14] { 147, 144, 129, 146, 139, 147, 224, 133, 129, 146, 142, 133, 132, 202 }, 192) + _0xafdd51fb);
        _0xd90280ba.SetText(this._0x9d752f9b, _0xbc4410b7._0xdb42a08b(new byte[13] { 252, 241, 254, 228, 245, 226, 254, 227, 144, 252, 249, 228, 186 }, 176) + _0xdceceed2 + _0xbc4410b7._0xdb42a08b(new byte[3] { 126, 113, 126 }, 94) + _0x2360e6ef.MapCells);
    }

    public void _0x1550c01a(int _0x3ef805a7, int _0x8dc53676)
    {
        _0xd90280ba.SetText(this._0x1c7ee866, _0xbc4410b7._0xdb42a08b(new byte[5] { 25, 12, 30, 6, 109 }, 77) + _0x3ef805a7 + _0xbc4410b7._0xdb42a08b(new byte[4] { 41, 70, 79, 41 }, 9) + _0x2360e6ef.TasksPerSession);
        _0xd90280ba.SetText(this._0xc953a8cc, _0x8dc53676 + _0xbc4410b7._0xdb42a08b(new byte[45] { 151, 228, 231, 246, 229, 252, 228, 151, 228, 248, 151, 241, 246, 229, 189, 249, 248, 227, 255, 254, 249, 240, 151, 254, 228, 151, 251, 248, 228, 227, 151, 224, 255, 254, 251, 242, 151, 238, 248, 226, 151, 224, 246, 254, 227 }, 183));
    }

    public _0xc9b630d4 _0x18d2cad7
    {
        get
        {
            return this._0x5007ef65;
        }
    }

    private TextMeshProUGUI _0xfe4a6dde;
    [SerializeField]
    private _0x761f29fe _art;
    public _0xc9b630d4 _0xe09f152a
    {
        get
        {
            return this._0x436357da;
        }
    }

    private TextMeshProUGUI _0xc30d2889;
    private TextMeshProUGUI _0x9d752f9b;
    /// <summary>
    /// Switches every template branch of the pop body off and returns our own card rect.
    /// The template's own buttons go off with it, so every caption and every action on the
    /// card below is ours and nothing can fire twice.
    /// </summary>
    private RectTransform _0x50fada63(_0x45251bed _0x360c74f9)
    {
        if (_0x360c74f9 == null || _0x360c74f9.Content == null)
            return null;
        Transform _0xddb7996d = _0x360c74f9.Content.transform;
        for (int _0x94a990e4 = _0xddb7996d.childCount - 1; _0x94a990e4 >= 0; _0x94a990e4--)
            _0xddb7996d.GetChild(_0x94a990e4).gameObject.SetActive(false);
        RectTransform _0x7846b062 = this._0x73e6e9be._0xaa5a67ea(_0xddb7996d, _0xbc4410b7._0xdb42a08b(new byte[4] { 78, 108, 127, 105 }, 13), _0xbe939921._0x7f5aa638, new Vector2(0f, 40f), new Vector2(1020f, 1240f));
        this._0x73e6e9be._0x546a2744(_0x7846b062, _0xbc4410b7._0xdb42a08b(new byte[8] { 121, 91, 72, 94, 104, 79, 86, 95 }, 58), _0xbe939921._0x434f62f6, new Vector2(0f, -36f), 420f, _0xb20acb45.Fade(_0xb20acb45.Gold, 0.85f));
        return _0x7846b062;
    }

    public _0xc9b630d4 _0x4c025de2
    {
        get
        {
            return this._0x5dc43caa;
        }
    }

    private TextMeshProUGUI _0xc953a8cc;
    private TextMeshProUGUI _0x24562b83;
    public _0xc9b630d4 _0xdbed7b35
    {
        get
        {
            return this._0xac91559d;
        }
    }

    private TextMeshProUGUI _0x16d3f89d(RectTransform _0x8e0d5a76, string _0x3ab3a63e)
    {
        return this._0x73e6e9be._0xb8fb9383(_0x8e0d5a76, _0xbc4410b7._0xdb42a08b(new byte[6] { 105, 68, 64, 69, 68, 83 }, 33), _0x3ab3a63e, _0xbe939921._0x434f62f6, new Vector2(0f, -120f), new Vector2(900f, 108f), 52f, _0xb20acb45.Ink, TextAlignmentOptions.Center);
    }

    private TextMeshProUGUI _0xd4a2035c;
}

internal static class _0xbc4410b7
{
    internal static string _0xdb42a08b(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}