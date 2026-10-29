using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class _0xc320c59d : MonoBehaviour
{
    private void _0x69720cc2(Touch? _0xb845263e)
    {
        if (!_0x199a02a5.Instance._0x407fb271)
        {
            _0xb845263e = null;
            return;
        }

        int _0x8d8506e2 = _0xb845263e.Value.touchId;
        _0xb845263e = Touch.activeTouches.FirstOrDefault(_0xa928392a => _0xa928392a.touchId == _0x8d8506e2);
        if (!this._0xa26d5662(_0xb845263e.Value))
            _0xb845263e = null;
    }

    private Touch? _0xab2c8c4c()
    {
        if (!_0x199a02a5.Instance._0x407fb271)
            return null;
        foreach (Touch _0xc73a18d2 in Touch.activeTouches)
            if (_0xc73a18d2.ended)
                if (this._0xa26d5662(_0xc73a18d2))
                    return _0xc73a18d2;
        return null;
    }

    private Touch? _0xa1a8038c(Bounds _0x5d53b0fe)
    {
        if (!_0x199a02a5.Instance._0x407fb271)
            return null;
        foreach (Touch _0x34cda615 in Touch.activeTouches)
            if (!_0x34cda615.ended)
            {
                Vector3 _0x84dae79a = Camera.main.ScreenToWorldPoint(_0x34cda615.screenPosition);
                Vector3 _0xc2c78092 = new(_0x84dae79a.x, _0x84dae79a.y, _0x5d53b0fe.center.z);
                if (_0x5d53b0fe.Contains(_0xc2c78092) && this._0xa26d5662(_0x34cda615))
                    return _0x34cda615;
            }

        return null;
    }

    private bool _0xa26d5662(Touch? _0x207b6421)
    {
        if (!_0x207b6421.HasValue)
            return false;
        Vector3 _0x7abb071a = Camera.main.ScreenToWorldPoint(_0x207b6421.Value.screenPosition);
        Vector3 _0x5d214d8c = _0x7abb071a;
        _0x5d214d8c.z = this.CameraTouchBounds.transform.position.z;
        if (this.CameraTouchBounds.bounds.Contains(_0x5d214d8c))
            return true;
        _0x207b6421 = null;
        return false;
    }

    private Touch? _0xc9ad2ef5(Bounds _0x50c1c48d)
    {
        if (!_0x199a02a5.Instance._0x407fb271)
            return null;
        foreach (Touch _0x45dcd9f0 in Touch.activeTouches)
            if (_0x45dcd9f0.ended)
            {
                Vector3 _0xbde2da11 = Camera.main.ScreenToWorldPoint(_0x45dcd9f0.screenPosition);
                Vector3 _0xeb0bd335 = new(_0xbde2da11.x, _0xbde2da11.y, _0x50c1c48d.center.z);
                if (_0x50c1c48d.Contains(_0xeb0bd335) && this._0xa26d5662(_0x45dcd9f0))
                    return _0x45dcd9f0;
            }

        return null;
    }

    private Touch? _0x2bcad8e8(Bounds _0x337d2254, TouchPhase _0x9c0ac606)
    {
        if (!_0x199a02a5.Instance._0x407fb271)
            return null;
        foreach (Touch _0x8663af8c in Touch.activeTouches)
            if (_0x8663af8c.phase == _0x9c0ac606)
            {
                Vector3 _0x9fe6d3bb = Camera.main.ScreenToWorldPoint(_0x8663af8c.screenPosition);
                Vector3 _0x732fd034 = new(_0x9fe6d3bb.x, _0x9fe6d3bb.y, _0x337d2254.center.z);
                if (_0x337d2254.Contains(_0x732fd034) && this._0xa26d5662(_0x8663af8c))
                    return _0x8663af8c;
            }

        return null;
    }

    private void Awake()
    {
        EnhancedTouchSupport.Enable();
        _0xbe354ba1 = this.gameObject.GetComponent<_0xc320c59d>();
    }

    private Touch? _0x938814f0()
    {
        if (!_0x199a02a5.Instance._0x407fb271)
            return null;
        foreach (Touch _0xbd85813f in Touch.activeTouches)
            if (!_0xbd85813f.ended)
                if (this._0xa26d5662(_0xbd85813f))
                    return _0xbd85813f;
        return null;
    }

    public BoxCollider2D CameraTouchBounds;
    private bool _0xfa79f8f7(Touch? _0x6e140d5e, Bounds _0xaf96f798, TouchPhase _0xf403e2de)
    {
        if (!_0x199a02a5.Instance._0x407fb271)
        {
            _0x6e140d5e = null;
            return false;
        }

        if (_0x6e140d5e != null)
            if (_0x6e140d5e.Value.phase == _0xf403e2de)
            {
                Vector3 _0x548991fa = Camera.main.ScreenToWorldPoint(_0x6e140d5e.Value.screenPosition);
                Vector3 _0xd1daff37 = new(_0x548991fa.x, _0x548991fa.y, _0xaf96f798.center.z);
                if (_0xaf96f798.Contains(_0xd1daff37) && this._0xa26d5662(_0x6e140d5e.Value))
                    return true;
            }

        return false;
    }

    private static _0xc320c59d _0xbe354ba1;
}