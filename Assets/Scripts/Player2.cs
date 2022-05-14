using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player2 : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.UpArrow) && animator.GetBool("JumpReady"))
        {
            animator.SetBool("JumpReady", false);
            animator.SetBool("IsJumping", true);
            animator.SetBool("IsIdle", false);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow)) {
            animator.SetBool("IsRunning", true);
            animator.SetBool("IsIdle", false);
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow)) {
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
