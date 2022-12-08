using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;

public class UI_Records : MonoBehaviour
{
    [SerializeField] private Transform contentScrolView;
    [SerializeField] private UI_PanelRowRecord prefabRowTable;

    void Start()
    {
        LoadData();
    }
   
    void LoadData()
    {
        string save = PlayerPrefs.GetString("save");
        string[] users = save.Split('|');
        for (int i = 0; i < users.Length-1; i++)
        {
            UI_PanelRowRecord currentRow = Instantiate(prefabRowTable, contentScrolView);
            string[] userInfo = users[i].Split(':');
            currentRow.textUserName.text = userInfo[1];
        }
    }

    public void ReturnMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
