using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rbPlayer;
    Animator animatorPlayer;

    public Animator attackAnimator;

    public float speed = 3;
    public float jumpForce = 6.5f;
    bool isOnGround = true;
    int health = 5;
    public int money = 0;
    float moveHorizontal;

    // Start is called before the first frame update
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody2D>();
        animatorPlayer = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");


        if (moveHorizontal > 0)
        {
            transform.localScale = new Vector2(1, 1);
        }

        if (moveHorizontal < 0)
        {
            transform.localScale = new Vector2(-1, 1);
        }

        rbPlayer.velocity = new Vector2(moveHorizontal * speed, rbPlayer.velocity.y);
        animatorPlayer.SetFloat("Move", Mathf.Abs(moveHorizontal));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Saltar();
        }

        if (Input.GetMouseButtonDown(0))
        {
            Atacar();
        }
    }


    public void AnimAttack()
    {
        attackAnimator.SetTrigger("Attack");
    }

    public void Atacar()
    {
        //Ataque
        if (isOnGround)
        {
            animatorPlayer.SetTrigger("Attack");
        }

    }

    public void Damage(int dmg)
    {

    }

    public void Saltar()
    {
        //salto
        if (isOnGround)
        {
            rbPlayer.velocity = new Vector2(moveHorizontal, jumpForce);
            animatorPlayer.SetTrigger("Jump");
            animatorPlayer.SetBool("Jumping", true);
            //PlayAudioClip(2);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isOnGround = true;

            animatorPlayer.SetBool("Jumping", false);
        }


    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isOnGround = false;

            animatorPlayer.SetBool("Jumping", true);
        }
    }
}
