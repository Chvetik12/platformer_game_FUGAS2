using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonePerson : MonoBehaviour
{
    private static SingletonePerson _singletone;

    public static SingletonePerson singletone
    {
        get
        {
            if (_singletone == null)
            {
                _singletone = GameObject.FindObjectOfType<SingletonePerson>();
                DontDestroyOnLoad(_singletone.gameObject);
            }
            return _singletone;

        }
    }

    void Awake()
    {
        if(_singletone == null)
        {
            _singletone = this;
            DontDestroyOnLoad(_singletone.gameObject);
        }
        else if(this != _singletone)
        {
            Destroy(this.gameObject);
        }        
    }
}
