using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player2 : MonoBehaviour
{

    public AudioClip whineSound;
    public AudioClip coinSound;

    public float runSpeed = 7f;
    public float turnSpeed = 180f;
    public float jumpHeight = 5f;
    public Rigidbody rb;
    bool isRunning;
    bool isGrounded;
    bool godMode;
    bool restart;
    static public bool winner;
    Vector3 lastCheckpointPosition;
    private KeyCode[] keyCodes = {
         KeyCode.Alpha1,
         KeyCode.Alpha2,
         KeyCode.Alpha3,
         KeyCode.Alpha4,
         KeyCode.Alpha5,
         KeyCode.Alpha6,
     };

    private void OnTriggerEnter(Collider col) {
        if (col.gameObject.tag == "Enemy" && !godMode) restart = true;
        if (col.gameObject.tag == "Odyssey") winner = true;
        if (col.gameObject.tag == "Coin")
        {
            runSpeed = runSpeed + 0.1f;
            Destroy(col.gameObject);
            AudioSource.PlayClipAtPoint(coinSound, transform.position, 0.05f);
        }
    }

    private void OnCollisionEnter(Collision col) {
        if (col.collider.tag == "Ground" || col.gameObject.tag == "Odyssey") isGrounded = true;
    }

    static public bool isWinner() {
        return winner;
    }

    public float getPlayerZ() {
        return transform.position.z;
    }

    // Start is called before the first frame update
    void Start() {
        isRunning = false;
        isGrounded = true;
        godMode = false;
        restart = false;
        winner = false;
        lastCheckpointPosition = new Vector3(5f, -0.3f, 4f);
    }

    // Update is called once per frame
    void Update() {
        for (int i = 1; i <= 6; ++i)
        {
            if (Input.GetKeyDown(keyCodes[i - 1]))
                SceneManager.LoadScene("LEVEL" + i);
        }

        if (Input.GetKeyDown(KeyCode.G)) godMode = !godMode;

        if (restart)
        {
            AudioSource.PlayClipAtPoint(whineSound, transform.position);
            transform.position = lastCheckpointPosition;
            transform.rotation = new Quaternion(0f, 0f, 0f, 0f);
            restart = false;
        }

        isRunning = Input.GetKey(KeyCode.I) || Input.GetKey(KeyCode.J) || Input.GetKey(KeyCode.K) || Input.GetKey(KeyCode.L);
        gameObject.GetComponent<Animator>().SetBool("IsRunning", isRunning);
        gameObject.GetComponent<Animator>().SetBool("IsJumping", !isGrounded);

        foreach (Camera c in Camera.allCameras) {
            if (c.gameObject.name == "Player2MainCamera")
            {
                c.transform.position = transform.position + new Vector3(0f, 3f, -4f);
                if (Input.GetKey(KeyCode.O)) c.depth = -1;
                else c.depth = 1;
            }
            else if (c.gameObject.name == "Player2SecondCamera") c.transform.position = transform.position + new Vector3(0f, 4f, 5f);
        }

        if (Input.GetKeyDown(KeyCode.U) && isGrounded)
        {
            rb.AddForce(new Vector3(0f, 1f, 0f) * jumpHeight, ForceMode.Impulse);
            isGrounded = false;
        }

        if (Input.GetKey(KeyCode.I)) transform.Translate(transform.forward * runSpeed * Time.deltaTime, Space.World);
        else if (Input.GetKey(KeyCode.K)) transform.Translate(-transform.forward * runSpeed * Time.deltaTime, Space.World);
        if (Input.GetKey(KeyCode.J)) transform.Rotate(0f, -turnSpeed * Time.deltaTime, 0f);
        else if (Input.GetKey(KeyCode.L)) transform.Rotate(0f, turnSpeed * Time.deltaTime, 0f);
    }
}