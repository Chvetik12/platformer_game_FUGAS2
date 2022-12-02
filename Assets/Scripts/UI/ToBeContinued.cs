using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToBeContinued : MonoBehaviour
{
    [SerializeField] private GameObject panelToBeContinued;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            panelToBeContinued.SetActive(true);
            Time.timeScale = 0;
        }
    }
}

