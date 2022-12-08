using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMain : MonoBehaviour
{  
    public void StartGame()
    {
        SceneManager.LoadScene(2);
    }

    public void OpenSettings()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
