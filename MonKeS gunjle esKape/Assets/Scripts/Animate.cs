using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animate : MonoBehaviour
{
    Animator Animator;
    Jump Jump;
    // Start is called before the first frame update
    void Start()
    {
        Animator = GetComponent<Animator>();
        Jump = GetComponent<Jump>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!Jump.isGrounded)
        {
            Animator.SetBool("isJumping", true);
            Animator.SetBool("isIdle", false);
            Animator.SetBool("isWalking", false);
            Animator.SetBool("isWalkingBackwards", false);
        }

        if (Jump.isGrounded)
        {
            Animator.SetBool("isJumping", false);
            Animator.SetBool("isIdle", true);
            Animator.SetBool("isWalking", true);
            Animator.SetBool("isWalkingBackwards", true);
            if (Input.GetAxisRaw("Vertical") == 1)
            {
                Animator.SetBool("isIdle", false);
                Animator.SetBool("isWalking", true);
                Animator.SetBool("isWalkingBackwards", false);
            }
            if (Input.GetAxisRaw("Vertical") == -1)
            {
                Animator.SetBool("isIdle", false);
                Animator.SetBool("isWalking", false);
                Animator.SetBool("isWalkingBackwards", true);
            }
        }
    }
}
