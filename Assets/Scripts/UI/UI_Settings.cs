using TMPro;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Settings : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputUserName;
    [SerializeField] private TextMeshProUGUI errorText;

    public void Save()
    {
        string userName = inputUserName.text;
        if(userName.Length < 4)
        {
            errorText.text = "Error: enter username >3 chars";
            return;
        }
        for (int i = 0; i < userName.Length; i++)
        {
            if(userName[i]==' ')
            {
                errorText.text = "Error: delete spase ";
                return;
            }
        }

        SingUserData.singletone.userName = userName;
        SceneManager.LoadScene(0);
    }
  
    void Update()
    {
        
    }
}
