using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{

    private int vida = 100;
    

    private float maxVelocidad = 5f;
    public float velocidad = 2f;
    public float jumpPower = 3.5f;

    private Rigidbody2D rb2d;
    private Animator anim;
    private bool jump;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("velocidad", Mathf.Abs(rb2d.velocity.x));

        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            jump = true;
        }
    }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        rb2d.AddForce(Vector2.right * velocidad * h);

        if(rb2d.velocity.x > maxVelocidad){
            rb2d.velocity = new Vector2(maxVelocidad, rb2d.velocity.y);
        }

        if(rb2d.velocity.x < -maxVelocidad)
        {
            rb2d.velocity = new Vector2(-maxVelocidad, rb2d.velocity.y);
        }

        if(h > 0.1f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }

        if (h < -0.1f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }

        if (jump)
        {
            rb2d.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            jump = false;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "moneda")
        {
            scoreScript.puntos += 1;
        }

        if (collision.gameObject.tag == "fueguito")
        {
            barraVida.hp += 2f;
        }
    }
}
