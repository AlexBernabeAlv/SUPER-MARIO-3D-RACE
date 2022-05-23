using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateDryBones : MonoBehaviour {

    public GameObject dryBones;
    public float runSpeed = 2f;
    public float turnSpeed = 90f;
    GameObject obj;
    bool done = false;
    // Start is called before the first frame update
    void Start() {
        obj = (GameObject)Instantiate(dryBones, new Vector3(-3.0f, -0.5f, 14.0f), dryBones.transform.rotation);
        obj.transform.Rotate(0, 180, 0);
        obj.transform.parent = transform;
        gameObject.GetComponent<Animator>().SetBool("IsRunning", true);

    }

    // Update is called once per frame
    void Update() {
        //while (!done) {
        //    if (obj.transform.position.z > 5)
        //    {
        //        if (obj.transform.rotation.y > 0) obj.transform.Rotate(0f, -turnSpeed * Time.deltaTime, 0f);
        //        else if (obj.transform.rotation.y < 0) obj.transform.Rotate(0f, turnSpeed * Time.deltaTime, 0f);
        //        else obj.transform.Translate(-transform.forward * runSpeed * Time.deltaTime, Space.World);
        //    }
        //    else done = true;
                //if (obj.transform.position.z > 10 && obj.transform.rotation.y == 180) obj.transform.Translate(obj.transform.forward * runSpeed * Time.deltaTime, Space.World);
                //else if (obj.transform.rotation.y > 0)
                //{
                //    obj.transform.Rotate(0f, -turnSpeed * Time.deltaTime, 0f);
                //}
                //else if (obj.transform.rotation.y == 0)
        //}
    }
}
