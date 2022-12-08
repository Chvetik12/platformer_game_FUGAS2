using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameUIController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textUserName;
    [SerializeField] private TextMeshProUGUI textScore;
    private int score = 0;

    void Start()
    {
        textUserName.text = SingUserData.singletone.userName;
    }

   
   public void AddScore()
    {
        score += Random.Range(1, 5);
        textScore.text = "Score: "+score;
    }
    public void ReturnMainMenu()
    {
        string saveScore = PlayerPrefs.GetString("save");
        saveScore += $"{SingUserData.singletone.userName}:{score}|";
        PlayerPrefs.SetString("save", saveScore);
        SceneManager.LoadScene(0);
    }
}
