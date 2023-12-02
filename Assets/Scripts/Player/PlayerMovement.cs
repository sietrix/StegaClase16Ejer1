using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Clase 16 - Ejercicio 1
public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    public float speed, turnSpeed;

    [Header("Jump")]
    public float jumpForce;

    private float vertical, horizontal;
    private bool canPlayerJump;
    private Rigidbody rg;
    private Animator anim;


    void Start()
    {
        rg = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        InputPlayer();
        Move();
        Rotate();
        Animating();
        CanJump();
    }

    private void FixedUpdate()
    {
        Jump();
    }

    void InputPlayer()
    {
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");
    }

    void Move()
    {
        transform.Translate(Vector3.forward * speed * vertical * Time.deltaTime);
    }

    void Rotate()
    {
        transform.Rotate(Vector3.up * turnSpeed * horizontal * Time.deltaTime);
    }

    void CanJump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            canPlayerJump = true;
        }
    }

    void Jump()
    {
        if(canPlayerJump)
        { 
            rg.AddForce(Vector3.up * jumpForce);
            canPlayerJump = false;
        }
    }

    void Animating()
    {
        // Comprobamos la velocidad de subida y bajada
        // rg.velocity.y > 1 por si hay rebote en el suelo
        // que no se active la transición
        if (rg.velocity.y > 1)
        {
            anim.SetBool("IsJumping", true);
        }
        else
        {
            anim.SetBool("IsJumping", false);
        }
    }



}
