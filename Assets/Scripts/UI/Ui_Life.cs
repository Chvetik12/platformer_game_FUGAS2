using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ui_Life : MonoBehaviour
{
    [SerializeField] private GameObject[] objLife;
    [SerializeField] private GameObject panelGameOver;
    private int life = 5;

    public void AddLife()
    {
        life++;
        UpdateLife();
    }

    public void RemuveLife()
    {
        life--;
        UpdateLife();
    }
    public void GameOver()
    {
        panelGameOver.SetActive(true);
    }
    public void NewGame()
    {
        Time.timeScale = 1;// щоб грав ігрок коли, почав заново рівень грати
        SceneManager.LoadScene(1);
        //var currentSceneIndex = SceneManager.GetActiveScene().buildIndex
          // SceneManager.LoadScene(currentSceneIndex);
    }
    void UpdateLife()
    {
        for (int i = 0; i < 5; i++)
        {
            if(life>i)
            {
                objLife[i].SetActive(true);
            }
            else
            {
                objLife[i].SetActive(false);
            }
        }
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.collider.tag == "spikes")
    //    {
    //        lifes -= 1;
    //        //print("CollisionEnter");


    //        if (lifes == 0)
    //        {
    //            var currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    //            SceneManager.LoadScene(currentSceneIndex);

    //        }
    //    }
    //}
}
