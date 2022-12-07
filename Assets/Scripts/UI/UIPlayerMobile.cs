using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPlayerMobile : MonoBehaviour
{
    private Hero hero;

    
    void Start()
    {
        hero = singletonePerson.singletone.GetComponent<Hero>();
    }

    public void LeftRunDown()
    {
        hero.move = -1; 
    }
    public void LeftRunDown()
    {
        hero.move = 0;
    }

}
