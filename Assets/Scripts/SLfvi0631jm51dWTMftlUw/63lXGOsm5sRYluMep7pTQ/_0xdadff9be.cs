using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class _0xdadff9be : MonoBehaviour
{
    private void Awake()
    {
        this._0x33c373e6 = this.GetComponent<Camera>();
        _0xe5c3f096 = this;
        this._0xf8b523ad();
    }

    private void _0xf8b523ad()
    {
        float _0x7adf2a1c, _0x1cf6f3f7, _0x84759e77, _0x68bea730;
        if (this._0x7389ca49 == _0xa67b4f34.Landscape)
            this._0x33c373e6.orthographicSize = 1f / this._0x33c373e6.aspect * this._0x15cf338a / 2f;
        else
            this._0x33c373e6.orthographicSize = this._0x15cf338a / 2f;
        this._0x34aefcf7 = 2f * this._0x33c373e6.orthographicSize;
        this._0x59fbdcf6 = this._0x34aefcf7 * this._0x33c373e6.aspect;
        float _0x1d48714e = this._0x33c373e6.transform.position.x;
        float _0x2d842c56 = this._0x33c373e6.transform.position.y;
        _0x7adf2a1c = _0x1d48714e - this._0x59fbdcf6 / 2;
        _0x1cf6f3f7 = _0x1d48714e + this._0x59fbdcf6 / 2;
        _0x84759e77 = _0x2d842c56 + this._0x34aefcf7 / 2;
        _0x68bea730 = _0x2d842c56 - this._0x34aefcf7 / 2;
        this._0x75de1406 = new Vector3(_0x7adf2a1c, _0x68bea730, 0);
        this._0x939160a9 = new Vector3(_0x1d48714e, _0x68bea730, 0);
        this._0x8d074d7e = new Vector3(_0x1cf6f3f7, _0x68bea730, 0);
        this._0x50774e79 = new Vector3(_0x7adf2a1c, _0x2d842c56, 0);
        this._0xd3a8791a = new Vector3(_0x1d48714e, _0x2d842c56, 0);
        this._0x32b5e79e = new Vector3(_0x1cf6f3f7, _0x2d842c56, 0);
        this._0x4adb62e3 = new Vector3(_0x7adf2a1c, _0x84759e77, 0);
        this._0x7b1a72c6 = new Vector3(_0x1d48714e, _0x84759e77, 0);
        this._0x6aecfcc8 = new Vector3(_0x1cf6f3f7, _0x84759e77, 0);
    }

    private new Camera _0x33c373e6;
    private float _0x15cf338a = 1;
    private float _0x34aefcf7 { get; set; }

    private Color _0x6959d5b5 = Color.white;
    private _0xa67b4f34 _0x7389ca49 = _0xa67b4f34.Portrait;
    private Vector3 _0x75de1406 { get; set; }
    private Vector3 _0x6aecfcc8 { get; set; }
    private Vector3 _0x8d074d7e { get; set; }
    //public bool executeInUpdate;
    private float _0x59fbdcf6 { get; set; }
    private Vector3 _0x7b1a72c6 { get; set; }
    private Vector3 _0x939160a9 { get; set; }
    private Vector3 _0x32b5e79e { get; set; }

    public enum _0xa67b4f34
    {
        Landscape,
        Portrait
    }

    private Vector3 _0xd3a8791a { get; set; }
    private Vector3 _0x50774e79 { get; set; }

    private void OnDrawGizmos()
    {
        Gizmos.color = this._0x6959d5b5;
        Matrix4x4 _0x5581cc2b = Gizmos.matrix;
        Gizmos.matrix = Matrix4x4.TRS(this.transform.position, this.transform.rotation, Vector3.one);
        if (this._0x33c373e6.orthographic)
        {
            float _0xa2328c7e = this._0x33c373e6.farClipPlane - this._0x33c373e6.nearClipPlane;
            float _0xe900788a = (this._0x33c373e6.farClipPlane + this._0x33c373e6.nearClipPlane) * 0.5f;
            Gizmos.DrawWireCube(new Vector3(0, 0, _0xe900788a), new Vector3(this._0x33c373e6.orthographicSize * 2 * this._0x33c373e6.aspect, this._0x33c373e6.orthographicSize * 2, _0xa2328c7e));
        }
        else
        {
            Gizmos.DrawFrustum(Vector3.zero, this._0x33c373e6.fieldOfView, this._0x33c373e6.farClipPlane, this._0x33c373e6.nearClipPlane, this._0x33c373e6.aspect);
        }

        Gizmos.matrix = _0x5581cc2b;
    }

    private static _0xdadff9be _0xe5c3f096;
    private Vector3 _0x4adb62e3 { get; set; }
}