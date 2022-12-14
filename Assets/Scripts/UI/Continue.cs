using UnityEngine;

public class Continue : MonoBehaviour
{
    public GameObject panel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Time.timeScale = 1f;
            panel.SetActive(false);
        }
    }
    //public void ContinueGame()
    // {
    //     Time.timeScale = 1f;
    //     panel.SetActive(false);
    // }
}
