using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatoController : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rigidbody2d;
    public float WalkSpeed;
    AudioSource somDePassos;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody2d = GetComponent<Rigidbody2D>();
        somDePassos = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.DownArrow))
        {
            animator.SetBool("Baixo", true);
            rigidbody2d.velocity = new Vector2(0, -WalkSpeed);
            somDePassos.enabled = true;
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            animator.SetBool("Cima", true);
            rigidbody2d.velocity = new Vector2(0, WalkSpeed);
            somDePassos.enabled = true;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetBool("Esquerda", true);
            rigidbody2d.velocity = new Vector2(-WalkSpeed, 0);
            somDePassos.enabled = true;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            animator.SetBool("Direita", true);
            rigidbody2d.velocity = new Vector2(WalkSpeed, 0);
            somDePassos.enabled = true;
        }


        if(Input.GetKeyUp(KeyCode.DownArrow))
        {
            animator.SetBool("Baixo", false);
            rigidbody2d.velocity = new Vector2(0, 0);
            somDePassos.enabled = false;
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            animator.SetBool("Cima", false);
            rigidbody2d.velocity = new Vector2(0, 0);
            somDePassos.enabled = false;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            animator.SetBool("Esquerda", false);
            rigidbody2d.velocity = new Vector2(0, 0);
            somDePassos.enabled = false;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            animator.SetBool("Direita", false);
            rigidbody2d.velocity = new Vector2(0, 0);
            somDePassos.enabled = false;
        }
    }
}
