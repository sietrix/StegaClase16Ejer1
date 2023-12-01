using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed, turnSpeed;
    private float vertical, horizontal;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InputPlayer();
        Move();
        Rotate();
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



}
