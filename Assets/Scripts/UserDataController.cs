// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class UserDataController : MonoBehaviour
// {
//     public static UserDataController Instance;
//     public int life = 3;
//     public int countSnow = 5;
//     public int countMushroom = 0;
//     void Awake()
//     {
//         if (Instance = 0)
//         {
//             DontDestroyOnLoad(gameObject);
//             Instance = this;
//             print("instance");
//         }
//         else
//         {
//             Destroy(gameObject);
//         }
//     }
//     public void ResetData()
//     {
//         life = 3;
//         countSnow = 5;
//         countMushroom = 0;
//     }
// }
