using System.Collections;// універсальний скріпт для порталів-перехід з рівня в рівень
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    [SerializeField] private int idNextLevel;
    [SerializeField] private int MushroomForNextLevel;
    public GameObject panel;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Hero hero = collision.GetComponent<Hero>();
            if (hero.countMushroom >= MushroomForNextLevel)
            {
                SceneManager.LoadScene(idNextLevel);
            }
            else
            {
                Time.timeScale = 0f;
                panel.SetActive(true);
            }
        }
    }

}
