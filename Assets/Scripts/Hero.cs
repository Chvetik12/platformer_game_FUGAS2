using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using TMPro;


public class Hero : MonoBehaviour
{
    const int ForseSnow = 400;
    public int countMushroom = 0;
    public float move;
    [SerializeField] private float speed = 5;
    [SerializeField] private float jump = 20;
    [SerializeField] private Transform sensorGround;
    [SerializeField] private Ui_Life Uilife;
    [SerializeField] private Rigidbody2D snow;
    [SerializeField] private bool isMobileController = false;
    private Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer sr;
    private bool isRight = true;
    private bool isGround;
    private bool isControl = true;
    //private float inputVertical;
    private int life = 3;
    private int countSnow = 5;

    // public int Mushroom //додатковий метод,так як він попереднь приватний
    // {
    //     get => Mushroom;
    // }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }
    private void Start()
    {
        SetValueInUI();
    }
    void SetValueInUI()
    {
        Uilife.SetCountMushroomUI(countMushroom);
        Uilife.SetCountSnowUI(countSnow);
        //Uilife.
    }
    //private void LevelLoaded(Scene scene, LoadSceneMode mode)
    //{
    //    if (SingletonePeson.singeltone.transform == transform)
    //    {
    //        Uilife = FindObjectOfType<Ui_Life>();
    //        SetValueInUI();
    //    }
    //}
    //private void LevelLoaded(Scene scene, LoadSceneMode mode)
    //{
    //  //  if(SingUserData.singletone.transform == transform)
    //    {
    //        Uilife = FindObjectOfType<Ui_Life>();
    //        SetValueInUI();
    //    }
    //}

    void FixedUpdate()
    {
        if (isControl)
        {
            //            if (!isMobileController)
            {
                move = Input.GetAxis("Horizontal");
            }
            rb.velocity = new Vector3(move * speed, rb.velocity.y, 0);
            anim.SetFloat("SpeedX", Mathf.Abs(move));
            Flip(move);
        }
    }

    void Update()
    {
        if (isControl)
        {
            Jump();
            Attack();
        }
    }

    void Attack()
    {
        if (Input.GetKeyDown(KeyCode.Return) && countSnow > 0)
        {
            countSnow--;
            Uilife.SetCountSnowUI(countSnow);
            Rigidbody2D tempSnow = Instantiate(snow, transform.position, Quaternion.identity);
            tempSnow.AddForce(new Vector2(isRight ? ForseSnow : -ForseSnow, 0));
        }
    }

    void Jump()
    {
        isGround = Physics2D.OverlapCircleAll(sensorGround.position, 0.3f).Length > 1;
        if (Input.GetButtonDown("Jump") && isGround)
        {
            rb.AddForce(Vector2.up * jump);
        }
        anim.SetBool("isGround", isGround);
    }
    void Flip(float move)
    {
        if (move < 0 && isRight)
        {
            isRight = false;
            sr.flipX = true;
        }
        else if (move > 0 && !isRight)
        {
            isRight = true;
            sr.flipX = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Mushroom")
        {
            countMushroom += 10;
            Uilife.SetCountMushroomUI(countMushroom);
            ItemSound itemSound = collision.GetComponentInParent<ItemSound>();//універсальний для всіх підбирань
            if (itemSound)
            {
                itemSound.PlaySound();
            }
            Destroy(collision.gameObject);

        }

        else if (collision.tag == "snow")
        {
            int count = collision.GetComponent<Item>().count;
            countSnow += count;
            Uilife.SetCountSnowUI(countSnow);
            Destroy(collision.gameObject);
        }

        else if (collision.tag == "floor" || collision.tag == "spike")
        {
            Damage();
            //anim.SetTrigger("spikes");
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Skeleton")
        {
            Damage();
            StartCoroutine(StopControl());
            rb.AddForce(new Vector2(collision.GetContact(0).normal.x * 500, 300));

        }
    }
    private void Damage()
    {
        life--;
        Uilife.RemuveLife();
        if (life == 0)
        {
            Time.timeScale = 0;
            Uilife.GameOver();
        }
        //anim.SetBool("Death", Death);
    }
    IEnumerator StopControl() //курутина підпрограма
    {
        isControl = false;
        yield return new WaitForSeconds(1);//1сек
        isControl = true;
    }
}




