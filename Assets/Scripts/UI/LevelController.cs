using UnityEngine.SceneManagement;
using UnityEngine;


public class LevelController : MonoBehaviour
{
    public void Levels1()
    {
        SceneManager.LoadScene(2);
    }
    public void Levels2()
    {
        SceneManager.LoadScene(3);
    }
    public void Levels3()
    {
        SceneManager.LoadScene(4);
    }
    public void menu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
    }
}
