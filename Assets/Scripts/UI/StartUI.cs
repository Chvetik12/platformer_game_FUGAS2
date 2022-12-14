using UnityEngine.SceneManagement;
using UnityEngine;

public class StartUI : MonoBehaviour
{
    public GameObject panel;
    public void StartGame()
    {
        SceneManager.LoadScene(2);
    }
    public void Level()
    {
        SceneManager.LoadScene(1);
    }
    // public void OpenRecords()
    // {
    //     SceneManager.LoadScene(2);
    // }
    public void Exit()
    {
        Application.Quit();
    }
}
