using TMPro;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Settings : MonoBehaviour
{
    [SerializeField] private InputField inputUserName;
    [SerializeField] private TextMeshProUGUI errorText;

    private void Save()
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

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
