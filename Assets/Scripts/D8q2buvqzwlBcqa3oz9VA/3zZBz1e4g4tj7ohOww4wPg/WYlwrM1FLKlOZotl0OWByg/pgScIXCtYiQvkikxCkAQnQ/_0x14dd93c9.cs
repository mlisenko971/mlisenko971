using UnityEngine;
using UnityEngine.UI;

public class _0x14dd93c9 : MonoBehaviour
{
    public int EndTutorialPanelIndex = 1;
    private void Start()
    {
        if (this.NextTutorialButton != null)
        {
            if (this.IsTutorialEndPanel)
            {
                this.NextTutorialButton.onClick.AddListener(() => _0xf449ad2c.Instance._0x192e1309(this.EndTutorialPanelIndex));
                this.NextTutorialButton.onClick.AddListener(() => _0x199a02a5.Instance._0x1a26567d());
            }
            else
            {
                this.NextTutorialButton.onClick.AddListener(() => _0xf449ad2c.Instance._0x192e1309(this.NextTutorialPanelIndex));
            }
        }

        if (this.TutorialEndButton != null)
        {
            this.TutorialEndButton.onClick.AddListener(() => _0xf449ad2c.Instance._0x192e1309(this.EndTutorialPanelIndex));
            this.TutorialEndButton.onClick.AddListener(() => _0x199a02a5.Instance._0x1a26567d());
        }
    }

    public Button NextTutorialButton;
    public int NextTutorialPanelIndex;
    public Button TutorialEndButton;
    public bool IsTutorialEndPanel;
}