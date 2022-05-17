using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player1 : MonoBehaviour
{

    public Animator animator;
    public AudioClip whineSound;

    public float runSpeed = 7.0f;
    public float turnSpeed = 180.0f;
    public float jumpSpeed = 4.0f;
    public int currentCheckpoint = 0;
    bool isIdle;
    bool isRunning;
    bool isJumping;
    bool godMode;
    bool restart;

    private void OnTriggerEnter(Collider col) {
        Debug.Log("Ya puedes volver a saltar");
        isJumping = false;
        animator.SetBool("IsJumping", isJumping);
        if(col.gameObject.tag == "Enemy") restart = true;
    }

    // Start is called before the first frame update
    void Start() {
        isIdle = true;
        isRunning = false;
        isJumping = false;
        godMode = false;
        restart = false;
        currentCheckpoint = 0;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.G)) godMode = !godMode;
        if (restart) {
            if (currentCheckpoint == 0) {
                transform.position = new Vector3(-5.0f, -0.5f, 5.0f);
                transform.rotation = new Quaternion(0.0f, 0.0f, 0.0f, 0.0f);
                AudioSource.PlayClipAtPoint(whineSound, transform.position);
            }
            restart = false;
        }
        // if(godMode){
        // disable collisions 
        //}

        isRunning = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D);
        animator.SetBool("IsRunning", isRunning);

        foreach (Camera c in Camera.allCameras) {
            if (c.gameObject.name == "Player1MainCamera") {
                c.transform.position = transform.position + new Vector3(0.0f, 3.0f, -4.0f);
                if (Input.GetKey(KeyCode.Q)) c.depth = -1;
                else c.depth = 1;
            }
            else if (c.gameObject.name == "Player1SecondCamera") c.transform.position = transform.position + new Vector3(0.0f, 4.0f, 5.0f);
        }

        if (isJumping) {
            Debug.Log("Saltando");
            transform.Translate(0.0f, jumpSpeed * Time.deltaTime, 0.0f);
        }

        if (Input.GetKeyDown(KeyCode.E) && !isJumping) {
            isJumping = true;
            animator.SetBool("IsJumping", isJumping);
        }
        else {
            if (Input.GetKey(KeyCode.W)) transform.Translate(0.0f, 0.0f, runSpeed * Time.deltaTime);
            else if (Input.GetKey(KeyCode.S)) transform.Translate(0.0f, 0.0f, -runSpeed * Time.deltaTime);
            if (Input.GetKey(KeyCode.A)) transform.Rotate(0.0f, -turnSpeed * Time.deltaTime, 0.0f);
            else if (Input.GetKey(KeyCode.D)) transform.Rotate(0.0f, turnSpeed * Time.deltaTime, 0.0f);
        }
        isIdle = !isRunning && !isJumping;
        animator.SetBool("IsIdle", isIdle);
    }
}
