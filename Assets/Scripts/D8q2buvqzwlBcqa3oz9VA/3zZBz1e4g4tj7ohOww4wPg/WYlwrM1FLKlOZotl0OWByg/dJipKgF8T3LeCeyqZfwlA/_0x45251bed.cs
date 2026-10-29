using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x45251bed : MonoBehaviour
{
    private void _0x4159b123()
    {
        DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(0f, 0.01f);
        else
            this.Content.transform.DOScale(0f, 0.01f);
        this.Content.SetActive(false);
    }

    public bool IsOnlyYScale;
    public float scaleDuration = 0.4f;
    public static void HideAllPops()
    {
        _0x27521385.Instance._0x3385ed62();
    }

    public TMP_Text ContentHeaderText;
    public void Show()
    {
        this.Content.SetActive(true);
        if ((DOTween.TweensByTarget(this.Content.transform)?.Count ?? 0) > 0)
            DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
        else
            this.Content.transform.DOScale(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
    }

    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0x4159b123();
    }

    public bool IsScaledDownOnAwake = true;
    public void _0x91bc1f45()
    {
        if (this.Content.gameObject.activeSelf)
        {
            DOTween.Kill(this.Content.transform, true);
            if (this.IsOnlyYScale)
                this.Content.transform.DOScaleY(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
            else
                this.Content.transform.DOScale(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
        }
    }

    private void Start()
    {
    // Content.SetActive(false);
    }

    private bool _0xb3183ce8 => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    public Ease ease = Ease.OutSine;
    public TMP_Text ContentAdditionalText;
    public GameObject Content;
    public Image ContentImage;
    public TMP_Text ContentMainText;
}