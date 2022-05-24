using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreateDryBones : MonoBehaviour {

    public GameObject dryBones;
    public float runSpeed = 2f;
    public float turnSpeed = 90f;
    GameObject[] obj;
    // Start is called before the first frame update
    void Start() {
        if (SceneManager.GetActiveScene().name == "LEVEL1")
        {
            obj = new GameObject[2];
            obj[0] = (GameObject)Instantiate(dryBones, new Vector3(-3.0f, -0.5f, 14.0f), dryBones.transform.rotation);
            obj[0].transform.Rotate(0, 180, 0);
            obj[0].transform.parent = transform;
            transform.GetChild(0).gameObject.GetComponent<Animator>().SetBool("IsRunning", true);
            Debug.Log("estoy aqui");
        }
        else if (SceneManager.GetActiveScene().name == "LEVEL2") {
            obj = new GameObject[4];

            for (int i = 0; i < 4; ++i)
            {
                if (i % 2 == 0)
                {
                    obj[i] = (GameObject)Instantiate(dryBones, new Vector3(-3.0f + i, -0.5f, 60.0f - i * 5), dryBones.transform.rotation);
                    obj[i].transform.Rotate(0, -90, 0);
                }
                else
                {
                    obj[i] = (GameObject)Instantiate(dryBones, new Vector3(3.0f - (i - 1), -0.5f, 60.0f - (i - 1) * 5), dryBones.transform.rotation);
                    obj[i].transform.Rotate(0, 90, 0);
                }
                obj[i].transform.parent = transform;
                transform.GetChild(i).gameObject.GetComponent<Animator>().SetBool("IsRunning", true);
            }
        }
        else if (SceneManager.GetActiveScene().name == "LEVEL3") { }
        else if (SceneManager.GetActiveScene().name == "LEVEL4") { }
        else if (SceneManager.GetActiveScene().name == "LEVEL5") { }
    }

    // Update is called once per frame
    void Update() {
        for(int i = 0;i<obj.Length; ++i)
        {
            if (obj[i].transform.position.z > 5) obj[i].transform.Translate(-transform.forward * runSpeed * Time.deltaTime, Space.World);
        }
    }
}
