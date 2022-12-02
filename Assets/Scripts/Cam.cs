//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Cam : MonoBehaviour
//{
//private Transform AstroMan;
//public bool debug;
//void Start()
//{
//	Screen.SetResolution(256, 240, true, 60);
//	AstroMan = GameObject.Find("AstroMan").transform;
//}
//void Update()
//{
//	if (AstroMan.position.x > transform.position.x || debug)
//	{
//		transform.position = new Vector3(AstroMan.position.x, transform.position.y, -10);
//	}
//}
//}
using UnityEngine;

public class Cam : MonoBehaviour
{
    [SerializeField] private Transform hero;
    [SerializeField] private float smoothTime = 0.7f;
    [SerializeField] private Vector3 offset = new Vector3(0f, 0f, -10f);

    private Vector3 velocity = Vector3.zero;

    void LateUpdate()
    {
        Vector3 desiredPos = hero.position + offset;
        Vector3 smoothedPos = Vector3.SmoothDamp(transform.position, desiredPos, ref velocity, smoothTime);
        transform.position = smoothedPos;
    }
}
