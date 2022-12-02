using System.Collections;// універсальний скріпт для порталів-перехід з рівня в рівень
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    [SerializeField] private int idNextLevel;
    [SerializeField] private int CrystalForNextLevel;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            //AstroMan astroMan = collision.GetComponent<AstroMan>();
            //if(astroMan.crystal>= CrystalForNextLevel)
            //{
            //    SceneManager.LoadScene(idNextLevel);
            //}
        }
    }
}
