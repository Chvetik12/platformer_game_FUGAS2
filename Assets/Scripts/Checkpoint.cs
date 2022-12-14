using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{

    [SerializeField] private Transform checkpoint;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player")
        {
            collision.transform.position = checkpoint.position;
            Transform cam = Camera.main.transform;
            cam.position = new Vector3(collision.transform.position.x, cam.position.y, -10);//-10 камера перед обєктами

        }
    }
}
