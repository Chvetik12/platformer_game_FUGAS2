using UnityEngine.SceneManagement;
using UnityEngine;

public class StartUI : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(0);
    }
    public void Level()
    {
        SceneManager.LoadScene(3);
    }
    public void OpenRecords()
    {
        SceneManager.LoadScene(2);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
