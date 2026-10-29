using UnityEngine;
using UnityEngine.UI;

public class _0xb3391cce : MonoBehaviour
{
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    private void Start()
    {
        this.Button.onClick.AddListener(() => _0x199a02a5.Instance._0x8e9fcba3(this.IsPhysicsRunOnClick));
    }

    public bool IsPhysicsRunOnClick;
    public Button Button;
}