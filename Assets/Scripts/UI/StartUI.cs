using UnityEngine.SceneManagement;
using UnityEngine;

public class StartUI : MonoBehaviour
{
    public void StartGame()
    {
       SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
