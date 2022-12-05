using UnityEngine;

public class MushroomEnemies : MonoBehaviour
{
    int hp = 1;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "snow")
        {
            hp--;
            if(hp <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
