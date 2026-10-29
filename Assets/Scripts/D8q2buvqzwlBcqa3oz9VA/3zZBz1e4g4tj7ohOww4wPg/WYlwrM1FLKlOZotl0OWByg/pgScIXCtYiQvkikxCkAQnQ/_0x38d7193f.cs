using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x38d7193f : MonoBehaviour
{
    public GameObject Background;
    public float SecondPassSliderValue = 0.5f;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x38d7193f>();
    }

    public void _0x44c7a0e3()
    {
        this._0x70cf99bd?.Kill();
        this.AnimationSlider.value = _0xccc2a4f9 ? this.SecondPassSliderValue : 0.05f;
    }

    public void _0x73b6a3ea()
    {
        this._0x70cf99bd?.Play();
    }

    public void _0xffbe92bb()
    {
        this._0x44c7a0e3();
        bool _0xb9c0d28e = _0xccc2a4f9;
        this._0x70cf99bd = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0x7c29fd71 => this.AnimationSlider.value = _0x7c29fd71, _0xb9c0d28e ? 1f : this.SecondPassSliderValue, this.DefaultAnimationTime)).SetEase(Ease.Linear);
        _0xccc2a4f9 = !_0xccc2a4f9;
    }

    public float DefaultAnimationTime = 0.4f;
    public float FirstAnimationTime = 10.0f;
    public static _0x38d7193f Instance;
    public Slider AnimationSlider;
    private static bool _0xccc2a4f9 = false;
    public GameObject Content;
    public GameObject Error;
    public void _0x7c616eab()
    {
        {
#if B_LOGS
            {
                Debug.Log($"[Test] Animate Force");
            }
#endif
        }

        this._0x70cf99bd?.Kill();
        if (AnimationSlider != null)
            this.AnimationSlider.value = 1f;
        _0xccc2a4f9 = false;
    }

    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == _0xacc331e0._0x1bb30693.SCENE_0 && !_0xccc2a4f9)
        {
            this._0x68988dda();
        }
        else
        {
            this._0xffbe92bb();
        }
    }

    private void _0x68988dda()
    {
        this.AnimationSlider.value = 0.05f;
        _0xccc2a4f9 = !_0xccc2a4f9;
        this._0x70cf99bd = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0x7c29fd71 => this.AnimationSlider.value = _0x7c29fd71, 1f, this.FirstAnimationTime)).SetEase(Ease.Linear).OnComplete(() =>
        {
            _0x04c385c5._0xe45971d9?._0x01a510ea();
        });
    }

    private Sequence _0x70cf99bd;
    public void _0x85218bf0()
    {
        this._0x70cf99bd?.Pause();
    }
}