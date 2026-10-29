using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xa61c0277 : MonoBehaviour
{
    private void _0xc052595e()
    {
        if (this.OuterBackground != null)
        {
            Image _0xca0a0199 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xca0a0199, true);
            _0xca0a0199.DOFade(0f, this.ScaleDuration);
        }
    }

    private void _0xcdc0789a()
    {
        if (this.OuterBackground != null)
        {
            Image _0x6342102b = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x6342102b, true);
            _0x6342102b.DOFade(1f, 0f);
        }
    }

    public float ScaleDuration = 0.4f;
    public bool IsScaledDownOnAwake = true;
    public void _0x7ac1fa99()
    {
        this._0xc052595e();
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
        {
            this.Content.SetActive(false);
        });
    }

    public void _0xf4fb73bf()
    {
        this._0xcdc0789a();
        this.Content.SetActive(true);
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.localScale = Vector3.one;
        _0xf449ad2c.Instance._0x2f419027(_0xf449ad2c.Instance.CurrentPanelIndex);
    }

    public TMP_Text HeaderText;
    public Ease Ease = Ease.OutSine;
    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.OuterBackground != null)
            this.OuterBackground.gameObject.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0x02accb90();
    }

    private void _0xe0266630()
    {
        if (this.OuterBackground != null)
        {
            Image _0x6fbf7742 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x6fbf7742, true);
            _0x6fbf7742.DOFade(1f, this.ScaleDuration / 2f);
        }
    }

    private bool _0x0bc0251c => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    private void _0x02accb90()
    {
        if (this.OuterBackground != null)
        {
            Image _0x7ae0bc6c = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x7ae0bc6c, true);
            _0x7ae0bc6c.DOFade(0f, 0.01f);
        }

        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, 0.01f);
    }

    public GameObject OuterBackground;
    public TMP_Text MainText;
    public GameObject Content;
    public void Show()
    {
        this._0xe0266630();
        if (this.Content != null)
        {
            DOTween.Kill(this.Content.transform, true);
            this.Content.SetActive(true);
            this.Content.transform.DOScale(1f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
            {
                _0xf449ad2c.Instance._0x2f419027(_0xf449ad2c.Instance.CurrentPanelIndex);
            });
        }
    }
}