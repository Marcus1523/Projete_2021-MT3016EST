using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player_moviment : MonoBehaviour
{

    public float Speed;
    public float JumpForce;
    private Rigidbody2D rig;
    private bool isJumping;
    private bool DobleJump;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
       rig = GetComponent<Rigidbody2D>(); 
       anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }

    void Move()
    {
        Vector3 moviment = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += moviment * Speed * Time.deltaTime;

        //ANIMAÇÃO
        //personagem indo para esquerda (animação)
        if(Input.GetAxis("Horizontal") < 0f)
        {
            anim.SetBool("run", true);
            transform.eulerAngles = new Vector3(0f, 180, 0f);
        }


         //personagem indo para direita
        if(Input.GetAxis("Horizontal") > 0f)
        {
            anim.SetBool("run", true);
            transform.eulerAngles = new Vector3(0f, 0f, 0f);

        }

        if(Input.GetAxis("Horizontal") == 0f)
        {
            anim.SetBool("run", false); 
        }

    }

    void Jump()
    {
        if(Input.GetButtonDown("Jump"))
        {
            if(isJumping == false)
            {
                 rig.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
            }
            else
            {
                if(DobleJump == true)
                {
                    rig.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
                    DobleJump = false;
                }
            }
           
        }
    }

    void OnCollisionEnter2D (Collision2D collision) //detectar a colisão com o mapa para dar varios pulos
    {
        if(collision.gameObject.layer == 10)
        {
            isJumping = false;
            DobleJump = true;
        }
    }

    void OnCollisionExit2D (Collision2D collision)
    {
        if(collision.gameObject.layer == 10)
        {
            isJumping = true;  
              
        }
    }

    

}
