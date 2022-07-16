using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D rb;
    public float Speed = 10f;
    protected bool GoLeft = false;
    protected bool GoRight = false;
    protected bool GoUp = false;
    protected bool GoDown = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a"))
        {
            GoLeft = true;
            animator.SetBool("Left",true);

        }
        else
        {
            GoLeft = false;
            animator.SetBool("Left", false);

        }

        if (Input.GetKey("d"))
        {
            GoRight = true;
            animator.SetBool("Right", true);
 
        }
        else
        {
            GoRight = false;
            animator.SetBool("Right", false);

        }
        if (Input.GetKey("w"))
        {
            GoUp = true;
            animator.SetBool("Up", true);

        }
        else
        {
            GoUp = false;
            animator.SetBool("Up", false);

        }
        if (Input.GetKey("s"))
        {
            GoDown = true;
            animator.SetBool("Down", true);

        }
        else
        {
            GoDown = false;
            animator.SetBool("Down", false);

        }
    }

    void FixedUpdate()
    {
        if (GoLeft)
        {
            rb.MovePosition(transform.position+Vector3.left*Speed*Time.deltaTime);
        }
        if (GoRight)
        {
            rb.MovePosition(transform.position + Vector3.right * Speed * Time.deltaTime);
        }
        if (GoUp)
        {
            rb.MovePosition(transform.position + Vector3.up * Speed * Time.deltaTime);
        }
        if (GoDown)
        {
            rb.MovePosition(transform.position + Vector3.down * Speed * Time.deltaTime);
        }
    }
    
}
