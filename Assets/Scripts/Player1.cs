using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player1 : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        animator.SetBool("JumpReady", true);
    }
    public Animator animator;
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        foreach (Camera c in Camera.allCameras)
        {
            if (c.gameObject.name == "Player1MainCamera")
            {
                if (Input.GetKey(KeyCode.Q)) c.depth = -1;
                else c.depth = 1;
            }
        }
        if (Input.GetKeyDown(KeyCode.E) && animator.GetBool("JumpReady"))
        {
            animator.SetBool("JumpReady", false);
            animator.SetBool("IsJumping", true);
            animator.SetBool("IsIdle", false);
        }
        else if (Input.GetKey(KeyCode.W)) {
            animator.SetBool("IsRunning", true);
            animator.SetBool("IsIdle", false);
        }
        //else if (!Input.GetKey(KeyCode.W)) {
        //    animator.SetBool("IsRunning", false);
        //    animator.SetBool("IsIdle", true);
        //}

        //}
        //else
        //{
        //    animator.SetBool("IsIdle", true);
        //    animator.SetBool("IsJumping", false);
        //    animator.SetBool("IsRunning", false);

        //}
    }
}
