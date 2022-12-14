using UnityEngine;

public class ItemSound : MonoBehaviour
{
    public void PlaySound()
    {
        GetComponent<AudioSource>().Play();
        Destroy(gameObject, 2);
    }
}
