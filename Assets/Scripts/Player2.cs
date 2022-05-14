using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player2 : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        animator.SetBool("JumpReady", true);
    }
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        foreach (Camera c in Camera.allCameras)
        {
            if (c.gameObject.name == "Player2MainCamera")
            {
                if (Input.GetKey(KeyCode.O)) c.depth = -1;
                else c.depth = 1;
            }
        }
        if (Input.GetKeyDown(KeyCode.U) && animator.GetBool("JumpReady"))
        {
            animator.SetBool("JumpReady", false);
            animator.SetBool("IsJumping", true);
            animator.SetBool("IsIdle", false);
        }
        else if (Input.GetKey(KeyCode.I))
        {
            animator.SetBool("IsRunning", true);
            animator.SetBool("IsIdle", false);
        }
        else if (!Input.GetKey(KeyCode.I))
        {
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
