using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float maxSpeed;
    public float jumpPower;
    Rigidbody2D rigid;
    SpriteRenderer spriteRenderer;
    public bool isJumping;
    Animator anim;

    void Update()
    {
        //stop speed
        if (Input.GetButtonUp("Horizontal"))
        {
            rigid.velocity = new Vector2(rigid.velocity.normalized.x * 0.5f, rigid.velocity.y);
        }


        //Direction sprite
        if (Input.GetButtonDown("Horizontal"))
        {
            spriteRenderer.flipX = Input.GetAxisRaw("Horizontal") == -1;
        }

        if( Input.GetKeyDown(KeyCode.Space))
        {
            if (isJumping == false)
            {
                Jump();
            }
        }


        //Animation
        if (rigid.velocity.normalized.x == 0)
        {
            anim.SetBool("iswalking", false);
        }
        else
        {
            anim.SetBool("iswalking", true);
        }
    }
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        //Move
        float h = Input.GetAxisRaw("Horizontal");

        rigid.AddForce(Vector2.right * h, ForceMode2D.Impulse);

        if (rigid.velocity.x > maxSpeed) // Right Max Speed
        {
            rigid.velocity = new Vector2(maxSpeed, rigid.velocity.y);
        }
        else if (rigid.velocity.x < maxSpeed * (-1)) // left Max Speed
        {
            rigid.velocity = new Vector2(maxSpeed * (-1), rigid.velocity.y);
        }
    }

    void Jump() 
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W)) 
        { 
            rigid.AddForce(Vector3.up * jumpPower, ForceMode2D.Impulse);
            anim.SetBool("isjumping", true);
            isJumping = true;
        } 
    }

    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.transform.tag == "Ground")
        {
            anim.SetBool("isjumping", false);
            isJumping = false;

        }

    }
}
