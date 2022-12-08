using UnityEngine;

public class SingUserData : MonoBehaviour
{
    private static SingUserData _singletone;
    public string userName = "user";


    public static SingUserData singletone
    {
        get
        {
            if (_singletone == null)
            {
                _singletone = GameObject.FindObjectOfType<SingUserData>();
                DontDestroyOnLoad(_singletone.gameObject);
            }
            return _singletone;

        }
    }

    void Awake()
    {
        if (_singletone == null)
        {
            _singletone = this;
            DontDestroyOnLoad(_singletone.gameObject);
        }
        else if (this != _singletone)
        {
            Destroy(this.gameObject);
        }
    }
}
