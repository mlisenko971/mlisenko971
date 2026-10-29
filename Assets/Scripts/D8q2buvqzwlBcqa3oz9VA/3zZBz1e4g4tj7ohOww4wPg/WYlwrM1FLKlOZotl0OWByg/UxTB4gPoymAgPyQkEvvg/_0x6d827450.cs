using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x6d827450 : MonoBehaviour
{
    public int LoadSceneId;
    private void Start()
    {
        if (this.IsLoadCurrentScene)
            this.Button.onClick.AddListener(() =>
            {
                _0x199a02a5.Instance._0xecb8d952(SceneManager.GetActiveScene().buildIndex);
            });
        else
            this.Button.onClick.AddListener(() => _0x199a02a5.Instance._0xecb8d952(this.LoadSceneId));
    }

    public bool IsLoadCurrentScene;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public Button Button;
}