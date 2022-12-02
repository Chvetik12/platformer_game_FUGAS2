using UnityEngine;

public class Continue : MonoBehaviour
{
    public GameObject panel;

    public void ContinueGame()
    {
        Time.timeScale = 1f;
        panel.SetActive(false);
    }
}
