using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class YoshiJump : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Te caiste puto");
        animator.SetBool("JumpReady", true);
    }
    public Animator animator;
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.W) && animator.GetBool("JumpReady"))
        {
            animator.SetBool("JumpReady", false);
            animator.SetBool("IsJumping", true);
            animator.SetBool("IsIdle", false);
        }
        else if (Input.GetKeyDown(KeyCode.D)) {
            animator.SetBool("IsRunning", true);
            animator.SetBool("IsIdle", false);
        }
        else if (Input.GetKeyUp(KeyCode.D)) {
            animator.SetBool("IsRunning", false);
            animator.SetBool("IsIdle", true);
        }

        //}
        //else
        //{
        //    animator.SetBool("IsIdle", true);
        //    animator.SetBool("IsJumping", false);
        //    animator.SetBool("IsRunning", false);

        //}
    }
}
