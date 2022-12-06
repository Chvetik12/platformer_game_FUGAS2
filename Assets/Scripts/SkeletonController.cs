using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonController : MonoBehaviour
{
    //const int ForseSnow = 400;
    [SerializeField] private float speed = 5;
    [SerializeField] private Transform sensorGround;
    [SerializeField] private Ui_Life Uilife;
    [SerializeField] private Transform markerL;
    [SerializeField] private Transform markerR;
    //[SerializeField] private Rigidbody2D snow;
    private Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer sr;
    private bool isRight = true;
    private int hp = 3; 

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        
    }

    void FixedUpdate()
    {
        Turn();
        float move = isRight ? 1 : -1;
        rb.velocity = new Vector3(move * speed, rb.velocity.y, 0);
        anim.SetFloat("SpeedX", Mathf.Abs(move));
    }

    void Update()
    {

       //Attack();
    }

    //void Attack()
    //{
    //    if (Input.GetKeyDown(KeyCode.Return) && countSnow > 0)
    //    {
    //        countSnow--;
    //        Uilife.SetCountSnowUI(countSnow);
    //        Rigidbody2D tempSnow = Instantiate(snow, transform.position, Quaternion.identity);
    //        tempSnow.AddForce(new Vector2(isRight ? ForseSnow : -ForseSnow, 0));
    //    }
    //}

    void Turn()
    {
        if(isRight)
        {
            if(transform.position.x > markerR.position.x)
            {
                isRight = false;
                sr.flipX = true;
            }
        }
        else
        {
            if(transform.position.x < markerL.position.x)
            {
                isRight = true;
                sr.flipX = false;
            }
        }
    }
  
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "snow")
        {
            hp--;
            if (hp <= 0)
            {
                anim.SetTrigger("death");
                Destroy(this);
                Destroy(GetComponent<Collider2D>());
                Destroy(rb);
                //Destroy(transform.parent.gameObject);
            }
           
        }
    }
    //private void Damage()
    //{
    //    hp--;
    //    Uilife.RemuveLife();
    //    if (hp == 0)
    //    {
    //        Time.timeScale = 0;
    //        Uilife.GameOver();
    //    }
    //}
}
