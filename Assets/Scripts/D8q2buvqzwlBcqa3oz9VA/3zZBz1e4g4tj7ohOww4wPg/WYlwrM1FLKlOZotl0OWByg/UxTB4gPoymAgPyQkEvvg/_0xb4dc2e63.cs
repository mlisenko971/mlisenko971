using UnityEngine;
using UnityEngine.UI;

public class _0xb4dc2e63 : MonoBehaviour
{
    public bool IsHideAllPops;
    public Button Button;
    private void Start()
    {
        if (this.IsShowLastPop)
            this.Button.onClick.AddListener(() =>
            {
                _0x27521385.Instance._0x95746113();
            });
        else if (this.IsHideAllPops)
            this.Button.onClick.AddListener(() => _0x27521385.Instance._0x3385ed62());
        else
            this.Button.onClick.AddListener(() => _0x27521385.Instance._0xaed9ad35(this.PopToShowIndex));
    }

    public int PopToShowIndex;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public bool IsShowLastPop;
}