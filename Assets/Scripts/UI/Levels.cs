// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;
// using UnityEngine.SceneManagement;

// public class Levels : MonoBehaviour
// {
//     public Button level2B;
//     public Button level3B;
//     int levelComplete;
//     // Start is called before the first frame update
//     void Start()
//     {
//         levelComplete = PlayerPrefs.GetInt("levelComplete");
//         level2B.interactable = false;
//         level3B.interactable = false;
//         switch (levelComplete)
//         {
//             case 1:
//                 level2B.interactable = true;
//                 break;
//             case 2:
//                 level2B.interactable = true;
//                 level3B.interactable = true;
//                 break;
//         }
//         void LoadTo(int level)
//         {
//             SceneManager.LoadScene(level);
//         }
//         void Reset()
//         {
//             level2B.interactable = false;
//             level3B.interactable = false;
//             PlayerPrefs.DeleteAll();
//         }
//     }
// }

// Update is called once per frame

